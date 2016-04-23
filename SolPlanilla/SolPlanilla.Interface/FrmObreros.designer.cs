namespace SolPlanilla.Interface
{
    partial class FrmObreros
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
            this.GrbConsulta = new System.Windows.Forms.GroupBox();
            this.GbFiltros = new System.Windows.Forms.GroupBox();
            this.BtnBusConsultarAll = new System.Windows.Forms.Button();
            this.txtBusApellidos = new System.Windows.Forms.TextBox();
            this.txtBusNombre = new System.Windows.Forms.TextBox();
            this.txtBusNumDocumento = new System.Windows.Forms.TextBox();
            this.LblBusNumeroDocumento = new System.Windows.Forms.Label();
            this.LblBusApellidos = new System.Windows.Forms.Label();
            this.LblBusNombres = new System.Windows.Forms.Label();
            this.DgvObreros = new System.Windows.Forms.DataGridView();
            this.colCodObrero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTipoDoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNumDoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colApellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEstado = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnNuevo = new System.Windows.Forms.Button();
            this.CmbCategoria = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.BtnGrabar = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.ctrlPersonaObrero = new SolPlanilla.Interface.Controles.CtrlPersona();
            this.GrbConsulta.SuspendLayout();
            this.GbFiltros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvObreros)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GrbConsulta
            // 
            this.GrbConsulta.Controls.Add(this.GbFiltros);
            this.GrbConsulta.Controls.Add(this.DgvObreros);
            this.GrbConsulta.Location = new System.Drawing.Point(12, 9);
            this.GrbConsulta.Name = "GrbConsulta";
            this.GrbConsulta.Size = new System.Drawing.Size(779, 300);
            this.GrbConsulta.TabIndex = 15;
            this.GrbConsulta.TabStop = false;
            // 
            // GbFiltros
            // 
            this.GbFiltros.Controls.Add(this.BtnBusConsultarAll);
            this.GbFiltros.Controls.Add(this.txtBusApellidos);
            this.GbFiltros.Controls.Add(this.txtBusNombre);
            this.GbFiltros.Controls.Add(this.txtBusNumDocumento);
            this.GbFiltros.Controls.Add(this.LblBusNumeroDocumento);
            this.GbFiltros.Controls.Add(this.LblBusApellidos);
            this.GbFiltros.Controls.Add(this.LblBusNombres);
            this.GbFiltros.Location = new System.Drawing.Point(6, 10);
            this.GbFiltros.Name = "GbFiltros";
            this.GbFiltros.Size = new System.Drawing.Size(183, 282);
            this.GbFiltros.TabIndex = 1;
            this.GbFiltros.TabStop = false;
            this.GbFiltros.Text = "Filtros de búsqueda";
            // 
            // BtnBusConsultarAll
            // 
            this.BtnBusConsultarAll.Location = new System.Drawing.Point(102, 253);
            this.BtnBusConsultarAll.Name = "BtnBusConsultarAll";
            this.BtnBusConsultarAll.Size = new System.Drawing.Size(75, 23);
            this.BtnBusConsultarAll.TabIndex = 6;
            this.BtnBusConsultarAll.Text = "Todos";
            this.BtnBusConsultarAll.UseVisualStyleBackColor = true;
            this.BtnBusConsultarAll.Click += new System.EventHandler(this.BtnBusConsultarAll_Click);
            // 
            // txtBusApellidos
            // 
            this.txtBusApellidos.Location = new System.Drawing.Point(15, 152);
            this.txtBusApellidos.MaxLength = 64;
            this.txtBusApellidos.Name = "txtBusApellidos";
            this.txtBusApellidos.Size = new System.Drawing.Size(162, 20);
            this.txtBusApellidos.TabIndex = 5;
            this.txtBusApellidos.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBusApellidos_KeyDown);
            // 
            // txtBusNombre
            // 
            this.txtBusNombre.Location = new System.Drawing.Point(15, 98);
            this.txtBusNombre.MaxLength = 64;
            this.txtBusNombre.Name = "txtBusNombre";
            this.txtBusNombre.Size = new System.Drawing.Size(162, 20);
            this.txtBusNombre.TabIndex = 4;
            this.txtBusNombre.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBusNombre_KeyDown);
            // 
            // txtBusNumDocumento
            // 
            this.txtBusNumDocumento.Location = new System.Drawing.Point(15, 47);
            this.txtBusNumDocumento.MaxLength = 15;
            this.txtBusNumDocumento.Name = "txtBusNumDocumento";
            this.txtBusNumDocumento.Size = new System.Drawing.Size(162, 20);
            this.txtBusNumDocumento.TabIndex = 3;
            this.txtBusNumDocumento.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBusNumDocumento_KeyDown);
            // 
            // LblBusNumeroDocumento
            // 
            this.LblBusNumeroDocumento.AutoSize = true;
            this.LblBusNumeroDocumento.Location = new System.Drawing.Point(12, 30);
            this.LblBusNumeroDocumento.Name = "LblBusNumeroDocumento";
            this.LblBusNumeroDocumento.Size = new System.Drawing.Size(90, 13);
            this.LblBusNumeroDocumento.TabIndex = 2;
            this.LblBusNumeroDocumento.Text = "Num. Documento";
            // 
            // LblBusApellidos
            // 
            this.LblBusApellidos.AutoSize = true;
            this.LblBusApellidos.Location = new System.Drawing.Point(12, 136);
            this.LblBusApellidos.Name = "LblBusApellidos";
            this.LblBusApellidos.Size = new System.Drawing.Size(49, 13);
            this.LblBusApellidos.TabIndex = 1;
            this.LblBusApellidos.Text = "Apellidos";
            // 
            // LblBusNombres
            // 
            this.LblBusNombres.AutoSize = true;
            this.LblBusNombres.Location = new System.Drawing.Point(12, 82);
            this.LblBusNombres.Name = "LblBusNombres";
            this.LblBusNombres.Size = new System.Drawing.Size(44, 13);
            this.LblBusNombres.TabIndex = 0;
            this.LblBusNombres.Text = "Nombre";
            // 
            // DgvObreros
            // 
            this.DgvObreros.AllowUserToAddRows = false;
            this.DgvObreros.AllowUserToDeleteRows = false;
            this.DgvObreros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvObreros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCodObrero,
            this.colTipoDoc,
            this.colNumDoc,
            this.colNombre,
            this.colApellido,
            this.colEstado});
            this.DgvObreros.Location = new System.Drawing.Point(195, 10);
            this.DgvObreros.Name = "DgvObreros";
            this.DgvObreros.ReadOnly = true;
            this.DgvObreros.RowHeadersWidth = 25;
            this.DgvObreros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvObreros.Size = new System.Drawing.Size(576, 285);
            this.DgvObreros.TabIndex = 0;
            this.DgvObreros.DoubleClick += new System.EventHandler(this.DgvObreros_DoubleClick);
            // 
            // colCodObrero
            // 
            this.colCodObrero.HeaderText = "Código";
            this.colCodObrero.Name = "colCodObrero";
            this.colCodObrero.ReadOnly = true;
            this.colCodObrero.Visible = false;
            // 
            // colTipoDoc
            // 
            this.colTipoDoc.HeaderText = "Documento";
            this.colTipoDoc.Name = "colTipoDoc";
            this.colTipoDoc.ReadOnly = true;
            // 
            // colNumDoc
            // 
            this.colNumDoc.HeaderText = "Num. Doc.";
            this.colNumDoc.Name = "colNumDoc";
            this.colNumDoc.ReadOnly = true;
            // 
            // colNombre
            // 
            this.colNombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colNombre.HeaderText = "Nombre";
            this.colNombre.Name = "colNombre";
            this.colNombre.ReadOnly = true;
            // 
            // colApellido
            // 
            this.colApellido.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colApellido.HeaderText = "Apellidos";
            this.colApellido.Name = "colApellido";
            this.colApellido.ReadOnly = true;
            // 
            // colEstado
            // 
            this.colEstado.HeaderText = "Estado";
            this.colEstado.Name = "colEstado";
            this.colEstado.ReadOnly = true;
            this.colEstado.Width = 60;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnNuevo);
            this.groupBox1.Controls.Add(this.ctrlPersonaObrero);
            this.groupBox1.Controls.Add(this.CmbCategoria);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.BtnGrabar);
            this.groupBox1.Controls.Add(this.BtnCancelar);
            this.groupBox1.Location = new System.Drawing.Point(12, 315);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(779, 275);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            // 
            // BtnNuevo
            // 
            this.BtnNuevo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnNuevo.Location = new System.Drawing.Point(21, 246);
            this.BtnNuevo.Name = "BtnNuevo";
            this.BtnNuevo.Size = new System.Drawing.Size(75, 23);
            this.BtnNuevo.TabIndex = 40;
            this.BtnNuevo.Text = "&Nuevo";
            this.BtnNuevo.UseVisualStyleBackColor = true;
            this.BtnNuevo.Click += new System.EventHandler(this.BtnNuevo_Click);
            // 
            // CmbCategoria
            // 
            this.CmbCategoria.FormattingEnabled = true;
            this.CmbCategoria.Location = new System.Drawing.Point(87, 183);
            this.CmbCategoria.Name = "CmbCategoria";
            this.CmbCategoria.Size = new System.Drawing.Size(121, 21);
            this.CmbCategoria.TabIndex = 38;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 186);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 37;
            this.label6.Text = "Categoria";
            // 
            // BtnGrabar
            // 
            this.BtnGrabar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnGrabar.Location = new System.Drawing.Point(615, 246);
            this.BtnGrabar.Name = "BtnGrabar";
            this.BtnGrabar.Size = new System.Drawing.Size(75, 23);
            this.BtnGrabar.TabIndex = 18;
            this.BtnGrabar.Text = "&Grabar";
            this.BtnGrabar.UseVisualStyleBackColor = true;
            this.BtnGrabar.Click += new System.EventHandler(this.BtnGrabar_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCancelar.Location = new System.Drawing.Point(696, 246);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(75, 23);
            this.BtnCancelar.TabIndex = 17;
            this.BtnCancelar.Text = "&Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // ctrlPersonaObrero
            // 
            this.ctrlPersonaObrero.Location = new System.Drawing.Point(7, 19);
            this.ctrlPersonaObrero.Name = "ctrlPersonaObrero";
            this.ctrlPersonaObrero.Size = new System.Drawing.Size(710, 158);
            this.ctrlPersonaObrero.TabIndex = 39;
            // 
            // FrmObreros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 606);
            this.Controls.Add(this.GrbConsulta);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmObreros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Obreros Por Obra";
            this.Load += new System.EventHandler(this.FrmObreros_Load);
            this.GrbConsulta.ResumeLayout(false);
            this.GbFiltros.ResumeLayout(false);
            this.GbFiltros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvObreros)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GrbConsulta;
        private System.Windows.Forms.DataGridView DgvObreros;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnGrabar;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.ComboBox CmbCategoria;
        private System.Windows.Forms.Label label6;
        private Controles.CtrlPersona ctrlPersonaObrero;
        private System.Windows.Forms.GroupBox GbFiltros;
        private System.Windows.Forms.Button BtnNuevo;
        private System.Windows.Forms.TextBox txtBusApellidos;
        private System.Windows.Forms.TextBox txtBusNombre;
        private System.Windows.Forms.TextBox txtBusNumDocumento;
        private System.Windows.Forms.Label LblBusNumeroDocumento;
        private System.Windows.Forms.Label LblBusApellidos;
        private System.Windows.Forms.Label LblBusNombres;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodObrero;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTipoDoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNumDoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn colApellido;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colEstado;
        private System.Windows.Forms.Button BtnBusConsultarAll;
    }
}