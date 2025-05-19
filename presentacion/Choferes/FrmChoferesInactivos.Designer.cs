namespace presentacion.Choferes
{
    partial class FrmChoferesInactivos
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
            this.lblChoferesInactivosTitulo = new System.Windows.Forms.Label();
            this.tbxChoferesInactivosFiltro = new System.Windows.Forms.TextBox();
            this.lblChoferesInactivosFiltro = new System.Windows.Forms.Label();
            this.dgvChoferesInactivos = new System.Windows.Forms.DataGridView();
            this.btnChoferesInactivosClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChoferesInactivos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblChoferesInactivosTitulo
            // 
            this.lblChoferesInactivosTitulo.AutoSize = true;
            this.lblChoferesInactivosTitulo.Font = new System.Drawing.Font("Consolas", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChoferesInactivosTitulo.Location = new System.Drawing.Point(39, 9);
            this.lblChoferesInactivosTitulo.Name = "lblChoferesInactivosTitulo";
            this.lblChoferesInactivosTitulo.Size = new System.Drawing.Size(303, 34);
            this.lblChoferesInactivosTitulo.TabIndex = 1;
            this.lblChoferesInactivosTitulo.Text = "CHOFERES INACTIVOS";
            // 
            // tbxChoferesInactivosFiltro
            // 
            this.tbxChoferesInactivosFiltro.Location = new System.Drawing.Point(12, 69);
            this.tbxChoferesInactivosFiltro.Name = "tbxChoferesInactivosFiltro";
            this.tbxChoferesInactivosFiltro.Size = new System.Drawing.Size(292, 20);
            this.tbxChoferesInactivosFiltro.TabIndex = 4;
            // 
            // lblChoferesInactivosFiltro
            // 
            this.lblChoferesInactivosFiltro.AutoSize = true;
            this.lblChoferesInactivosFiltro.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChoferesInactivosFiltro.Location = new System.Drawing.Point(10, 54);
            this.lblChoferesInactivosFiltro.Name = "lblChoferesInactivosFiltro";
            this.lblChoferesInactivosFiltro.Size = new System.Drawing.Size(34, 12);
            this.lblChoferesInactivosFiltro.TabIndex = 3;
            this.lblChoferesInactivosFiltro.Text = "Filtro";
            // 
            // dgvChoferesInactivos
            // 
            this.dgvChoferesInactivos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChoferesInactivos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvChoferesInactivos.Location = new System.Drawing.Point(12, 95);
            this.dgvChoferesInactivos.MultiSelect = false;
            this.dgvChoferesInactivos.Name = "dgvChoferesInactivos";
            this.dgvChoferesInactivos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvChoferesInactivos.Size = new System.Drawing.Size(356, 245);
            this.dgvChoferesInactivos.TabIndex = 5;
            // 
            // btnChoferesInactivosClose
            // 
            this.btnChoferesInactivosClose.Location = new System.Drawing.Point(317, 346);
            this.btnChoferesInactivosClose.Name = "btnChoferesInactivosClose";
            this.btnChoferesInactivosClose.Size = new System.Drawing.Size(51, 23);
            this.btnChoferesInactivosClose.TabIndex = 7;
            this.btnChoferesInactivosClose.Text = "Cerrar";
            this.btnChoferesInactivosClose.UseVisualStyleBackColor = true;
            this.btnChoferesInactivosClose.Click += new System.EventHandler(this.btnChoferesClose_Click);
            // 
            // FrmChoferesInactivos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 375);
            this.Controls.Add(this.btnChoferesInactivosClose);
            this.Controls.Add(this.dgvChoferesInactivos);
            this.Controls.Add(this.tbxChoferesInactivosFiltro);
            this.Controls.Add(this.lblChoferesInactivosFiltro);
            this.Controls.Add(this.lblChoferesInactivosTitulo);
            this.Name = "FrmChoferesInactivos";
            this.Text = "FrmChoferesInactivos";
            this.Load += new System.EventHandler(this.FrmChoferesInactivos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChoferesInactivos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblChoferesInactivosTitulo;
        private System.Windows.Forms.TextBox tbxChoferesInactivosFiltro;
        private System.Windows.Forms.Label lblChoferesInactivosFiltro;
        private System.Windows.Forms.DataGridView dgvChoferesInactivos;
        private System.Windows.Forms.Button btnChoferesInactivosClose;
    }
}