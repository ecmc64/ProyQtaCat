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
    public partial class FrmCategoria : Form
    {
        private BeMaestroCategoriaObrero _categoriaObrero;
        private bool _esNuevoRegistro;

        public FrmCategoria()
        {
            InitializeComponent();
            _categoriaObrero = new BeMaestroCategoriaObrero();
            _esNuevoRegistro = true;
        }
        #region Eventos
        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
        
        private void FrmCategoria_Load(object sender, EventArgs e)
        {
            NuevoRegistro();
            CargarGrilla();
        }

        private void dgvCategoria_Click(object sender, EventArgs e)
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
                var listaEmpresas = proxy.ConsultarCategoriaObreroLista(GlobalVars.Empresa);
                bsCategoria.DataSource = null;

                if (listaEmpresas.Any())
                    bsCategoria.DataSource = listaEmpresas;
            }

            
        }

        private void SeleccionarItemGrilla()
        {
            if (dgvCategoria.RowCount == 0)
                return;

            if (dgvCategoria.CurrentRow == null) return;
            var fila = dgvCategoria.Rows.IndexOf(dgvCategoria.CurrentRow);
            _categoriaObrero = (BeMaestroCategoriaObrero)dgvCategoria.Rows[fila].DataBoundItem;

            _esNuevoRegistro = false;

            txtDescripcion.Text = _categoriaObrero.Descripcion;
            ChkActivo.Checked = _categoriaObrero.Activo;
        }

        private void NuevoRegistro()
        {
            _esNuevoRegistro = true;

            txtDescripcion.Text = string.Empty;
            ChkActivo.Checked = true;

            _categoriaObrero = new BeMaestroCategoriaObrero
            {
                IdCategoria = Guid.NewGuid(),
                Empresa = GlobalVars.Empresa,
                UsuarioCreador = GlobalVars.Usuario,
                UsuarioModificador = GlobalVars.Usuario
            };
        }

        private void GuardarRegistro()
        {
            if (string.IsNullOrEmpty(txtDescripcion.Text))
            {
                MessageBox.Show(@"Ingrese campo Descripción");
                return;
            }

            _categoriaObrero.Descripcion = txtDescripcion.Text.Trim();
            _categoriaObrero.Activo = ChkActivo.Checked;
            _categoriaObrero.FechaModificacion = DateTime.Now;

            if (_esNuevoRegistro)
                _categoriaObrero.FechaCreacion = DateTime.Now;

            using (var proxy = new ProxyWeb.ServicioPlanillaClient(GlobalVars.PuertoWcf))
            {
                var oCategoriaResultado = proxy.GrabarCategoriaObrero(_categoriaObrero, _esNuevoRegistro);

                if (oCategoriaResultado.EstadoEntidad.Correcto)
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

        private void GrbPersona_Enter(object sender, EventArgs e)
        {

        }

        private void GrbConsulta_Enter(object sender, EventArgs e)
        {

        }

        private void dgvCategoria_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }









    }
}
