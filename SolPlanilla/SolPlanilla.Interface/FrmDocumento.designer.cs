namespace SolPlanilla.Interface
{
    partial class FrmDocumento
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
            this.GrpDocumento = new System.Windows.Forms.GroupBox();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.BtnGrabar = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.LblEstado = new System.Windows.Forms.Label();
            this.ChkActivo = new System.Windows.Forms.CheckBox();
            this.TxtDocumento = new System.Windows.Forms.TextBox();
            this.LblDocumento = new System.Windows.Forms.Label();
            this.GrpConsulta = new System.Windows.Forms.GroupBox();
            this.dgvDocumento = new System.Windows.Forms.DataGridView();
            this.idDocumentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idEmpresaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDocumentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.activoDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.usuarioCreadorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuarioModificadorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaCreacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaModificacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numDocumentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empresaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoEntidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsDocumento = new System.Windows.Forms.BindingSource(this.components);
            this.GrpDocumento.SuspendLayout();
            this.GrpConsulta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocumento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDocumento)).BeginInit();
            this.SuspendLayout();
            // 
            // GrpDocumento
            // 
            this.GrpDocumento.Controls.Add(this.btnNuevo);
            this.GrpDocumento.Controls.Add(this.BtnGrabar);
            this.GrpDocumento.Controls.Add(this.BtnCancelar);
            this.GrpDocumento.Controls.Add(this.LblEstado);
            this.GrpDocumento.Controls.Add(this.ChkActivo);
            this.GrpDocumento.Controls.Add(this.TxtDocumento);
            this.GrpDocumento.Controls.Add(this.LblDocumento);
            this.GrpDocumento.Location = new System.Drawing.Point(268, 0);
            this.GrpDocumento.Name = "GrpDocumento";
            this.GrpDocumento.Size = new System.Drawing.Size(432, 249);
            this.GrpDocumento.TabIndex = 0;
            this.GrpDocumento.TabStop = false;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnNuevo.Location = new System.Drawing.Point(23, 220);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 23);
            this.btnNuevo.TabIndex = 51;
            this.btnNuevo.Text = "&Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Visible = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // BtnGrabar
            // 
            this.BtnGrabar.Location = new System.Drawing.Point(259, 220);
            this.BtnGrabar.Name = "BtnGrabar";
            this.BtnGrabar.Size = new System.Drawing.Size(75, 23);
            this.BtnGrabar.TabIndex = 16;
            this.BtnGrabar.Text = "&Grabar";
            this.BtnGrabar.UseVisualStyleBackColor = true;
            this.BtnGrabar.Click += new System.EventHandler(this.BtnGrabar_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Location = new System.Drawing.Point(340, 220);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(75, 23);
            this.BtnCancelar.TabIndex = 15;
            this.BtnCancelar.Text = "&Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // LblEstado
            // 
            this.LblEstado.AutoSize = true;
            this.LblEstado.Location = new System.Drawing.Point(15, 94);
            this.LblEstado.Name = "LblEstado";
            this.LblEstado.Size = new System.Drawing.Size(37, 13);
            this.LblEstado.TabIndex = 14;
            this.LblEstado.Text = "Activo";
            // 
            // ChkActivo
            // 
            this.ChkActivo.AutoSize = true;
            this.ChkActivo.Location = new System.Drawing.Point(83, 93);
            this.ChkActivo.Name = "ChkActivo";
            this.ChkActivo.Size = new System.Drawing.Size(15, 14);
            this.ChkActivo.TabIndex = 13;
            this.ChkActivo.UseVisualStyleBackColor = true;
            this.ChkActivo.CheckedChanged += new System.EventHandler(this.ChkActivo_CheckedChanged);
            this.ChkActivo.Click += new System.EventHandler(this.ChkActivo_Click);
            // 
            // TxtDocumento
            // 
            this.TxtDocumento.Location = new System.Drawing.Point(83, 59);
            this.TxtDocumento.MaxLength = 64;
            this.TxtDocumento.Name = "TxtDocumento";
            this.TxtDocumento.Size = new System.Drawing.Size(340, 20);
            this.TxtDocumento.TabIndex = 3;
            this.TxtDocumento.TextChanged += new System.EventHandler(this.TxtDocumento_TextChanged);
            this.TxtDocumento.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtDocumento_KeyDown);
            // 
            // LblDocumento
            // 
            this.LblDocumento.AutoSize = true;
            this.LblDocumento.Location = new System.Drawing.Point(15, 62);
            this.LblDocumento.Name = "LblDocumento";
            this.LblDocumento.Size = new System.Drawing.Size(62, 13);
            this.LblDocumento.TabIndex = 2;
            this.LblDocumento.Text = "Documento";
            // 
            // GrpConsulta
            // 
            this.GrpConsulta.Controls.Add(this.dgvDocumento);
            this.GrpConsulta.Location = new System.Drawing.Point(6, 0);
            this.GrpConsulta.Name = "GrpConsulta";
            this.GrpConsulta.Size = new System.Drawing.Size(256, 249);
            this.GrpConsulta.TabIndex = 1;
            this.GrpConsulta.TabStop = false;
            this.GrpConsulta.Enter += new System.EventHandler(this.GrpConsulta_Enter);
            // 
            // dgvDocumento
            // 
            this.dgvDocumento.AutoGenerateColumns = false;
            this.dgvDocumento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDocumento.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDocumentoDataGridViewTextBoxColumn,
            this.idEmpresaDataGridViewTextBoxColumn,
            this.nombreDocumentoDataGridViewTextBoxColumn,
            this.activoDataGridViewCheckBoxColumn,
            this.usuarioCreadorDataGridViewTextBoxColumn,
            this.usuarioModificadorDataGridViewTextBoxColumn,
            this.fechaCreacionDataGridViewTextBoxColumn,
            this.fechaModificacionDataGridViewTextBoxColumn,
            this.numDocumentoDataGridViewTextBoxColumn,
            this.empresaDataGridViewTextBoxColumn,
            this.estadoEntidadDataGridViewTextBoxColumn});
            this.dgvDocumento.DataSource = this.bsDocumento;
            this.dgvDocumento.Location = new System.Drawing.Point(0, 12);
            this.dgvDocumento.Name = "dgvDocumento";
            this.dgvDocumento.ReadOnly = true;
            this.dgvDocumento.Size = new System.Drawing.Size(250, 237);
            this.dgvDocumento.TabIndex = 0;
            this.dgvDocumento.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDocumento_CellContentClick);
            this.dgvDocumento.Click += new System.EventHandler(this.dgvDocumento_Click);
            // 
            // idDocumentoDataGridViewTextBoxColumn
            // 
            this.idDocumentoDataGridViewTextBoxColumn.DataPropertyName = "IdDocumento";
            this.idDocumentoDataGridViewTextBoxColumn.HeaderText = "IdDocumento";
            this.idDocumentoDataGridViewTextBoxColumn.Name = "idDocumentoDataGridViewTextBoxColumn";
            this.idDocumentoDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDocumentoDataGridViewTextBoxColumn.Visible = false;
            // 
            // idEmpresaDataGridViewTextBoxColumn
            // 
            this.idEmpresaDataGridViewTextBoxColumn.DataPropertyName = "IdEmpresa";
            this.idEmpresaDataGridViewTextBoxColumn.HeaderText = "IdEmpresa";
            this.idEmpresaDataGridViewTextBoxColumn.Name = "idEmpresaDataGridViewTextBoxColumn";
            this.idEmpresaDataGridViewTextBoxColumn.ReadOnly = true;
            this.idEmpresaDataGridViewTextBoxColumn.Visible = false;
            // 
            // nombreDocumentoDataGridViewTextBoxColumn
            // 
            this.nombreDocumentoDataGridViewTextBoxColumn.DataPropertyName = "NombreDocumento";
            this.nombreDocumentoDataGridViewTextBoxColumn.HeaderText = "NombreDocumento";
            this.nombreDocumentoDataGridViewTextBoxColumn.Name = "nombreDocumentoDataGridViewTextBoxColumn";
            this.nombreDocumentoDataGridViewTextBoxColumn.ReadOnly = true;
            this.nombreDocumentoDataGridViewTextBoxColumn.Width = 160;
            // 
            // activoDataGridViewCheckBoxColumn
            // 
            this.activoDataGridViewCheckBoxColumn.DataPropertyName = "Activo";
            this.activoDataGridViewCheckBoxColumn.HeaderText = "Activo";
            this.activoDataGridViewCheckBoxColumn.Name = "activoDataGridViewCheckBoxColumn";
            this.activoDataGridViewCheckBoxColumn.ReadOnly = true;
            this.activoDataGridViewCheckBoxColumn.Width = 47;
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
            // numDocumentoDataGridViewTextBoxColumn
            // 
            this.numDocumentoDataGridViewTextBoxColumn.DataPropertyName = "NumDocumento";
            this.numDocumentoDataGridViewTextBoxColumn.HeaderText = "NumDocumento";
            this.numDocumentoDataGridViewTextBoxColumn.Name = "numDocumentoDataGridViewTextBoxColumn";
            this.numDocumentoDataGridViewTextBoxColumn.ReadOnly = true;
            this.numDocumentoDataGridViewTextBoxColumn.Visible = false;
            // 
            // empresaDataGridViewTextBoxColumn
            // 
            this.empresaDataGridViewTextBoxColumn.DataPropertyName = "Empresa";
            this.empresaDataGridViewTextBoxColumn.HeaderText = "Empresa";
            this.empresaDataGridViewTextBoxColumn.Name = "empresaDataGridViewTextBoxColumn";
            this.empresaDataGridViewTextBoxColumn.ReadOnly = true;
            this.empresaDataGridViewTextBoxColumn.Visible = false;
            // 
            // estadoEntidadDataGridViewTextBoxColumn
            // 
            this.estadoEntidadDataGridViewTextBoxColumn.DataPropertyName = "EstadoEntidad";
            this.estadoEntidadDataGridViewTextBoxColumn.HeaderText = "EstadoEntidad";
            this.estadoEntidadDataGridViewTextBoxColumn.Name = "estadoEntidadDataGridViewTextBoxColumn";
            this.estadoEntidadDataGridViewTextBoxColumn.ReadOnly = true;
            this.estadoEntidadDataGridViewTextBoxColumn.Visible = false;
            // 
            // bsDocumento
            // 
            this.bsDocumento.DataSource = typeof(SolPlanilla.BE.BeMaestroDocumento);
            // 
            // FrmDocumento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 261);
            this.Controls.Add(this.GrpConsulta);
            this.Controls.Add(this.GrpDocumento);
            this.Name = "FrmDocumento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Maestro Documento";
            this.Load += new System.EventHandler(this.FrmDocumento_Load);
            this.GrpDocumento.ResumeLayout(false);
            this.GrpDocumento.PerformLayout();
            this.GrpConsulta.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocumento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDocumento)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GrpDocumento;
        private System.Windows.Forms.Label LblDocumento;
        private System.Windows.Forms.TextBox TxtDocumento;
        private System.Windows.Forms.Label LblEstado;
        private System.Windows.Forms.CheckBox ChkActivo;
        private System.Windows.Forms.GroupBox GrpConsulta;
        private System.Windows.Forms.DataGridView dgvDocumento;
        private System.Windows.Forms.Button BtnGrabar;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.BindingSource bsDocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDocumentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idEmpresaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDocumentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn activoDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuarioCreadorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuarioModificadorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaCreacionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaModificacionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numDocumentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn empresaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoEntidadDataGridViewTextBoxColumn;
      //  private System.Windows.Forms.BindingSource bsDocumento;
    }
}