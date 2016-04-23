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
    public class DaMaestroEmpresa
    {
        public Exception ErrorConsulta;

        private const string CadenaSelect = "SELECT IdEmpresa, RazonSocial,Ruc,Direccion,Activo ";

        public List<BE.BeMaestroEmpresa> GetMaestroEmpresa()
        {
            var empresas = new List<BE.BeMaestroEmpresa>();
            try
            {
                const string comandoSql = @"select IdEmpresa, RazonSocial, Ruc, Direccion, Activo from Maestroempresa Order by RazonSocial";
                var db = DatabaseFactory.CreateDatabase(HelperConsultas.CadenaConexion);
                var cmd = db.GetSqlStringCommand(comandoSql);

                var oReader = db.ExecuteReader(cmd);
                while (oReader.Read())
                {
                    var empresa = new BE.BeMaestroEmpresa();
                    empresa.IdEmpresa = HelperConsultas.GetValueSql<Guid>(oReader.GetValue(0));
                    empresa.RazonSocial = HelperConsultas.GetValueSql<string>(oReader.GetValue(1));
                    empresa.Ruc = HelperConsultas.GetValueSql<string>(oReader.GetValue(2));
                    empresa.Direccion = HelperConsultas.GetValueSql<string>(oReader.GetValue(3));
                    empresa.Activo = HelperConsultas.GetValueSql<bool>(oReader.GetValue(4));

                    empresas.Add(empresa);

                }

            }
            catch (Exception ex)
            {
                ErrorConsulta = ex;
                empresas = null;
            }

            return empresas;
        }

        public BeMaestroEmpresa InsEmpresa(BeMaestroEmpresa pEmpresa)
        {
            try
            {
                var comandoSql =
                    string.Concat(
                        "INSERT INTO dbo.MaestroEmpresa ( IdEmpresa,RazonSocial,Ruc,Direccion,Activo ) ",
                        "VALUES  ( @pIdEmpresa, @pRazonSocial, @pRuc, @pDireccion, @pActivo)");

                var db = DatabaseFactory.CreateDatabase(HelperConsultas.CadenaConexion);
                var cmd = db.GetSqlStringCommand(comandoSql);

                cmd.Parameters.Add(HelperConsultas.CrearParametro(cmd, "@pIdEmpresa", DbType.Guid, pEmpresa.IdEmpresa));
                cmd.Parameters.Add(HelperConsultas.CrearParametro(cmd, "@pRazonSocial", DbType.String, pEmpresa.RazonSocial));
                cmd.Parameters.Add(HelperConsultas.CrearParametro(cmd, "@pRuc", DbType.String, pEmpresa.Ruc));
                cmd.Parameters.Add(HelperConsultas.CrearParametro(cmd, "@pDireccion", DbType.String, pEmpresa.Direccion));
                cmd.Parameters.Add(HelperConsultas.CrearParametro(cmd, "@pActivo", DbType.Boolean, pEmpresa.Activo));

                var filas = db.ExecuteNonQuery(cmd);
                pEmpresa.EstadoEntidad = HelperConsultas.SetEstadoEntidad(true, filas, null);
            }
            catch (Exception ex)
            {
                ErrorConsulta = ex;
                pEmpresa.EstadoEntidad = HelperConsultas.SetEstadoEntidad(false, 0, ex);
            }
            return pEmpresa;
        }

        public BeMaestroEmpresa UpdEmpresa(BeMaestroEmpresa pEmpresa)
        {
            try
            {
                var comandoSql =
                    string.Concat(
                        "UPDATE dbo.MaestroEmpresa ",
                        "SET RazonSocial=@pRazonSocial,  ",
                        "	Ruc=@pRuc, ",
                        "	Direccion=@pDireccion, ",
                        "	Activo=@pActivo ",
                        "WHERE IdEmpresa=@pIdEmpresa");


                var db = DatabaseFactory.CreateDatabase(HelperConsultas.CadenaConexion);
                var cmd = db.GetSqlStringCommand(comandoSql);

                cmd.Parameters.Add(HelperConsultas.CrearParametro(cmd, "@pIdEmpresa", DbType.Guid, pEmpresa.IdEmpresa));
                cmd.Parameters.Add(HelperConsultas.CrearParametro(cmd, "@pRazonSocial", DbType.String, pEmpresa.RazonSocial));
                cmd.Parameters.Add(HelperConsultas.CrearParametro(cmd, "@pRuc", DbType.String, pEmpresa.Ruc));
                cmd.Parameters.Add(HelperConsultas.CrearParametro(cmd, "@pDireccion", DbType.String, pEmpresa.Direccion));
                cmd.Parameters.Add(HelperConsultas.CrearParametro(cmd, "@pActivo", DbType.Boolean, pEmpresa.Activo));

                var filas = db.ExecuteNonQuery(cmd);
                pEmpresa.EstadoEntidad = HelperConsultas.SetEstadoEntidad(true, filas, null);
            }
            catch (Exception ex)
            {
                ErrorConsulta = ex;
                pEmpresa.EstadoEntidad = HelperConsultas.SetEstadoEntidad(false, 0, ex);
            }
            return pEmpresa;
        }

        private BeMaestroEmpresa CargarEntidad(IDataReader pReader)
        {
            var empresa = new BeMaestroEmpresa();

            try
            {
                empresa.IdEmpresa = HelperConsultas.GetValueSql<Guid>(pReader.GetValue(0));
                empresa.RazonSocial = HelperConsultas.GetValueSql<string>(pReader.GetValue(1));
                empresa.Ruc = HelperConsultas.GetValueSql<string>(pReader.GetValue(2));
                empresa.Direccion = HelperConsultas.GetValueSql<string>(pReader.GetValue(3));
                empresa.Activo = HelperConsultas.GetValueSql<bool>(pReader.GetValue(4));


            }
            catch (Exception ex)
            {
                empresa = null;
                ErrorConsulta = ex;
            }
            return empresa;
        }


    }
}
