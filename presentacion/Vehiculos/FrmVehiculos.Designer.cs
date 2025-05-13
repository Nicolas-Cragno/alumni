namespace presentacion.Vehiculos
{
    partial class FrmVehiculos
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
            this.btnVehiculosCerrar = new System.Windows.Forms.Button();
            this.btnVehiculosT = new System.Windows.Forms.Button();
            this.dgvVehiculosT = new System.Windows.Forms.DataGridView();
            this.tbxVehiculosT = new System.Windows.Forms.TextBox();
            this.lblVehiculosFiltroT = new System.Windows.Forms.Label();
            this.lblVehiculosTitulo = new System.Windows.Forms.Label();
            this.btnVehiculosF = new System.Windows.Forms.Button();
            this.dgvVehiculosF = new System.Windows.Forms.DataGridView();
            this.tbxVehiculosF = new System.Windows.Forms.TextBox();
            this.lblVehiculosFiltroF = new System.Windows.Forms.Label();
            this.lblVehiculosSubTituloT = new System.Windows.Forms.Label();
            this.lblVehiculosSubtituloF = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehiculosT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehiculosF)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVehiculosCerrar
            // 
            this.btnVehiculosCerrar.Location = new System.Drawing.Point(706, 375);
            this.btnVehiculosCerrar.Name = "btnVehiculosCerrar";
            this.btnVehiculosCerrar.Size = new System.Drawing.Size(51, 23);
            this.btnVehiculosCerrar.TabIndex = 12;
            this.btnVehiculosCerrar.Text = "Cerrar";
            this.btnVehiculosCerrar.UseVisualStyleBackColor = true;
            this.btnVehiculosCerrar.Click += new System.EventHandler(this.btnVehiculosCerrar_Click);
            // 
            // btnVehiculosT
            // 
            this.btnVehiculosT.Location = new System.Drawing.Point(281, 113);
            this.btnVehiculosT.Name = "btnVehiculosT";
            this.btnVehiculosT.Size = new System.Drawing.Size(61, 23);
            this.btnVehiculosT.TabIndex = 11;
            this.btnVehiculosT.Text = "Agregar";
            this.btnVehiculosT.UseVisualStyleBackColor = true;
            this.btnVehiculosT.Click += new System.EventHandler(this.btnVehiculosT_Click);
            // 
            // dgvVehiculosT
            // 
            this.dgvVehiculosT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVehiculosT.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvVehiculosT.Location = new System.Drawing.Point(34, 141);
            this.dgvVehiculosT.MultiSelect = false;
            this.dgvVehiculosT.Name = "dgvVehiculosT";
            this.dgvVehiculosT.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVehiculosT.Size = new System.Drawing.Size(312, 220);
            this.dgvVehiculosT.TabIndex = 10;
            this.dgvVehiculosT.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVehiculosT_CellContentClick);
            this.dgvVehiculosT.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVehiculosT_CellContentDoubleClick);
            this.dgvVehiculosT.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVehiculosT_CellDoubleClick);
            // 
            // tbxVehiculosT
            // 
            this.tbxVehiculosT.Location = new System.Drawing.Point(77, 115);
            this.tbxVehiculosT.Name = "tbxVehiculosT";
            this.tbxVehiculosT.Size = new System.Drawing.Size(198, 20);
            this.tbxVehiculosT.TabIndex = 9;
            this.tbxVehiculosT.TextChanged += new System.EventHandler(this.tbxVehiculosT_TextChanged);
            this.tbxVehiculosT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxVehiculosT_KeyPress);
            // 
            // lblVehiculosFiltroT
            // 
            this.lblVehiculosFiltroT.AutoSize = true;
            this.lblVehiculosFiltroT.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVehiculosFiltroT.Location = new System.Drawing.Point(37, 119);
            this.lblVehiculosFiltroT.Name = "lblVehiculosFiltroT";
            this.lblVehiculosFiltroT.Size = new System.Drawing.Size(34, 12);
            this.lblVehiculosFiltroT.TabIndex = 8;
            this.lblVehiculosFiltroT.Text = "Filtro";
            // 
            // lblVehiculosTitulo
            // 
            this.lblVehiculosTitulo.AutoSize = true;
            this.lblVehiculosTitulo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVehiculosTitulo.Location = new System.Drawing.Point(301, 14);
            this.lblVehiculosTitulo.Name = "lblVehiculosTitulo";
            this.lblVehiculosTitulo.Size = new System.Drawing.Size(188, 33);
            this.lblVehiculosTitulo.TabIndex = 7;
            this.lblVehiculosTitulo.Text = "VEHICULOS";
            // 
            // btnVehiculosF
            // 
            this.btnVehiculosF.Location = new System.Drawing.Point(692, 113);
            this.btnVehiculosF.Name = "btnVehiculosF";
            this.btnVehiculosF.Size = new System.Drawing.Size(61, 23);
            this.btnVehiculosF.TabIndex = 16;
            this.btnVehiculosF.Text = "Agregar";
            this.btnVehiculosF.UseVisualStyleBackColor = true;
            this.btnVehiculosF.Click += new System.EventHandler(this.btnVehiculosF_Click);
            // 
            // dgvVehiculosF
            // 
            this.dgvVehiculosF.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVehiculosF.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvVehiculosF.Location = new System.Drawing.Point(445, 141);
            this.dgvVehiculosF.MultiSelect = false;
            this.dgvVehiculosF.Name = "dgvVehiculosF";
            this.dgvVehiculosF.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVehiculosF.Size = new System.Drawing.Size(312, 220);
            this.dgvVehiculosF.TabIndex = 15;
            this.dgvVehiculosF.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVehiculosF_CellContentClick);
            this.dgvVehiculosF.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVehiculosF_CellContentDoubleClick);
            this.dgvVehiculosF.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVehiculosF_CellDoubleClick);
            // 
            // tbxVehiculosF
            // 
            this.tbxVehiculosF.Location = new System.Drawing.Point(488, 115);
            this.tbxVehiculosF.Name = "tbxVehiculosF";
            this.tbxVehiculosF.Size = new System.Drawing.Size(198, 20);
            this.tbxVehiculosF.TabIndex = 14;
            this.tbxVehiculosF.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxVehiculosF_KeyPress);
            // 
            // lblVehiculosFiltroF
            // 
            this.lblVehiculosFiltroF.AutoSize = true;
            this.lblVehiculosFiltroF.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVehiculosFiltroF.Location = new System.Drawing.Point(448, 119);
            this.lblVehiculosFiltroF.Name = "lblVehiculosFiltroF";
            this.lblVehiculosFiltroF.Size = new System.Drawing.Size(34, 12);
            this.lblVehiculosFiltroF.TabIndex = 13;
            this.lblVehiculosFiltroF.Text = "Filtro";
            // 
            // lblVehiculosSubTituloT
            // 
            this.lblVehiculosSubTituloT.AutoSize = true;
            this.lblVehiculosSubTituloT.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVehiculosSubTituloT.Location = new System.Drawing.Point(127, 69);
            this.lblVehiculosSubTituloT.Name = "lblVehiculosSubTituloT";
            this.lblVehiculosSubTituloT.Size = new System.Drawing.Size(126, 28);
            this.lblVehiculosSubTituloT.TabIndex = 17;
            this.lblVehiculosSubTituloT.Text = "Tractores";
            // 
            // lblVehiculosSubtituloF
            // 
            this.lblVehiculosSubtituloF.AutoSize = true;
            this.lblVehiculosSubtituloF.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVehiculosSubtituloF.Location = new System.Drawing.Point(543, 69);
            this.lblVehiculosSubtituloF.Name = "lblVehiculosSubtituloF";
            this.lblVehiculosSubtituloF.Size = new System.Drawing.Size(121, 28);
            this.lblVehiculosSubtituloF.TabIndex = 18;
            this.lblVehiculosSubtituloF.Text = "Furgones";
            // 
            // FrmVehiculos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 410);
            this.Controls.Add(this.lblVehiculosSubtituloF);
            this.Controls.Add(this.lblVehiculosSubTituloT);
            this.Controls.Add(this.btnVehiculosF);
            this.Controls.Add(this.dgvVehiculosF);
            this.Controls.Add(this.tbxVehiculosF);
            this.Controls.Add(this.lblVehiculosFiltroF);
            this.Controls.Add(this.btnVehiculosCerrar);
            this.Controls.Add(this.btnVehiculosT);
            this.Controls.Add(this.dgvVehiculosT);
            this.Controls.Add(this.tbxVehiculosT);
            this.Controls.Add(this.lblVehiculosFiltroT);
            this.Controls.Add(this.lblVehiculosTitulo);
            this.Name = "FrmVehiculos";
            this.Text = "FrmVehiculos";
            this.Load += new System.EventHandler(this.FrmVehiculos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehiculosT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehiculosF)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVehiculosCerrar;
        private System.Windows.Forms.Button btnVehiculosT;
        private System.Windows.Forms.DataGridView dgvVehiculosT;
        private System.Windows.Forms.TextBox tbxVehiculosT;
        private System.Windows.Forms.Label lblVehiculosFiltroT;
        private System.Windows.Forms.Label lblVehiculosTitulo;
        private System.Windows.Forms.Button btnVehiculosF;
        private System.Windows.Forms.DataGridView dgvVehiculosF;
        private System.Windows.Forms.TextBox tbxVehiculosF;
        private System.Windows.Forms.Label lblVehiculosFiltroF;
        private System.Windows.Forms.Label lblVehiculosSubTituloT;
        private System.Windows.Forms.Label lblVehiculosSubtituloF;
    }
}