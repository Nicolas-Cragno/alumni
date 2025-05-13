namespace presentacion.Tractores
{
    partial class FrmFichaTractor
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
            this.btnFichaTractorCerrar = new System.Windows.Forms.Button();
            this.btnAgregarFichaTractorEventos = new System.Windows.Forms.Button();
            this.tbxFichaTractorEventosFiltro = new System.Windows.Forms.TextBox();
            this.lblFichaTractorEventosFiltro = new System.Windows.Forms.Label();
            this.dgvFichaTractorEventos = new System.Windows.Forms.DataGridView();
            this.lblFichaTractorEventosTitulo = new System.Windows.Forms.Label();
            this.bntFichaTractorEditar = new System.Windows.Forms.Button();
            this.tbxFichaTractorObservaciones = new System.Windows.Forms.TextBox();
            this.lblFichaTractorObservaciones = new System.Windows.Forms.Label();
            this.tbxFichaTractorMarca = new System.Windows.Forms.TextBox();
            this.lblFichaTractorMarca = new System.Windows.Forms.Label();
            this.tbxFichaTractorModelo = new System.Windows.Forms.TextBox();
            this.lblFichaTractorModelo = new System.Windows.Forms.Label();
            this.tbxFichaTractorEmpresa = new System.Windows.Forms.TextBox();
            this.lblFichaTractorEmpresa = new System.Windows.Forms.Label();
            this.tbxFichaTractorDominio = new System.Windows.Forms.TextBox();
            this.lblFichaTractorDominio = new System.Windows.Forms.Label();
            this.tbxFichaTractorInterno = new System.Windows.Forms.TextBox();
            this.lblFichaTractorInterno = new System.Windows.Forms.Label();
            this.lblFichaTractorTitulo = new System.Windows.Forms.Label();
            this.tbxFichaTractorEstado = new System.Windows.Forms.TextBox();
            this.lblFichaTractorEstado = new System.Windows.Forms.Label();
            this.gpxFichaTractorSatelital = new System.Windows.Forms.GroupBox();
            this.lblFichaTractorSatCb = new System.Windows.Forms.Label();
            this.lblFichaTractorSatUb = new System.Windows.Forms.Label();
            this.tbxFichaTractorSatUb = new System.Windows.Forms.TextBox();
            this.tbxFichaTractorSatCb = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFichaTractorEventos)).BeginInit();
            this.gpxFichaTractorSatelital.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnFichaTractorCerrar
            // 
            this.btnFichaTractorCerrar.Location = new System.Drawing.Point(506, 437);
            this.btnFichaTractorCerrar.Name = "btnFichaTractorCerrar";
            this.btnFichaTractorCerrar.Size = new System.Drawing.Size(75, 23);
            this.btnFichaTractorCerrar.TabIndex = 49;
            this.btnFichaTractorCerrar.Text = "Cerrar";
            this.btnFichaTractorCerrar.UseVisualStyleBackColor = true;
            this.btnFichaTractorCerrar.Click += new System.EventHandler(this.btnFichaTractorCerrar_Click);
            // 
            // btnAgregarFichaTractorEventos
            // 
            this.btnAgregarFichaTractorEventos.Location = new System.Drawing.Point(517, 108);
            this.btnAgregarFichaTractorEventos.Name = "btnAgregarFichaTractorEventos";
            this.btnAgregarFichaTractorEventos.Size = new System.Drawing.Size(56, 23);
            this.btnAgregarFichaTractorEventos.TabIndex = 48;
            this.btnAgregarFichaTractorEventos.Text = "Agregar";
            this.btnAgregarFichaTractorEventos.UseVisualStyleBackColor = true;
            // 
            // tbxFichaTractorEventosFiltro
            // 
            this.tbxFichaTractorEventosFiltro.Location = new System.Drawing.Point(364, 110);
            this.tbxFichaTractorEventosFiltro.Name = "tbxFichaTractorEventosFiltro";
            this.tbxFichaTractorEventosFiltro.Size = new System.Drawing.Size(147, 20);
            this.tbxFichaTractorEventosFiltro.TabIndex = 47;
            // 
            // lblFichaTractorEventosFiltro
            // 
            this.lblFichaTractorEventosFiltro.AutoSize = true;
            this.lblFichaTractorEventosFiltro.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFichaTractorEventosFiltro.Location = new System.Drawing.Point(324, 114);
            this.lblFichaTractorEventosFiltro.Name = "lblFichaTractorEventosFiltro";
            this.lblFichaTractorEventosFiltro.Size = new System.Drawing.Size(34, 12);
            this.lblFichaTractorEventosFiltro.TabIndex = 46;
            this.lblFichaTractorEventosFiltro.Text = "Filtro";
            // 
            // dgvFichaTractorEventos
            // 
            this.dgvFichaTractorEventos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFichaTractorEventos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvFichaTractorEventos.Location = new System.Drawing.Point(316, 136);
            this.dgvFichaTractorEventos.MultiSelect = false;
            this.dgvFichaTractorEventos.Name = "dgvFichaTractorEventos";
            this.dgvFichaTractorEventos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFichaTractorEventos.Size = new System.Drawing.Size(265, 295);
            this.dgvFichaTractorEventos.TabIndex = 45;
            // 
            // lblFichaTractorEventosTitulo
            // 
            this.lblFichaTractorEventosTitulo.AutoSize = true;
            this.lblFichaTractorEventosTitulo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFichaTractorEventosTitulo.Location = new System.Drawing.Point(312, 67);
            this.lblFichaTractorEventosTitulo.Name = "lblFichaTractorEventosTitulo";
            this.lblFichaTractorEventosTitulo.Size = new System.Drawing.Size(228, 24);
            this.lblFichaTractorEventosTitulo.TabIndex = 44;
            this.lblFichaTractorEventosTitulo.Text = "Eventos relacionados";
            // 
            // bntFichaTractorEditar
            // 
            this.bntFichaTractorEditar.Location = new System.Drawing.Point(193, 437);
            this.bntFichaTractorEditar.Name = "bntFichaTractorEditar";
            this.bntFichaTractorEditar.Size = new System.Drawing.Size(75, 23);
            this.bntFichaTractorEditar.TabIndex = 43;
            this.bntFichaTractorEditar.Text = "Editar Datos";
            this.bntFichaTractorEditar.UseVisualStyleBackColor = true;
            this.bntFichaTractorEditar.Click += new System.EventHandler(this.bntFichaTractorEditar_Click);
            // 
            // tbxFichaTractorObservaciones
            // 
            this.tbxFichaTractorObservaciones.Location = new System.Drawing.Point(26, 322);
            this.tbxFichaTractorObservaciones.Multiline = true;
            this.tbxFichaTractorObservaciones.Name = "tbxFichaTractorObservaciones";
            this.tbxFichaTractorObservaciones.ReadOnly = true;
            this.tbxFichaTractorObservaciones.Size = new System.Drawing.Size(242, 109);
            this.tbxFichaTractorObservaciones.TabIndex = 42;
            // 
            // lblFichaTractorObservaciones
            // 
            this.lblFichaTractorObservaciones.AutoSize = true;
            this.lblFichaTractorObservaciones.Location = new System.Drawing.Point(32, 306);
            this.lblFichaTractorObservaciones.Name = "lblFichaTractorObservaciones";
            this.lblFichaTractorObservaciones.Size = new System.Drawing.Size(78, 13);
            this.lblFichaTractorObservaciones.TabIndex = 41;
            this.lblFichaTractorObservaciones.Text = "Observaciones";
            // 
            // tbxFichaTractorMarca
            // 
            this.tbxFichaTractorMarca.Location = new System.Drawing.Point(26, 178);
            this.tbxFichaTractorMarca.Name = "tbxFichaTractorMarca";
            this.tbxFichaTractorMarca.ReadOnly = true;
            this.tbxFichaTractorMarca.Size = new System.Drawing.Size(157, 20);
            this.tbxFichaTractorMarca.TabIndex = 38;
            // 
            // lblFichaTractorMarca
            // 
            this.lblFichaTractorMarca.AutoSize = true;
            this.lblFichaTractorMarca.Location = new System.Drawing.Point(32, 162);
            this.lblFichaTractorMarca.Name = "lblFichaTractorMarca";
            this.lblFichaTractorMarca.Size = new System.Drawing.Size(36, 13);
            this.lblFichaTractorMarca.TabIndex = 37;
            this.lblFichaTractorMarca.Text = "marca";
            // 
            // tbxFichaTractorModelo
            // 
            this.tbxFichaTractorModelo.Location = new System.Drawing.Point(193, 136);
            this.tbxFichaTractorModelo.Name = "tbxFichaTractorModelo";
            this.tbxFichaTractorModelo.ReadOnly = true;
            this.tbxFichaTractorModelo.Size = new System.Drawing.Size(75, 20);
            this.tbxFichaTractorModelo.TabIndex = 36;
            // 
            // lblFichaTractorModelo
            // 
            this.lblFichaTractorModelo.AutoSize = true;
            this.lblFichaTractorModelo.Location = new System.Drawing.Point(199, 120);
            this.lblFichaTractorModelo.Name = "lblFichaTractorModelo";
            this.lblFichaTractorModelo.Size = new System.Drawing.Size(41, 13);
            this.lblFichaTractorModelo.TabIndex = 35;
            this.lblFichaTractorModelo.Text = "modelo";
            // 
            // tbxFichaTractorEmpresa
            // 
            this.tbxFichaTractorEmpresa.Location = new System.Drawing.Point(26, 136);
            this.tbxFichaTractorEmpresa.Name = "tbxFichaTractorEmpresa";
            this.tbxFichaTractorEmpresa.ReadOnly = true;
            this.tbxFichaTractorEmpresa.Size = new System.Drawing.Size(157, 20);
            this.tbxFichaTractorEmpresa.TabIndex = 32;
            // 
            // lblFichaTractorEmpresa
            // 
            this.lblFichaTractorEmpresa.AutoSize = true;
            this.lblFichaTractorEmpresa.Location = new System.Drawing.Point(32, 120);
            this.lblFichaTractorEmpresa.Name = "lblFichaTractorEmpresa";
            this.lblFichaTractorEmpresa.Size = new System.Drawing.Size(47, 13);
            this.lblFichaTractorEmpresa.TabIndex = 31;
            this.lblFichaTractorEmpresa.Text = "empresa";
            // 
            // tbxFichaTractorDominio
            // 
            this.tbxFichaTractorDominio.Location = new System.Drawing.Point(134, 94);
            this.tbxFichaTractorDominio.Name = "tbxFichaTractorDominio";
            this.tbxFichaTractorDominio.ReadOnly = true;
            this.tbxFichaTractorDominio.Size = new System.Drawing.Size(134, 20);
            this.tbxFichaTractorDominio.TabIndex = 30;
            // 
            // lblFichaTractorDominio
            // 
            this.lblFichaTractorDominio.AutoSize = true;
            this.lblFichaTractorDominio.Location = new System.Drawing.Point(140, 78);
            this.lblFichaTractorDominio.Name = "lblFichaTractorDominio";
            this.lblFichaTractorDominio.Size = new System.Drawing.Size(43, 13);
            this.lblFichaTractorDominio.TabIndex = 29;
            this.lblFichaTractorDominio.Text = "dominio";
            // 
            // tbxFichaTractorInterno
            // 
            this.tbxFichaTractorInterno.Location = new System.Drawing.Point(26, 94);
            this.tbxFichaTractorInterno.Name = "tbxFichaTractorInterno";
            this.tbxFichaTractorInterno.ReadOnly = true;
            this.tbxFichaTractorInterno.Size = new System.Drawing.Size(100, 20);
            this.tbxFichaTractorInterno.TabIndex = 28;
            // 
            // lblFichaTractorInterno
            // 
            this.lblFichaTractorInterno.AutoSize = true;
            this.lblFichaTractorInterno.Location = new System.Drawing.Point(32, 78);
            this.lblFichaTractorInterno.Name = "lblFichaTractorInterno";
            this.lblFichaTractorInterno.Size = new System.Drawing.Size(39, 13);
            this.lblFichaTractorInterno.TabIndex = 27;
            this.lblFichaTractorInterno.Text = "interno";
            // 
            // lblFichaTractorTitulo
            // 
            this.lblFichaTractorTitulo.AutoSize = true;
            this.lblFichaTractorTitulo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFichaTractorTitulo.Location = new System.Drawing.Point(20, 27);
            this.lblFichaTractorTitulo.Name = "lblFichaTractorTitulo";
            this.lblFichaTractorTitulo.Size = new System.Drawing.Size(248, 33);
            this.lblFichaTractorTitulo.TabIndex = 26;
            this.lblFichaTractorTitulo.Text = "Ficha del tractor";
            // 
            // tbxFichaTractorEstado
            // 
            this.tbxFichaTractorEstado.Location = new System.Drawing.Point(193, 178);
            this.tbxFichaTractorEstado.Name = "tbxFichaTractorEstado";
            this.tbxFichaTractorEstado.ReadOnly = true;
            this.tbxFichaTractorEstado.Size = new System.Drawing.Size(75, 20);
            this.tbxFichaTractorEstado.TabIndex = 51;
            // 
            // lblFichaTractorEstado
            // 
            this.lblFichaTractorEstado.AutoSize = true;
            this.lblFichaTractorEstado.Location = new System.Drawing.Point(199, 162);
            this.lblFichaTractorEstado.Name = "lblFichaTractorEstado";
            this.lblFichaTractorEstado.Size = new System.Drawing.Size(39, 13);
            this.lblFichaTractorEstado.TabIndex = 50;
            this.lblFichaTractorEstado.Text = "estado";
            // 
            // gpxFichaTractorSatelital
            // 
            this.gpxFichaTractorSatelital.Controls.Add(this.tbxFichaTractorSatCb);
            this.gpxFichaTractorSatelital.Controls.Add(this.tbxFichaTractorSatUb);
            this.gpxFichaTractorSatelital.Controls.Add(this.lblFichaTractorSatCb);
            this.gpxFichaTractorSatelital.Controls.Add(this.lblFichaTractorSatUb);
            this.gpxFichaTractorSatelital.Location = new System.Drawing.Point(26, 214);
            this.gpxFichaTractorSatelital.Name = "gpxFichaTractorSatelital";
            this.gpxFichaTractorSatelital.Size = new System.Drawing.Size(242, 86);
            this.gpxFichaTractorSatelital.TabIndex = 86;
            this.gpxFichaTractorSatelital.TabStop = false;
            this.gpxFichaTractorSatelital.Text = "Satelital";
            // 
            // lblFichaTractorSatCb
            // 
            this.lblFichaTractorSatCb.AutoSize = true;
            this.lblFichaTractorSatCb.Location = new System.Drawing.Point(6, 52);
            this.lblFichaTractorSatCb.Name = "lblFichaTractorSatCb";
            this.lblFichaTractorSatCb.Size = new System.Drawing.Size(63, 13);
            this.lblFichaTractorSatCb.TabIndex = 82;
            this.lblFichaTractorSatCb.Text = "combustible";
            // 
            // lblFichaTractorSatUb
            // 
            this.lblFichaTractorSatUb.AutoSize = true;
            this.lblFichaTractorSatUb.Location = new System.Drawing.Point(11, 22);
            this.lblFichaTractorSatUb.Name = "lblFichaTractorSatUb";
            this.lblFichaTractorSatUb.Size = new System.Drawing.Size(53, 13);
            this.lblFichaTractorSatUb.TabIndex = 73;
            this.lblFichaTractorSatUb.Text = "ubicación";
            // 
            // tbxFichaTractorSatUb
            // 
            this.tbxFichaTractorSatUb.Location = new System.Drawing.Point(70, 19);
            this.tbxFichaTractorSatUb.Name = "tbxFichaTractorSatUb";
            this.tbxFichaTractorSatUb.ReadOnly = true;
            this.tbxFichaTractorSatUb.Size = new System.Drawing.Size(157, 20);
            this.tbxFichaTractorSatUb.TabIndex = 84;
            // 
            // tbxFichaTractorSatCb
            // 
            this.tbxFichaTractorSatCb.Location = new System.Drawing.Point(70, 49);
            this.tbxFichaTractorSatCb.Name = "tbxFichaTractorSatCb";
            this.tbxFichaTractorSatCb.ReadOnly = true;
            this.tbxFichaTractorSatCb.Size = new System.Drawing.Size(157, 20);
            this.tbxFichaTractorSatCb.TabIndex = 85;
            // 
            // FrmFichaTractor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 472);
            this.Controls.Add(this.gpxFichaTractorSatelital);
            this.Controls.Add(this.tbxFichaTractorEstado);
            this.Controls.Add(this.lblFichaTractorEstado);
            this.Controls.Add(this.btnFichaTractorCerrar);
            this.Controls.Add(this.btnAgregarFichaTractorEventos);
            this.Controls.Add(this.tbxFichaTractorEventosFiltro);
            this.Controls.Add(this.lblFichaTractorEventosFiltro);
            this.Controls.Add(this.dgvFichaTractorEventos);
            this.Controls.Add(this.lblFichaTractorEventosTitulo);
            this.Controls.Add(this.bntFichaTractorEditar);
            this.Controls.Add(this.tbxFichaTractorObservaciones);
            this.Controls.Add(this.lblFichaTractorObservaciones);
            this.Controls.Add(this.tbxFichaTractorMarca);
            this.Controls.Add(this.lblFichaTractorMarca);
            this.Controls.Add(this.tbxFichaTractorModelo);
            this.Controls.Add(this.lblFichaTractorModelo);
            this.Controls.Add(this.tbxFichaTractorEmpresa);
            this.Controls.Add(this.lblFichaTractorEmpresa);
            this.Controls.Add(this.tbxFichaTractorDominio);
            this.Controls.Add(this.lblFichaTractorDominio);
            this.Controls.Add(this.tbxFichaTractorInterno);
            this.Controls.Add(this.lblFichaTractorInterno);
            this.Controls.Add(this.lblFichaTractorTitulo);
            this.Name = "FrmFichaTractor";
            this.Text = "FrmFichaTractor";
            this.Load += new System.EventHandler(this.FrmFichaTractor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFichaTractorEventos)).EndInit();
            this.gpxFichaTractorSatelital.ResumeLayout(false);
            this.gpxFichaTractorSatelital.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFichaTractorCerrar;
        private System.Windows.Forms.Button btnAgregarFichaTractorEventos;
        private System.Windows.Forms.TextBox tbxFichaTractorEventosFiltro;
        private System.Windows.Forms.Label lblFichaTractorEventosFiltro;
        private System.Windows.Forms.DataGridView dgvFichaTractorEventos;
        private System.Windows.Forms.Label lblFichaTractorEventosTitulo;
        private System.Windows.Forms.Button bntFichaTractorEditar;
        private System.Windows.Forms.TextBox tbxFichaTractorObservaciones;
        private System.Windows.Forms.Label lblFichaTractorObservaciones;
        private System.Windows.Forms.TextBox tbxFichaTractorMarca;
        private System.Windows.Forms.Label lblFichaTractorMarca;
        private System.Windows.Forms.TextBox tbxFichaTractorModelo;
        private System.Windows.Forms.Label lblFichaTractorModelo;
        private System.Windows.Forms.TextBox tbxFichaTractorEmpresa;
        private System.Windows.Forms.Label lblFichaTractorEmpresa;
        private System.Windows.Forms.TextBox tbxFichaTractorDominio;
        private System.Windows.Forms.Label lblFichaTractorDominio;
        private System.Windows.Forms.TextBox tbxFichaTractorInterno;
        private System.Windows.Forms.Label lblFichaTractorInterno;
        private System.Windows.Forms.Label lblFichaTractorTitulo;
        private System.Windows.Forms.TextBox tbxFichaTractorEstado;
        private System.Windows.Forms.Label lblFichaTractorEstado;
        private System.Windows.Forms.GroupBox gpxFichaTractorSatelital;
        private System.Windows.Forms.Label lblFichaTractorSatCb;
        private System.Windows.Forms.Label lblFichaTractorSatUb;
        private System.Windows.Forms.TextBox tbxFichaTractorSatCb;
        private System.Windows.Forms.TextBox tbxFichaTractorSatUb;
    }
}