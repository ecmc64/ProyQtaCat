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
    public partial class FrmUit : Form
    {

        private BeMaestroUit _uit;
        private bool _esNuevoRegistro;

        public FrmUit()
        {
            InitializeComponent();
            _uit = new BeMaestroUit();
            _esNuevoRegistro = true;

        }

        
        private void TxtAnio_TextChanged(object sender, EventArgs e)
        {

        }

        
        private void txtAnio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (e.KeyChar == 46)
            {
                e.Handled = false;
            }
            else if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtImporte.Focus();
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtImporte_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (e.KeyChar == 46)
            {
                e.Handled = false;
            }
            else if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                BtnGrabar.Focus();
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void BtnGrabar_Click(object sender, EventArgs e)
        {
            GuardarRegistro();
        }


        private void CargarGrilla()
        {


            using (var proxy = new ProxyWeb.ServicioPlanillaClient(GlobalVars.PuertoWcf))
            {

                var listaUits = proxy.ConsultarUitLista();
                bsUit.DataSource = null;

                if (listaUits.Any())
                    bsUit.DataSource = listaUits;

            }

        }

        private void SeleccionarItemGrilla()
        {
            if (DgvUit.RowCount == 0)
                return;

            if (DgvUit.CurrentRow == null) return;
            var fila = DgvUit.Rows.IndexOf(DgvUit.CurrentRow);
            _uit = (BeMaestroUit)DgvUit.Rows[fila].DataBoundItem;

            _esNuevoRegistro = false;


            txtAnio.Text = Convert.ToString(_uit.Anio);
            txtImporte.Text = Convert.ToString(_uit.MontoUnidadImpositivaTrib);
                      
        }

        private void NuevoRegistro()
        {
            _esNuevoRegistro = true;


            
            txtAnio.Text = string.Empty;
            txtImporte.Text = string.Empty;
            

            _uit = new BeMaestroUit
            {
                Empresa = GlobalVars.Empresa,
                Anio = DateTime.Now.Year,
                MontoUnidadImpositivaTrib =  0,
                UsuarioCreador = GlobalVars.Usuario,
                UsuarioModificador = GlobalVars.Usuario,
                FechaCreacion = DateTime.Now,
                FechaModificacion = DateTime.Now
            };
        }

        private void GuardarRegistro()
        {
            if (string.IsNullOrEmpty(txtAnio.Text))
            {
                MessageBox.Show(@"Ingrese campo Año");
                return;
            }

            _uit.Anio = int.Parse(txtAnio.Text);
            _uit.MontoUnidadImpositivaTrib = System.Convert.ToDecimal(txtImporte.Text);

            using (var proxy = new ProxyWeb.ServicioPlanillaClient(GlobalVars.PuertoWcf))
            {

                var oUitResultado = proxy.GrabarUit(_uit, _esNuevoRegistro);

                if (oUitResultado.EstadoEntidad.Correcto)
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

        private void FrmUit_Load(object sender, EventArgs e)
        {
            NuevoRegistro();
            CargarGrilla();
        }
               
    }
        
    
}
