namespace SolPlanilla.Interface
{
    partial class FrmImportConsolidado
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
            this.lblProgreso = new System.Windows.Forms.Label();
            this.pbProgreso = new System.Windows.Forms.ProgressBar();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnImportar = new System.Windows.Forms.Button();
            this.btnExaminar = new System.Windows.Forms.Button();
            this.txtRuta = new System.Windows.Forms.TextBox();
            this.lblRuta = new System.Windows.Forms.Label();
            this.rtxtMensajes = new System.Windows.Forms.RichTextBox();
            this.lblAnio = new System.Windows.Forms.Label();
            this.lblMes = new System.Windows.Forms.Label();
            this.nudAnio = new System.Windows.Forms.NumericUpDown();
            this.cmbMes = new System.Windows.Forms.ComboBox();
            this.gbForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAnio)).BeginInit();
            this.SuspendLayout();
            // 
            // gbForm
            // 
            this.gbForm.Controls.Add(this.cmbMes);
            this.gbForm.Controls.Add(this.nudAnio);
            this.gbForm.Controls.Add(this.lblMes);
            this.gbForm.Controls.Add(this.lblAnio);
            this.gbForm.Controls.Add(this.btnExaminar);
            this.gbForm.Controls.Add(this.txtRuta);
            this.gbForm.Controls.Add(this.lblRuta);
            this.gbForm.Location = new System.Drawing.Point(12, 12);
            this.gbForm.Name = "gbForm";
            this.gbForm.Size = new System.Drawing.Size(526, 88);
            this.gbForm.TabIndex = 1;
            this.gbForm.TabStop = false;
            this.gbForm.Text = "Seleccione archivo MDB a importar";
            // 
            // lblProgreso
            // 
            this.lblProgreso.AutoSize = true;
            this.lblProgreso.Location = new System.Drawing.Point(12, 364);
            this.lblProgreso.Name = "lblProgreso";
            this.lblProgreso.Size = new System.Drawing.Size(52, 13);
            this.lblProgreso.TabIndex = 6;
            this.lblProgreso.Text = "Progreso:";
            // 
            // pbProgreso
            // 
            this.pbProgreso.Location = new System.Drawing.Point(12, 384);
            this.pbProgreso.Name = "pbProgreso";
            this.pbProgreso.Size = new System.Drawing.Size(315, 23);
            this.pbProgreso.TabIndex = 5;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = global::SolPlanilla.Interface.Properties.Resources.Cancel2;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(438, 364);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(93, 43);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnImportar
            // 
            this.btnImportar.Image = global::SolPlanilla.Interface.Properties.Resources.Ok2;
            this.btnImportar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImportar.Location = new System.Drawing.Point(339, 364);
            this.btnImportar.Name = "btnImportar";
            this.btnImportar.Size = new System.Drawing.Size(93, 43);
            this.btnImportar.TabIndex = 3;
            this.btnImportar.Text = "Importar";
            this.btnImportar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnImportar.UseVisualStyleBackColor = true;
            // 
            // btnExaminar
            // 
            this.btnExaminar.Location = new System.Drawing.Point(488, 20);
            this.btnExaminar.Name = "btnExaminar";
            this.btnExaminar.Size = new System.Drawing.Size(31, 23);
            this.btnExaminar.TabIndex = 2;
            this.btnExaminar.Text = "...";
            this.btnExaminar.UseVisualStyleBackColor = true;
            // 
            // txtRuta
            // 
            this.txtRuta.Location = new System.Drawing.Point(96, 22);
            this.txtRuta.Name = "txtRuta";
            this.txtRuta.Size = new System.Drawing.Size(386, 20);
            this.txtRuta.TabIndex = 1;
            // 
            // lblRuta
            // 
            this.lblRuta.AutoSize = true;
            this.lblRuta.Location = new System.Drawing.Point(6, 25);
            this.lblRuta.Name = "lblRuta";
            this.lblRuta.Size = new System.Drawing.Size(84, 13);
            this.lblRuta.TabIndex = 0;
            this.lblRuta.Text = "Ruta de Archivo";
            // 
            // rtxtMensajes
            // 
            this.rtxtMensajes.Location = new System.Drawing.Point(12, 106);
            this.rtxtMensajes.Name = "rtxtMensajes";
            this.rtxtMensajes.Size = new System.Drawing.Size(526, 252);
            this.rtxtMensajes.TabIndex = 7;
            this.rtxtMensajes.Text = "";
            // 
            // lblAnio
            // 
            this.lblAnio.AutoSize = true;
            this.lblAnio.Location = new System.Drawing.Point(6, 61);
            this.lblAnio.Name = "lblAnio";
            this.lblAnio.Size = new System.Drawing.Size(26, 13);
            this.lblAnio.TabIndex = 3;
            this.lblAnio.Text = "Año";
            // 
            // lblMes
            // 
            this.lblMes.AutoSize = true;
            this.lblMes.Location = new System.Drawing.Point(93, 61);
            this.lblMes.Name = "lblMes";
            this.lblMes.Size = new System.Drawing.Size(27, 13);
            this.lblMes.TabIndex = 4;
            this.lblMes.Text = "Mes";
            // 
            // nudAnio
            // 
            this.nudAnio.Location = new System.Drawing.Point(38, 59);
            this.nudAnio.Maximum = new decimal(new int[] {
            2999,
            0,
            0,
            0});
            this.nudAnio.Minimum = new decimal(new int[] {
            2010,
            0,
            0,
            0});
            this.nudAnio.Name = "nudAnio";
            this.nudAnio.Size = new System.Drawing.Size(49, 20);
            this.nudAnio.TabIndex = 5;
            this.nudAnio.Value = new decimal(new int[] {
            2010,
            0,
            0,
            0});
            // 
            // cmbMes
            // 
            this.cmbMes.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbMes.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbMes.FormattingEnabled = true;
            this.cmbMes.Items.AddRange(new object[] {
            "Enero",
            "Febrero",
            "Marzo",
            "Abril",
            "Mayo",
            "Junio",
            "Julio",
            "Agosto",
            "Septiembre",
            "Octubre",
            "Noviembre",
            "Diciembre"});
            this.cmbMes.Location = new System.Drawing.Point(127, 59);
            this.cmbMes.Name = "cmbMes";
            this.cmbMes.Size = new System.Drawing.Size(121, 21);
            this.cmbMes.TabIndex = 6;
            // 
            // FrmImportConsolidado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 419);
            this.Controls.Add(this.rtxtMensajes);
            this.Controls.Add(this.lblProgreso);
            this.Controls.Add(this.gbForm);
            this.Controls.Add(this.pbProgreso);
            this.Controls.Add(this.btnImportar);
            this.Controls.Add(this.btnCancelar);
            this.Name = "FrmImportConsolidado";
            this.Text = "Importaciòn de Pagos Consolidado";
            this.gbForm.ResumeLayout(false);
            this.gbForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAnio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbForm;
        private System.Windows.Forms.Button btnExaminar;
        private System.Windows.Forms.TextBox txtRuta;
        private System.Windows.Forms.Label lblRuta;
        private System.Windows.Forms.Label lblProgreso;
        private System.Windows.Forms.ProgressBar pbProgreso;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnImportar;
        private System.Windows.Forms.RichTextBox rtxtMensajes;
        private System.Windows.Forms.ComboBox cmbMes;
        private System.Windows.Forms.NumericUpDown nudAnio;
        private System.Windows.Forms.Label lblMes;
        private System.Windows.Forms.Label lblAnio;
    }
}