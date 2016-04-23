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
    public class DaMaestroDocumento
    {
        public Exception ErrorConsulta;

        private const string CadenaSelect = "SELECT IdDocumento,IdEmpresa,Activo,NombreDocumento,UsuarioCreador,UsuarioModificador,FechaCreacion,FechaModificacion ";

        public BeMaestroDocumento GetDocumento(BeMaestroDocumento pDocumento)
        {
            var documento = new BeMaestroDocumento();
            try
            {
                var comandoSql = string.Concat(CadenaSelect, "FROM dbo.MaestroDocumento WHERE IdDocumento=@pIdDocumento AND IdEmpresa=@pIdEmpresa");
                var db = DatabaseFactory.CreateDatabase(HelperConsultas.CadenaConexion);
                var cmd = db.GetSqlStringCommand(comandoSql);

                cmd.Parameters.Add(HelperConsultas.CrearParametro(cmd, "@pIdEmpresa", DbType.Guid, pDocumento.Empresa.IdEmpresa));
                cmd.Parameters.Add(HelperConsultas.CrearParametro(cmd, "@pIdDocumento", DbType.Guid, pDocumento.IdDocumento));

                var oReader = db.ExecuteReader(cmd);
                var registros = 0;

                if (oReader.Read())
                {
                    documento = CargarEntidad(oReader);
                    registros++;
                }

                documento.EstadoEntidad = HelperConsultas.SetEstadoEntidad(true, registros, null);
            }
            catch (Exception ex)
            {
                ErrorConsulta = ex;
                documento.EstadoEntidad = HelperConsultas.SetEstadoEntidad(false, 0, ex);
            }

            return documento;
        }

        public List<BeMaestroDocumento> GetDocumento(BeMaestroEmpresa pEmpresa)
        {
            var documentos = new List<BeMaestroDocumento>();
            try
            {
                var comandoSql = string.Concat(CadenaSelect, "FROM dbo.MaestroDocumento WHERE IdEmpresa=@pIdEmpresa");
                var db = DatabaseFactory.CreateDatabase(HelperConsultas.CadenaConexion);
                var cmd = db.GetSqlStringCommand(comandoSql);

                cmd.Parameters.Add(HelperConsultas.CrearParametro(cmd, "@pIdEmpresa", DbType.Guid, pEmpresa.IdEmpresa));

                var oReader = db.ExecuteReader(cmd);

                while (oReader.Read())
                {
                    var persona = CargarEntidad(oReader);
                    if (persona != null)
                        documentos.Add(persona);
                }
            }
            catch (Exception ex)
            {
                ErrorConsulta = ex;
            }

            return documentos;
        }

        public BeMaestroDocumento InsDocumento(BeMaestroDocumento pDocumento)
        {
            try
            {
                var comandoSql =
                    string.Concat(
                        "INSERT INTO dbo.MaestroDocumento (IdDocumento,IdEmpresa,Activo,NombreDocumento,UsuarioCreador,UsuarioModificador,FechaCreacion,FechaModificacion) ",
                        "VALUES  (@pIdDocumento,@pIdEmpresa,@pActivo,@pNombreDocumento,@pUsuarioCreador,@pUsuarioModificador,@pFechaCreacion,@pFechaModificacion)");
                var db = DatabaseFactory.CreateDatabase(HelperConsultas.CadenaConexion);
                var cmd = db.GetSqlStringCommand(comandoSql);
                cmd.Parameters.Add(HelperConsultas.CrearParametro(cmd, "@pIdDocumento", DbType.Guid, pDocumento.IdDocumento));
                cmd.Parameters.Add(HelperConsultas.CrearParametro(cmd, "@pNombreDocumento", DbType.String, pDocumento.NombreDocumento));
                cmd.Parameters.Add(HelperConsultas.CrearParametro(cmd, "@pActivo", DbType.Boolean, pDocumento.Activo));
                cmd.Parameters.Add(HelperConsultas.CrearParametro(cmd, "@pUsuarioCreador", DbType.String, pDocumento.UsuarioCreador));
                cmd.Parameters.Add(HelperConsultas.CrearParametro(cmd, "@pFechaCreacion", DbType.DateTime, pDocumento.FechaCreacion));
                cmd.Parameters.Add(HelperConsultas.CrearParametro(cmd, "@pUsuarioModificador", DbType.String, pDocumento.UsuarioModificador));
                cmd.Parameters.Add(HelperConsultas.CrearParametro(cmd, "@pFechaModificacion", DbType.DateTime, pDocumento.FechaModificacion));
                cmd.Parameters.Add(HelperConsultas.CrearParametro(cmd, "@pIdEmpresa", DbType.Guid, pDocumento.Empresa.IdEmpresa));


                var filas = db.ExecuteNonQuery(cmd);
                pDocumento.EstadoEntidad = HelperConsultas.SetEstadoEntidad(true, filas, null);
            }
            catch (Exception ex)
            {
                ErrorConsulta = ex;
                pDocumento.EstadoEntidad = HelperConsultas.SetEstadoEntidad(false, 0, ex);
            }
            return pDocumento;
        }

        public BeMaestroDocumento UpdDocumento(BeMaestroDocumento pDocumento)
        {
            try
            {
                var comandoSql =
                    string.Concat(
                        "UPDATE dbo.MaestroDocumento ",
                        "SET NombreDocumento=@pNombreDocumento,  ",
                        "	Activo=@pActivo, ",
                        "	UsuarioModificador=@pUsuarioModificador, ",
                        "	FechaModificacion=@pFechaModificacion ",
                        "WHERE IdDoumento=@pIdDocumento ",
                        "	AND IdEmpresa=@pIdEmpresa");

                var db = DatabaseFactory.CreateDatabase(HelperConsultas.CadenaConexion);
                var cmd = db.GetSqlStringCommand(comandoSql);

                cmd.Parameters.Add(HelperConsultas.CrearParametro(cmd, "@IdDocumento", DbType.Guid, pDocumento.IdDocumento));
                cmd.Parameters.Add(HelperConsultas.CrearParametro(cmd, "@pNombreDocumento", DbType.String, pDocumento.NombreDocumento));
                cmd.Parameters.Add(HelperConsultas.CrearParametro(cmd, "@pActivo", DbType.Boolean, pDocumento.Activo));
                cmd.Parameters.Add(HelperConsultas.CrearParametro(cmd, "@pUsuarioCreador", DbType.String, pDocumento.UsuarioCreador));
                cmd.Parameters.Add(HelperConsultas.CrearParametro(cmd, "@pFechaCreacion", DbType.DateTime, pDocumento.FechaCreacion));
                cmd.Parameters.Add(HelperConsultas.CrearParametro(cmd, "@pUsuarioModificador", DbType.String, pDocumento.UsuarioModificador));
                cmd.Parameters.Add(HelperConsultas.CrearParametro(cmd, "@pFechaModificacion", DbType.DateTime, pDocumento.FechaModificacion));
                cmd.Parameters.Add(HelperConsultas.CrearParametro(cmd, "@pIdEmpresa", DbType.Guid, pDocumento.Empresa.IdEmpresa));

                var filas = db.ExecuteNonQuery(cmd);
                pDocumento.EstadoEntidad = HelperConsultas.SetEstadoEntidad(true, filas, null);
            }
            catch (Exception ex)
            {
                ErrorConsulta = ex;
                pDocumento.EstadoEntidad = HelperConsultas.SetEstadoEntidad(false, 0, ex);
            }
            return pDocumento;
        }
        private BeMaestroDocumento CargarEntidad(IDataReader pReader)
        {
            var documento = new BeMaestroDocumento();

            try
            {
                documento.IdDocumento = HelperConsultas.GetValueSql<Guid>(pReader.GetValue(0));
                documento.Empresa = new BeMaestroEmpresa
                {
                    IdEmpresa = HelperConsultas.GetValueSql<Guid>(pReader.GetValue(1))
                };
                documento.Activo = HelperConsultas.GetValueSql<bool>(pReader.GetValue(2));
                documento.NombreDocumento = HelperConsultas.GetValueSql<string>(pReader.GetValue(3));
                documento.UsuarioCreador = HelperConsultas.GetValueSql<string>(pReader.GetValue(4));
                documento.UsuarioModificador = HelperConsultas.GetValueSql<string>(pReader.GetValue(5));
                documento.FechaCreacion = HelperConsultas.GetValueSql<DateTime>(pReader.GetValue(6));
                documento.FechaModificacion = HelperConsultas.GetValueSql<DateTime>(pReader.GetValue(7));

            }
            catch (Exception ex)
            {
                documento = null;
                ErrorConsulta = ex;
            }
            return documento;
        }
    }
}
