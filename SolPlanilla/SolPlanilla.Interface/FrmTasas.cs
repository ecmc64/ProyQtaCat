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
    public partial class FrmTasas : Form
    {

        private BeMaestroTasa _tasa;
        private bool _esNuevoRegistro;

        public FrmTasas()
        {
            InitializeComponent();
            _tasa = new BeMaestroTasa();
            _esNuevoRegistro = true;
        }
        #region Eventos
        private void FrmTasas_Load(object sender, EventArgs e)
        {
            NuevoRegistro();
            CargarGrilla();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnGrabar_Click(object sender, EventArgs e)
        {
            GuardarRegistro();
        }
        #endregion 

        #region Funviones
        private void CargarGrilla()
        {

            using (var proxy = new ProxyWeb.ServicioPlanillaClient(GlobalVars.PuertoWcf))
            {

                var listaTasas = proxy.ConsultarTasaLista();
                bsTasa.DataSource = null;

                if (listaTasas.Any())
                    bsTasa.DataSource = listaTasas;

            }

        }

        private void SeleccionarItemGrilla()
        {
            if (DgvTasa.RowCount == 0)
                return;

            if (DgvTasa.CurrentRow == null) return;
            var fila = DgvTasa.Rows.IndexOf(DgvTasa.CurrentRow);
            _tasa = (BeMaestroTasa)DgvTasa.Rows[fila].DataBoundItem;

            _esNuevoRegistro = false;


            txtRentaExceso.Text = Convert.ToString(_tasa.RentaExcesoUit);
            txtRentaHasta.Text = Convert.ToString(_tasa.RentaHastaUit);
            txtTasa.Text = Convert.ToString(_tasa.Tasas);

        }

        private void NuevoRegistro()
        {
            _esNuevoRegistro = true;

            txtRentaExceso.Text = string.Empty;
            txtRentaHasta.Text = string.Empty;
            txtTasa.Text = string.Empty;

            _tasa = new BeMaestroTasa
            {
                Empresa = GlobalVars.Empresa,
                UsuarioCreador = GlobalVars.Usuario,
                UsuarioModificador = GlobalVars.Usuario,
                FechaCreacion = DateTime.Now,
                FechaModificacion = DateTime.Now,
                IdTasa = Guid.NewGuid(),
                Tasas = 0,
                RentaExcesoUit = 0

            };
        }
        
        private void GuardarRegistro()
        {
            if (string.IsNullOrEmpty(txtRentaExceso.Text))
            {
                MessageBox.Show(@"Ingrese Renta Exceso");
                return;
            }

            if (string.IsNullOrEmpty(txtRentaHasta.Text))
            {
                MessageBox.Show(@"Ingrese Renta Hasta");
                return;
            }

            if (string.IsNullOrEmpty(txtTasa.Text))
            {
                MessageBox.Show(@"Ingrese Tasa");
                return;
            }

            _tasa.RentaExcesoUit = int.Parse(txtRentaExceso.Text);
            _tasa.RentaHastaUit = int.Parse(txtRentaHasta.Text);
            _tasa.Tasas = Convert.ToDecimal(txtTasa.Text);


            using (var proxy = new ProxyWeb.ServicioPlanillaClient(GlobalVars.PuertoWcf))
            {
                
                var oUitResultado = proxy.GrabarTasa(_tasa, _esNuevoRegistro);
                
                
                //var oUitResultado =proxy.GrabarTasa()

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
        #endregion
    }



}
