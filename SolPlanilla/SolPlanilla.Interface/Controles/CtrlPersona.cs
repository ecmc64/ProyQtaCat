using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SolPlanilla.BE;

namespace SolPlanilla.Interface.Controles
{
    public partial class CtrlPersona : UserControl
    {
        private BeMaestroPersona _persona = new BeMaestroPersona();

        public CtrlPersona()
        {
            InitializeComponent();
        }

        #region Eventos

        private void cmbTipoDocumento_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cmbTipoDocumento.SelectedValue == null) return;
            
            _persona.Documento = (BeMaestroDocumento)cmbTipoDocumento.SelectedValue;
            txtNumeroDocumento.Text = string.Empty;
            txtNumeroDocumento.Focus();
        }

        private void txtNombre_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txtApellido.Focus();
        }

        private void txtApellido_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txtDireccion.Focus();
        }

        private void txtDireccion_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                chkActivo.Focus();
        }
        #endregion

        #region Funciones

        public void Nuevo()
        {
            _persona = new BeMaestroPersona
            {
                IdPersona = Guid.NewGuid(),
                UsuarioCreador = GlobalVars.Usuario,
                UsuarioModificador = GlobalVars.Usuario,
                FechaCreacion = DateTime.Now,
                FechaModificacion = DateTime.Now,
                Empresa = GlobalVars.Empresa,
                Documento = new BeMaestroDocumento()
            };

            txtNumeroDocumento.Text = string.Empty;
            txtNombre.Text = string.Empty;
            txtApellido.Text = string.Empty;
            txtDireccion.Text = string.Empty;
            chkActivo.Checked = true;
        }

        public void AsignarPersona(BeMaestroPersona pPersona)
        {
            _persona = pPersona;
            txtNumeroDocumento.Text = pPersona.Documento.NumDocumento;
            txtNombre.Text = pPersona.Nombres;
            txtApellido.Text = pPersona.Apellidos;
            txtDireccion.Text = pPersona.Direccion;
            chkActivo.Checked = pPersona.Activo;
        }

        public BeMaestroPersona ObtenerMaestroPersona()
        {
            _persona.Nombres = txtNombre.Text.Trim();
            _persona.Apellidos = txtApellido.Text.Trim();
            _persona.Direccion = txtDireccion.Text.Trim();
            _persona.Activo = chkActivo.Checked;
            _persona.Documento = (BeMaestroDocumento)cmbTipoDocumento.SelectedValue;
            _persona.Documento.NumDocumento = txtNumeroDocumento.Text.Trim();
            return _persona;
        }

        public void LlenarCombo()
        {
            using (var proxy = new ProxyWeb.ServicioPlanillaClient(GlobalVars.PuertoWcf))
            {
                var listaDocumentos = proxy.ConsultarDocumentoLista(GlobalVars.Empresa);
                if (listaDocumentos.Any())
                {
                    cmbTipoDocumento.DisplayMember = "NombreDocumento";
                    cmbTipoDocumento.DataSource = listaDocumentos;
                }
                    
            }
        }
        #endregion

        private void txtNumeroDocumento_KeyDown(object sender, KeyEventArgs e)
        {
            GlobalVars.SoloNumeros(e);
        }

    }
}
