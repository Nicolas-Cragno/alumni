namespace presentacion
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.menuPrincipal = new System.Windows.Forms.MenuStrip();
            this.movimientosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eventosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viajesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.choferesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vehiculosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tractoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.otrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuPrincipal
            // 
            this.menuPrincipal.AllowMerge = false;
            this.menuPrincipal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.menuPrincipal.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuPrincipal.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuPrincipal.GripMargin = new System.Windows.Forms.Padding(0);
            this.menuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.movimientosToolStripMenuItem,
            this.eventosToolStripMenuItem,
            this.viajesToolStripMenuItem,
            this.choferesToolStripMenuItem,
            this.vehiculosToolStripMenuItem,
            this.clientesToolStripMenuItem});
            this.menuPrincipal.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Table;
            this.menuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.menuPrincipal.Name = "menuPrincipal";
            this.menuPrincipal.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuPrincipal.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.menuPrincipal.ShowItemToolTips = true;
            this.menuPrincipal.Size = new System.Drawing.Size(156, 450);
            this.menuPrincipal.TabIndex = 0;
            this.menuPrincipal.Text = "Menu";
            // 
            // movimientosToolStripMenuItem
            // 
            this.movimientosToolStripMenuItem.Name = "movimientosToolStripMenuItem";
            this.movimientosToolStripMenuItem.Size = new System.Drawing.Size(150, 28);
            this.movimientosToolStripMenuItem.Text = "Movimientos";
            this.movimientosToolStripMenuItem.Click += new System.EventHandler(this.movimientosToolStripMenuItem_Click);
            // 
            // eventosToolStripMenuItem
            // 
            this.eventosToolStripMenuItem.Name = "eventosToolStripMenuItem";
            this.eventosToolStripMenuItem.Size = new System.Drawing.Size(103, 28);
            this.eventosToolStripMenuItem.Text = "Eventos";
            this.eventosToolStripMenuItem.Click += new System.EventHandler(this.eventosToolStripMenuItem_Click);
            // 
            // viajesToolStripMenuItem
            // 
            this.viajesToolStripMenuItem.Name = "viajesToolStripMenuItem";
            this.viajesToolStripMenuItem.Size = new System.Drawing.Size(83, 28);
            this.viajesToolStripMenuItem.Text = "Viajes";
            this.viajesToolStripMenuItem.Click += new System.EventHandler(this.viajesToolStripMenuItem_Click);
            // 
            // choferesToolStripMenuItem
            // 
            this.choferesToolStripMenuItem.Name = "choferesToolStripMenuItem";
            this.choferesToolStripMenuItem.Size = new System.Drawing.Size(115, 28);
            this.choferesToolStripMenuItem.Text = "Choferes";
            this.choferesToolStripMenuItem.Click += new System.EventHandler(this.choferesToolStripMenuItem_Click);
            // 
            // vehiculosToolStripMenuItem
            // 
            this.vehiculosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tractoresToolStripMenuItem,
            this.otrosToolStripMenuItem});
            this.vehiculosToolStripMenuItem.Name = "vehiculosToolStripMenuItem";
            this.vehiculosToolStripMenuItem.Size = new System.Drawing.Size(122, 28);
            this.vehiculosToolStripMenuItem.Text = "Vehiculos";
            // 
            // tractoresToolStripMenuItem
            // 
            this.tractoresToolStripMenuItem.Name = "tractoresToolStripMenuItem";
            this.tractoresToolStripMenuItem.Size = new System.Drawing.Size(296, 28);
            this.tractoresToolStripMenuItem.Text = "Tractores y Furgones";
            this.tractoresToolStripMenuItem.Click += new System.EventHandler(this.tractoresToolStripMenuItem_Click);
            // 
            // otrosToolStripMenuItem
            // 
            this.otrosToolStripMenuItem.Name = "otrosToolStripMenuItem";
            this.otrosToolStripMenuItem.Size = new System.Drawing.Size(296, 28);
            this.otrosToolStripMenuItem.Text = "Otros vehiculos";
            this.otrosToolStripMenuItem.Click += new System.EventHandler(this.otrosToolStripMenuItem_Click);
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(105, 28);
            this.clientesToolStripMenuItem.Text = "Clientes";
            this.clientesToolStripMenuItem.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 257);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(156, 153);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuPrincipal);
            this.IsMdiContainer = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuPrincipal.ResumeLayout(false);
            this.menuPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.MenuStrip menuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem movimientosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eventosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viajesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem choferesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vehiculosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tractoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem otrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

