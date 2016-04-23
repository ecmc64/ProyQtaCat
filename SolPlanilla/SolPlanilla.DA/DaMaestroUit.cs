using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.EnterpriseLibrary.Data;
using SolPlanilla.BE;


namespace SolPlanilla.DA
{
    public class DaMaestroUit
    {
        public Exception ErrorConsulta;

        private const string CadenaSelect = "Select IdEmpresa,Anio,MontoUnidadImpositivaTrib,UsuarioCreador,UsuarioModificador,FechaCreacion,FechaModificacion ";

        public List<BE.BeMaestroUit> GetMaestroUit()
        {
            var uits = new List<BE.BeMaestroUit>();
            try
            {
                const string comandoSql = @"Select IdEmpresa,Anio,MontoUnidadImpositivaTrib,UsuarioCreador,UsuarioModificador,FechaCreacion,FechaModificacion from MaestroUIT order by IdEmpresa";
                var db = DatabaseFactory.CreateDatabase(HelperConsultas.CadenaConexion);
                var cmd = db.GetSqlStringCommand(comandoSql);

                var oReader = db.ExecuteReader(cmd);
                while (oReader.Read())
                {
                    var uit = new BE.BeMaestroUit();
                    uit.Empresa = new BeMaestroEmpresa { IdEmpresa = HelperConsultas.GetValueSql<Guid>(oReader.GetValue(0)) };
                    uit.Anio = HelperConsultas.GetValueSql<int>(oReader.GetValue(1));
                    uit.MontoUnidadImpositivaTrib = HelperConsultas.GetValueSql<decimal>(oReader.GetValue(2));
                    uit.UsuarioCreador = HelperConsultas.GetValueSql<string>(oReader.GetValue(3));
                    uit.UsuarioModificador = HelperConsultas.GetValueSql<string>(oReader.GetValue(4));
                    uit.FechaCreacion = HelperConsultas.GetValueSql<DateTime>(oReader.GetValue(5));
                    uit.FechaModificacion = HelperConsultas.GetValueSql<DateTime>(oReader.GetValue(6));
                    

                    uits.Add(uit);

                }

            }
            catch (Exception ex)
            {
                ErrorConsulta = ex;
                uits = null;
            }

            return uits;
        }

        public BeMaestroUit InsUit(BeMaestroUit pUit)
        {
            try
            {
                var comandoSql =
                    string.Concat(
                        "INSERT INTO dbo.MaestroUit ( IdEmpresa,Anio,MontoUnidadImpositivaTrib,UsuarioCreador,UsuarioModificador,FechaCreacion,FechaModificacion ) ",
                        "VALUES  ( @pIdEmpresa,@pAnio,@pMontoUnidadImpositivaTrib,@pUsuarioCreador,@pUsuarioModificador,@pFechaCreacion,@pFechaModificacion)");

                var db = DatabaseFactory.CreateDatabase(HelperConsultas.CadenaConexion);
                var cmd = db.GetSqlStringCommand(comandoSql);

                cmd.Parameters.Add(HelperConsultas.CrearParametro(cmd, "@pIdEmpresa", DbType.Guid, pUit.Empresa.IdEmpresa));
                cmd.Parameters.Add(HelperConsultas.CrearParametro(cmd, "@pAnio", DbType.Int16, pUit.Anio));
                cmd.Parameters.Add(HelperConsultas.CrearParametro(cmd, "@pMontoUnidadImpositivaTrib", DbType.Currency, pUit.MontoUnidadImpositivaTrib));
                cmd.Parameters.Add(HelperConsultas.CrearParametro(cmd, "@pUsuarioCreador", DbType.String, pUit.UsuarioCreador));
                cmd.Parameters.Add(HelperConsultas.CrearParametro(cmd, "@pUsuarioModificador", DbType.String, pUit.UsuarioModificador));
                cmd.Parameters.Add(HelperConsultas.CrearParametro(cmd, "@pFechaCreacion", DbType.DateTime,pUit.FechaCreacion));
                cmd.Parameters.Add(HelperConsultas.CrearParametro(cmd, "@pFechaModificacion", DbType.DateTime,pUit.FechaModificacion));

                var filas = db.ExecuteNonQuery(cmd);
                pUit.EstadoEntidad = HelperConsultas.SetEstadoEntidad(true, filas, null);
            }
            catch (Exception ex)
            {
                ErrorConsulta = ex;
                pUit.EstadoEntidad = HelperConsultas.SetEstadoEntidad(false, 0, ex);
            }
            return pUit;
        }

        public BeMaestroUit UpdUit(BeMaestroUit pUit)
        {
            try
            {
                var comandoSql =
                    string.Concat(
                        "UPDATE dbo.MaestroUit ",
                        "SET Anio=@pAnio,  ",
                        "	MontoUnidadImpositivaTrib=@pMontoUnidadImpositivaTrib, ",
                        "	UsuarioCreador=@pUsuarioCreador, ",
                        "	UsuarioModificador=@pUsuarioModificador, ",
                        "	FechaCreacion=@pFechaCreacion, ",
                        "	FechaModificacion=@pFechaModificacion ",
                        "WHERE IdEmpresa=@pIdEmpresa");


                var db = DatabaseFactory.CreateDatabase(HelperConsultas.CadenaConexion);
                var cmd = db.GetSqlStringCommand(comandoSql);

                cmd.Parameters.Add(HelperConsultas.CrearParametro(cmd, "@pIdEmpresa", DbType.Guid, pUit.Empresa.IdEmpresa));
                cmd.Parameters.Add(HelperConsultas.CrearParametro(cmd, "@pAnio", DbType.Int16, pUit.Anio));
                cmd.Parameters.Add(HelperConsultas.CrearParametro(cmd, "@pMontoUnidadImpositivaTrib", DbType.Decimal, pUit.MontoUnidadImpositivaTrib));
                cmd.Parameters.Add(HelperConsultas.CrearParametro(cmd, "@pUsuarioCreador", DbType.String, pUit.UsuarioCreador));
                cmd.Parameters.Add(HelperConsultas.CrearParametro(cmd, "@pUsuarioModificador", DbType.String, pUit.UsuarioModificador));
                cmd.Parameters.Add(HelperConsultas.CrearParametro(cmd, "@pFechaCreacion", DbType.DateTime, pUit.FechaCreacion));
                cmd.Parameters.Add(HelperConsultas.CrearParametro(cmd, "@pFechaModificacion", DbType.DateTime, pUit.FechaModificacion));

                var filas = db.ExecuteNonQuery(cmd);
                pUit.EstadoEntidad = HelperConsultas.SetEstadoEntidad(true, filas, null);
            }
            catch (Exception ex)
            {
                ErrorConsulta = ex;
                pUit.EstadoEntidad = HelperConsultas.SetEstadoEntidad(false, 0, ex);
            }
            return pUit;
        }

        private BeMaestroUit CargarEntidad(IDataReader pReader)
        {
            var uit = new BeMaestroUit();

            try
            {
                uit.Empresa = new BeMaestroEmpresa { IdEmpresa = HelperConsultas.GetValueSql<Guid>(pReader.GetValue(0)) };
                uit.Anio = HelperConsultas.GetValueSql<int>(pReader.GetValue(1));
                uit.MontoUnidadImpositivaTrib = HelperConsultas.GetValueSql<decimal>(pReader.GetValue(2));
                uit.UsuarioCreador = HelperConsultas.GetValueSql<string>(pReader.GetValue(3));
                uit.UsuarioModificador = HelperConsultas.GetValueSql<string>(pReader.GetValue(4));
                uit.FechaCreacion = HelperConsultas.GetValueSql<DateTime>(pReader.GetValue(5));
                uit.FechaModificacion = HelperConsultas.GetValueSql<DateTime>(pReader.GetValue(6));                
            }
            catch (Exception ex)
            {
                uit = null;
                ErrorConsulta = ex;
            }
            return uit;
        }


    }
}
