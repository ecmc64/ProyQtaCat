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
    public partial class FrmObreros : Form
    {
        private BeMaestroObrero _obrero;
        private List<BeMaestroObrero> _listaObreros;
        private List<BeMaestroObrero> _listaMaestroObrerosAll; 
        private bool _grabar;

        public FrmObreros()
        {
            InitializeComponent();
        }

        #region Eventos

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmObreros_Load(object sender, EventArgs e)
        {
            
            ctrlPersonaObrero.LlenarCombo();
            ConsultarListaObreros();
            LlenarGrillaBusqueda();
            LlenarCategorias();
            _grabar = false;
            _listaMaestroObrerosAll = _listaObreros;
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            LimpiarCamposDetalle();
            _grabar = true;
        }

        private void BtnGrabar_Click(object sender, EventArgs e)
        {
            GrabarObrero();
        }
        
        private void txtBusNumDocumento_KeyDown(object sender, KeyEventArgs e)
        {
            GlobalVars.SoloNumeros(e);
            if(e.KeyCode != Keys.Enter) return;
            if (!_listaMaestroObrerosAll.Exists(x => x.Documento.NumDocumento.ToString() == txtBusNumDocumento.Text))
                return;
            _listaObreros = _listaMaestroObrerosAll.Where(x => x.Documento.NumDocumento.ToString() == txtBusNumDocumento.Text).ToList();
            LlenarGrillaBusqueda();
        }

        private void txtBusNombre_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void txtBusApellidos_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void DgvObreros_DoubleClick(object sender, EventArgs e)
        {
            if (DgvObreros.RowCount == 0) return;
            if (DgvObreros.CurrentRow == null) return;

            var fila = DgvObreros.Rows.IndexOf(DgvObreros.CurrentRow);

            var idObrero = new Guid(DgvObreros.Rows[fila].Cells["colCodObrero"].Value.ToString());

            _obrero = _listaObreros.Find(x => x.IdPersona == idObrero);

            _grabar = false;
            MostrarObrero();
        }

        private void BtnBusConsultarAll_Click(object sender, EventArgs e)
        {
            _listaObreros = _listaMaestroObrerosAll;
            LlenarGrillaBusqueda();
        }

        #endregion

        #region Funciones

        private void LimpiarCamposBusqueda()
        {
            txtBusNumDocumento.Text = string.Empty;
            txtBusNombre.Text = string.Empty;
            txtBusApellidos.Text = string.Empty;
        }

        private void LimpiarCamposDetalle()
        {
            ctrlPersonaObrero.Nuevo();
            CmbCategoria.Text = string.Empty;
        }

        private void LlenarGrillaBusqueda()
        {
            DgvObreros.Rows.Clear();
            if (_listaObreros == null) return;

            foreach (var obrero in _listaObreros)
            {
                DgvObreros.Rows.Add(obrero.IdPersona.ToString(),
                    obrero.Documento.NombreDocumento,
                    obrero.Documento.NumDocumento,
                    obrero.Nombres,
                    obrero.Apellidos,
                    obrero.Activo);
            }
        }

        private void ConsultarListaObreros()
        {
            using (var proxy = new ProxyWeb.ServicioPlanillaClient(GlobalVars.PuertoWcf))
            {
                
                var listaObreros = proxy.ConsultarObreroLista(GlobalVars.Empresa);
                _listaObreros = listaObreros;
            }
        }

        private void LlenarCategorias()
        {
            using (var proxy = new ProxyWeb.ServicioPlanillaClient(GlobalVars.PuertoWcf))
            {
                var listaCategorias = proxy.ConsultarCategoriaObreroLista(GlobalVars.Empresa);
                CmbCategoria.DataSource = listaCategorias;
                CmbCategoria.DisplayMember = "Descripcion";
                
            }
        }

        private void GrabarObrero()
        {
            if (string.IsNullOrWhiteSpace(CmbCategoria.Text))
            {
                MessageBox.Show(@"Seleccionar categoría", @"Grabar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            
            var obrero = HelperEntidad.CopiarPropiedadesPersonaObrero(ctrlPersonaObrero.ObtenerMaestroPersona());
            obrero.Categoria = (BeMaestroCategoriaObrero)CmbCategoria.SelectedValue;

            using (var proxy = new ProxyWeb.ServicioPlanillaClient(GlobalVars.PuertoWcf))
            {
                var resultado = proxy.GrabarObrero(obrero, _grabar);

                if (resultado.EstadoEntidad.Correcto)
                {
                    MessageBox.Show(@"Se grabó correctamente", @"Grabar", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    ConsultarListaObreros();
                    LlenarGrillaBusqueda();
                    LimpiarCamposDetalle();
                }
                else
                {
                    MessageBox.Show(@"Error al grabar", @"Grabar", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }


        }

        private void MostrarObrero()
        {
            ctrlPersonaObrero.AsignarPersona(_obrero);
            CmbCategoria.Text = _obrero.Categoria.Descripcion;
        }

        #endregion







        
    }
}
