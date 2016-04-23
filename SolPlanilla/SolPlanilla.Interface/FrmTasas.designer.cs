namespace SolPlanilla.Interface
{
    partial class FrmTasas
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
            this.components = new System.ComponentModel.Container();
            this.label3 = new System.Windows.Forms.Label();
            this.GrpTasa = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtRentaExceso = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtRentaHasta = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnGrabar = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.txtTasa = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.GrpConsulta = new System.Windows.Forms.GroupBox();
            this.DgvTasa = new System.Windows.Forms.DataGridView();
            this.bsTasa = new System.Windows.Forms.BindingSource(this.components);
            this.idTasaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empresaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuarioCreadorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuarioModificadorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaCreacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaModificacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tasasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rentaExcesoUitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rentaHastaUitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoEntidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GrpTasa.SuspendLayout();
            this.GrpConsulta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvTasa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTasa)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 3;
            // 
            // GrpTasa
            // 
            this.GrpTasa.Controls.Add(this.label6);
            this.GrpTasa.Controls.Add(this.label5);
            this.GrpTasa.Controls.Add(this.txtRentaExceso);
            this.GrpTasa.Controls.Add(this.label4);
            this.GrpTasa.Controls.Add(this.txtRentaHasta);
            this.GrpTasa.Controls.Add(this.label1);
            this.GrpTasa.Controls.Add(this.BtnGrabar);
            this.GrpTasa.Controls.Add(this.BtnCancelar);
            this.GrpTasa.Controls.Add(this.txtTasa);
            this.GrpTasa.Controls.Add(this.label2);
            this.GrpTasa.Location = new System.Drawing.Point(336, 12);
            this.GrpTasa.Name = "GrpTasa";
            this.GrpTasa.Size = new System.Drawing.Size(411, 267);
            this.GrpTasa.TabIndex = 9;
            this.GrpTasa.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(239, 116);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "UIT";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(239, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "UIT";
            // 
            // txtRentaExceso
            // 
            this.txtRentaExceso.Location = new System.Drawing.Point(201, 87);
            this.txtRentaExceso.MaxLength = 3;
            this.txtRentaExceso.Name = "txtRentaExceso";
            this.txtRentaExceso.Size = new System.Drawing.Size(32, 20);
            this.txtRentaExceso.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(121, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Renta Exceso";
            // 
            // txtRentaHasta
            // 
            this.txtRentaHasta.Location = new System.Drawing.Point(201, 113);
            this.txtRentaHasta.MaxLength = 3;
            this.txtRentaHasta.Name = "txtRentaHasta";
            this.txtRentaHasta.Size = new System.Drawing.Size(32, 20);
            this.txtRentaHasta.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(128, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Renta Hasta";
            // 
            // BtnGrabar
            // 
            this.BtnGrabar.Location = new System.Drawing.Point(250, 232);
            this.BtnGrabar.Name = "BtnGrabar";
            this.BtnGrabar.Size = new System.Drawing.Size(75, 23);
            this.BtnGrabar.TabIndex = 18;
            this.BtnGrabar.Text = "&Grabar";
            this.BtnGrabar.UseVisualStyleBackColor = true;
            this.BtnGrabar.Click += new System.EventHandler(this.BtnGrabar_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Location = new System.Drawing.Point(331, 232);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(75, 23);
            this.BtnCancelar.TabIndex = 17;
            this.BtnCancelar.Text = "&Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // txtTasa
            // 
            this.txtTasa.Location = new System.Drawing.Point(201, 139);
            this.txtTasa.MaxLength = 3;
            this.txtTasa.Name = "txtTasa";
            this.txtTasa.Size = new System.Drawing.Size(32, 20);
            this.txtTasa.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(164, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Tasa";
            // 
            // GrpConsulta
            // 
            this.GrpConsulta.Controls.Add(this.DgvTasa);
            this.GrpConsulta.Location = new System.Drawing.Point(5, 12);
            this.GrpConsulta.Name = "GrpConsulta";
            this.GrpConsulta.Size = new System.Drawing.Size(325, 267);
            this.GrpConsulta.TabIndex = 10;
            this.GrpConsulta.TabStop = false;
            // 
            // DgvTasa
            // 
            this.DgvTasa.AllowUserToAddRows = false;
            this.DgvTasa.AllowUserToDeleteRows = false;
            this.DgvTasa.AutoGenerateColumns = false;
            this.DgvTasa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvTasa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idTasaDataGridViewTextBoxColumn,
            this.empresaDataGridViewTextBoxColumn,
            this.usuarioCreadorDataGridViewTextBoxColumn,
            this.usuarioModificadorDataGridViewTextBoxColumn,
            this.fechaCreacionDataGridViewTextBoxColumn,
            this.fechaModificacionDataGridViewTextBoxColumn,
            this.tasasDataGridViewTextBoxColumn,
            this.rentaExcesoUitDataGridViewTextBoxColumn,
            this.rentaHastaUitDataGridViewTextBoxColumn,
            this.estadoEntidadDataGridViewTextBoxColumn});
            this.DgvTasa.DataSource = this.bsTasa;
            this.DgvTasa.Location = new System.Drawing.Point(7, 19);
            this.DgvTasa.Name = "DgvTasa";
            this.DgvTasa.ReadOnly = true;
            this.DgvTasa.RowHeadersWidth = 25;
            this.DgvTasa.Size = new System.Drawing.Size(312, 242);
            this.DgvTasa.TabIndex = 0;
            // 
            // bsTasa
            // 
            this.bsTasa.DataSource = typeof(SolPlanilla.BE.BeMaestroTasa);
            // 
            // idTasaDataGridViewTextBoxColumn
            // 
            this.idTasaDataGridViewTextBoxColumn.DataPropertyName = "IdTasa";
            this.idTasaDataGridViewTextBoxColumn.HeaderText = "IdTasa";
            this.idTasaDataGridViewTextBoxColumn.Name = "idTasaDataGridViewTextBoxColumn";
            this.idTasaDataGridViewTextBoxColumn.ReadOnly = true;
            this.idTasaDataGridViewTextBoxColumn.Visible = false;
            // 
            // empresaDataGridViewTextBoxColumn
            // 
            this.empresaDataGridViewTextBoxColumn.DataPropertyName = "Empresa";
            this.empresaDataGridViewTextBoxColumn.HeaderText = "Empresa";
            this.empresaDataGridViewTextBoxColumn.Name = "empresaDataGridViewTextBoxColumn";
            this.empresaDataGridViewTextBoxColumn.ReadOnly = true;
            this.empresaDataGridViewTextBoxColumn.Visible = false;
            // 
            // usuarioCreadorDataGridViewTextBoxColumn
            // 
            this.usuarioCreadorDataGridViewTextBoxColumn.DataPropertyName = "UsuarioCreador";
            this.usuarioCreadorDataGridViewTextBoxColumn.HeaderText = "UsuarioCreador";
            this.usuarioCreadorDataGridViewTextBoxColumn.Name = "usuarioCreadorDataGridViewTextBoxColumn";
            this.usuarioCreadorDataGridViewTextBoxColumn.ReadOnly = true;
            this.usuarioCreadorDataGridViewTextBoxColumn.Visible = false;
            // 
            // usuarioModificadorDataGridViewTextBoxColumn
            // 
            this.usuarioModificadorDataGridViewTextBoxColumn.DataPropertyName = "UsuarioModificador";
            this.usuarioModificadorDataGridViewTextBoxColumn.HeaderText = "UsuarioModificador";
            this.usuarioModificadorDataGridViewTextBoxColumn.Name = "usuarioModificadorDataGridViewTextBoxColumn";
            this.usuarioModificadorDataGridViewTextBoxColumn.ReadOnly = true;
            this.usuarioModificadorDataGridViewTextBoxColumn.Visible = false;
            // 
            // fechaCreacionDataGridViewTextBoxColumn
            // 
            this.fechaCreacionDataGridViewTextBoxColumn.DataPropertyName = "FechaCreacion";
            this.fechaCreacionDataGridViewTextBoxColumn.HeaderText = "FechaCreacion";
            this.fechaCreacionDataGridViewTextBoxColumn.Name = "fechaCreacionDataGridViewTextBoxColumn";
            this.fechaCreacionDataGridViewTextBoxColumn.ReadOnly = true;
            this.fechaCreacionDataGridViewTextBoxColumn.Visible = false;
            // 
            // fechaModificacionDataGridViewTextBoxColumn
            // 
            this.fechaModificacionDataGridViewTextBoxColumn.DataPropertyName = "FechaModificacion";
            this.fechaModificacionDataGridViewTextBoxColumn.HeaderText = "FechaModificacion";
            this.fechaModificacionDataGridViewTextBoxColumn.Name = "fechaModificacionDataGridViewTextBoxColumn";
            this.fechaModificacionDataGridViewTextBoxColumn.ReadOnly = true;
            this.fechaModificacionDataGridViewTextBoxColumn.Visible = false;
            // 
            // tasasDataGridViewTextBoxColumn
            // 
            this.tasasDataGridViewTextBoxColumn.DataPropertyName = "Tasas";
            this.tasasDataGridViewTextBoxColumn.HeaderText = "Tasas";
            this.tasasDataGridViewTextBoxColumn.Name = "tasasDataGridViewTextBoxColumn";
            this.tasasDataGridViewTextBoxColumn.ReadOnly = true;
            this.tasasDataGridViewTextBoxColumn.Width = 60;
            // 
            // rentaExcesoUitDataGridViewTextBoxColumn
            // 
            this.rentaExcesoUitDataGridViewTextBoxColumn.DataPropertyName = "RentaExcesoUit";
            this.rentaExcesoUitDataGridViewTextBoxColumn.HeaderText = "RentaExcesoUit";
            this.rentaExcesoUitDataGridViewTextBoxColumn.Name = "rentaExcesoUitDataGridViewTextBoxColumn";
            this.rentaExcesoUitDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rentaHastaUitDataGridViewTextBoxColumn
            // 
            this.rentaHastaUitDataGridViewTextBoxColumn.DataPropertyName = "RentaHastaUit";
            this.rentaHastaUitDataGridViewTextBoxColumn.HeaderText = "RentaHastaUit";
            this.rentaHastaUitDataGridViewTextBoxColumn.Name = "rentaHastaUitDataGridViewTextBoxColumn";
            this.rentaHastaUitDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // estadoEntidadDataGridViewTextBoxColumn
            // 
            this.estadoEntidadDataGridViewTextBoxColumn.DataPropertyName = "EstadoEntidad";
            this.estadoEntidadDataGridViewTextBoxColumn.HeaderText = "EstadoEntidad";
            this.estadoEntidadDataGridViewTextBoxColumn.Name = "estadoEntidadDataGridViewTextBoxColumn";
            this.estadoEntidadDataGridViewTextBoxColumn.ReadOnly = true;
            this.estadoEntidadDataGridViewTextBoxColumn.Visible = false;
            // 
            // FrmTasas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 281);
            this.Controls.Add(this.GrpConsulta);
            this.Controls.Add(this.GrpTasa);
            this.Controls.Add(this.label3);
            this.Name = "FrmTasas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tasa";
            this.Load += new System.EventHandler(this.FrmTasas_Load);
            this.GrpTasa.ResumeLayout(false);
            this.GrpTasa.PerformLayout();
            this.GrpConsulta.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvTasa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTasa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox GrpTasa;
        private System.Windows.Forms.TextBox txtTasa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnGrabar;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.GroupBox GrpConsulta;
        private System.Windows.Forms.DataGridView DgvTasa;
        private System.Windows.Forms.TextBox txtRentaExceso;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtRentaHasta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.BindingSource bsTasa;
        private System.Windows.Forms.DataGridViewTextBoxColumn idTasaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn empresaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuarioCreadorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuarioModificadorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaCreacionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaModificacionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tasasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rentaExcesoUitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rentaHastaUitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoEntidadDataGridViewTextBoxColumn;
    }
}