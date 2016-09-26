using System.Data;
using System.Data.Common;
using Microsoft.Practices.EnterpriseLibrary.Data;
using SolPlanilla.BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolPlanilla.DA
{
    public class DaPeriodosDeObras
    {
        public Exception ErrorConsulta;
        private const string CadenaSelect = "SELECT IdEmpresa, IdObra, IdPersona, IdPeriodo, UsuarioCreador, FechaCreacion, UsuarioModificador, FechaModificacion, Jornal, Dominical, DescansoMedico, Feriado, BUC, Altura, Agua, Pasaje, Escolar, Movilidad, HoraExtra, Reintegro, Vacaciones, Gratificacion, Viatico, Sepelio, Altitud, Ley29351 ";

        public List<BePeriodosDeObras> GetPeriodosDeObras(BeObreroPorObra pObreroPorObra)
        {
            var listado = new List<BePeriodosDeObras>();
            //try
            //{

            //}
            //catch ()
            //{
                
            //}
            return listado;
        }

        public BePeriodosDeObras GetPeriodosDeObras(BePeriodosDeObras pPeriodoDeObra)
        {
            return pPeriodoDeObra;
        }

        public BePeriodosDeObras InsPeriodosDeObras(BePeriodosDeObras pPeriodosDeObras)
        {
            try
            {
                var comandoSql =
                    string.Concat(
                        "INSERT dbo.PeriodosDeObras ( IdEmpresa, IdObra, IdPersona, IdPeriodo, UsuarioCreador, FechaCreacion, UsuarioModificador, FechaModificacion, Jornal, Dominical, DescansoMedico, Feriado, BUC, Altura, Agua, Pasaje, Escolar, Movilidad, HoraExtra, Reintegro, Vacaciones, Gratificacion, Viatico, Sepelio, Altitud, Ley29351 ) ",
                        "VALUES  ( @pIdEmpresa, @pIdObra, @pIdPersona, @pIdPeriodo, @pUsuarioCreador, @pFechaCreacion, @pUsuarioModificador, @pFechaModificacion, @pJornal, @pDominical, @pDescansoMedico, @pFeriado, @pBUC, @pAltura, @pAgua, @pPasaje, @pEscolar, @pMovilidad, @pHoraExtra, @pReintegro, @pVacaciones, @pGratificacion, @pViatico, @pSepelio, @pAltitud, @pLey29351 )"
                        );

                var db = DatabaseFactory.CreateDatabase(HelperConsultas.CadenaConexion);
                var cmd = db.GetSqlStringCommand(comandoSql);

                CargarParametros(cmd, pPeriodosDeObras);

                var filas = db.ExecuteNonQuery(cmd);
                pPeriodosDeObras.EstadoEntidad = HelperConsultas.SetEstadoEntidad(true, filas, null);

            }
            catch (Exception ex)
            {
                ErrorConsulta = ex;
                pPeriodosDeObras.EstadoEntidad = HelperConsultas.SetEstadoEntidad(false, 0, ex);
            }

            return pPeriodosDeObras;
        }

        public BePeriodosDeObras UpdPeriodosDeObras(BePeriodosDeObras pPeriodosDeObras)
        {
            try
            {
                var comandoSql =
                    string.Concat(
                        "UPDATE PeriodosDeObras ",
                        "SET UsuarioModificador=@pUsuarioModificador, ",
                        "    FechaModificacion=@pFechaModificacion,",
                        "    Jornal=@pJornal,",
                        "    Dominical=@pDominical,",
                        "    DescansoMedico=@pDescansoMedico,",
                        "    Feriado=@pFeriado,",
                        "    BUC=@pBUC,",
                        "    Altura=@pAltura,",
                        "    Agua=@pAgua,",
                        "    Pasaje=@pPasaje,",
                        "    Escolar=@pEscolar,",
                        "    Movilidad=@pMovilidad,",
                        "    HoraExtra=@pHoraExtra,",
                        "    Reintegro=@pReintegro,",
                        "    Vacaciones=@pVacaciones,",
                        "    Gratificacion=@pGratificacion,",
                        "    Viatico=@pViatico,",
                        "    Sepelio=@pSepelio,",
                        "    Altitud=@pAltitud,",
                        "    Ley29351=@pLey29351 ",
                        "WHERE IdEmpresa=@pIdEmpresa",
                        "    AND IdObra=@pIdObra",
                        "    AND IdPersona=@pIdPersona",
                        "    AND IdPeriodo=@pIdPeriodo"
                        );

                var db = DatabaseFactory.CreateDatabase(HelperConsultas.CadenaConexion);
                var cmd = db.GetSqlStringCommand(comandoSql);

                CargarParametros(cmd, pPeriodosDeObras);

                var filas = db.ExecuteNonQuery(cmd);
                pPeriodosDeObras.EstadoEntidad = HelperConsultas.SetEstadoEntidad(true, filas, null);
            }
            catch (Exception ex)
            {
                ErrorConsulta = ex;
                pPeriodosDeObras.EstadoEntidad = HelperConsultas.SetEstadoEntidad(false, 0, ex);
            }
            return pPeriodosDeObras;

        }

        private BePeriodosDeObras CargarEntidad(IDataReader pReader)
        {
            var entidad = new BePeriodosDeObras();

            try
            {
                entidad.Empresa = new BeMaestroEmpresa { IdEmpresa = HelperConsultas.GetValueSql<Guid>(pReader.GetValue(0)) };
                entidad.Obra = new BeMaestroObras { IdObra = HelperConsultas.GetValueSql<Guid>(pReader.GetValue(1)) };
                entidad.Obrero = new BeMaestroObrero { IdPersona = HelperConsultas.GetValueSql<Guid>(pReader.GetValue(2)) };
                entidad.Periodo = new BePeriodos { IdPeriodo = HelperConsultas.GetValueSql<Guid>(pReader.GetValue(3)) };
                entidad.UsuarioCreador = HelperConsultas.GetValueSql<string>(pReader.GetValue(4));
                entidad.FechaCreacion = HelperConsultas.GetValueSql<DateTime>(pReader.GetValue(5));
                entidad.UsuarioModificador = HelperConsultas.GetValueSql<string>(pReader.GetValue(6));
                entidad.FechaModificacion = HelperConsultas.GetValueSql<DateTime>(pReader.GetValue(7));
                entidad.Jornal = HelperConsultas.GetValueSql<double>(pReader.GetValue(8));
                entidad.Dominical = HelperConsultas.GetValueSql<double>(pReader.GetValue(9));
                entidad.DescansoMedico = HelperConsultas.GetValueSql<double>(pReader.GetValue(10));
                entidad.Feriado = HelperConsultas.GetValueSql<double>(pReader.GetValue(11));
                entidad.Buc = HelperConsultas.GetValueSql<double>(pReader.GetValue(12));
                entidad.Altura = HelperConsultas.GetValueSql<double>(pReader.GetValue(13));
                entidad.Agua = HelperConsultas.GetValueSql<double>(pReader.GetValue(14));
                entidad.Pasaje = HelperConsultas.GetValueSql<double>(pReader.GetValue(15));
                entidad.Escolar = HelperConsultas.GetValueSql<double>(pReader.GetValue(16));
                entidad.Movilidad = HelperConsultas.GetValueSql<double>(pReader.GetValue(17));
                entidad.HoraExtra = HelperConsultas.GetValueSql<double>(pReader.GetValue(18));
                entidad.Reintegro = HelperConsultas.GetValueSql<double>(pReader.GetValue(19));
                entidad.Vacaciones = HelperConsultas.GetValueSql<double>(pReader.GetValue(20));
                entidad.Gratificacion = HelperConsultas.GetValueSql<double>(pReader.GetValue(21));
                entidad.Viatico = HelperConsultas.GetValueSql<double>(pReader.GetValue(22));
                entidad.Sepelio = HelperConsultas.GetValueSql<double>(pReader.GetValue(23));
                entidad.Altitud = HelperConsultas.GetValueSql<double>(pReader.GetValue(24));
                entidad.Ley29351 = HelperConsultas.GetValueSql<double>(pReader.GetValue(25));
            }
            catch (Exception ex)
            {
                entidad = null;
                ErrorConsulta = ex;
            }

            return entidad;
        }

        private void CargarParametros(DbCommand pCmd, BePeriodosDeObras pPeriodo)
        {
            pCmd.Parameters.Add(HelperConsultas.CrearParametro(pCmd, "@pIdEmpresa", DbType.Guid, pPeriodo.Empresa.IdEmpresa));
            pCmd.Parameters.Add(HelperConsultas.CrearParametro(pCmd, "@pIdObra", DbType.Guid, pPeriodo.Obra.IdObra));
            pCmd.Parameters.Add(HelperConsultas.CrearParametro(pCmd, "@pIdPersona", DbType.Guid, pPeriodo.Obrero.IdPersona));
            pCmd.Parameters.Add(HelperConsultas.CrearParametro(pCmd, "@pIdPeriodo", DbType.Guid, pPeriodo.Periodo.IdPeriodo));
            pCmd.Parameters.Add(HelperConsultas.CrearParametro(pCmd, "@pUsuarioCreador", DbType.String, pPeriodo.UsuarioCreador));
            pCmd.Parameters.Add(HelperConsultas.CrearParametro(pCmd, "@pFechaCreacion", DbType.DateTime, pPeriodo.FechaCreacion));
            pCmd.Parameters.Add(HelperConsultas.CrearParametro(pCmd, "@pUsuarioModificador", DbType.String, pPeriodo.UsuarioModificador));
            pCmd.Parameters.Add(HelperConsultas.CrearParametro(pCmd, "@pFechaModificacion", DbType.DateTime, pPeriodo.FechaModificacion));
            pCmd.Parameters.Add(HelperConsultas.CrearParametro(pCmd, "@pJornal", DbType.Decimal, pPeriodo.Jornal));
            pCmd.Parameters.Add(HelperConsultas.CrearParametro(pCmd, "@pDominical", DbType.Decimal, pPeriodo.Dominical));
            pCmd.Parameters.Add(HelperConsultas.CrearParametro(pCmd, "@pDescansoMedico", DbType.Decimal, pPeriodo.DescansoMedico));
            pCmd.Parameters.Add(HelperConsultas.CrearParametro(pCmd, "@pFeriado", DbType.Decimal, pPeriodo.Feriado));
            pCmd.Parameters.Add(HelperConsultas.CrearParametro(pCmd, "@pBUC", DbType.Decimal, pPeriodo.Buc));
            pCmd.Parameters.Add(HelperConsultas.CrearParametro(pCmd, "@pAltura", DbType.Decimal, pPeriodo.Altura));
            pCmd.Parameters.Add(HelperConsultas.CrearParametro(pCmd, "@pAgua", DbType.Decimal, pPeriodo.Agua));
            pCmd.Parameters.Add(HelperConsultas.CrearParametro(pCmd, "@pPasaje", DbType.Decimal, pPeriodo.Pasaje));
            pCmd.Parameters.Add(HelperConsultas.CrearParametro(pCmd, "@pEscolar", DbType.Decimal, pPeriodo.Escolar));
            pCmd.Parameters.Add(HelperConsultas.CrearParametro(pCmd, "@pMovilidad", DbType.Decimal, pPeriodo.Movilidad));
            pCmd.Parameters.Add(HelperConsultas.CrearParametro(pCmd, "@pHoraExtra", DbType.Decimal, pPeriodo.HoraExtra));
            pCmd.Parameters.Add(HelperConsultas.CrearParametro(pCmd, "@pReintegro", DbType.Decimal, pPeriodo.Reintegro));
            pCmd.Parameters.Add(HelperConsultas.CrearParametro(pCmd, "@pVacaciones", DbType.Decimal, pPeriodo.Vacaciones));
            pCmd.Parameters.Add(HelperConsultas.CrearParametro(pCmd, "@pGratificacion", DbType.Decimal, pPeriodo.Gratificacion));
            pCmd.Parameters.Add(HelperConsultas.CrearParametro(pCmd, "@pViatico", DbType.Decimal, pPeriodo.Viatico));
            pCmd.Parameters.Add(HelperConsultas.CrearParametro(pCmd, "@pSepelio", DbType.Decimal, pPeriodo.Sepelio));
            pCmd.Parameters.Add(HelperConsultas.CrearParametro(pCmd, "@pAltitud", DbType.Decimal, pPeriodo.Altitud));
            pCmd.Parameters.Add(HelperConsultas.CrearParametro(pCmd, "@pLey29351", DbType.Decimal, pPeriodo.Ley29351));
        }

    }
}
