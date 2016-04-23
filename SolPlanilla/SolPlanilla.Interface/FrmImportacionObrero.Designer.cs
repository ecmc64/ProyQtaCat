namespace SolPlanilla.Interface
{
    partial class FrmImportacionObrero
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbForm = new System.Windows.Forms.GroupBox();
            this.cmbTabla = new System.Windows.Forms.ComboBox();
            this.lblTabla = new System.Windows.Forms.Label();
            this.lblProgreso = new System.Windows.Forms.Label();
            this.pbProgreso = new System.Windows.Forms.ProgressBar();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnImportar = new System.Windows.Forms.Button();
            this.btnExaminar = new System.Windows.Forms.Button();
            this.txtRuta = new System.Windows.Forms.TextBox();
            this.lblRuta = new System.Windows.Forms.Label();
            this.BgwImportar = new System.ComponentModel.BackgroundWorker();
            this.gbForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbForm
            // 
            this.gbForm.Controls.Add(this.cmbTabla);
            this.gbForm.Controls.Add(this.lblTabla);
            this.gbForm.Controls.Add(this.lblProgreso);
            this.gbForm.Controls.Add(this.pbProgreso);
            this.gbForm.Controls.Add(this.btnCancelar);
            this.gbForm.Controls.Add(this.btnImportar);
            this.gbForm.Controls.Add(this.btnExaminar);
            this.gbForm.Controls.Add(this.txtRuta);
            this.gbForm.Controls.Add(this.lblRuta);
            this.gbForm.Location = new System.Drawing.Point(12, 12);
            this.gbForm.Name = "gbForm";
            this.gbForm.Size = new System.Drawing.Size(525, 151);
            this.gbForm.TabIndex = 0;
            this.gbForm.TabStop = false;
            this.gbForm.Text = "Seleccione archivo MDB a importar";
            // 
            // cmbTabla
            // 
            this.cmbTabla.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTabla.FormattingEnabled = true;
            this.cmbTabla.Items.AddRange(new object[] {
            "Obreros",
            "Obras"});
            this.cmbTabla.Location = new System.Drawing.Point(96, 22);
            this.cmbTabla.Name = "cmbTabla";
            this.cmbTabla.Size = new System.Drawing.Size(145, 21);
            this.cmbTabla.TabIndex = 8;
            // 
            // lblTabla
            // 
            this.lblTabla.AutoSize = true;
            this.lblTabla.Location = new System.Drawing.Point(6, 25);
            this.lblTabla.Name = "lblTabla";
            this.lblTabla.Size = new System.Drawing.Size(34, 13);
            this.lblTabla.TabIndex = 7;
            this.lblTabla.Text = "Tabla";
            // 
            // lblProgreso
            // 
            this.lblProgreso.AutoSize = true;
            this.lblProgreso.Location = new System.Drawing.Point(6, 83);
            this.lblProgreso.Name = "lblProgreso";
            this.lblProgreso.Size = new System.Drawing.Size(52, 13);
            this.lblProgreso.TabIndex = 6;
            this.lblProgreso.Text = "Progreso:";
            // 
            // pbProgreso
            // 
            this.pbProgreso.Location = new System.Drawing.Point(6, 102);
            this.pbProgreso.Name = "pbProgreso";
            this.pbProgreso.Size = new System.Drawing.Size(315, 23);
            this.pbProgreso.TabIndex = 5;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = global::SolPlanilla.Interface.Properties.Resources.Cancel2;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(426, 83);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(93, 43);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnImportar
            // 
            this.btnImportar.Image = global::SolPlanilla.Interface.Properties.Resources.Ok2;
            this.btnImportar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImportar.Location = new System.Drawing.Point(327, 83);
            this.btnImportar.Name = "btnImportar";
            this.btnImportar.Size = new System.Drawing.Size(93, 43);
            this.btnImportar.TabIndex = 3;
            this.btnImportar.Text = "Importar";
            this.btnImportar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnImportar.UseVisualStyleBackColor = true;
            this.btnImportar.Click += new System.EventHandler(this.btnImportar_Click);
            // 
            // btnExaminar
            // 
            this.btnExaminar.Location = new System.Drawing.Point(488, 49);
            this.btnExaminar.Name = "btnExaminar";
            this.btnExaminar.Size = new System.Drawing.Size(31, 23);
            this.btnExaminar.TabIndex = 2;
            this.btnExaminar.Text = "...";
            this.btnExaminar.UseVisualStyleBackColor = true;
            this.btnExaminar.Click += new System.EventHandler(this.btnExaminar_Click);
            // 
            // txtRuta
            // 
            this.txtRuta.Location = new System.Drawing.Point(96, 51);
            this.txtRuta.Name = "txtRuta";
            this.txtRuta.Size = new System.Drawing.Size(386, 20);
            this.txtRuta.TabIndex = 1;
            // 
            // lblRuta
            // 
            this.lblRuta.AutoSize = true;
            this.lblRuta.Location = new System.Drawing.Point(6, 54);
            this.lblRuta.Name = "lblRuta";
            this.lblRuta.Size = new System.Drawing.Size(84, 13);
            this.lblRuta.TabIndex = 0;
            this.lblRuta.Text = "Ruta de Archivo";
            // 
            // BgwImportar
            // 
            this.BgwImportar.WorkerReportsProgress = true;
            this.BgwImportar.WorkerSupportsCancellation = true;
            this.BgwImportar.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BgwImportar_DoWork);
            this.BgwImportar.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.BgwImportar_ProgressChanged);
            this.BgwImportar.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BgwImportar_RunWorkerCompleted);
            // 
            // FrmImportacionObrero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 178);
            this.Controls.Add(this.gbForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmImportacionObrero";
            this.Text = "Importación de Tablas";
            this.Load += new System.EventHandler(this.FrmImportacionObrero_Load);
            this.gbForm.ResumeLayout(false);
            this.gbForm.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbForm;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnImportar;
        private System.Windows.Forms.Button btnExaminar;
        private System.Windows.Forms.TextBox txtRuta;
        private System.Windows.Forms.Label lblRuta;
        private System.ComponentModel.BackgroundWorker BgwImportar;
        private System.Windows.Forms.ProgressBar pbProgreso;
        private System.Windows.Forms.Label lblProgreso;
        private System.Windows.Forms.ComboBox cmbTabla;
        private System.Windows.Forms.Label lblTabla;
    }
}