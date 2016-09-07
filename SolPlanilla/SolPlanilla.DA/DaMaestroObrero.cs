using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.EnterpriseLibrary.Data;
using SolPlanilla.BE;

namespace SolPlanilla.DA
{
    public class DaMaestroObrero
    {
        public Exception ErrorConsulta;
        private const string CadenaSelect = @"select IdPersona, IdEmpresa, IdCategoria, CodigoAlterno ";

        public BeMaestroObrero GetMaestroObrero(BeMaestroObrero pObrero)
        {
            var obrero = new BeMaestroObrero();
            try
            {
                var comandoSql = string.Concat(CadenaSelect, "FROM dbo.MaestroObrero WHERE IdPersona=@pIdPersona AND IdEmpresa=@pIdEmpresa");
                var db = DatabaseFactory.CreateDatabase(HelperConsultas.CadenaConexion);
                var cmd = db.GetSqlStringCommand(comandoSql);

                cmd.Parameters.Add(HelperConsultas.CrearParametro(cmd, "@pIdEmpresa", DbType.Guid, pObrero.Empresa.IdEmpresa));
                cmd.Parameters.Add(HelperConsultas.CrearParametro(cmd, "@pIdPersona", DbType.Guid, pObrero.IdPersona));

                var oReader = db.ExecuteReader(cmd);
                var filas = 0;

                if (oReader.Read())
                {
                    obrero = CargarEntidad(oReader);
                    filas = 1;
                }

                pObrero.EstadoEntidad = HelperConsultas.SetEstadoEntidad(true, filas, null);
            }
            catch (Exception ex)
            {
                ErrorConsulta = ex;
                pObrero.EstadoEntidad = HelperConsultas.SetEstadoEntidad(false, 0, ex);
            }
            return obrero;
        }

        public List<BeMaestroObrero> GetMaestroObrero(BeMaestroEmpresa pEmpresa)
        {
            var obreros = new List<BeMaestroObrero>();
            try
            {
                string comandoSql = string.Concat(CadenaSelect, @"FROM dbo.MaestroObrero WHERE IdEmpresa=@pIdEmpresa");
                var db = DatabaseFactory.CreateDatabase(HelperConsultas.CadenaConexion);
                var cmd = db.GetSqlStringCommand(comandoSql);

                cmd.Parameters.Add(HelperConsultas.CrearParametro(cmd, "@pIdEmpresa", DbType.Guid, pEmpresa.IdEmpresa));

                var oReader = db.ExecuteReader(cmd);

                while (oReader.Read())
                {
                    var obrero = CargarEntidad(oReader);
                    obreros.Add(obrero);
                }

            }
            catch (Exception ex)
            {
                ErrorConsulta = ex;
            }
            return obreros;
        }

        public BeMaestroObrero InsMaestroObrero(BeMaestroObrero pObrero)
        {
            try
            {
                var comandoSql = string.Concat("INSERT INTO dbo.MaestroObrero ( IdPersona, IdEmpresa, IdCategoria, CodigoAlterno ) ",
                    "VALUES  ( @pIdPersona, @pIdEmpresa, @pIdCategoria, @pCodigoAlterno)");
                var db = DatabaseFactory.CreateDatabase(HelperConsultas.CadenaConexion);
                var cmd = db.GetSqlStringCommand(comandoSql);

                CargarParametros(cmd, pObrero);

                var filas = db.ExecuteNonQuery(cmd);

                pObrero.EstadoEntidad = HelperConsultas.SetEstadoEntidad(true, filas, null);

            }
            catch (Exception ex)
            {
                ErrorConsulta = ex;
                pObrero.EstadoEntidad = HelperConsultas.SetEstadoEntidad(false, 0, ex);
            }

            return pObrero;
        }

        public BeMaestroObrero UpdMaestroObrero(BeMaestroObrero pObrero)
        {
            try
            {
                var comandoSql =
                    string.Concat(
                        "UPDATE dbo.MaestroObrero ",
                        "SET IdCategoria=@pIdCategoria ",
                        "    CodigoAlterno=@pCodigoAlterno ",
                        "WHERE IdPersona=@pIdPersona ",
                        "	AND IdEmpresa=@pIdEmpresa");
                var db = DatabaseFactory.CreateDatabase(HelperConsultas.CadenaConexion);
                var cmd = db.GetSqlStringCommand(comandoSql);

                CargarParametros(cmd, pObrero);
                
                var filas = db.ExecuteNonQuery(cmd);

                pObrero.EstadoEntidad = HelperConsultas.SetEstadoEntidad(true, filas, null);
            }
            catch (Exception ex)
            {
                ErrorConsulta = ex;
                pObrero.EstadoEntidad = HelperConsultas.SetEstadoEntidad(false, 0, ex);
            }

            return pObrero;
        }

        private BeMaestroObrero CargarEntidad(IDataReader pReader)
        {
            var obrero = new BeMaestroObrero();
            try
            {
                obrero.IdPersona = HelperConsultas.GetValueSql<Guid>(pReader.GetValue(0));
                obrero.Empresa = new BeMaestroEmpresa
                {
                    IdEmpresa = HelperConsultas.GetValueSql<Guid>(pReader.GetValue(0))
                };
                obrero.Categoria = new BeMaestroCategoriaObrero
                {
                    IdCategoria = HelperConsultas.GetValueSql<Guid>(pReader.GetValue(2))
                };
                obrero.CodigoAlterno = HelperConsultas.GetValueSql<string>(pReader.GetValue(3));

            }
            catch (Exception ex)
            {
                ErrorConsulta = ex;
                obrero = null;
            }

            return obrero;
        }

        private void CargarParametros(DbCommand pCmd, BeMaestroObrero pObrero)
        {
            pCmd.Parameters.Add(HelperConsultas.CrearParametro(pCmd, "@pIdEmpresa", DbType.Guid, pObrero.Empresa.IdEmpresa));
            pCmd.Parameters.Add(HelperConsultas.CrearParametro(pCmd, "@pIdPersona", DbType.Guid, pObrero.IdPersona));
            pCmd.Parameters.Add(HelperConsultas.CrearParametro(pCmd, "@pIdCategoria", DbType.Guid, pObrero.Categoria.IdCategoria));
            pCmd.Parameters.Add(HelperConsultas.CrearParametro(pCmd, "@pCodigoAlterno", DbType.Guid, pObrero.CodigoAlterno));
        }
    }
}

