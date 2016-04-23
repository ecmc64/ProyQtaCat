using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Restaurante.UI.BackOffice.Maestros;

namespace SolPlanilla.Interface
{
    public partial class FrmMdi : Form
    {
        private bool _cerrarAplicacion;

        public FrmMdi()
        {
            InitializeComponent();
            _cerrarAplicacion = true;
        }

        #region Eventos

        private void FrmMdi_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(_cerrarAplicacion)
                Application.Exit();
        }

        private void FrmMdi_Activated(object sender, EventArgs e)
        {
            sslUsuario.Text = @"Usuario: " + GlobalVars.Usuario;
            sslHoraIngreso.Text = @"Hora de ingreso: " + GlobalVars.FechaIngreso.ToShortDateString() + @" " + GlobalVars.FechaIngreso.ToShortTimeString();
            sslProyecto.Text = @"Proyecto: <No seleccionado>";
            sslEmpresa.Text = @"Empresa: " + GlobalVars.Empresa.RazonSocial;
            sslProyecto.Tag = false;
            _cerrarAplicacion = true;
        }

        #region Eventos Menu
        private void mnuASalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mnuACerrarSesion_Click(object sender, EventArgs e)
        {
            _cerrarAplicacion = false;
            var oLogin = SingletonFormProvider.GetInstance<FrmLogin>(this);
            oLogin.Show();
            this.Hide();
        }

        private void mnuAEmpresa_Click(object sender, EventArgs e)
        {
            var oLogin = SingletonFormProvider.GetInstance<FrmEmpresa>(this);
            oLogin.MdiParent = this;
            oLogin.Show();
        }

        private void mnuAUit_Click(object sender, EventArgs e)
        {
            var oLogin = SingletonFormProvider.GetInstance<FrmUit>(this);
            oLogin.MdiParent = this;
            oLogin.Show();
        }

        private void mnuATasa_Click(object sender, EventArgs e)
        {
            var oLogin = SingletonFormProvider.GetInstance<FrmTasas>(this);
            oLogin.MdiParent = this;
            oLogin.Show();
        }

        private void mnuMObras_Click(object sender, EventArgs e)
        {
            var oLogin = SingletonFormProvider.GetInstance<FrmObras>(this);
            oLogin.MdiParent = this;
            oLogin.Show();
        }

        private void mnuMDocumento_Click(object sender, EventArgs e)
        {
            var oLogin = SingletonFormProvider.GetInstance<FrmDocumento>(this);
            oLogin.MdiParent = this;
            oLogin.Show();
        }

        private void mnuMCategoría_Click(object sender, EventArgs e)
        {
            var oLogin = SingletonFormProvider.GetInstance<FrmCategoria>(this);
            oLogin.MdiParent = this;
            oLogin.Show();
        }

        private void mnuMObreros_Click(object sender, EventArgs e)
        {
            var oLogin = SingletonFormProvider.GetInstance<FrmObreros>(this);
            oLogin.MdiParent = this;
            oLogin.Show();
        }

        private void mnuUImportacionObreros_Click(object sender, EventArgs e)
        {
            var oLogin = SingletonFormProvider.GetInstance<FrmImportacionObrero>(this);
            oLogin.MdiParent = this;
            oLogin.Show();
        }
        #endregion


        

        #endregion

        #region Funciones



        #endregion

    }
}
