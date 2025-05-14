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
            this.btnVehiculos = new System.Windows.Forms.Button();
            this.btnChoferes = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnEventos = new System.Windows.Forms.Button();
            this.btnMovimientos = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnVehiculos
            // 
            this.btnVehiculos.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVehiculos.Location = new System.Drawing.Point(34, 104);
            this.btnVehiculos.Name = "btnVehiculos";
            this.btnVehiculos.Size = new System.Drawing.Size(253, 36);
            this.btnVehiculos.TabIndex = 0;
            this.btnVehiculos.Text = "VEHICULOS";
            this.btnVehiculos.UseVisualStyleBackColor = true;
            this.btnVehiculos.Click += new System.EventHandler(this.btnVehiculos_Click);
            // 
            // btnChoferes
            // 
            this.btnChoferes.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChoferes.Location = new System.Drawing.Point(34, 40);
            this.btnChoferes.Name = "btnChoferes";
            this.btnChoferes.Size = new System.Drawing.Size(253, 36);
            this.btnChoferes.TabIndex = 1;
            this.btnChoferes.Text = "CHOFERES";
            this.btnChoferes.UseVisualStyleBackColor = true;
            this.btnChoferes.Click += new System.EventHandler(this.btnChoferes_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnVehiculos);
            this.groupBox1.Controls.Add(this.btnChoferes);
            this.groupBox1.Location = new System.Drawing.Point(306, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(327, 172);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Recursos";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnEventos);
            this.groupBox2.Controls.Add(this.btnMovimientos);
            this.groupBox2.Location = new System.Drawing.Point(306, 228);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(327, 172);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Acciones";
            // 
            // btnEventos
            // 
            this.btnEventos.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEventos.Location = new System.Drawing.Point(34, 104);
            this.btnEventos.Name = "btnEventos";
            this.btnEventos.Size = new System.Drawing.Size(253, 36);
            this.btnEventos.TabIndex = 0;
            this.btnEventos.Text = "EVENTOS";
            this.btnEventos.UseVisualStyleBackColor = true;
            this.btnEventos.Click += new System.EventHandler(this.btnEventos_Click);
            // 
            // btnMovimientos
            // 
            this.btnMovimientos.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMovimientos.Location = new System.Drawing.Point(34, 40);
            this.btnMovimientos.Name = "btnMovimientos";
            this.btnMovimientos.Size = new System.Drawing.Size(253, 36);
            this.btnMovimientos.TabIndex = 1;
            this.btnMovimientos.Text = "MOVIMIENTOS";
            this.btnMovimientos.UseVisualStyleBackColor = true;
            this.btnMovimientos.Click += new System.EventHandler(this.btnMovimientos_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 454);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmPrincipal";
            this.Text = "FrmPrincipal";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnVehiculos;
        private System.Windows.Forms.Button btnChoferes;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnEventos;
        private System.Windows.Forms.Button btnMovimientos;
    }
}