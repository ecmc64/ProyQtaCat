namespace SolPlanilla.Interface
{
    partial class FrmUit
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnGrabar = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.txtImporte = new System.Windows.Forms.TextBox();
            this.LblImpote = new System.Windows.Forms.Label();
            this.txtAnio = new System.Windows.Forms.TextBox();
            this.LblAnio = new System.Windows.Forms.Label();
            this.GrbConsulta = new System.Windows.Forms.GroupBox();
            this.DgvUit = new System.Windows.Forms.DataGridView();
            this.bsUit = new System.Windows.Forms.BindingSource(this.components);
            this.empresaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.anioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.montoUnidadImpositivaTribDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuarioCreadorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuarioModificadorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaCreacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaModificacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoEntidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.GrbConsulta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvUit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsUit)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnGrabar);
            this.groupBox1.Controls.Add(this.BtnCancelar);
            this.groupBox1.Controls.Add(this.txtImporte);
            this.groupBox1.Controls.Add(this.LblImpote);
            this.groupBox1.Controls.Add(this.txtAnio);
            this.groupBox1.Controls.Add(this.LblAnio);
            this.groupBox1.Location = new System.Drawing.Point(351, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(380, 379);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // BtnGrabar
            // 
            this.BtnGrabar.Location = new System.Drawing.Point(222, 341);
            this.BtnGrabar.Name = "BtnGrabar";
            this.BtnGrabar.Size = new System.Drawing.Size(75, 23);
            this.BtnGrabar.TabIndex = 18;
            this.BtnGrabar.Text = "&Grabar";
            this.BtnGrabar.UseVisualStyleBackColor = true;
            this.BtnGrabar.Click += new System.EventHandler(this.BtnGrabar_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Location = new System.Drawing.Point(303, 341);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(75, 23);
            this.BtnCancelar.TabIndex = 17;
            this.BtnCancelar.Text = "&Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // txtImporte
            // 
            this.txtImporte.Location = new System.Drawing.Point(71, 64);
            this.txtImporte.MaxLength = 10;
            this.txtImporte.Name = "txtImporte";
            this.txtImporte.Size = new System.Drawing.Size(60, 20);
            this.txtImporte.TabIndex = 9;
            this.txtImporte.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtImporte_KeyPress);
            // 
            // LblImpote
            // 
            this.LblImpote.AutoSize = true;
            this.LblImpote.Location = new System.Drawing.Point(25, 67);
            this.LblImpote.Name = "LblImpote";
            this.LblImpote.Size = new System.Drawing.Size(42, 13);
            this.LblImpote.TabIndex = 8;
            this.LblImpote.Text = "Importe";
            // 
            // txtAnio
            // 
            this.txtAnio.Location = new System.Drawing.Point(71, 31);
            this.txtAnio.MaxLength = 4;
            this.txtAnio.Name = "txtAnio";
            this.txtAnio.Size = new System.Drawing.Size(38, 20);
            this.txtAnio.TabIndex = 0;
            this.txtAnio.TextChanged += new System.EventHandler(this.TxtAnio_TextChanged);
            this.txtAnio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAnio_KeyPress);
            // 
            // LblAnio
            // 
            this.LblAnio.AutoSize = true;
            this.LblAnio.Location = new System.Drawing.Point(25, 34);
            this.LblAnio.Name = "LblAnio";
            this.LblAnio.Size = new System.Drawing.Size(26, 13);
            this.LblAnio.TabIndex = 6;
            this.LblAnio.Text = "Año";
            // 
            // GrbConsulta
            // 
            this.GrbConsulta.Controls.Add(this.DgvUit);
            this.GrbConsulta.Location = new System.Drawing.Point(0, 0);
            this.GrbConsulta.Name = "GrbConsulta";
            this.GrbConsulta.Size = new System.Drawing.Size(345, 386);
            this.GrbConsulta.TabIndex = 1;
            this.GrbConsulta.TabStop = false;
            // 
            // DgvUit
            // 
            this.DgvUit.AllowUserToAddRows = false;
            this.DgvUit.AllowUserToDeleteRows = false;
            this.DgvUit.AutoGenerateColumns = false;
            this.DgvUit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvUit.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.empresaDataGridViewTextBoxColumn,
            this.anioDataGridViewTextBoxColumn,
            this.montoUnidadImpositivaTribDataGridViewTextBoxColumn,
            this.usuarioCreadorDataGridViewTextBoxColumn,
            this.usuarioModificadorDataGridViewTextBoxColumn,
            this.fechaCreacionDataGridViewTextBoxColumn,
            this.fechaModificacionDataGridViewTextBoxColumn,
            this.estadoEntidadDataGridViewTextBoxColumn});
            this.DgvUit.DataSource = this.bsUit;
            this.DgvUit.Location = new System.Drawing.Point(12, 12);
            this.DgvUit.Name = "DgvUit";
            this.DgvUit.ReadOnly = true;
            this.DgvUit.RowHeadersWidth = 25;
            this.DgvUit.Size = new System.Drawing.Size(327, 366);
            this.DgvUit.TabIndex = 0;
            // 
            // bsUit
            // 
            this.bsUit.DataSource = typeof(SolPlanilla.BE.BeMaestroUit);
            // 
            // empresaDataGridViewTextBoxColumn
            // 
            this.empresaDataGridViewTextBoxColumn.DataPropertyName = "Empresa";
            this.empresaDataGridViewTextBoxColumn.HeaderText = "Empresa";
            this.empresaDataGridViewTextBoxColumn.Name = "empresaDataGridViewTextBoxColumn";
            this.empresaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // anioDataGridViewTextBoxColumn
            // 
            this.anioDataGridViewTextBoxColumn.DataPropertyName = "Anio";
            this.anioDataGridViewTextBoxColumn.HeaderText = "Anio";
            this.anioDataGridViewTextBoxColumn.Name = "anioDataGridViewTextBoxColumn";
            this.anioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // montoUnidadImpositivaTribDataGridViewTextBoxColumn
            // 
            this.montoUnidadImpositivaTribDataGridViewTextBoxColumn.DataPropertyName = "MontoUnidadImpositivaTrib";
            this.montoUnidadImpositivaTribDataGridViewTextBoxColumn.HeaderText = "MontoUnidadImpositivaTrib";
            this.montoUnidadImpositivaTribDataGridViewTextBoxColumn.Name = "montoUnidadImpositivaTribDataGridViewTextBoxColumn";
            this.montoUnidadImpositivaTribDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // usuarioCreadorDataGridViewTextBoxColumn
            // 
            this.usuarioCreadorDataGridViewTextBoxColumn.DataPropertyName = "UsuarioCreador";
            this.usuarioCreadorDataGridViewTextBoxColumn.HeaderText = "UsuarioCreador";
            this.usuarioCreadorDataGridViewTextBoxColumn.Name = "usuarioCreadorDataGridViewTextBoxColumn";
            this.usuarioCreadorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // usuarioModificadorDataGridViewTextBoxColumn
            // 
            this.usuarioModificadorDataGridViewTextBoxColumn.DataPropertyName = "UsuarioModificador";
            this.usuarioModificadorDataGridViewTextBoxColumn.HeaderText = "UsuarioModificador";
            this.usuarioModificadorDataGridViewTextBoxColumn.Name = "usuarioModificadorDataGridViewTextBoxColumn";
            this.usuarioModificadorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechaCreacionDataGridViewTextBoxColumn
            // 
            this.fechaCreacionDataGridViewTextBoxColumn.DataPropertyName = "FechaCreacion";
            this.fechaCreacionDataGridViewTextBoxColumn.HeaderText = "FechaCreacion";
            this.fechaCreacionDataGridViewTextBoxColumn.Name = "fechaCreacionDataGridViewTextBoxColumn";
            this.fechaCreacionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechaModificacionDataGridViewTextBoxColumn
            // 
            this.fechaModificacionDataGridViewTextBoxColumn.DataPropertyName = "FechaModificacion";
            this.fechaModificacionDataGridViewTextBoxColumn.HeaderText = "FechaModificacion";
            this.fechaModificacionDataGridViewTextBoxColumn.Name = "fechaModificacionDataGridViewTextBoxColumn";
            this.fechaModificacionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // estadoEntidadDataGridViewTextBoxColumn
            // 
            this.estadoEntidadDataGridViewTextBoxColumn.DataPropertyName = "EstadoEntidad";
            this.estadoEntidadDataGridViewTextBoxColumn.HeaderText = "EstadoEntidad";
            this.estadoEntidadDataGridViewTextBoxColumn.Name = "estadoEntidadDataGridViewTextBoxColumn";
            this.estadoEntidadDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // FrmUit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 390);
            this.Controls.Add(this.GrbConsulta);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmUit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Maestro UIT";
            this.Load += new System.EventHandler(this.FrmUit_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.GrbConsulta.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvUit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsUit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtImporte;
        private System.Windows.Forms.Label LblImpote;
        private System.Windows.Forms.TextBox txtAnio;
        private System.Windows.Forms.Label LblAnio;
        private System.Windows.Forms.Button BtnGrabar;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.GroupBox GrbConsulta;
        private System.Windows.Forms.DataGridView DgvUit;
        private System.Windows.Forms.BindingSource bsUit;
        private System.Windows.Forms.DataGridViewTextBoxColumn empresaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn anioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn montoUnidadImpositivaTribDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuarioCreadorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuarioModificadorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaCreacionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaModificacionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoEntidadDataGridViewTextBoxColumn;
    }
}