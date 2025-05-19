namespace presentacion.Furgones
{
    partial class frmModificarFurgon
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
            this.cbxModificarFurgonEmpresa = new System.Windows.Forms.ComboBox();
            this.btnModificarFurgon = new System.Windows.Forms.Button();
            this.tbxModificarFurgonObservaciones = new System.Windows.Forms.TextBox();
            this.lblAgregarModificarObservaciones = new System.Windows.Forms.Label();
            this.lblModificarFurgonEmpresa = new System.Windows.Forms.Label();
            this.tbxModificarFurgonDominio = new System.Windows.Forms.TextBox();
            this.lblModificarFurgonDominio = new System.Windows.Forms.Label();
            this.lblModificarFurgonTitulo = new System.Windows.Forms.Label();
            this.cbxModificarFurgonTaller = new System.Windows.Forms.CheckBox();
            this.cbxModificarFurgonActivo = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // cbxModificarFurgonEmpresa
            // 
            this.cbxModificarFurgonEmpresa.FormattingEnabled = true;
            this.cbxModificarFurgonEmpresa.Location = new System.Drawing.Point(75, 70);
            this.cbxModificarFurgonEmpresa.Name = "cbxModificarFurgonEmpresa";
            this.cbxModificarFurgonEmpresa.Size = new System.Drawing.Size(257, 21);
            this.cbxModificarFurgonEmpresa.TabIndex = 108;
            // 
            // btnModificarFurgon
            // 
            this.btnModificarFurgon.Location = new System.Drawing.Point(251, 272);
            this.btnModificarFurgon.Name = "btnModificarFurgon";
            this.btnModificarFurgon.Size = new System.Drawing.Size(81, 23);
            this.btnModificarFurgon.TabIndex = 105;
            this.btnModificarFurgon.Text = "Agregar";
            this.btnModificarFurgon.UseVisualStyleBackColor = true;
            this.btnModificarFurgon.Click += new System.EventHandler(this.btnModificarFurgon_Click);
            // 
            // tbxModificarFurgonObservaciones
            // 
            this.tbxModificarFurgonObservaciones.Location = new System.Drawing.Point(25, 123);
            this.tbxModificarFurgonObservaciones.Multiline = true;
            this.tbxModificarFurgonObservaciones.Name = "tbxModificarFurgonObservaciones";
            this.tbxModificarFurgonObservaciones.Size = new System.Drawing.Size(307, 126);
            this.tbxModificarFurgonObservaciones.TabIndex = 104;
            // 
            // lblAgregarModificarObservaciones
            // 
            this.lblAgregarModificarObservaciones.AutoSize = true;
            this.lblAgregarModificarObservaciones.Location = new System.Drawing.Point(26, 107);
            this.lblAgregarModificarObservaciones.Name = "lblAgregarModificarObservaciones";
            this.lblAgregarModificarObservaciones.Size = new System.Drawing.Size(78, 13);
            this.lblAgregarModificarObservaciones.TabIndex = 103;
            this.lblAgregarModificarObservaciones.Text = "Observaciones";
            // 
            // lblModificarFurgonEmpresa
            // 
            this.lblModificarFurgonEmpresa.AutoSize = true;
            this.lblModificarFurgonEmpresa.Location = new System.Drawing.Point(22, 74);
            this.lblModificarFurgonEmpresa.Name = "lblModificarFurgonEmpresa";
            this.lblModificarFurgonEmpresa.Size = new System.Drawing.Size(47, 13);
            this.lblModificarFurgonEmpresa.TabIndex = 102;
            this.lblModificarFurgonEmpresa.Text = "empresa";
            // 
            // tbxModificarFurgonDominio
            // 
            this.tbxModificarFurgonDominio.Location = new System.Drawing.Point(75, 44);
            this.tbxModificarFurgonDominio.Name = "tbxModificarFurgonDominio";
            this.tbxModificarFurgonDominio.Size = new System.Drawing.Size(113, 20);
            this.tbxModificarFurgonDominio.TabIndex = 101;
            // 
            // lblModificarFurgonDominio
            // 
            this.lblModificarFurgonDominio.AutoSize = true;
            this.lblModificarFurgonDominio.Location = new System.Drawing.Point(26, 47);
            this.lblModificarFurgonDominio.Name = "lblModificarFurgonDominio";
            this.lblModificarFurgonDominio.Size = new System.Drawing.Size(43, 13);
            this.lblModificarFurgonDominio.TabIndex = 100;
            this.lblModificarFurgonDominio.Text = "dominio";
            // 
            // lblModificarFurgonTitulo
            // 
            this.lblModificarFurgonTitulo.AutoSize = true;
            this.lblModificarFurgonTitulo.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModificarFurgonTitulo.Location = new System.Drawing.Point(114, 9);
            this.lblModificarFurgonTitulo.Name = "lblModificarFurgonTitulo";
            this.lblModificarFurgonTitulo.Size = new System.Drawing.Size(126, 19);
            this.lblModificarFurgonTitulo.TabIndex = 110;
            this.lblModificarFurgonTitulo.Text = "INT - DOMINIO";
            this.lblModificarFurgonTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbxModificarFurgonTaller
            // 
            this.cbxModificarFurgonTaller.AutoSize = true;
            this.cbxModificarFurgonTaller.Location = new System.Drawing.Point(29, 255);
            this.cbxModificarFurgonTaller.Name = "cbxModificarFurgonTaller";
            this.cbxModificarFurgonTaller.Size = new System.Drawing.Size(66, 17);
            this.cbxModificarFurgonTaller.TabIndex = 112;
            this.cbxModificarFurgonTaller.Text = "OK taller";
            this.cbxModificarFurgonTaller.UseVisualStyleBackColor = true;
            // 
            // cbxModificarFurgonActivo
            // 
            this.cbxModificarFurgonActivo.AutoSize = true;
            this.cbxModificarFurgonActivo.Location = new System.Drawing.Point(29, 278);
            this.cbxModificarFurgonActivo.Name = "cbxModificarFurgonActivo";
            this.cbxModificarFurgonActivo.Size = new System.Drawing.Size(56, 17);
            this.cbxModificarFurgonActivo.TabIndex = 111;
            this.cbxModificarFurgonActivo.Text = "Activo";
            this.cbxModificarFurgonActivo.UseVisualStyleBackColor = true;
            // 
            // frmModificarFurgon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 311);
            this.Controls.Add(this.cbxModificarFurgonTaller);
            this.Controls.Add(this.cbxModificarFurgonActivo);
            this.Controls.Add(this.lblModificarFurgonTitulo);
            this.Controls.Add(this.cbxModificarFurgonEmpresa);
            this.Controls.Add(this.btnModificarFurgon);
            this.Controls.Add(this.tbxModificarFurgonObservaciones);
            this.Controls.Add(this.lblAgregarModificarObservaciones);
            this.Controls.Add(this.lblModificarFurgonEmpresa);
            this.Controls.Add(this.tbxModificarFurgonDominio);
            this.Controls.Add(this.lblModificarFurgonDominio);
            this.Name = "frmModificarFurgon";
            this.Text = "frmModificarFurgon";
            this.Load += new System.EventHandler(this.frmModificarFurgon_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cbxModificarFurgonEmpresa;
        private System.Windows.Forms.Button btnModificarFurgon;
        private System.Windows.Forms.TextBox tbxModificarFurgonObservaciones;
        private System.Windows.Forms.Label lblAgregarModificarObservaciones;
        private System.Windows.Forms.Label lblModificarFurgonEmpresa;
        private System.Windows.Forms.TextBox tbxModificarFurgonDominio;
        private System.Windows.Forms.Label lblModificarFurgonDominio;
        private System.Windows.Forms.Label lblModificarFurgonTitulo;
        private System.Windows.Forms.CheckBox cbxModificarFurgonTaller;
        private System.Windows.Forms.CheckBox cbxModificarFurgonActivo;
    }
}