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
    public class DaObreroPorObra
    {
        public Exception ErrorConsulta;
        private const string CadenaSelect = "SELECT IdEmpresa, IdObra, IdPersona, UsuarioCreador, FechaCreacion, UsuarioModificador, FechaModificacion, Activo, IdCategoria";

        public List<BeObreroPorObra> GetObrerosPorObra(BeObreroPorObra pObreroPorObra)
        {
            var detalleObrerosDeObras = new List<BeObreroPorObra>();
            try
            {
                var comandoSql = string.Concat(CadenaSelect, @"FROM dbo.ObreroPorObra WHERE IdEmpresa=@pIdEmpresa AND IdObra=@pIdObra");
                var db = DatabaseFactory.CreateDatabase(HelperConsultas.CadenaConexion);
                var cmd = db.GetSqlStringCommand(comandoSql);

                cmd.Parameters.Add(HelperConsultas.CrearParametro(cmd, "@IdEmpresa", DbType.Guid, pObreroPorObra.Empresa.IdEmpresa));
                cmd.Parameters.Add(HelperConsultas.CrearParametro(cmd, "@pIdObra", DbType.Guid, pObreroPorObra.Obra.IdObra));

                var oReader = db.ExecuteReader(cmd);

                while (oReader.Read())
                {
                    var periodo = CargarEntidad(oReader);
                    detalleObrerosDeObras.Add(periodo);
                }

            }
            catch (Exception ex)
            {
                ErrorConsulta = ex;
                detalleObrerosDeObras = null;
            }
            return detalleObrerosDeObras;
        }

        public BeObreroPorObra InsObreroPorObra(BeObreroPorObra pObreroPorObra)
        {
            try
            {
                var comandoSql =
                    string.Concat(
                        "INSERT INTO dbo.ObreroPorObra (IdEmpresa, IdObra, IdPersona, UsuarioCreador, FechaCreacion, UsuarioModificador, FechaModificacion, Activo, IdCategoria ) ",
                        "VALUES  ( @pIdEmpresa, @pIdObra, @pIdPersona, @pUsuarioCreador, @pFechaCreacion, @pUsuarioModificador, @pFechaModificacion, @pActivo, @pIdCategoria )");

                var db = DatabaseFactory.CreateDatabase(HelperConsultas.CadenaConexion);
                var cmd = db.GetSqlStringCommand(comandoSql);

                CargarParametros(cmd, pObreroPorObra);

                var filas = db.ExecuteNonQuery(cmd);
                pObreroPorObra.EstadoEntidad = HelperConsultas.SetEstadoEntidad(true, filas, null);

            }
            catch (Exception ex)
            {
                ErrorConsulta = ex;
                pObreroPorObra.EstadoEntidad = HelperConsultas.SetEstadoEntidad(false, 0, ex);
            }
            return pObreroPorObra;
        }

        public BeObreroPorObra UpdObreroPorObra(BeObreroPorObra pObreroPorObra)
        {
            try
            {
                var comandoSql =
                    string.Concat(
                        "UPDATE dbo.ObreroPorObra ",
                        "SET IdCategoria=@pIdCategoria, ",
                        "   UsuarioModificador=@pUsuarioModificador, ",
                        "	FechaModificacion=@pFechaModificacion ",
                        "WHERE IdEmpresa=@pIdEmpresa",
                        "   AND IdObra=@pIdObra ",
                        "   AND IdPersona=@pIdPersona");

                var db = DatabaseFactory.CreateDatabase(HelperConsultas.CadenaConexion);
                var cmd = db.GetSqlStringCommand(comandoSql);

                CargarParametros(cmd, pObreroPorObra);

                var filas = db.ExecuteNonQuery(cmd);
                pObreroPorObra.EstadoEntidad = HelperConsultas.SetEstadoEntidad(true, filas, null);
            }
            catch (Exception ex)
            {
                ErrorConsulta = ex;
                pObreroPorObra.EstadoEntidad = HelperConsultas.SetEstadoEntidad(false, 0, ex);
            }
            return pObreroPorObra;
        }

        private BeObreroPorObra CargarEntidad(IDataReader pReader)
        {
            var obreroPorObra = new BeObreroPorObra();

            try
            {
                obreroPorObra.Empresa = new BeMaestroEmpresa { IdEmpresa = HelperConsultas.GetValueSql<Guid>(pReader.GetValue(0)) };
                obreroPorObra.Obra = new BeMaestroObras { IdObra = HelperConsultas.GetValueSql<Guid>(pReader.GetValue(1)) };
                obreroPorObra.Obrero = new BeMaestroObrero { IdPersona = HelperConsultas.GetValueSql<Guid>(pReader.GetValue(2)) };
                obreroPorObra.UsuarioCreador = HelperConsultas.GetValueSql<string>(pReader.GetValue(3));
                obreroPorObra.FechaCreacion = HelperConsultas.GetValueSql<DateTime>(pReader.GetValue(4));
                obreroPorObra.UsuarioModificador = HelperConsultas.GetValueSql<string>(pReader.GetValue(5));
                obreroPorObra.FechaModificacion = HelperConsultas.GetValueSql<DateTime>(pReader.GetValue(6));
                obreroPorObra.CategoriaObrero = new BeMaestroCategoriaObrero
                {
                    IdCategoria = HelperConsultas.GetValueSql<Guid>(pReader.GetValue(7)),
                    Empresa = obreroPorObra.Empresa
                };
            }
            catch (Exception ex)
            {
                obreroPorObra = null;
                ErrorConsulta = ex;
            }
            return obreroPorObra;
        }

        private void CargarParametros(DbCommand pCmd, BeObreroPorObra pPeriodo)
        {
            pCmd.Parameters.Add(HelperConsultas.CrearParametro(pCmd, "@pIdEmpresa", DbType.Guid, pPeriodo.Empresa.IdEmpresa));
            pCmd.Parameters.Add(HelperConsultas.CrearParametro(pCmd, "@pIdObra", DbType.Guid, pPeriodo.Obra.IdObra));
            pCmd.Parameters.Add(HelperConsultas.CrearParametro(pCmd, "@pIdPersona", DbType.Guid, pPeriodo.Obrero.IdPersona));
            pCmd.Parameters.Add(HelperConsultas.CrearParametro(pCmd, "@pUsuarioCreador", DbType.String, pPeriodo.UsuarioCreador));
            pCmd.Parameters.Add(HelperConsultas.CrearParametro(pCmd, "@pFechaCreacion", DbType.DateTime, pPeriodo.FechaCreacion));
            pCmd.Parameters.Add(HelperConsultas.CrearParametro(pCmd, "@pUsuarioModificador", DbType.String, pPeriodo.UsuarioModificador));
            pCmd.Parameters.Add(HelperConsultas.CrearParametro(pCmd, "@pFechaModificacion", DbType.DateTime, pPeriodo.FechaModificacion));
            pCmd.Parameters.Add(HelperConsultas.CrearParametro(pCmd, "@pActivo", DbType.Boolean, pPeriodo.Activo));
            pCmd.Parameters.Add(HelperConsultas.CrearParametro(pCmd, "@pIdCategoria", DbType.Guid, pPeriodo.CategoriaObrero.IdCategoria));

        }
    }
}
