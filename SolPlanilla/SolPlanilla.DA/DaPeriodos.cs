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
    public class DaPeriodos
    {
        public Exception ErrorConsulta;

        private const string CadenaSelect = "Select IdPeriodo, IdEmpresa, Anio, Activo, UsuarioCreador, FechaCreacion, UsuarioModificador, FechaModificacion, FechaInicio, FechaFin,SemanaInicio, SemanaFin, Mes ";

        public List<BePeriodos> GetPeriodos(BeMaestroEmpresa pEmpresa)
        {
            var periodos = new List<BE.BePeriodos>();
            try
            {
                string comandoSql = string.Concat(CadenaSelect, @"FROM Periodos WHERE IdEmpresa=@pIdEmpresa");
                var db = DatabaseFactory.CreateDatabase(HelperConsultas.CadenaConexion);
                var cmd = db.GetSqlStringCommand(comandoSql);

                cmd.Parameters.Add(HelperConsultas.CrearParametro(cmd, "@IdEmpresa", DbType.Guid, pEmpresa.IdEmpresa));

                var oReader = db.ExecuteReader(cmd);
                while (oReader.Read())
                {
                    var periodo = CargarEntidad(oReader);
                    periodos.Add(periodo);

                }

            }
            catch (Exception ex)
            {
                ErrorConsulta = ex;
                periodos = null;
            }

            return periodos;
        }

        public BePeriodos GetPeriodoByAnioMes(BePeriodos pPeriodo)
        {
            var periodo = new BePeriodos();
            try
            {
                string comandoSql = string.Concat(CadenaSelect, @"FROM Periodos WHERE IdEmpresa=@pIdEmpresa AND Anio=@pAnio AND Mes=@pMes");
                var db = DatabaseFactory.CreateDatabase(HelperConsultas.CadenaConexion);
                var cmd = db.GetSqlStringCommand(comandoSql);

                cmd.Parameters.Add(HelperConsultas.CrearParametro(cmd, "@IdEmpresa", DbType.Guid, pPeriodo.Empresa.IdEmpresa));
                cmd.Parameters.Add(HelperConsultas.CrearParametro(cmd, "@pAnio", DbType.Int32, pPeriodo.Anio));
                cmd.Parameters.Add(HelperConsultas.CrearParametro(cmd, "@pMes", DbType.Int32, pPeriodo.Mes));

                var oReader = db.ExecuteReader(cmd);
                var fila = 0;

                if (oReader.Read())
                {
                    periodo = CargarEntidad(oReader);
                    fila = 1;
                }
                    
                periodo.EstadoEntidad = HelperConsultas.SetEstadoEntidad(true, fila, null);
            }
            catch (Exception ex)
            {
                ErrorConsulta = ex;
                periodo.EstadoEntidad = HelperConsultas.SetEstadoEntidad(false, 0, ex);
            }

            return periodo;
        }

        public BePeriodos InsPeriodos(BePeriodos pPeriodo)
        {
            try
            {
                var comandoSql =
                    string.Concat(
                        "INSERT INTO dbo.Periodos ( IdPeriodo, IdEmpresa, Anio, Activo, UsuarioCreador, FechaCreacion, UsuarioModificador, FechaModificacion, FechaInicio, FechaFin,SemanaInicio, SemanaFin, Mes) ",
                        "VALUES  ( @pIdPeriodo, @IdEmpresa, @pAnio, @pActivo, @pUsuarioCreador, @pFechaCreacion, @pUsuarioModificador,@pFechaModificacion,@pFechaInicio, @pFechaFin, @pSemanaInicio, @pSemanaFin, @pMes)");

                var db = DatabaseFactory.CreateDatabase(HelperConsultas.CadenaConexion);
                var cmd = db.GetSqlStringCommand(comandoSql);

                CargarParametros(cmd, pPeriodo);

                var filas = db.ExecuteNonQuery(cmd);
                pPeriodo.EstadoEntidad = HelperConsultas.SetEstadoEntidad(true, filas, null);
            }
            catch (Exception ex)
            {
                ErrorConsulta = ex;
                pPeriodo.EstadoEntidad = HelperConsultas.SetEstadoEntidad(false, 0, ex);
            }
            return pPeriodo;
        }

        public BePeriodos UpdPeriodos(BePeriodos pPeriodo)
        {
            try
            {
                var comandoSql =
                    string.Concat(
                        "UPDATE dbo.Periodos ",
                        "SET Anio=@pAnio, ",
                        "   Activo=@pActivo, ",
                        "	UsuarioCreador=@pUsuarioCreador, ",
                        "	FechaCreacion=@pFechaCreacion, ",
                        "	UsuarioModificador=@pUsuarioModificador, ",
                        "	FechaModificacion=@pFechaModificacion, ",
                        "   FechaInicio=@pFechaInicio, ",
                        "	FechaFin=@pFechaFin, ",
                        "	SemanaInicio=@pSemanaInicio, ",
                        "	SemanaFin=@pSemanaFin, ",
                        "	Mes=@pMes ",
                        "WHERE IdPeriodo=@pIdPeriodo ",
                        "   AND IdEmpresa=@pIdEmpresa ");

                var db = DatabaseFactory.CreateDatabase(HelperConsultas.CadenaConexion);
                var cmd = db.GetSqlStringCommand(comandoSql);

                CargarParametros(cmd, pPeriodo);

                var filas = db.ExecuteNonQuery(cmd);
                pPeriodo.EstadoEntidad = HelperConsultas.SetEstadoEntidad(true, filas, null);
            }
            catch (Exception ex)
            {
                ErrorConsulta = ex;
                pPeriodo.EstadoEntidad = HelperConsultas.SetEstadoEntidad(false, 0, ex);
            }
            return pPeriodo;
        }

        private BePeriodos CargarEntidad(IDataReader pReader)
        {
            var periodo = new BePeriodos();
            try
            {
                periodo.IdPeriodo = HelperConsultas.GetValueSql<Guid>(pReader.GetValue(0));
                periodo.Empresa = new BeMaestroEmpresa { IdEmpresa = HelperConsultas.GetValueSql<Guid>(pReader.GetValue(1)) };
                periodo.Anio = HelperConsultas.GetValueSql<int>(pReader.GetValue(2));
                periodo.Activo = HelperConsultas.GetValueSql<Boolean>(pReader.GetValue(3));
                periodo.UsuarioCreador = HelperConsultas.GetValueSql<string>(pReader.GetValue(4));
                periodo.FechaCreacion = HelperConsultas.GetValueSql<DateTime>(pReader.GetValue(5));
                periodo.UsuarioModificador = HelperConsultas.GetValueSql<string>(pReader.GetValue(6));
                periodo.FechaModificacion = HelperConsultas.GetValueSql<DateTime>(pReader.GetValue(7));
                periodo.FechaInicio = HelperConsultas.GetValueSql<DateTime>(pReader.GetValue(8));
                periodo.FechaFin = HelperConsultas.GetValueSql<DateTime>(pReader.GetValue(9));
                periodo.SemanaInicio = HelperConsultas.GetValueSql<int>(pReader.GetValue(10));
                periodo.SemanaFin = HelperConsultas.GetValueSql<int>(pReader.GetValue(11));
                periodo.Mes = HelperConsultas.GetValueSql<int>(pReader.GetValue(12));
            }
            catch (Exception ex)
            {
                periodo = null;
                ErrorConsulta = ex;
            }
            return periodo;
        }

        private void CargarParametros(DbCommand pCmd, BePeriodos pPeriodo)
        {
            pCmd.Parameters.Add(HelperConsultas.CrearParametro(pCmd, "@pIdPeriodo", DbType.Guid, pPeriodo.IdPeriodo));
            pCmd.Parameters.Add(HelperConsultas.CrearParametro(pCmd, "@IdEmpresa", DbType.Guid, pPeriodo.Empresa.IdEmpresa));
            pCmd.Parameters.Add(HelperConsultas.CrearParametro(pCmd, "@pAnio", DbType.Int32, pPeriodo.Anio));
            pCmd.Parameters.Add(HelperConsultas.CrearParametro(pCmd, "@pActivo", DbType.Boolean, pPeriodo.Activo));
            pCmd.Parameters.Add(HelperConsultas.CrearParametro(pCmd, "@pUsuarioCreador", DbType.String, pPeriodo.UsuarioCreador));
            pCmd.Parameters.Add(HelperConsultas.CrearParametro(pCmd, "@pFechaCreacion", DbType.DateTime, pPeriodo.FechaCreacion));
            pCmd.Parameters.Add(HelperConsultas.CrearParametro(pCmd, "@pUsuarioModificador", DbType.String, pPeriodo.UsuarioModificador));
            pCmd.Parameters.Add(HelperConsultas.CrearParametro(pCmd, "@pFechaModificacion", DbType.DateTime, pPeriodo.FechaModificacion));
            pCmd.Parameters.Add(HelperConsultas.CrearParametro(pCmd, "@pFechaInicio", DbType.DateTime, pPeriodo.FechaInicio));
            pCmd.Parameters.Add(HelperConsultas.CrearParametro(pCmd, "@pFechaFin", DbType.DateTime, pPeriodo.FechaFin));
            pCmd.Parameters.Add(HelperConsultas.CrearParametro(pCmd, "@pSemanaInicio", DbType.Int32, pPeriodo.SemanaInicio));
            pCmd.Parameters.Add(HelperConsultas.CrearParametro(pCmd, "@pSemanaFin", DbType.Int32, pPeriodo.SemanaFin));
            pCmd.Parameters.Add(HelperConsultas.CrearParametro(pCmd, "@pMes", DbType.Int32, pPeriodo.Mes));
        }
    }
}
