using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SolPlanilla.BE;


namespace SolPlanilla.Interface
{
    public partial class FrmDocumento : Form
    {
        private BeMaestroDocumento _documentoObrero; 
        private bool _esNuevoRegistro;

        public FrmDocumento()
        {
            InitializeComponent();
            _documentoObrero = new BeMaestroDocumento();
            _esNuevoRegistro = true;
        }

        #region Eventos
        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmDocumento_Load(object sender, EventArgs e)
        {
            NuevoRegistro();
            CargarGrilla();
        }

        private void dgvDocumento_Click(object sender, EventArgs e)
        {
            SeleccionarItemGrilla();
        }


        private void btnNuevo_Click(object sender, EventArgs e)
        {
            NuevoRegistro();
        }

        private void BtnGrabar_Click(object sender, EventArgs e)
        {
            GuardarRegistro();
            NuevoRegistro();
        }

        #endregion

        #region Funciones

        private void CargarGrilla()
        {
            using (var proxy = new ProxyWeb.ServicioPlanillaClient(GlobalVars.PuertoWcf))
            {
                var listaEmpresas = proxy.ConsultarDocumentoLista(GlobalVars.Empresa);
                bsDocumento.DataSource = null;

                if (listaEmpresas.Any())
                    bsDocumento.DataSource = listaEmpresas;
            }


        }

        private void SeleccionarItemGrilla()
        {
            if (dgvDocumento.RowCount == 0)
                return;

            if (dgvDocumento.CurrentRow == null) return;
            var fila = dgvDocumento.Rows.IndexOf(dgvDocumento.CurrentRow);
            _documentoObrero = (BeMaestroDocumento)dgvDocumento.Rows[fila].DataBoundItem;

            _esNuevoRegistro = false;

            TxtDocumento.Text = _documentoObrero.NombreDocumento;
            ChkActivo.Checked = _documentoObrero.Activo;
        }


        private void NuevoRegistro()
        {
            _esNuevoRegistro = true;

         
            TxtDocumento.Text = string.Empty;
            ChkActivo.Checked = true;

            _documentoObrero = new BeMaestroDocumento
            {
                
                IdDocumento = Guid.NewGuid(),                                                                                                                    
                Empresa = GlobalVars.Empresa,                                                                                                                      
                Activo =  ChkActivo.Checked,                                                                                                                          
                NombreDocumento = TxtDocumento.Text,                                                                                                                
                UsuarioCreador  = GlobalVars.Usuario,                                                                                                            
                UsuarioModificador = GlobalVars.Usuario,                                                                                                              
                FechaCreacion = GlobalVars.FechaIngreso,                                                                                                                    
                FechaModificacion = GlobalVars.FechaIngreso  
                                
            };
        }


        private void GuardarRegistro()
        {
           
            _documentoObrero.NombreDocumento = TxtDocumento.Text.Trim();
            _documentoObrero.Activo = ChkActivo.Checked;
            _documentoObrero.FechaModificacion = DateTime.Now;


            if (_esNuevoRegistro)
                _documentoObrero.FechaCreacion = DateTime.Now;

            using (var proxy = new ProxyWeb.ServicioPlanillaClient(GlobalVars.PuertoWcf))
            {
                var oDocumentoResultado = proxy.GrabarDocumento(_documentoObrero, _esNuevoRegistro);

                if (oDocumentoResultado.EstadoEntidad.Correcto)
                {
                    MessageBox.Show(@"Se registró correctamente", @"Guardar", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    CargarGrilla();
                }
                else
                {
                    MessageBox.Show(@"Error al guardar", @"Guardar", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }

        }

        #endregion

        private void GrpConsulta_Enter(object sender, EventArgs e)
        {

        }

        private void dgvDocumento_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void TxtDocumento_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void TxtDocumento_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (string.IsNullOrEmpty(TxtDocumento.Text))
                    return;
                else
                   ChkActivo.Focus();
            }
        }

        private void ChkActivo_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ChkActivo_Click(object sender, EventArgs e)
        {
                 BtnGrabar.Focus();
        }

      


      
    }



}
