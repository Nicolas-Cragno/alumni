namespace presentacion.Eventos
{
    partial class frmMovimientos
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
            this.btnMovimientosClose = new System.Windows.Forms.Button();
            this.btnMovimientosNuevo = new System.Windows.Forms.Button();
            this.dgvMovimientos = new System.Windows.Forms.DataGridView();
            this.tbxMovimientosFiltro = new System.Windows.Forms.TextBox();
            this.lblMovimientosFiltro = new System.Windows.Forms.Label();
            this.lblMovimientosTitulo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMovimientos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMovimientosClose
            // 
            this.btnMovimientosClose.Location = new System.Drawing.Point(581, 376);
            this.btnMovimientosClose.Name = "btnMovimientosClose";
            this.btnMovimientosClose.Size = new System.Drawing.Size(51, 23);
            this.btnMovimientosClose.TabIndex = 18;
            this.btnMovimientosClose.Text = "Cerrar";
            this.btnMovimientosClose.UseVisualStyleBackColor = true;
            this.btnMovimientosClose.Click += new System.EventHandler(this.btnMovimientosClose_Click);
            // 
            // btnMovimientosNuevo
            // 
            this.btnMovimientosNuevo.Location = new System.Drawing.Point(540, 78);
            this.btnMovimientosNuevo.Name = "btnMovimientosNuevo";
            this.btnMovimientosNuevo.Size = new System.Drawing.Size(92, 23);
            this.btnMovimientosNuevo.TabIndex = 17;
            this.btnMovimientosNuevo.Text = "Agregar Nuevo";
            this.btnMovimientosNuevo.UseVisualStyleBackColor = true;
            this.btnMovimientosNuevo.Click += new System.EventHandler(this.btnMovimientosNuevo_Click);
            // 
            // dgvMovimientos
            // 
            this.dgvMovimientos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMovimientos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvMovimientos.Location = new System.Drawing.Point(12, 107);
            this.dgvMovimientos.MultiSelect = false;
            this.dgvMovimientos.Name = "dgvMovimientos";
            this.dgvMovimientos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMovimientos.Size = new System.Drawing.Size(620, 263);
            this.dgvMovimientos.TabIndex = 16;
            this.dgvMovimientos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMovimientos_CellDoubleClick);
            // 
            // tbxMovimientosFiltro
            // 
            this.tbxMovimientosFiltro.Location = new System.Drawing.Point(54, 80);
            this.tbxMovimientosFiltro.Name = "tbxMovimientosFiltro";
            this.tbxMovimientosFiltro.Size = new System.Drawing.Size(292, 20);
            this.tbxMovimientosFiltro.TabIndex = 15;
            this.tbxMovimientosFiltro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxMovimientosFiltro_KeyPress);
            // 
            // lblMovimientosFiltro
            // 
            this.lblMovimientosFiltro.AutoSize = true;
            this.lblMovimientosFiltro.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMovimientosFiltro.Location = new System.Drawing.Point(14, 84);
            this.lblMovimientosFiltro.Name = "lblMovimientosFiltro";
            this.lblMovimientosFiltro.Size = new System.Drawing.Size(34, 12);
            this.lblMovimientosFiltro.TabIndex = 14;
            this.lblMovimientosFiltro.Text = "Filtro";
            // 
            // lblMovimientosTitulo
            // 
            this.lblMovimientosTitulo.AutoSize = true;
            this.lblMovimientosTitulo.Font = new System.Drawing.Font("Consolas", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMovimientosTitulo.Location = new System.Drawing.Point(227, 24);
            this.lblMovimientosTitulo.Name = "lblMovimientosTitulo";
            this.lblMovimientosTitulo.Size = new System.Drawing.Size(191, 34);
            this.lblMovimientosTitulo.TabIndex = 13;
            this.lblMovimientosTitulo.Text = "MOVIMIENTOS";
            // 
            // frmMovimientos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(644, 411);
            this.Controls.Add(this.btnMovimientosClose);
            this.Controls.Add(this.btnMovimientosNuevo);
            this.Controls.Add(this.dgvMovimientos);
            this.Controls.Add(this.tbxMovimientosFiltro);
            this.Controls.Add(this.lblMovimientosFiltro);
            this.Controls.Add(this.lblMovimientosTitulo);
            this.MinimizeBox = false;
            this.Name = "frmMovimientos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMovimientos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMovimientos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMovimientos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMovimientosClose;
        private System.Windows.Forms.Button btnMovimientosNuevo;
        private System.Windows.Forms.DataGridView dgvMovimientos;
        private System.Windows.Forms.TextBox tbxMovimientosFiltro;
        private System.Windows.Forms.Label lblMovimientosFiltro;
        private System.Windows.Forms.Label lblMovimientosTitulo;
    }
}