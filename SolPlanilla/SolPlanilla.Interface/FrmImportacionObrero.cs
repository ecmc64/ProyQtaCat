using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace SolPlanilla.Interface
{
    public partial class FrmImportacionObrero : Form
    {
        private string textoCombo;
        private string rutaArchivo;
        
        public FrmImportacionObrero()
        {
            InitializeComponent();
        }

        #region Eventos
        private void FrmImportacionObrero_Load(object sender, EventArgs e)
        {
            pbProgreso.Visible = lblProgreso.Visible = false;
            pbProgreso.Tag = 0;
        }

        private void BgwImportar_DoWork(object sender, DoWorkEventArgs e)
        {
            switch (textoCombo)
            {
                case "Obreros":
                    ImportarObrero(e);
                    break;
                case "Obras":
                    ImportarObra(e);
                    break;

            }
            
        }

        private void BgwImportar_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            if (e.UserState == null)
                pbProgreso.Value = e.ProgressPercentage;
            else
            {
                var exp = (Exception) e.UserState;
                pbProgreso.Tag = 1;
                MessageBox.Show(@"Error al importar: " + exp.Message, @"Importación", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void BgwImportar_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if ((int)pbProgreso.Tag == 0)
                MessageBox.Show((e.Cancelled) ? @"Se canceló la importación." : @"Se culminó la importación.", @"Importar",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

            lblProgreso.Visible = false;
            pbProgreso.Visible = false;
        }

        private void btnExaminar_Click(object sender, EventArgs e)
        {
            if(BgwImportar.IsBusy) return;

            var openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = @"Archivos mdb|*.mdb";
            openFileDialog1.Title = @"Seleccione base de datos de trabajadores";

            txtRuta.Text = openFileDialog1.ShowDialog() == DialogResult.OK ? openFileDialog1.FileName : string.Empty;
        }
        
        #endregion

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (BgwImportar.IsBusy)
            {
                if (MessageBox.Show(@"¿Desea cancelar la importación?", @"Cancelar", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    BgwImportar.CancelAsync();
                }
            }
            else
            {
                this.Close();
            }
        }

        private void btnImportar_Click(object sender, EventArgs e)
        {
            if (BgwImportar.IsBusy) return;
            if (string.IsNullOrEmpty(cmbTabla.Text))
            {
                MessageBox.Show(@"Seleccione tabla a importar", @"Importar", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                return;
            }
            if (string.IsNullOrWhiteSpace(txtRuta.Text))
            {
                MessageBox.Show(@"Seleccione el archivo a importar", @"Importar", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                return;
            }
            textoCombo = cmbTabla.Text;
            rutaArchivo = txtRuta.Text;

            lblProgreso.Visible = pbProgreso.Visible = true;
            pbProgreso.Minimum = 0;
            pbProgreso.Maximum = 100;
            pbProgreso.Value = 0;
            BgwImportar.RunWorkerAsync();
        }

        #region Funciones

        private void ImportarObrero(DoWorkEventArgs e)
        {
            var lecturaMdb = new Clases.LeerMdb(rutaArchivo);
            var obreros = lecturaMdb.ListarObreros();
            var i = 1;
            Exception ex = null;
            using (var proxy = new ProxyWeb.ServicioPlanillaClient(GlobalVars.PuertoWcf))
            {
                foreach (var obrero in obreros)
                {
                    if (BgwImportar.CancellationPending)
                    {
                        e.Cancel = true;
                        break;
                    }


                    var obreoImportado = proxy.ImportarObrero(obrero);
                    if (!obreoImportado.EstadoEntidad.Correcto)
                    {
                        e.Cancel = true;
                        ex = obreoImportado.EstadoEntidad.ErrorEjecutar;
                    }

                    var a = (i * 100) / obreros.Count;
                    BgwImportar.ReportProgress(a, ex);
                    i++;
                }
            }
        }

        private void ImportarObra(DoWorkEventArgs e)
        {
            var lecturaMdb = new Clases.LeerMdb(rutaArchivo);

            var obras = lecturaMdb.ListarObras();
            var i = 1;
            Exception ex = null;
            using (var proxy = new ProxyWeb.ServicioPlanillaClient(GlobalVars.PuertoWcf))
            {
                foreach (var obra in obras)
                {
                    if (BgwImportar.CancellationPending)
                    {
                        e.Cancel = true;
                        break;
                    }

                    var obraImportado = proxy.ImportarObras(obra);
                    if (!obraImportado.EstadoEntidad.Correcto)
                    {
                        e.Cancel = true;
                        ex = obraImportado.EstadoEntidad.ErrorEjecutar;
                    }

                    var a = (i * 100) / obras.Count;
                    BgwImportar.ReportProgress(a, ex);
                    i++;
                    
                }
            }
        }
        #endregion
    }
}
