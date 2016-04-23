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
    public class DaMaestroCategoriaObrero
    {
        public Exception ErrorConsulta;

        private const string CadenaSelect = "SELECT IdCategoria, Descripcion, Activo, UsuarioCreador, FechaCreacion, UsuarioModificador, FechaModificacion, IdEmpresa ";

        public BeMaestroCategoriaObrero GetCategoriaObrero(BeMaestroCategoriaObrero pCategoriaObrero)
        {
            var categoria = new BeMaestroCategoriaObrero();
            try
            {
                var comandoSql = string.Concat(CadenaSelect,"FROM dbo.MaestroCategoriaObrero WHERE IdCategoria=@pIdCategoria AND IdEmpresa=@pIdEmpresa");
                var db = DatabaseFactory.CreateDatabase(HelperConsultas.CadenaConexion);
                var cmd = db.GetSqlStringCommand(comandoSql);

                cmd.Parameters.Add(HelperConsultas.CrearParametro(cmd, "@pIdEmpresa", DbType.Guid, pCategoriaObrero.Empresa.IdEmpresa));
                cmd.Parameters.Add(HelperConsultas.CrearParametro(cmd, "@pIdCategoria", DbType.Guid, pCategoriaObrero.IdCategoria));

                var oReader = db.ExecuteReader(cmd);
                var registros = 0;

                if (oReader.Read())
                {
                    categoria = CargarEntidad(oReader);
                    registros++;
                }

                categoria.EstadoEntidad = HelperConsultas.SetEstadoEntidad(true, registros, null);
            }
            catch (Exception ex)
            {
                ErrorConsulta = ex;
                categoria.EstadoEntidad = HelperConsultas.SetEstadoEntidad(false, 0, ex);
            }

            return categoria;
        }

        public List<BeMaestroCategoriaObrero> GetCategoriaObrero(BeMaestroEmpresa pEmpresa)
        {
            var categorias = new List<BeMaestroCategoriaObrero>();
            try
            {
                var comandoSql = string.Concat(CadenaSelect,"FROM dbo.MaestroCategoriaObrero WHERE IdEmpresa=@pIdEmpresa");
                var db = DatabaseFactory.CreateDatabase(HelperConsultas.CadenaConexion);
                var cmd = db.GetSqlStringCommand(comandoSql);

                cmd.Parameters.Add(HelperConsultas.CrearParametro(cmd, "@pIdEmpresa", DbType.Guid, pEmpresa.IdEmpresa));

                var oReader = db.ExecuteReader(cmd);

                while (oReader.Read())
                {
                    var persona = CargarEntidad(oReader);
                    if (persona != null)
                        categorias.Add(persona);
                }
            }
            catch (Exception ex)
            {
                ErrorConsulta = ex;
            }

            return categorias;
        }

        public BeMaestroCategoriaObrero InsCategoriaObrero(BeMaestroCategoriaObrero pCategoriaObrero)
        {
            try
            {
                var comandoSql =
                    string.Concat(
                        "INSERT INTO dbo.MaestroCategoriaObrero ( IdCategoria, Descripcion, Activo, UsuarioCreador, FechaCreacion, UsuarioModificador, FechaModificacion, IdEmpresa ) ",
                        "VALUES  ( @pIdCategoria, @pDescripcion, @pActivo, @pUsuarioCreador, @pFechaCreacion, @pUsuarioModificador, @pFechaModificacion, @pIdEmpresa)");
                var db = DatabaseFactory.CreateDatabase(HelperConsultas.CadenaConexion);
                var cmd = db.GetSqlStringCommand(comandoSql);

                cmd.Parameters.Add(HelperConsultas.CrearParametro(cmd, "@pIdCategoria", DbType.Guid, pCategoriaObrero.IdCategoria));
                cmd.Parameters.Add(HelperConsultas.CrearParametro(cmd, "@pDescripcion", DbType.String, pCategoriaObrero.Descripcion));
                cmd.Parameters.Add(HelperConsultas.CrearParametro(cmd, "@pActivo", DbType.Boolean, pCategoriaObrero.Activo));
                cmd.Parameters.Add(HelperConsultas.CrearParametro(cmd, "@pUsuarioCreador", DbType.String, pCategoriaObrero.UsuarioCreador));
                cmd.Parameters.Add(HelperConsultas.CrearParametro(cmd, "@pFechaCreacion", DbType.DateTime, pCategoriaObrero.FechaCreacion));
                cmd.Parameters.Add(HelperConsultas.CrearParametro(cmd, "@pUsuarioModificador", DbType.String, pCategoriaObrero.UsuarioModificador));
                cmd.Parameters.Add(HelperConsultas.CrearParametro(cmd, "@pFechaModificacion", DbType.DateTime, pCategoriaObrero.FechaModificacion));
                cmd.Parameters.Add(HelperConsultas.CrearParametro(cmd, "@pIdEmpresa", DbType.Guid, pCategoriaObrero.Empresa.IdEmpresa));


                var filas = db.ExecuteNonQuery(cmd);
                pCategoriaObrero.EstadoEntidad = HelperConsultas.SetEstadoEntidad(true, filas, null);
            }
            catch (Exception ex)
            {
                ErrorConsulta = ex;
                pCategoriaObrero.EstadoEntidad = HelperConsultas.SetEstadoEntidad(false, 0, ex);
            }
            return pCategoriaObrero;
        }

        public BeMaestroCategoriaObrero UpdCategoriaObrero(BeMaestroCategoriaObrero pCategoriaObrero)
        {
            try
            {
                var comandoSql =
                    string.Concat(
                        "UPDATE dbo.MaestroCategoriaObrero ",
                        "SET Descripcion=@pDescripcion,  ",
                        "	Activo=@pActivo, ",
                        "	UsuarioModificador=@pUsuarioModificador, ",
                        "	FechaModificacion=@pFechaModificacion ",
                        "WHERE IdCategoria=@pIdCategoria ",
                        "	AND IdEmpresa=@pIdEmpresa");

                var db = DatabaseFactory.CreateDatabase(HelperConsultas.CadenaConexion);
                var cmd = db.GetSqlStringCommand(comandoSql);

                cmd.Parameters.Add(HelperConsultas.CrearParametro(cmd, "@pIdCategoria", DbType.Guid, pCategoriaObrero.IdCategoria));
                cmd.Parameters.Add(HelperConsultas.CrearParametro(cmd, "@pDescripcion", DbType.String, pCategoriaObrero.Descripcion));
                cmd.Parameters.Add(HelperConsultas.CrearParametro(cmd, "@pActivo", DbType.Boolean, pCategoriaObrero.Activo));
                cmd.Parameters.Add(HelperConsultas.CrearParametro(cmd, "@pUsuarioModificador", DbType.String, pCategoriaObrero.UsuarioModificador));
                cmd.Parameters.Add(HelperConsultas.CrearParametro(cmd, "@pFechaModificacion", DbType.DateTime, pCategoriaObrero.FechaModificacion));
                cmd.Parameters.Add(HelperConsultas.CrearParametro(cmd, "@pIdEmpresa", DbType.Guid, pCategoriaObrero.Empresa.IdEmpresa));

                var filas = db.ExecuteNonQuery(cmd);
                pCategoriaObrero.EstadoEntidad = HelperConsultas.SetEstadoEntidad(true, filas, null);
            }
            catch (Exception ex)
            {
                ErrorConsulta = ex;
                pCategoriaObrero.EstadoEntidad = HelperConsultas.SetEstadoEntidad(false, 0, ex);
            }
            return pCategoriaObrero;
        }

        private BeMaestroCategoriaObrero CargarEntidad(IDataReader pReader)
        {
            var categoria = new BeMaestroCategoriaObrero();

            try
            {
                categoria.IdCategoria = HelperConsultas.GetValueSql<Guid>(pReader.GetValue(0));
                categoria.Descripcion = HelperConsultas.GetValueSql<string>(pReader.GetValue(1));
                categoria.Activo = HelperConsultas.GetValueSql<bool>(pReader.GetValue(2));
                categoria.UsuarioCreador = HelperConsultas.GetValueSql<string>(pReader.GetValue(3));
                categoria.FechaCreacion = HelperConsultas.GetValueSql<DateTime>(pReader.GetValue(4));
                categoria.UsuarioModificador = HelperConsultas.GetValueSql<string>(pReader.GetValue(5));
                categoria.FechaModificacion = HelperConsultas.GetValueSql<DateTime>(pReader.GetValue(6));
                categoria.Empresa = new BeMaestroEmpresa
                {
                    IdEmpresa = HelperConsultas.GetValueSql<Guid>(pReader.GetValue(7))
                };
            }
            catch (Exception ex)
            {
                categoria = null;
                ErrorConsulta = ex;
            }
            return categoria;
        }
    }
}
