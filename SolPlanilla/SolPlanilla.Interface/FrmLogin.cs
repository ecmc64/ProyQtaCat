using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Restaurante.UI.BackOffice.Maestros;
using SolPlanilla.BE;


namespace SolPlanilla.Interface
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();

            GlobalVars.PuertoWcf = ConfigurationManager.AppSettings["PuertoWcf"];
        }
        #region Eventos
        private void btnConectar_Click(object sender, EventArgs e)
        {
            if (!ConectarServicio()) return;

            using (var proxy = new ProxyWeb.ServicioPlanillaClient(GlobalVars.PuertoWcf))
            {
                var listaEmpresas = proxy.ConsultarEmpresaLista();
                cmbEmpresa.DataSource = listaEmpresas;
                cmbEmpresa.DisplayMember = "RazonSocial";

            }

            GbLogin.Enabled = true;
            btnConectar.Visible = false;
            picImagen.Visible = true;
            //TODO:llenar combo de empresas
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            //TODO: Validar usuario y contraseña
            GlobalVars.Usuario = txtUsuario.Text.Trim();
            GlobalVars.FechaIngreso = DateTime.Now;

            GlobalVars.Empresa = (BeMaestroEmpresa)cmbEmpresa.SelectedItem;
            GlobalVars.Proyecto = string.Empty;
            
            var oMdi = SingletonFormProvider.GetInstance<FrmMdi>(this);
            //var oMdi = new FrmMdi();
            oMdi.WindowState = FormWindowState.Maximized;
            oMdi.Show();
            Hide();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        #endregion
        
        #region Funciones
        private bool ConectarServicio()
        {
            var resultado = true;
            try
            {
                using (var proxy = new ProxyWeb.ServicioPlanillaClient(GlobalVars.PuertoWcf))
                {
                    resultado = proxy.TestConexion();
                }

            }
            catch (Exception)
            {
                MessageBox.Show(
                    @"Error al conectar con el servidor:" + Environment.NewLine + @"Verifique la conexión de red.",
                    @"Conectar a servidor", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            return resultado;
        }
        #endregion

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtContraseña_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txtContraseña.Focus();

        }

        private void txtContraseña_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                BtnAceptar.Focus(); 
        }

        private void cmbEmpresa_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbEmpresa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txtUsuario.Focus();
        }

        
    }
}
