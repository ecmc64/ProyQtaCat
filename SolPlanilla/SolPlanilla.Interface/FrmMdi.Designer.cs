namespace SolPlanilla.Interface
{
    partial class FrmMdi
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
            this.MnuPrincipal = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAEmpresa = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuASep1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuAUit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuATasa = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuASep2 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuACerrarSesion = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuASalir = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenimientosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMObras = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMDocumento = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMCategoría = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMObreros = new System.Windows.Forms.ToolStripMenuItem();
            this.utilitariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuUImportacionObreros = new System.Windows.Forms.ToolStripMenuItem();
            this.ssBarraEstado = new System.Windows.Forms.StatusStrip();
            this.sslEmpresa = new System.Windows.Forms.ToolStripStatusLabel();
            this.sslSep2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.sslUsuario = new System.Windows.Forms.ToolStripStatusLabel();
            this.sslSep1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.sslHoraIngreso = new System.Windows.Forms.ToolStripStatusLabel();
            this.sslProyecto = new System.Windows.Forms.ToolStripStatusLabel();
            this.MnuPrincipal.SuspendLayout();
            this.ssBarraEstado.SuspendLayout();
            this.SuspendLayout();
            // 
            // MnuPrincipal
            // 
            this.MnuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.mantenimientosToolStripMenuItem,
            this.utilitariosToolStripMenuItem});
            this.MnuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.MnuPrincipal.Name = "MnuPrincipal";
            this.MnuPrincipal.Size = new System.Drawing.Size(924, 24);
            this.MnuPrincipal.TabIndex = 0;
            this.MnuPrincipal.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAEmpresa,
            this.mnuASep1,
            this.mnuAUit,
            this.mnuATasa,
            this.mnuASep2,
            this.mnuACerrarSesion,
            this.mnuASalir});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // mnuAEmpresa
            // 
            this.mnuAEmpresa.Name = "mnuAEmpresa";
            this.mnuAEmpresa.Size = new System.Drawing.Size(152, 22);
            this.mnuAEmpresa.Text = "Empresa";
            this.mnuAEmpresa.Click += new System.EventHandler(this.mnuAEmpresa_Click);
            // 
            // mnuASep1
            // 
            this.mnuASep1.Name = "mnuASep1";
            this.mnuASep1.Size = new System.Drawing.Size(149, 6);
            // 
            // mnuAUit
            // 
            this.mnuAUit.Name = "mnuAUit";
            this.mnuAUit.Size = new System.Drawing.Size(152, 22);
            this.mnuAUit.Text = "Maestro UIT";
            this.mnuAUit.Click += new System.EventHandler(this.mnuAUit_Click);
            // 
            // mnuATasa
            // 
            this.mnuATasa.Name = "mnuATasa";
            this.mnuATasa.Size = new System.Drawing.Size(152, 22);
            this.mnuATasa.Text = "Maestro Tasa";
            this.mnuATasa.Click += new System.EventHandler(this.mnuATasa_Click);
            // 
            // mnuASep2
            // 
            this.mnuASep2.Name = "mnuASep2";
            this.mnuASep2.Size = new System.Drawing.Size(149, 6);
            // 
            // mnuACerrarSesion
            // 
            this.mnuACerrarSesion.Name = "mnuACerrarSesion";
            this.mnuACerrarSesion.Size = new System.Drawing.Size(152, 22);
            this.mnuACerrarSesion.Text = "Cerrar Sesión";
            this.mnuACerrarSesion.Click += new System.EventHandler(this.mnuACerrarSesion_Click);
            // 
            // mnuASalir
            // 
            this.mnuASalir.Name = "mnuASalir";
            this.mnuASalir.Size = new System.Drawing.Size(152, 22);
            this.mnuASalir.Text = "Salir";
            this.mnuASalir.Click += new System.EventHandler(this.mnuASalir_Click);
            // 
            // mantenimientosToolStripMenuItem
            // 
            this.mantenimientosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuMObras,
            this.mnuMDocumento,
            this.mnuMCategoría,
            this.mnuMObreros});
            this.mantenimientosToolStripMenuItem.Name = "mantenimientosToolStripMenuItem";
            this.mantenimientosToolStripMenuItem.Size = new System.Drawing.Size(106, 20);
            this.mantenimientosToolStripMenuItem.Text = "Mantenimientos";
            // 
            // mnuMObras
            // 
            this.mnuMObras.Name = "mnuMObras";
            this.mnuMObras.Size = new System.Drawing.Size(152, 22);
            this.mnuMObras.Text = "Obras";
            this.mnuMObras.Click += new System.EventHandler(this.mnuMObras_Click);
            // 
            // mnuMDocumento
            // 
            this.mnuMDocumento.Name = "mnuMDocumento";
            this.mnuMDocumento.Size = new System.Drawing.Size(152, 22);
            this.mnuMDocumento.Text = "Documento";
            this.mnuMDocumento.Click += new System.EventHandler(this.mnuMDocumento_Click);
            // 
            // mnuMCategoría
            // 
            this.mnuMCategoría.Name = "mnuMCategoría";
            this.mnuMCategoría.Size = new System.Drawing.Size(152, 22);
            this.mnuMCategoría.Text = "Categoría";
            this.mnuMCategoría.Click += new System.EventHandler(this.mnuMCategoría_Click);
            // 
            // mnuMObreros
            // 
            this.mnuMObreros.Name = "mnuMObreros";
            this.mnuMObreros.Size = new System.Drawing.Size(152, 22);
            this.mnuMObreros.Text = "Obreros";
            this.mnuMObreros.Click += new System.EventHandler(this.mnuMObreros_Click);
            // 
            // utilitariosToolStripMenuItem
            // 
            this.utilitariosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuUImportacionObreros});
            this.utilitariosToolStripMenuItem.Name = "utilitariosToolStripMenuItem";
            this.utilitariosToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.utilitariosToolStripMenuItem.Text = "Utilitarios";
            // 
            // mnuUImportacionObreros
            // 
            this.mnuUImportacionObreros.Name = "mnuUImportacionObreros";
            this.mnuUImportacionObreros.Size = new System.Drawing.Size(192, 22);
            this.mnuUImportacionObreros.Text = "Importación de Tablas";
            this.mnuUImportacionObreros.Click += new System.EventHandler(this.mnuUImportacionObreros_Click);
            // 
            // ssBarraEstado
            // 
            this.ssBarraEstado.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sslEmpresa,
            this.sslSep2,
            this.sslUsuario,
            this.sslSep1,
            this.sslHoraIngreso,
            this.sslProyecto});
            this.ssBarraEstado.Location = new System.Drawing.Point(0, 536);
            this.ssBarraEstado.Name = "ssBarraEstado";
            this.ssBarraEstado.Size = new System.Drawing.Size(924, 22);
            this.ssBarraEstado.TabIndex = 2;
            this.ssBarraEstado.Text = "statusStrip1";
            // 
            // sslEmpresa
            // 
            this.sslEmpresa.Name = "sslEmpresa";
            this.sslEmpresa.Size = new System.Drawing.Size(82, 17);
            this.sslEmpresa.Text = "Empresa: Data";
            // 
            // sslSep2
            // 
            this.sslSep2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.sslSep2.Name = "sslSep2";
            this.sslSep2.Size = new System.Drawing.Size(10, 17);
            this.sslSep2.Text = "|";
            // 
            // sslUsuario
            // 
            this.sslUsuario.Name = "sslUsuario";
            this.sslUsuario.Size = new System.Drawing.Size(47, 17);
            this.sslUsuario.Text = "Usuario";
            // 
            // sslSep1
            // 
            this.sslSep1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.sslSep1.Name = "sslSep1";
            this.sslSep1.Size = new System.Drawing.Size(10, 17);
            this.sslSep1.Text = "|";
            this.sslSep1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // sslHoraIngreso
            // 
            this.sslHoraIngreso.Name = "sslHoraIngreso";
            this.sslHoraIngreso.Size = new System.Drawing.Size(150, 17);
            this.sslHoraIngreso.Text = "Hora de Ingreso: 10:00 a.m.";
            // 
            // sslProyecto
            // 
            this.sslProyecto.Name = "sslProyecto";
            this.sslProyecto.Size = new System.Drawing.Size(610, 17);
            this.sslProyecto.Spring = true;
            this.sslProyecto.Text = "Proyecto: Tia María";
            this.sslProyecto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FrmMdi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 558);
            this.Controls.Add(this.ssBarraEstado);
            this.Controls.Add(this.MnuPrincipal);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.MnuPrincipal;
            this.Name = "FrmMdi";
            this.Text = "Sistema de Control de Salarios";
            this.Activated += new System.EventHandler(this.FrmMdi_Activated);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmMdi_FormClosed);
            this.MnuPrincipal.ResumeLayout(false);
            this.MnuPrincipal.PerformLayout();
            this.ssBarraEstado.ResumeLayout(false);
            this.ssBarraEstado.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MnuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuAEmpresa;
        private System.Windows.Forms.ToolStripMenuItem mnuASalir;
        private System.Windows.Forms.StatusStrip ssBarraEstado;
        private System.Windows.Forms.ToolStripStatusLabel sslUsuario;
        private System.Windows.Forms.ToolStripStatusLabel sslSep1;
        private System.Windows.Forms.ToolStripStatusLabel sslHoraIngreso;
        private System.Windows.Forms.ToolStripStatusLabel sslProyecto;
        private System.Windows.Forms.ToolStripStatusLabel sslEmpresa;
        private System.Windows.Forms.ToolStripStatusLabel sslSep2;
        private System.Windows.Forms.ToolStripSeparator mnuASep1;
        private System.Windows.Forms.ToolStripMenuItem mnuACerrarSesion;
        private System.Windows.Forms.ToolStripMenuItem mnuAUit;
        private System.Windows.Forms.ToolStripMenuItem mnuATasa;
        private System.Windows.Forms.ToolStripSeparator mnuASep2;
        private System.Windows.Forms.ToolStripMenuItem mantenimientosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuMObras;
        private System.Windows.Forms.ToolStripMenuItem mnuMDocumento;
        private System.Windows.Forms.ToolStripMenuItem mnuMCategoría;
        private System.Windows.Forms.ToolStripMenuItem mnuMObreros;
        private System.Windows.Forms.ToolStripMenuItem utilitariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuUImportacionObreros;
    }
}