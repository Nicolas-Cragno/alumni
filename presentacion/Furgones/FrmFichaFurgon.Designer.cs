﻿namespace presentacion.Furgones
{
    partial class FrmFichaFurgon
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
            this.tbxFichaFurgonEstado = new System.Windows.Forms.TextBox();
            this.lblFichaFurgonEstado = new System.Windows.Forms.Label();
            this.btnFichaFurgonCerrar = new System.Windows.Forms.Button();
            this.btnAgregarFichaFurgonEventos = new System.Windows.Forms.Button();
            this.tbxFichaFurgonEventosFiltro = new System.Windows.Forms.TextBox();
            this.lblFichaFurgonEventosFiltro = new System.Windows.Forms.Label();
            this.dgvFichaFurgonEventos = new System.Windows.Forms.DataGridView();
            this.lblFichaFurgonEventosTitulo = new System.Windows.Forms.Label();
            this.bntFichaFurgonEditar = new System.Windows.Forms.Button();
            this.tbxFichaFurgonObservaciones = new System.Windows.Forms.TextBox();
            this.lblFichaFurgonObservaciones = new System.Windows.Forms.Label();
            this.tbxFichaFurgonEmpresa = new System.Windows.Forms.TextBox();
            this.lblFichaFurgonEmpresa = new System.Windows.Forms.Label();
            this.tbxFichaFurgonDominio = new System.Windows.Forms.TextBox();
            this.lblFichaFurgonDominio = new System.Windows.Forms.Label();
            this.tbxFichaFurgonInterno = new System.Windows.Forms.TextBox();
            this.lblFichaFurgonInterno = new System.Windows.Forms.Label();
            this.lblFichaFurgonTitulo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFichaFurgonEventos)).BeginInit();
            this.SuspendLayout();
            // 
            // tbxFichaFurgonEstado
            // 
            this.tbxFichaFurgonEstado.Location = new System.Drawing.Point(194, 129);
            this.tbxFichaFurgonEstado.Name = "tbxFichaFurgonEstado";
            this.tbxFichaFurgonEstado.ReadOnly = true;
            this.tbxFichaFurgonEstado.Size = new System.Drawing.Size(75, 20);
            this.tbxFichaFurgonEstado.TabIndex = 108;
            // 
            // lblFichaFurgonEstado
            // 
            this.lblFichaFurgonEstado.AutoSize = true;
            this.lblFichaFurgonEstado.Location = new System.Drawing.Point(200, 113);
            this.lblFichaFurgonEstado.Name = "lblFichaFurgonEstado";
            this.lblFichaFurgonEstado.Size = new System.Drawing.Size(39, 13);
            this.lblFichaFurgonEstado.TabIndex = 107;
            this.lblFichaFurgonEstado.Text = "estado";
            // 
            // btnFichaFurgonCerrar
            // 
            this.btnFichaFurgonCerrar.Location = new System.Drawing.Point(507, 295);
            this.btnFichaFurgonCerrar.Name = "btnFichaFurgonCerrar";
            this.btnFichaFurgonCerrar.Size = new System.Drawing.Size(75, 23);
            this.btnFichaFurgonCerrar.TabIndex = 106;
            this.btnFichaFurgonCerrar.Text = "Cerrar";
            this.btnFichaFurgonCerrar.UseVisualStyleBackColor = true;
            this.btnFichaFurgonCerrar.Click += new System.EventHandler(this.btnFichaFurgonCerrar_Click);
            // 
            // btnAgregarFichaFurgonEventos
            // 
            this.btnAgregarFichaFurgonEventos.Location = new System.Drawing.Point(518, 101);
            this.btnAgregarFichaFurgonEventos.Name = "btnAgregarFichaFurgonEventos";
            this.btnAgregarFichaFurgonEventos.Size = new System.Drawing.Size(56, 23);
            this.btnAgregarFichaFurgonEventos.TabIndex = 105;
            this.btnAgregarFichaFurgonEventos.Text = "Agregar";
            this.btnAgregarFichaFurgonEventos.UseVisualStyleBackColor = true;
            this.btnAgregarFichaFurgonEventos.Click += new System.EventHandler(this.btnAgregarFichaFurgonEventos_Click);
            // 
            // tbxFichaFurgonEventosFiltro
            // 
            this.tbxFichaFurgonEventosFiltro.Location = new System.Drawing.Point(365, 103);
            this.tbxFichaFurgonEventosFiltro.Name = "tbxFichaFurgonEventosFiltro";
            this.tbxFichaFurgonEventosFiltro.Size = new System.Drawing.Size(147, 20);
            this.tbxFichaFurgonEventosFiltro.TabIndex = 104;
            this.tbxFichaFurgonEventosFiltro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxFichaFurgonEventosFiltro_KeyPress);
            // 
            // lblFichaFurgonEventosFiltro
            // 
            this.lblFichaFurgonEventosFiltro.AutoSize = true;
            this.lblFichaFurgonEventosFiltro.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFichaFurgonEventosFiltro.Location = new System.Drawing.Point(325, 107);
            this.lblFichaFurgonEventosFiltro.Name = "lblFichaFurgonEventosFiltro";
            this.lblFichaFurgonEventosFiltro.Size = new System.Drawing.Size(34, 12);
            this.lblFichaFurgonEventosFiltro.TabIndex = 103;
            this.lblFichaFurgonEventosFiltro.Text = "Filtro";
            // 
            // dgvFichaFurgonEventos
            // 
            this.dgvFichaFurgonEventos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFichaFurgonEventos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvFichaFurgonEventos.Location = new System.Drawing.Point(317, 129);
            this.dgvFichaFurgonEventos.MultiSelect = false;
            this.dgvFichaFurgonEventos.Name = "dgvFichaFurgonEventos";
            this.dgvFichaFurgonEventos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFichaFurgonEventos.Size = new System.Drawing.Size(265, 160);
            this.dgvFichaFurgonEventos.TabIndex = 102;
            this.dgvFichaFurgonEventos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFichaFurgonEventos_CellDoubleClick);
            // 
            // lblFichaFurgonEventosTitulo
            // 
            this.lblFichaFurgonEventosTitulo.AutoSize = true;
            this.lblFichaFurgonEventosTitulo.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFichaFurgonEventosTitulo.Location = new System.Drawing.Point(313, 60);
            this.lblFichaFurgonEventosTitulo.Name = "lblFichaFurgonEventosTitulo";
            this.lblFichaFurgonEventosTitulo.Size = new System.Drawing.Size(250, 24);
            this.lblFichaFurgonEventosTitulo.TabIndex = 101;
            this.lblFichaFurgonEventosTitulo.Text = "Eventos relacionados";
            // 
            // bntFichaFurgonEditar
            // 
            this.bntFichaFurgonEditar.Location = new System.Drawing.Point(194, 295);
            this.bntFichaFurgonEditar.Name = "bntFichaFurgonEditar";
            this.bntFichaFurgonEditar.Size = new System.Drawing.Size(75, 23);
            this.bntFichaFurgonEditar.TabIndex = 100;
            this.bntFichaFurgonEditar.Text = "Editar Datos";
            this.bntFichaFurgonEditar.UseVisualStyleBackColor = true;
            this.bntFichaFurgonEditar.Click += new System.EventHandler(this.bntFichaFurgonEditar_Click);
            // 
            // tbxFichaFurgonObservaciones
            // 
            this.tbxFichaFurgonObservaciones.Location = new System.Drawing.Point(27, 180);
            this.tbxFichaFurgonObservaciones.Multiline = true;
            this.tbxFichaFurgonObservaciones.Name = "tbxFichaFurgonObservaciones";
            this.tbxFichaFurgonObservaciones.ReadOnly = true;
            this.tbxFichaFurgonObservaciones.Size = new System.Drawing.Size(242, 109);
            this.tbxFichaFurgonObservaciones.TabIndex = 99;
            // 
            // lblFichaFurgonObservaciones
            // 
            this.lblFichaFurgonObservaciones.AutoSize = true;
            this.lblFichaFurgonObservaciones.Location = new System.Drawing.Point(33, 164);
            this.lblFichaFurgonObservaciones.Name = "lblFichaFurgonObservaciones";
            this.lblFichaFurgonObservaciones.Size = new System.Drawing.Size(78, 13);
            this.lblFichaFurgonObservaciones.TabIndex = 98;
            this.lblFichaFurgonObservaciones.Text = "Observaciones";
            // 
            // tbxFichaFurgonEmpresa
            // 
            this.tbxFichaFurgonEmpresa.Location = new System.Drawing.Point(27, 129);
            this.tbxFichaFurgonEmpresa.Name = "tbxFichaFurgonEmpresa";
            this.tbxFichaFurgonEmpresa.ReadOnly = true;
            this.tbxFichaFurgonEmpresa.Size = new System.Drawing.Size(157, 20);
            this.tbxFichaFurgonEmpresa.TabIndex = 93;
            // 
            // lblFichaFurgonEmpresa
            // 
            this.lblFichaFurgonEmpresa.AutoSize = true;
            this.lblFichaFurgonEmpresa.Location = new System.Drawing.Point(33, 113);
            this.lblFichaFurgonEmpresa.Name = "lblFichaFurgonEmpresa";
            this.lblFichaFurgonEmpresa.Size = new System.Drawing.Size(47, 13);
            this.lblFichaFurgonEmpresa.TabIndex = 92;
            this.lblFichaFurgonEmpresa.Text = "empresa";
            // 
            // tbxFichaFurgonDominio
            // 
            this.tbxFichaFurgonDominio.Location = new System.Drawing.Point(135, 87);
            this.tbxFichaFurgonDominio.Name = "tbxFichaFurgonDominio";
            this.tbxFichaFurgonDominio.ReadOnly = true;
            this.tbxFichaFurgonDominio.Size = new System.Drawing.Size(134, 20);
            this.tbxFichaFurgonDominio.TabIndex = 91;
            // 
            // lblFichaFurgonDominio
            // 
            this.lblFichaFurgonDominio.AutoSize = true;
            this.lblFichaFurgonDominio.Location = new System.Drawing.Point(141, 71);
            this.lblFichaFurgonDominio.Name = "lblFichaFurgonDominio";
            this.lblFichaFurgonDominio.Size = new System.Drawing.Size(43, 13);
            this.lblFichaFurgonDominio.TabIndex = 90;
            this.lblFichaFurgonDominio.Text = "dominio";
            // 
            // tbxFichaFurgonInterno
            // 
            this.tbxFichaFurgonInterno.Location = new System.Drawing.Point(27, 87);
            this.tbxFichaFurgonInterno.Name = "tbxFichaFurgonInterno";
            this.tbxFichaFurgonInterno.ReadOnly = true;
            this.tbxFichaFurgonInterno.Size = new System.Drawing.Size(100, 20);
            this.tbxFichaFurgonInterno.TabIndex = 89;
            // 
            // lblFichaFurgonInterno
            // 
            this.lblFichaFurgonInterno.AutoSize = true;
            this.lblFichaFurgonInterno.Location = new System.Drawing.Point(33, 71);
            this.lblFichaFurgonInterno.Name = "lblFichaFurgonInterno";
            this.lblFichaFurgonInterno.Size = new System.Drawing.Size(39, 13);
            this.lblFichaFurgonInterno.TabIndex = 88;
            this.lblFichaFurgonInterno.Text = "interno";
            // 
            // lblFichaFurgonTitulo
            // 
            this.lblFichaFurgonTitulo.AutoSize = true;
            this.lblFichaFurgonTitulo.Font = new System.Drawing.Font("Consolas", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFichaFurgonTitulo.Location = new System.Drawing.Point(21, 20);
            this.lblFichaFurgonTitulo.Name = "lblFichaFurgonTitulo";
            this.lblFichaFurgonTitulo.Size = new System.Drawing.Size(271, 34);
            this.lblFichaFurgonTitulo.TabIndex = 87;
            this.lblFichaFurgonTitulo.Text = "Ficha del furgón";
            // 
            // FrmFichaFurgon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 336);
            this.Controls.Add(this.tbxFichaFurgonEstado);
            this.Controls.Add(this.lblFichaFurgonEstado);
            this.Controls.Add(this.btnFichaFurgonCerrar);
            this.Controls.Add(this.btnAgregarFichaFurgonEventos);
            this.Controls.Add(this.tbxFichaFurgonEventosFiltro);
            this.Controls.Add(this.lblFichaFurgonEventosFiltro);
            this.Controls.Add(this.dgvFichaFurgonEventos);
            this.Controls.Add(this.lblFichaFurgonEventosTitulo);
            this.Controls.Add(this.bntFichaFurgonEditar);
            this.Controls.Add(this.tbxFichaFurgonObservaciones);
            this.Controls.Add(this.lblFichaFurgonObservaciones);
            this.Controls.Add(this.tbxFichaFurgonEmpresa);
            this.Controls.Add(this.lblFichaFurgonEmpresa);
            this.Controls.Add(this.tbxFichaFurgonDominio);
            this.Controls.Add(this.lblFichaFurgonDominio);
            this.Controls.Add(this.tbxFichaFurgonInterno);
            this.Controls.Add(this.lblFichaFurgonInterno);
            this.Controls.Add(this.lblFichaFurgonTitulo);
            this.Name = "FrmFichaFurgon";
            this.Text = "FrmFichaFurgon";
            this.Load += new System.EventHandler(this.FrmFichaFurgon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFichaFurgonEventos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxFichaFurgonEstado;
        private System.Windows.Forms.Label lblFichaFurgonEstado;
        private System.Windows.Forms.Button btnFichaFurgonCerrar;
        private System.Windows.Forms.Button btnAgregarFichaFurgonEventos;
        private System.Windows.Forms.TextBox tbxFichaFurgonEventosFiltro;
        private System.Windows.Forms.Label lblFichaFurgonEventosFiltro;
        private System.Windows.Forms.DataGridView dgvFichaFurgonEventos;
        private System.Windows.Forms.Label lblFichaFurgonEventosTitulo;
        private System.Windows.Forms.Button bntFichaFurgonEditar;
        private System.Windows.Forms.TextBox tbxFichaFurgonObservaciones;
        private System.Windows.Forms.Label lblFichaFurgonObservaciones;
        private System.Windows.Forms.TextBox tbxFichaFurgonEmpresa;
        private System.Windows.Forms.Label lblFichaFurgonEmpresa;
        private System.Windows.Forms.TextBox tbxFichaFurgonDominio;
        private System.Windows.Forms.Label lblFichaFurgonDominio;
        private System.Windows.Forms.TextBox tbxFichaFurgonInterno;
        private System.Windows.Forms.Label lblFichaFurgonInterno;
        private System.Windows.Forms.Label lblFichaFurgonTitulo;
    }
}