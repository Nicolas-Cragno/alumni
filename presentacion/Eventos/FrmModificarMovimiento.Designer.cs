namespace presentacion.Eventos
{
    partial class FrmModificarMovimiento
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
            this.btnModificarMovimientoCerrar = new System.Windows.Forms.Button();
            this.btnModificarMovimiento = new System.Windows.Forms.Button();
            this.cbxModificarMovimientoChofer = new System.Windows.Forms.ComboBox();
            this.cbxModificarMovimientoInterno = new System.Windows.Forms.ComboBox();
            this.lblModificarMovimientoDNI = new System.Windows.Forms.Label();
            this.tbxModificarMovimientoDetalle = new System.Windows.Forms.TextBox();
            this.lblModificarMovimientoDetalle = new System.Windows.Forms.Label();
            this.lblModificarMovimientoInterno = new System.Windows.Forms.Label();
            this.lblModificarMovimientoTitulo = new System.Windows.Forms.Label();
            this.cbxModificarMovimientoFurgon = new System.Windows.Forms.ComboBox();
            this.lblModificarMovimientoFurgon = new System.Windows.Forms.Label();
            this.lblModificarMovimientoFecha = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnModificarMovimientoCerrar
            // 
            this.btnModificarMovimientoCerrar.Location = new System.Drawing.Point(279, 323);
            this.btnModificarMovimientoCerrar.Name = "btnModificarMovimientoCerrar";
            this.btnModificarMovimientoCerrar.Size = new System.Drawing.Size(74, 23);
            this.btnModificarMovimientoCerrar.TabIndex = 106;
            this.btnModificarMovimientoCerrar.Text = "Cerrar";
            this.btnModificarMovimientoCerrar.UseVisualStyleBackColor = true;
            this.btnModificarMovimientoCerrar.Click += new System.EventHandler(this.btnModificarMovimientoCerrar_Click);
            // 
            // btnModificarMovimiento
            // 
            this.btnModificarMovimiento.Location = new System.Drawing.Point(29, 323);
            this.btnModificarMovimiento.Name = "btnModificarMovimiento";
            this.btnModificarMovimiento.Size = new System.Drawing.Size(102, 23);
            this.btnModificarMovimiento.TabIndex = 105;
            this.btnModificarMovimiento.Text = "Guardar Cambios";
            this.btnModificarMovimiento.UseVisualStyleBackColor = true;
            this.btnModificarMovimiento.Click += new System.EventHandler(this.btnModificarMovimiento_Click);
            // 
            // cbxModificarMovimientoChofer
            // 
            this.cbxModificarMovimientoChofer.FormattingEnabled = true;
            this.cbxModificarMovimientoChofer.Location = new System.Drawing.Point(73, 80);
            this.cbxModificarMovimientoChofer.Name = "cbxModificarMovimientoChofer";
            this.cbxModificarMovimientoChofer.Size = new System.Drawing.Size(280, 21);
            this.cbxModificarMovimientoChofer.TabIndex = 104;
            this.cbxModificarMovimientoChofer.SelectedIndexChanged += new System.EventHandler(this.cbxModificarMovimientoChofer_SelectedIndexChanged);
            // 
            // cbxModificarMovimientoInterno
            // 
            this.cbxModificarMovimientoInterno.FormattingEnabled = true;
            this.cbxModificarMovimientoInterno.Location = new System.Drawing.Point(73, 108);
            this.cbxModificarMovimientoInterno.Name = "cbxModificarMovimientoInterno";
            this.cbxModificarMovimientoInterno.Size = new System.Drawing.Size(72, 21);
            this.cbxModificarMovimientoInterno.TabIndex = 101;
            this.cbxModificarMovimientoInterno.SelectedIndexChanged += new System.EventHandler(this.cbxModificarMovimientoInterno_SelectedIndexChanged);
            // 
            // lblModificarMovimientoDNI
            // 
            this.lblModificarMovimientoDNI.AutoSize = true;
            this.lblModificarMovimientoDNI.Location = new System.Drawing.Point(30, 83);
            this.lblModificarMovimientoDNI.Name = "lblModificarMovimientoDNI";
            this.lblModificarMovimientoDNI.Size = new System.Drawing.Size(37, 13);
            this.lblModificarMovimientoDNI.TabIndex = 100;
            this.lblModificarMovimientoDNI.Text = "chofer";
            // 
            // tbxModificarMovimientoDetalle
            // 
            this.tbxModificarMovimientoDetalle.Location = new System.Drawing.Point(29, 151);
            this.tbxModificarMovimientoDetalle.Multiline = true;
            this.tbxModificarMovimientoDetalle.Name = "tbxModificarMovimientoDetalle";
            this.tbxModificarMovimientoDetalle.Size = new System.Drawing.Size(324, 166);
            this.tbxModificarMovimientoDetalle.TabIndex = 99;
            // 
            // lblModificarMovimientoDetalle
            // 
            this.lblModificarMovimientoDetalle.AutoSize = true;
            this.lblModificarMovimientoDetalle.Location = new System.Drawing.Point(30, 135);
            this.lblModificarMovimientoDetalle.Name = "lblModificarMovimientoDetalle";
            this.lblModificarMovimientoDetalle.Size = new System.Drawing.Size(40, 13);
            this.lblModificarMovimientoDetalle.TabIndex = 98;
            this.lblModificarMovimientoDetalle.Text = "Detalle";
            // 
            // lblModificarMovimientoInterno
            // 
            this.lblModificarMovimientoInterno.AutoSize = true;
            this.lblModificarMovimientoInterno.Location = new System.Drawing.Point(28, 112);
            this.lblModificarMovimientoInterno.Name = "lblModificarMovimientoInterno";
            this.lblModificarMovimientoInterno.Size = new System.Drawing.Size(39, 13);
            this.lblModificarMovimientoInterno.TabIndex = 97;
            this.lblModificarMovimientoInterno.Text = "interno";
            // 
            // lblModificarMovimientoTitulo
            // 
            this.lblModificarMovimientoTitulo.AutoSize = true;
            this.lblModificarMovimientoTitulo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModificarMovimientoTitulo.Location = new System.Drawing.Point(24, 9);
            this.lblModificarMovimientoTitulo.Name = "lblModificarMovimientoTitulo";
            this.lblModificarMovimientoTitulo.Size = new System.Drawing.Size(273, 28);
            this.lblModificarMovimientoTitulo.TabIndex = 96;
            this.lblModificarMovimientoTitulo.Text = "Edición de movimiento";
            // 
            // cbxModificarMovimientoFurgon
            // 
            this.cbxModificarMovimientoFurgon.FormattingEnabled = true;
            this.cbxModificarMovimientoFurgon.Location = new System.Drawing.Point(279, 108);
            this.cbxModificarMovimientoFurgon.Name = "cbxModificarMovimientoFurgon";
            this.cbxModificarMovimientoFurgon.Size = new System.Drawing.Size(72, 21);
            this.cbxModificarMovimientoFurgon.TabIndex = 108;
            this.cbxModificarMovimientoFurgon.SelectedIndexChanged += new System.EventHandler(this.cbxModificarMovimientoFurgon_SelectedIndexChanged);
            // 
            // lblModificarMovimientoFurgon
            // 
            this.lblModificarMovimientoFurgon.AutoSize = true;
            this.lblModificarMovimientoFurgon.Location = new System.Drawing.Point(234, 112);
            this.lblModificarMovimientoFurgon.Name = "lblModificarMovimientoFurgon";
            this.lblModificarMovimientoFurgon.Size = new System.Drawing.Size(37, 13);
            this.lblModificarMovimientoFurgon.TabIndex = 107;
            this.lblModificarMovimientoFurgon.Text = "furgon";
            // 
            // lblModificarMovimientoFecha
            // 
            this.lblModificarMovimientoFecha.AutoSize = true;
            this.lblModificarMovimientoFecha.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModificarMovimientoFecha.Location = new System.Drawing.Point(40, 37);
            this.lblModificarMovimientoFecha.Name = "lblModificarMovimientoFecha";
            this.lblModificarMovimientoFecha.Size = new System.Drawing.Size(186, 18);
            this.lblModificarMovimientoFecha.TabIndex = 109;
            this.lblModificarMovimientoFecha.Text = "Edición de movimiento";
            // 
            // FrmModificarMovimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 354);
            this.Controls.Add(this.lblModificarMovimientoFecha);
            this.Controls.Add(this.cbxModificarMovimientoFurgon);
            this.Controls.Add(this.lblModificarMovimientoFurgon);
            this.Controls.Add(this.btnModificarMovimientoCerrar);
            this.Controls.Add(this.btnModificarMovimiento);
            this.Controls.Add(this.cbxModificarMovimientoChofer);
            this.Controls.Add(this.cbxModificarMovimientoInterno);
            this.Controls.Add(this.lblModificarMovimientoDNI);
            this.Controls.Add(this.tbxModificarMovimientoDetalle);
            this.Controls.Add(this.lblModificarMovimientoDetalle);
            this.Controls.Add(this.lblModificarMovimientoInterno);
            this.Controls.Add(this.lblModificarMovimientoTitulo);
            this.Name = "FrmModificarMovimiento";
            this.Text = "FrmModificarMovimiento";
            this.Load += new System.EventHandler(this.FrmModificarMovimiento_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnModificarMovimientoCerrar;
        private System.Windows.Forms.Button btnModificarMovimiento;
        private System.Windows.Forms.ComboBox cbxModificarMovimientoChofer;
        private System.Windows.Forms.ComboBox cbxModificarMovimientoInterno;
        private System.Windows.Forms.Label lblModificarMovimientoDNI;
        private System.Windows.Forms.TextBox tbxModificarMovimientoDetalle;
        private System.Windows.Forms.Label lblModificarMovimientoDetalle;
        private System.Windows.Forms.Label lblModificarMovimientoInterno;
        private System.Windows.Forms.Label lblModificarMovimientoTitulo;
        private System.Windows.Forms.ComboBox cbxModificarMovimientoFurgon;
        private System.Windows.Forms.Label lblModificarMovimientoFurgon;
        private System.Windows.Forms.Label lblModificarMovimientoFecha;
    }
}