using System;
using System.Data;
using System.Data.Common;
using SolPlanilla.BE;

namespace SolPlanilla.DA
{
    internal class HelperConsultas
    {
        #region Constantes
        internal const string CadenaConexion = "DB";
        #endregion

        internal static DbParameter CrearParametro(DbCommand pCmd, string pNombreParametro, DbType pDbType, object pValor)
        {
            var par = pCmd.CreateParameter();
            par.ParameterName = pNombreParametro;
            par.DbType = pDbType;
            par.Value = pValor;
            return par;
        }

        internal static T GetValueSql<T>(object pValor)
        {
            var valorParametro = default(T);

            if (pValor != DBNull.Value)
            {
                valorParametro = (T) Convert.ChangeType(pValor, typeof (T));
            }

            return valorParametro;
        }

        internal static BeEstadoEntidad SetEstadoEntidad(bool pEstado, int pFilas, Exception pError)
        {
            return new BeEstadoEntidad{Correcto = pEstado, ErrorEjecutar = pError, NumeroFilasAfectadas = pFilas};
        }

    }
}
