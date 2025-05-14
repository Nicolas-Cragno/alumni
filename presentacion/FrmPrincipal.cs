using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;
using negocio;
using presentacion.Eventos;
using presentacion.Vehiculos;

namespace presentacion
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void btnChoferes_Click(object sender, EventArgs e)
        {
            FrmChoferes ventana = new FrmChoferes();
            ventana.ShowDialog();
        }

        private void btnVehiculos_Click(object sender, EventArgs e)
        {
            FrmVehiculos ventana = new FrmVehiculos();
            ventana.ShowDialog();
        }

        private void btnMovimientos_Click(object sender, EventArgs e)
        {
            frmMovimientos ventana = new frmMovimientos();    
            ventana.ShowDialog();
        }

        private void btnEventos_Click(object sender, EventArgs e)
        {
            FrmEventos ventana = new FrmEventos();
            ventana.ShowDialog();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}
