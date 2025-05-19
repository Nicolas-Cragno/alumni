namespace presentacion
{
    partial class FrmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuPrincipal = new System.Windows.Forms.MenuStrip();
            this.tsmMovimientos = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmEventos = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmViajes = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmRecursos = new System.Windows.Forms.ToolStripMenuItem();
            this.choferesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tractoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.otrosVehiculosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.empresasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 224);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(160, 153);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // menuPrincipal
            // 
            this.menuPrincipal.AllowMerge = false;
            this.menuPrincipal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.menuPrincipal.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuPrincipal.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuPrincipal.GripMargin = new System.Windows.Forms.Padding(0);
            this.menuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmMovimientos,
            this.tsmEventos,
            this.tsmViajes,
            this.tsmRecursos});
            this.menuPrincipal.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Table;
            this.menuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.menuPrincipal.Name = "menuPrincipal";
            this.menuPrincipal.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuPrincipal.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.menuPrincipal.ShowItemToolTips = true;
            this.menuPrincipal.Size = new System.Drawing.Size(160, 450);
            this.menuPrincipal.TabIndex = 6;
            this.menuPrincipal.Text = "Menu";
            // 
            // tsmMovimientos
            // 
            this.tsmMovimientos.Name = "tsmMovimientos";
            this.tsmMovimientos.Size = new System.Drawing.Size(154, 28);
            this.tsmMovimientos.Text = "Movimientos";
            this.tsmMovimientos.Click += new System.EventHandler(this.movimientosToolStripMenuItem_Click);
            // 
            // tsmEventos
            // 
            this.tsmEventos.Name = "tsmEventos";
            this.tsmEventos.Size = new System.Drawing.Size(106, 28);
            this.tsmEventos.Text = "Eventos";
            this.tsmEventos.Click += new System.EventHandler(this.tsmEventos_Click);
            // 
            // tsmViajes
            // 
            this.tsmViajes.Name = "tsmViajes";
            this.tsmViajes.Size = new System.Drawing.Size(94, 28);
            this.tsmViajes.Text = "Viajes";
            this.tsmViajes.Click += new System.EventHandler(this.tsmViajes_Click);
            // 
            // tsmRecursos
            // 
            this.tsmRecursos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.choferesToolStripMenuItem,
            this.tractoresToolStripMenuItem,
            this.otrosVehiculosToolStripMenuItem,
            this.empresasToolStripMenuItem,
            this.clientesToolStripMenuItem});
            this.tsmRecursos.Name = "tsmRecursos";
            this.tsmRecursos.Size = new System.Drawing.Size(118, 28);
            this.tsmRecursos.Text = "Recursos";
            this.tsmRecursos.Click += new System.EventHandler(this.gestionarRecursosToolStripMenuItem_Click);
            // 
            // choferesToolStripMenuItem
            // 
            this.choferesToolStripMenuItem.Name = "choferesToolStripMenuItem";
            this.choferesToolStripMenuItem.Size = new System.Drawing.Size(260, 28);
            this.choferesToolStripMenuItem.Text = "Choferes";
            this.choferesToolStripMenuItem.Click += new System.EventHandler(this.choferesToolStripMenuItem_Click);
            // 
            // tractoresToolStripMenuItem
            // 
            this.tractoresToolStripMenuItem.Name = "tractoresToolStripMenuItem";
            this.tractoresToolStripMenuItem.Size = new System.Drawing.Size(260, 28);
            this.tractoresToolStripMenuItem.Text = "Vehiculos";
            this.tractoresToolStripMenuItem.Click += new System.EventHandler(this.tractoresToolStripMenuItem_Click);
            // 
            // otrosVehiculosToolStripMenuItem
            // 
            this.otrosVehiculosToolStripMenuItem.Name = "otrosVehiculosToolStripMenuItem";
            this.otrosVehiculosToolStripMenuItem.Size = new System.Drawing.Size(260, 28);
            this.otrosVehiculosToolStripMenuItem.Text = "Otros vehiculos";
            this.otrosVehiculosToolStripMenuItem.Click += new System.EventHandler(this.otrosVehiculosToolStripMenuItem_Click);
            // 
            // empresasToolStripMenuItem
            // 
            this.empresasToolStripMenuItem.Name = "empresasToolStripMenuItem";
            this.empresasToolStripMenuItem.Size = new System.Drawing.Size(260, 28);
            this.empresasToolStripMenuItem.Text = "Empresas";
            this.empresasToolStripMenuItem.Click += new System.EventHandler(this.empresasToolStripMenuItem_Click);
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(260, 28);
            this.clientesToolStripMenuItem.Text = "Clientes";
            this.clientesToolStripMenuItem.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuPrincipal);
            this.IsMdiContainer = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPrincipal";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmPrincipal";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuPrincipal.ResumeLayout(false);
            this.menuPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem tsmMovimientos;
        private System.Windows.Forms.ToolStripMenuItem tsmEventos;
        private System.Windows.Forms.ToolStripMenuItem tsmViajes;
        private System.Windows.Forms.ToolStripMenuItem tsmRecursos;
        private System.Windows.Forms.ToolStripMenuItem choferesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tractoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem otrosVehiculosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem empresasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
    }
}