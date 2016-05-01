using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;
using Microsoft.SqlServer.Server;
using SolPlanilla.BE;

namespace SolPlanilla.Interface.Clases
{
    internal class LeerMdb
    {
        private readonly string _rutaArchivo;

        private readonly Guid m_IdDocumentoDNI = new Guid("1467652E-D708-408C-A83D-AD533646632E");
        private readonly Guid m_IdCategoria = new Guid("354368A5-7519-4E63-89C1-D47D75A1519D");

        public string Mensaje;

        public LeerMdb(string pRutaArchivo)
        {
            _rutaArchivo = pRutaArchivo;
        }

        private string CadenaConexion()
        {
            return string.Format("Provider=Microsoft.Jet.OLEDB.4.0;Data Source={0}", _rutaArchivo);
        }
        public List<BeMaestroObrero> ListarObreros()
        {
            var lista = new List<BeMaestroObrero>();
            try
            {
                var cadenaDeConexion = CadenaConexion();

                using (var cn = new OleDbConnection(cadenaDeConexion))
                {
                    var cmd = new OleDbCommand("Select MtCodi,MtNomb,MtPate,MtMate,MtDire,MtDocu from FDMASTRA", cn);
                    cn.Open();
                    using (var rdr = cmd.ExecuteReader())
                    {
                        while (rdr != null && rdr.Read())
                        {
                            var obrero = new BeMaestroObrero();
                            obrero.IdPersona = Guid.NewGuid();
                            obrero.Nombres = rdr.GetString(1);
                            obrero.Apellidos = string.Format("{0} {1}", rdr.GetString(2), rdr.GetString(3));
                            obrero.Direccion = rdr.GetString(4);
                            obrero.Activo = true;
                            obrero.Documento = new BeMaestroDocumento
                            {
                                IdDocumento = m_IdDocumentoDNI,
                                NumDocumento = rdr.GetString(5)
                            };
                            obrero.Categoria = new BeMaestroCategoriaObrero {IdCategoria = m_IdCategoria};

                            obrero.UsuarioCreador = GlobalVars.Usuario;
                            obrero.FechaCreacion = DateTime.Now;
                            obrero.UsuarioModificador = GlobalVars.Usuario;
                            obrero.FechaModificacion = DateTime.Now;
                            obrero.Empresa = GlobalVars.Empresa;

                            lista.Add(obrero);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Mensaje = ex.Message;
            }

            return lista;
        }

        public List<BeMaestroObras> ListarObras()
        {
            var lista = new List<BeMaestroObras>();
            try
            {
                var cadenaDeConexion = CadenaConexion();

                using (var cn = new OleDbConnection(cadenaDeConexion))
                {
                    var cmd = new OleDbCommand("Select TCodig,TRazon,TDirec,TLocal,TDistr,TNuruc,TInici,TTermi from FDMASEMP where TTpact='S'", cn);
                    cn.Open();
                    using (var rdr = cmd.ExecuteReader())
                    {
                        while (rdr != null && rdr.Read())
                        {
                            var obra = new BeMaestroObras();
                            obra.IdObra = Guid.NewGuid();
                            obra.CodigoAntiguo = rdr.GetString(0);
                            obra.Descripcion = rdr.GetString(1);
                            obra.FechaInicio = rdr.GetDateTime(6);
                            obra.FechaFin = rdr.GetDateTime(7);
                            obra.Activo = true;

                            obra.DireccionObra = string.Format("{0} {1} {2}", rdr.GetString(2), rdr.GetString(3),
                                rdr.GetString(4));
                            obra.RucObra = rdr.GetString(5);


                            obra.UsuarioCreador = GlobalVars.Usuario;
                            obra.FechaCreacion = DateTime.Now;
                            obra.UsuarioModificador = GlobalVars.Usuario;
                            obra.FechaModificacion = DateTime.Now;
                            obra.Empresa = GlobalVars.Empresa;

                            lista.Add(obra);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Mensaje = ex.Message;
            }

            return lista;
        }

        public void LeerTablaObra()
        {
            
        }

        public List<BeImpPeriodos> ListarPeriodos(string pCodEmpresa)
        {
            var lista = new List<BeImpPeriodos>();

            try
            {
                var cadenaDeConexion = CadenaConexion();

                using (var cn = new OleDbConnection(cadenaDeConexion))
                {
                    var cmd = new OleDbCommand(string.Format("Select pCodEmpresa from FD13{0} ", pCodEmpresa), cn);
                    cn.Open();
                    using (var rdr = cmd.ExecuteReader())
                    {
                        while (rdr != null && rdr.Read())
                        {
                            var periodo = new BeImpPeriodos
                            {
                                Anio = rdr.GetInt32(0),
                                Mes = rdr.GetInt32(1),
                                SemanaInicio = rdr.GetInt32(2),
                                SemanaFin = rdr.GetInt32(3)
                            };

                            lista.Add(periodo);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Mensaje = ex.Message;
                lista = null;
            }
            return lista;
        }

    }
}
