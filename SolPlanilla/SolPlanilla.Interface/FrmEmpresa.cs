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
    public partial class FrmEmpresa : Form
    {
        
        private BeMaestroEmpresa _empresa;
        private bool _esNuevoRegistro;


        public FrmEmpresa()
        {
            InitializeComponent();
            _empresa = new BeMaestroEmpresa();
            _esNuevoRegistro = true;
        }

        #region Eventos

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmEmpresa_Load(object sender, EventArgs e)
        {
            CargarGrilla();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            NuevoRegistro();

        }


        private void BtnGrabar_Click(object sender, EventArgs e)
        {
            GuardarRegistro();
        }

        #endregion

        #region Funciones

        private void CargarGrilla()
        {
          
            
            using (var proxy = new ProxyWeb.ServicioPlanillaClient(GlobalVars.PuertoWcf))
            {
                
                var listaEmpresas = proxy.ConsultarEmpresaLista();
                bsEmpresa.DataSource = null;

                if (listaEmpresas.Any())
                    bsEmpresa.DataSource = listaEmpresas;
                
            }
           
        }

        private void SeleccionarItemGrilla()
        {
            if (dgvEmpresa.RowCount == 0)
                return;

            if (dgvEmpresa.CurrentRow == null) return;
            var fila = dgvEmpresa.Rows.IndexOf(dgvEmpresa.CurrentRow);
            _empresa = (BeMaestroEmpresa)dgvEmpresa.Rows[fila].DataBoundItem;

            _esNuevoRegistro = false;

            
            txtRazonSocial.Text = _empresa.RazonSocial;
            txtRuc.Text = _empresa.Ruc;
            txtDireccion.Text = _empresa.Direccion;
            chkActivo.Checked = _empresa.Activo;
            
        }


        private void NuevoRegistro()
        {
            _esNuevoRegistro = true;


         /**   txtCodigo.Text = string.Empty;  **/
            txtRazonSocial.Text = string.Empty;
            txtRuc.Text = string.Empty;
            txtDireccion.Text = string.Empty;
            chkActivo.Checked = true;

            _empresa = new BeMaestroEmpresa
            {
                IdEmpresa = Guid.NewGuid(),
                RazonSocial = string.Empty,
                Ruc = GlobalVars.Usuario,
                Direccion = GlobalVars.Usuario
            };
        }

        private void GuardarRegistro()
        {
            if (string.IsNullOrEmpty(txtRazonSocial.Text))
            {
                MessageBox.Show(@"Ingrese campo Razon Social");
                return;
            }

            _empresa.RazonSocial = txtRazonSocial.Text.Trim();
            _empresa.Ruc = txtRuc.Text.Trim();
            _empresa.Direccion = txtDireccion.Text.Trim();
            _empresa.Activo = chkActivo.Checked;

            
            if (_esNuevoRegistro)
                _empresa.IdEmpresa = Guid.NewGuid();

            using (var proxy = new ProxyWeb.ServicioPlanillaClient(GlobalVars.PuertoWcf))
            {
                
                var oEmpresaResultado = proxy.GrabarEmpresa(_empresa, _esNuevoRegistro);

                if (oEmpresaResultado.EstadoEntidad.Correcto)
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

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dgvEmpresa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvEmpresa_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvEmpresa_Click(object sender, EventArgs e)
        {
            SeleccionarItemGrilla();
        }

        private void txtRazonSocial_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                if (string.IsNullOrEmpty(txtRazonSocial.Text))
                {
                    return;
                }
                else
                {
                    txtRuc.Focus();
                }
                    
        }

        private void txtRazonSocial_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtRuc_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                if (string.IsNullOrEmpty(txtRuc.Text))
                {
                    return;
                }
                else
                {
                    txtDireccion.Focus(); 
                }                              
        }

        private void txtRuc_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDireccion_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDireccion_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                if (string.IsNullOrEmpty(txtDireccion.Text))
                {
                    return;
                }
                else
                {
                    chkActivo.Focus();
                }
        }

        private void chkActivo_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkActivo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                BtnGrabar.Focus();
        }


    }
}