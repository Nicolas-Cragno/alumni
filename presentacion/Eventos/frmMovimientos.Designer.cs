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
            this.btnMovimientosClose.Location = new System.Drawing.Point(423, 387);
            this.btnMovimientosClose.Name = "btnMovimientosClose";
            this.btnMovimientosClose.Size = new System.Drawing.Size(51, 23);
            this.btnMovimientosClose.TabIndex = 18;
            this.btnMovimientosClose.Text = "Cerrar";
            this.btnMovimientosClose.UseVisualStyleBackColor = true;
            this.btnMovimientosClose.Click += new System.EventHandler(this.btnMovimientosClose_Click);
            // 
            // btnMovimientosNuevo
            // 
            this.btnMovimientosNuevo.Location = new System.Drawing.Point(382, 78);
            this.btnMovimientosNuevo.Name = "btnMovimientosNuevo";
            this.btnMovimientosNuevo.Size = new System.Drawing.Size(92, 23);
            this.btnMovimientosNuevo.TabIndex = 17;
            this.btnMovimientosNuevo.Text = "Agregar Nuevo";
            this.btnMovimientosNuevo.UseVisualStyleBackColor = true;
            // 
            // dgvMovimientos
            // 
            this.dgvMovimientos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMovimientos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvMovimientos.Location = new System.Drawing.Point(34, 107);
            this.dgvMovimientos.MultiSelect = false;
            this.dgvMovimientos.Name = "dgvMovimientos";
            this.dgvMovimientos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMovimientos.Size = new System.Drawing.Size(453, 263);
            this.dgvMovimientos.TabIndex = 16;
            // 
            // tbxMovimientosFiltro
            // 
            this.tbxMovimientosFiltro.Location = new System.Drawing.Point(81, 81);
            this.tbxMovimientosFiltro.Name = "tbxMovimientosFiltro";
            this.tbxMovimientosFiltro.Size = new System.Drawing.Size(292, 20);
            this.tbxMovimientosFiltro.TabIndex = 15;
            // 
            // lblMovimientosFiltro
            // 
            this.lblMovimientosFiltro.AutoSize = true;
            this.lblMovimientosFiltro.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMovimientosFiltro.Location = new System.Drawing.Point(41, 85);
            this.lblMovimientosFiltro.Name = "lblMovimientosFiltro";
            this.lblMovimientosFiltro.Size = new System.Drawing.Size(34, 12);
            this.lblMovimientosFiltro.TabIndex = 14;
            this.lblMovimientosFiltro.Text = "Filtro";
            // 
            // lblMovimientosTitulo
            // 
            this.lblMovimientosTitulo.AutoSize = true;
            this.lblMovimientosTitulo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMovimientosTitulo.Location = new System.Drawing.Point(148, 24);
            this.lblMovimientosTitulo.Name = "lblMovimientosTitulo";
            this.lblMovimientosTitulo.Size = new System.Drawing.Size(225, 33);
            this.lblMovimientosTitulo.TabIndex = 13;
            this.lblMovimientosTitulo.Text = "MOVIMIENTOS";
            // 
            // frmMovimientos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 422);
            this.Controls.Add(this.btnMovimientosClose);
            this.Controls.Add(this.btnMovimientosNuevo);
            this.Controls.Add(this.dgvMovimientos);
            this.Controls.Add(this.tbxMovimientosFiltro);
            this.Controls.Add(this.lblMovimientosFiltro);
            this.Controls.Add(this.lblMovimientosTitulo);
            this.Name = "frmMovimientos";
            this.Text = "frmMovimientos";
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