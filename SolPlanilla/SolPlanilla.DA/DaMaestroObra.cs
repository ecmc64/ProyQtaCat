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
    public class DaMaestroObra
    {
        public Exception ErrorConsulta;

        private const string CadenaSelect =
            "SELECT IdEmpresa, IdObra, Descripcion, FechaInicio, FechaFin, Activo, DireccionObra, RucObra, UsuarioCreador, FechaCreacion, UsuarioModificador, FechaModificacion, CodigoAntiguo ";
        
        public BeMaestroObras GetMaestroObras(BeMaestroObras pMaestroObras)
        {
            var obra = new BeMaestroObras();
            try
            {
                var comandoSql = string.Concat(CadenaSelect, "FROM dbo.MaestroObras WHERE IdEmpresa=@pIdEmpresa AND IdObra=@pIdObra");
                var db = DatabaseFactory.CreateDatabase(HelperConsultas.CadenaConexion);
                var cmd = db.GetSqlStringCommand(comandoSql);

                cmd.Parameters.Add(HelperConsultas.CrearParametro(cmd, "@pIdEmpresa", DbType.Guid, pMaestroObras.Empresa.IdEmpresa));
                cmd.Parameters.Add(HelperConsultas.CrearParametro(cmd, "@pIdDocumento", DbType.Guid, pMaestroObras.IdObra));

                var oReader = db.ExecuteReader(cmd);
                var registros = 0;

                if (oReader.Read())
                {
                    obra = CargarEntidad(oReader);
                    registros++;
                }

                obra.EstadoEntidad = HelperConsultas.SetEstadoEntidad(true, registros, null);
            }
            catch (Exception ex)
            {
                ErrorConsulta = ex;
                obra.EstadoEntidad = HelperConsultas.SetEstadoEntidad(false, 0, ex);
            }

            return obra;
        }

        public BeMaestroObras GetMaestroObrasByCodigoAntiguo(BeMaestroObras pMaestroObras)
        {
            var obra = new BeMaestroObras();
            try
            {
                var comandoSql = string.Concat(CadenaSelect, "FROM dbo.MaestroObras WHERE IdEmpresa=@pIdEmpresa AND CodigoAntiguo=@CodigoAntiguo");
                var db = DatabaseFactory.CreateDatabase(HelperConsultas.CadenaConexion);
                var cmd = db.GetSqlStringCommand(comandoSql);

                cmd.Parameters.Add(HelperConsultas.CrearParametro(cmd, "@pIdEmpresa", DbType.Guid, pMaestroObras.Empresa.IdEmpresa));
                cmd.Parameters.Add(HelperConsultas.CrearParametro(cmd, "@CodigoAntiguo", DbType.String, pMaestroObras.CodigoAntiguo));

                var oReader = db.ExecuteReader(cmd);
                var registros = 0;

                if (oReader.Read())
                {
                    obra = CargarEntidad(oReader);
                    registros++;
                }

                obra.EstadoEntidad = HelperConsultas.SetEstadoEntidad(true, registros, null);
            }
            catch (Exception ex)
            {
                ErrorConsulta = ex;
                obra.EstadoEntidad = HelperConsultas.SetEstadoEntidad(false, 0, ex);
            }

            return obra;
        }
        
        public List<BeMaestroObras> GetMaestroObras(BeMaestroEmpresa pEmpresa)
        {
            var obras = new List<BeMaestroObras>();

            try
            {
                var comandoSql = string.Concat(CadenaSelect, "FROM dbo.MaestroObras WHERE IdEmpresa=@pIdEmpresa");
                var db = DatabaseFactory.CreateDatabase(HelperConsultas.CadenaConexion);
                var cmd = db.GetSqlStringCommand(comandoSql);

                cmd.Parameters.Add(HelperConsultas.CrearParametro(cmd, "@pIdEmpresa", DbType.Guid, pEmpresa.IdEmpresa));

                var oReader = db.ExecuteReader(cmd);

                while (oReader.Read())
                {
                    var obra = CargarEntidad(oReader);
                    if (obra != null)
                        obras.Add(obra);
                }
            }
            catch (Exception ex)
            {
                ErrorConsulta = ex;
            }

            return obras;
        }

        public BeMaestroObras InsMaestroObras(BeMaestroObras pObra)
        {
            try
            {
                var comandoSql =
                    string.Concat(
                        "INSERT INTO dbo.MaestroObras ( IdEmpresa, IdObra, Descripcion, FechaInicio, FechaFin, Activo, DireccionObra, RucObra, UsuarioCreador, FechaCreacion, UsuarioModificador, FechaModificacion, CodigoAntiguo ) ",
                        "VALUES  ( @pIdEmpresa,@pIdObra,@pDescripcion, @pFechaInicio, @pFechaFin, @pActivo, @pDireccionObra, @pRucObra, @pUsuarioCreador,@pFechaCreacion, @pUsuarioModificador, @pFechaModificacion, @pCodigoAntiguo )");
                var db = DatabaseFactory.CreateDatabase(HelperConsultas.CadenaConexion);
                var cmd = db.GetSqlStringCommand(comandoSql);
                CargarParametros(cmd, pObra);

                var filas = db.ExecuteNonQuery(cmd);
                pObra.EstadoEntidad = HelperConsultas.SetEstadoEntidad(true, filas, null);
            }
            catch (Exception ex)
            {
                ErrorConsulta = ex;
                pObra.EstadoEntidad = HelperConsultas.SetEstadoEntidad(false, 0, ex);
            }
            return pObra;
        }

        public BeMaestroObras UpdMaestroObra(BeMaestroObras pObra)
        {
            try
            {
                var comandoSql =
                    string.Concat(
                        "UPDATE dbo.MaestroObras ",
                        "SET Activo=@pActivo,  ",
                        "	CodigoAntiguo=@pCodigoAntiguo, ",
                        "	Descripcion=@pDescripcion,",
                        "	DireccionObra=@pDireccionObra,",
                        "	FechaFin=@pFechaFin, ",
                        "	FechaInicio=@pFechaInicio, ",
                        "	FechaModificacion=@pFechaModificacion, ",
                        "	RucObra=@pRucObra, ",
                        "	UsuarioModificador=@pUsuarioModificador ",
                        "WHERE IdEmpresa=@pIdEmpresa ",
                        "	AND IdObra=@pidObra");

                var db = DatabaseFactory.CreateDatabase(HelperConsultas.CadenaConexion);
                var cmd = db.GetSqlStringCommand(comandoSql);

                CargarParametros(cmd,pObra);

                var filas = db.ExecuteNonQuery(cmd);
                pObra.EstadoEntidad = HelperConsultas.SetEstadoEntidad(true, filas, null);
            }
            catch (Exception ex)
            {
                ErrorConsulta = ex;
                pObra.EstadoEntidad = HelperConsultas.SetEstadoEntidad(false, 0, ex);
            }
            return pObra;
        }

        private BeMaestroObras CargarEntidad(IDataReader pReader)
        {
            var obra = new BeMaestroObras();

            try
            {
                obra.IdObra = HelperConsultas.GetValueSql<Guid>(pReader.GetValue(1));
                obra.Empresa = new BeMaestroEmpresa
                {
                    IdEmpresa = HelperConsultas.GetValueSql<Guid>(pReader.GetValue(0))
                };

                obra.Descripcion = HelperConsultas.GetValueSql<string>(pReader.GetValue(2));
                obra.FechaInicio = HelperConsultas.GetValueSql<DateTime>(pReader.GetValue(3));
                obra.FechaFin = HelperConsultas.GetValueSql<DateTime>(pReader.GetValue(4));
                obra.Activo = HelperConsultas.GetValueSql<bool>(pReader.GetValue(5));
                obra.DireccionObra = HelperConsultas.GetValueSql<string>(pReader.GetValue(6));
                obra.RucObra = HelperConsultas.GetValueSql<string>(pReader.GetValue(7));
                obra.UsuarioCreador=HelperConsultas.GetValueSql<string>(pReader.GetValue(8));
                obra.FechaCreacion=HelperConsultas.GetValueSql<DateTime>(pReader.GetValue(9));
                obra.UsuarioModificador = HelperConsultas.GetValueSql<string>(pReader.GetValue(10));
                obra.FechaModificacion = HelperConsultas.GetValueSql<DateTime>(pReader.GetValue(11));
                obra.CodigoAntiguo = HelperConsultas.GetValueSql<string>(pReader.GetValue(12));

            }
            catch (Exception ex)
            {
                obra = null;
                ErrorConsulta = ex;
            }
            return obra;
        }

        private void CargarParametros(DbCommand pCmd, BeMaestroObras pObra)
        {
            pCmd.Parameters.Add(HelperConsultas.CrearParametro(pCmd, "@pIdObra", DbType.Guid, pObra.IdObra));
            pCmd.Parameters.Add(HelperConsultas.CrearParametro(pCmd, "@pDescripcion", DbType.String, pObra.Descripcion));
            pCmd.Parameters.Add(HelperConsultas.CrearParametro(pCmd, "@pFechaInicio", DbType.DateTime, pObra.FechaInicio));
            pCmd.Parameters.Add(HelperConsultas.CrearParametro(pCmd, "@pFechaFin", DbType.DateTime, pObra.FechaFin));
            pCmd.Parameters.Add(HelperConsultas.CrearParametro(pCmd, "@pDireccionObra", DbType.String, pObra.DireccionObra));
            pCmd.Parameters.Add(HelperConsultas.CrearParametro(pCmd, "@pRucObra", DbType.String, pObra.RucObra));
            pCmd.Parameters.Add(HelperConsultas.CrearParametro(pCmd, "@pActivo", DbType.Boolean, pObra.Activo));
            pCmd.Parameters.Add(HelperConsultas.CrearParametro(pCmd, "@pUsuarioCreador", DbType.String, pObra.UsuarioCreador));
            pCmd.Parameters.Add(HelperConsultas.CrearParametro(pCmd, "@pFechaCreacion", DbType.DateTime, pObra.FechaCreacion));
            pCmd.Parameters.Add(HelperConsultas.CrearParametro(pCmd, "@pUsuarioModificador", DbType.String, pObra.UsuarioModificador));
            pCmd.Parameters.Add(HelperConsultas.CrearParametro(pCmd, "@pFechaModificacion", DbType.DateTime, pObra.FechaModificacion));
            pCmd.Parameters.Add(HelperConsultas.CrearParametro(pCmd, "@pIdEmpresa", DbType.Guid, pObra.Empresa.IdEmpresa));
            pCmd.Parameters.Add(HelperConsultas.CrearParametro(pCmd, "@pCodigoAntiguo", DbType.String, pObra.CodigoAntiguo));
        }
    }
}
