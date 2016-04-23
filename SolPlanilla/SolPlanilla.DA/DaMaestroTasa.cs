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
    public class DaMaestroTasa
    {
        public Exception ErrorConsulta;

        private const string CadenaSelect = "Select IdEmpresa,UsuarioCreador,UsuarioModificador,FechaCreacion,FechaModificacion,IdTasa,Tasa,RentaExcesoUit,RentaHastaUit ";

        public List<BE.BeMaestroTasa> GetMaestroTasa()
        {
            var tasas = new List<BE.BeMaestroTasa>();
            try
            {
                var comandoSql = string.Concat(CadenaSelect, "from MaestroTasa order by IdTasa");
                var db = DatabaseFactory.CreateDatabase(HelperConsultas.CadenaConexion);
                var cmd = db.GetSqlStringCommand(comandoSql);

                var oReader = db.ExecuteReader(cmd);
                while (oReader.Read())
                {

                    var tasa = CargarEntidad(oReader);
                    tasas.Add(tasa);

                }

            }
            catch (Exception ex)
            {
                ErrorConsulta = ex;
                tasas = null;
            }

            return tasas;

        }

        public BeMaestroTasa InsTasa(BeMaestroTasa pTasa)
        {
            try
            {
                var comandoSql =
                    string.Concat(
                        "INSERT INTO dbo.MaestroTasa ( IdEmpresa,UsuarioCreador,FechaCreacion,IdTasa,Tasa,RentaExcesoUit,RentaHastaUit,UsuarioModificador,FechaModificacion ) ",
                        "VALUES  ( @pIdEmpresa,@pUsuarioCreador,@pFechaCreacion,@pIdTasa,@pTasa,@pRentaExcesoUit,@pRentaHastaUit,@pUsuarioModificador,@pFechaModificacion)");

                var db = DatabaseFactory.CreateDatabase(HelperConsultas.CadenaConexion);
                var cmd = db.GetSqlStringCommand(comandoSql);

                cmd.Parameters.Add(HelperConsultas.CrearParametro(cmd, "@pIdEmpresa", DbType.Guid, pTasa.Empresa.IdEmpresa));
                cmd.Parameters.Add(HelperConsultas.CrearParametro(cmd, "@pUsuarioCreador", DbType.String, pTasa.UsuarioCreador));
                cmd.Parameters.Add(HelperConsultas.CrearParametro(cmd, "@pFechaCreacion", DbType.DateTime, pTasa.FechaCreacion));
                cmd.Parameters.Add(HelperConsultas.CrearParametro(cmd, "@pIdTasa", DbType.Guid, pTasa.IdTasa));
                cmd.Parameters.Add(HelperConsultas.CrearParametro(cmd, "@pTasa", DbType.Decimal, pTasa.Tasas));
                cmd.Parameters.Add(HelperConsultas.CrearParametro(cmd, "@pRentaExcesoUit", DbType.Int16, pTasa.RentaExcesoUit));
                cmd.Parameters.Add(HelperConsultas.CrearParametro(cmd, "@pRentaHastaUit", DbType.Int16, pTasa.RentaHastaUit));
                cmd.Parameters.Add(HelperConsultas.CrearParametro(cmd, "@pUsuarioModificador", DbType.String, pTasa.UsuarioCreador));
                cmd.Parameters.Add(HelperConsultas.CrearParametro(cmd, "@pFechaModificacion", DbType.DateTime, pTasa.FechaCreacion));


                var filas = db.ExecuteNonQuery(cmd);
                pTasa.EstadoEntidad = HelperConsultas.SetEstadoEntidad(true, filas, null);
            }
            catch (Exception ex)
            {
                ErrorConsulta = ex;
                pTasa.EstadoEntidad = HelperConsultas.SetEstadoEntidad(false, 0, ex);
            }
            return pTasa;
        }

        public BeMaestroTasa UpdTasa(BeMaestroTasa pTasa)
        {
            try
            {
                var comandoSql =
                    string.Concat(
                        "UPDATE dbo.MaestroTasa ",
                        "SET MontoUnidadImpositivaTrib=@pMontoUnidadImpositivaTrib, ",
                        "	UsuarioModificador=@pUsuarioModificador, ",
                        "	FechaModificacion=@pFechaModificacion ",
                        "	Tasa=@pTasa ",
                        "	RentaExcesoUit=@pRentaExcesoUit ",
                        "	RentaHastaUit=@pRentaHastaUit ",
                        "WHERE IdEmpresa=@pIdEmpresa And IdTasa = @pIdTasa");


                var db = DatabaseFactory.CreateDatabase(HelperConsultas.CadenaConexion);
                var cmd = db.GetSqlStringCommand(comandoSql);

                cmd.Parameters.Add(HelperConsultas.CrearParametro(cmd, "@pIdEmpresa", DbType.Guid, pTasa.Empresa.IdEmpresa));
                cmd.Parameters.Add(HelperConsultas.CrearParametro(cmd, "@pUsuarioModificador", DbType.String, pTasa.UsuarioCreador));
                cmd.Parameters.Add(HelperConsultas.CrearParametro(cmd, "@pFechaModificacion", DbType.DateTime, pTasa.FechaCreacion));
                cmd.Parameters.Add(HelperConsultas.CrearParametro(cmd, "@pIdTasa", DbType.Guid, pTasa.IdTasa));
                cmd.Parameters.Add(HelperConsultas.CrearParametro(cmd, "@pTasa", DbType.Decimal, pTasa.Tasas));
                cmd.Parameters.Add(HelperConsultas.CrearParametro(cmd, "@pRentaExcesoUit", DbType.Int16, pTasa.RentaExcesoUit));
                cmd.Parameters.Add(HelperConsultas.CrearParametro(cmd, "@pRentaHastaUit", DbType.Int16, pTasa.RentaHastaUit));

                var filas = db.ExecuteNonQuery(cmd);
                pTasa.EstadoEntidad = HelperConsultas.SetEstadoEntidad(true, filas, null);
            }
            catch (Exception ex)
            {
                ErrorConsulta = ex;
                pTasa.EstadoEntidad = HelperConsultas.SetEstadoEntidad(false, 0, ex);
            }
            return pTasa;
        }
        private BeMaestroTasa CargarEntidad(IDataReader pReader)
        {
            var tasa = new BeMaestroTasa();

            try
            {
                tasa.Empresa = new BeMaestroEmpresa { IdEmpresa = HelperConsultas.GetValueSql<Guid>(pReader.GetValue(0)) };
                tasa.UsuarioCreador = HelperConsultas.GetValueSql<string>(pReader.GetValue(1));
                tasa.UsuarioModificador = HelperConsultas.GetValueSql<string>(pReader.GetValue(2));
                tasa.FechaCreacion = HelperConsultas.GetValueSql<DateTime>(pReader.GetValue(3));
                tasa.FechaModificacion = HelperConsultas.GetValueSql<DateTime>(pReader.GetValue(4));
                tasa.IdTasa = HelperConsultas.GetValueSql<Guid>(pReader.GetValue(5));
                tasa.Tasas = HelperConsultas.GetValueSql<Decimal>(pReader.GetValue(6));
                tasa.RentaExcesoUit = HelperConsultas.GetValueSql<Int16>(pReader.GetValue(7));
                tasa.RentaHastaUit = HelperConsultas.GetValueSql<Int16>(pReader.GetValue(8));

            }
            catch (Exception ex)
            {
                tasa = null;
                ErrorConsulta = ex;
            }
            return tasa;
        }
    }
}
