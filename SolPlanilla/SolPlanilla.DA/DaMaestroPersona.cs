using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Practices.EnterpriseLibrary.Data;
using SolPlanilla.BE;

namespace SolPlanilla.DA
{
    public class DaMaestroPersona
    {
        public Exception ErrorConsulta;
        private const string CadenaSelect = @"SELECT IdEmpresa, IdPersona, IdDocumento, Numdocumento, Activo, Nombres, Apellidos, Direccion, UsuarioCreador, FechaCreacion, UsuarioModificador, FechaModificacion ";

        public BeMaestroPersona GetMaetroPersona (BeMaestroPersona pPersona)
        {
            var persona = new BeMaestroPersona();
            try
            {
                var comandoSql = string.Concat(CadenaSelect, "FROM dbo.MaestroPersona WHERE IdPersona=@pIdPersona AND IdEmpresa=@pIdEmpresa");
                var db = DatabaseFactory.CreateDatabase(HelperConsultas.CadenaConexion);
                var cmd = db.GetSqlStringCommand(comandoSql);

                cmd.Parameters.Add(HelperConsultas.CrearParametro(cmd, "@pIdEmpresa", DbType.Guid, pPersona.Empresa.IdEmpresa));
                cmd.Parameters.Add(HelperConsultas.CrearParametro(cmd, "@pIdPersona", DbType.Guid, pPersona.IdPersona));

                var oReader = db.ExecuteReader(cmd);
                var filas = 0;
                if (oReader.Read())
                {
                    persona = CargarEntidad(oReader);
                    filas = 1;
                }

                pPersona.EstadoEntidad = HelperConsultas.SetEstadoEntidad(true, filas, null);
            }
            catch (Exception ex)
            {
                ErrorConsulta = ex;
                pPersona.EstadoEntidad = HelperConsultas.SetEstadoEntidad(false, 0, ex);
            }

            return persona;
        }

        public BeMaestroPersona GetMaetroPersonaByDni(BeMaestroEmpresa pEmpresa, string pDni)
        {
            var persona = new BeMaestroPersona();
            try
            {
                var comandoSql = string.Concat(CadenaSelect, "FROM dbo.MaestroPersona WHERE IdEmpresa=@pIdEmpresa AND Numdocumento=@pNumDocumento");
                var db = DatabaseFactory.CreateDatabase(HelperConsultas.CadenaConexion);
                var cmd = db.GetSqlStringCommand(comandoSql);

                cmd.Parameters.Add(HelperConsultas.CrearParametro(cmd, "@pIdEmpresa", DbType.Guid, pEmpresa.IdEmpresa));
                cmd.Parameters.Add(HelperConsultas.CrearParametro(cmd, "@pNumDocumento", DbType.String, pDni));

                var oReader = db.ExecuteReader(cmd);
                var filas = 0;
                if (oReader.Read())
                {
                    persona = CargarEntidad(oReader);
                    filas = 1;
                }

                persona.EstadoEntidad = HelperConsultas.SetEstadoEntidad(true, filas, null);
            }
            catch (Exception ex)
            {
                ErrorConsulta = ex;
                persona.EstadoEntidad = HelperConsultas.SetEstadoEntidad(false, 0, ex);
            }

            return persona;
        }
        public List<BeMaestroPersona> GetMaetroPersona(BeMaestroEmpresa pEmpresa)
        {
            var personas = new List<BeMaestroPersona>();
            try
            {
                var comandoSql = string.Concat(CadenaSelect,"FROM dbo.MaestroPersona WHERE IdEmpresa=@pIdEmpresa");
                var db = DatabaseFactory.CreateDatabase(HelperConsultas.CadenaConexion);
                var cmd = db.GetSqlStringCommand(comandoSql);

                cmd.Parameters.Add(HelperConsultas.CrearParametro(cmd, "@pIdEmpresa", DbType.Guid, pEmpresa.IdEmpresa));

                var oReader = db.ExecuteReader(cmd);

                while (oReader.Read())
                {
                    var persona = CargarEntidad(oReader);
                    if (persona != null)
                        personas.Add(persona);
                }

            }
            catch (Exception ex)
            {
                ErrorConsulta = ex;
            }

            return personas;
        }

        public BeMaestroPersona InsPersona(BeMaestroPersona pPersona)
        {
            try
            {
                var comandoSql =
                    string.Concat(
                        "INSERT INTO dbo.MaestroPersona ( IdPersona, IdDocumento, Numdocumento, Activo, IdEmpresa, Nombres, Apellidos, Direccion, UsuarioCreador, UsuarioModificador, FechaCreacion, FechaModificacion )",
                        "VALUES  ( @pIdPersona,@pIdDocumento,@pNumdocumento,@pActivo,@pIdEmpresa,@pNombres,@pApellidos,@pDireccion,@pUsuarioCreador,@pUsuarioModificador,@pFechaCreacion,@pFechaModificacion)");
                var db = DatabaseFactory.CreateDatabase(HelperConsultas.CadenaConexion);
                var cmd = db.GetSqlStringCommand(comandoSql);

                cmd.Parameters.Add(HelperConsultas.CrearParametro(cmd, "@pIdPersona", DbType.Guid, pPersona.IdPersona));
                cmd.Parameters.Add(HelperConsultas.CrearParametro(cmd, "@pIdDocumento", DbType.Guid, pPersona.Documento.IdDocumento));
                cmd.Parameters.Add(HelperConsultas.CrearParametro(cmd, "@pNumdocumento", DbType.String, pPersona.Documento.NumDocumento));
                cmd.Parameters.Add(HelperConsultas.CrearParametro(cmd, "@pActivo", DbType.Boolean, pPersona.Activo));
                cmd.Parameters.Add(HelperConsultas.CrearParametro(cmd, "@pIdEmpresa", DbType.Guid, pPersona.Empresa.IdEmpresa));
                cmd.Parameters.Add(HelperConsultas.CrearParametro(cmd, "@pNombres", DbType.String, pPersona.Nombres));
                cmd.Parameters.Add(HelperConsultas.CrearParametro(cmd, "@pApellidos", DbType.String, pPersona.Apellidos));
                cmd.Parameters.Add(HelperConsultas.CrearParametro(cmd, "@pDireccion", DbType.String, pPersona.Direccion));
                cmd.Parameters.Add(HelperConsultas.CrearParametro(cmd, "@pUsuarioCreador", DbType.String, pPersona.UsuarioCreador));
                cmd.Parameters.Add(HelperConsultas.CrearParametro(cmd, "@pUsuarioModificador", DbType.String, pPersona.UsuarioModificador));
                cmd.Parameters.Add(HelperConsultas.CrearParametro(cmd, "@pFechaCreacion", DbType.DateTime, pPersona.FechaCreacion));
                cmd.Parameters.Add(HelperConsultas.CrearParametro(cmd, "@pFechaModificacion", DbType.DateTime, pPersona.FechaModificacion));

                var filas = db.ExecuteNonQuery(cmd);
                pPersona.EstadoEntidad = HelperConsultas.SetEstadoEntidad(true, filas, null);
            }
            catch (Exception ex)
            {
                ErrorConsulta = ex;
                pPersona.EstadoEntidad = HelperConsultas.SetEstadoEntidad(false, 0, ex);
            }
            return pPersona;
        }

        public BeMaestroPersona UpdPersona(BeMaestroPersona pPersona)
        {
            try
            {
                var comandoSql =
                    string.Concat(
                        "UPDATE dbo.MaestroPersona ",
                        "SET IdDocumento=@pIdDocumento, ",
                        "	Numdocumento=@pNumdocumento, ",
                        "	Activo=@pActivo, ",
                        "	Nombres=@pNombres, ",
                        "	Apellidos=@pApellidos, ",
                        "	Direccion=@pDireccion, ",
                        "	UsuarioModificador=@pUsuarioModificador, ",
                        "	FechaModificacion=@pFechaModificacion ",
                        "WHERE IdPersona=@pIdPersona ",
                        "	AND IdEmpresa=@pIdEmpresa");
                var db = DatabaseFactory.CreateDatabase(HelperConsultas.CadenaConexion);
                var cmd = db.GetSqlStringCommand(comandoSql);

                cmd.Parameters.Add(HelperConsultas.CrearParametro(cmd, "@pIdPersona", DbType.Guid, pPersona.IdPersona));
                cmd.Parameters.Add(HelperConsultas.CrearParametro(cmd, "@pIdDocumento", DbType.Guid, pPersona.Documento.IdDocumento));
                cmd.Parameters.Add(HelperConsultas.CrearParametro(cmd, "@pNumdocumento", DbType.String, pPersona.Documento.NumDocumento));
                cmd.Parameters.Add(HelperConsultas.CrearParametro(cmd, "@pActivo", DbType.Boolean, pPersona.Activo));
                cmd.Parameters.Add(HelperConsultas.CrearParametro(cmd, "@pIdEmpresa", DbType.Guid, pPersona.Empresa.IdEmpresa));
                cmd.Parameters.Add(HelperConsultas.CrearParametro(cmd, "@pNombres", DbType.String, pPersona.Nombres));
                cmd.Parameters.Add(HelperConsultas.CrearParametro(cmd, "@pApellidos", DbType.String, pPersona.Apellidos));
                cmd.Parameters.Add(HelperConsultas.CrearParametro(cmd, "@pDireccion", DbType.String, pPersona.Direccion));
                cmd.Parameters.Add(HelperConsultas.CrearParametro(cmd, "@pUsuarioModificador", DbType.String, pPersona.UsuarioModificador));
                cmd.Parameters.Add(HelperConsultas.CrearParametro(cmd, "@pFechaModificacion", DbType.DateTime, pPersona.FechaModificacion));

                var filas = db.ExecuteNonQuery(cmd);
                pPersona.EstadoEntidad = HelperConsultas.SetEstadoEntidad(true, filas, null);
            }
            catch (Exception ex)
            {
                ErrorConsulta = ex;
                pPersona.EstadoEntidad = HelperConsultas.SetEstadoEntidad(false, 0, ex);
            }
            return pPersona;
        }

        private BeMaestroPersona CargarEntidad(IDataReader pReader)
        {
            var persona = new BeMaestroPersona();

            try
            {
                persona.Empresa = new BeMaestroEmpresa
                {
                    IdEmpresa = HelperConsultas.GetValueSql<Guid>(pReader.GetValue(0))
                };
                persona.IdPersona = HelperConsultas.GetValueSql<Guid>(pReader.GetValue(1));
                persona.Documento = new BeMaestroDocumento
                {
                    IdDocumento = HelperConsultas.GetValueSql<Guid>(pReader.GetValue(2)),
                    NumDocumento = HelperConsultas.GetValueSql<string>(pReader.GetValue(3)),
                    Empresa = new BeMaestroEmpresa { IdEmpresa = HelperConsultas.GetValueSql<Guid>(pReader.GetValue(0)) }
                };
                persona.Activo = HelperConsultas.GetValueSql<bool>(pReader.GetValue(4));
                persona.Nombres = HelperConsultas.GetValueSql<string>(pReader.GetValue(5));
                persona.Apellidos = HelperConsultas.GetValueSql<string>(pReader.GetValue(6));
                persona.Direccion = HelperConsultas.GetValueSql<string>(pReader.GetValue(7));
                persona.UsuarioCreador = HelperConsultas.GetValueSql<string>(pReader.GetValue(8));
                persona.FechaCreacion = HelperConsultas.GetValueSql<DateTime>(pReader.GetValue(9));
                persona.UsuarioModificador = HelperConsultas.GetValueSql<string>(pReader.GetValue(10));
                persona.FechaModificacion = HelperConsultas.GetValueSql<DateTime>(pReader.GetValue(11));
            }
            catch (Exception ex)
            {
                persona = null;
                ErrorConsulta = ex;
            }
            return persona;
        }
    }
}
