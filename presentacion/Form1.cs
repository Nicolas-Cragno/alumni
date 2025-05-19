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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Aguante Boca");
        }

        private void cerrarVentantas()
        {
            foreach (Form v in this.MdiChildren)
            {
                v.Close();
            }
        }

        private void movimientosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cerrarVentantas();
            frmMovimientos ventana = new frmMovimientos();
            ventana.MdiParent = this;
            ventana.WindowState = FormWindowState.Maximized;
            ventana.Show();
        }

        private void eventosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cerrarVentantas();
            FrmEventos ventana = new FrmEventos();
            ventana.MdiParent = this;
            ventana.WindowState = FormWindowState.Maximized;
            ventana.Show();
        }

        private void viajesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cerrarVentantas();
            /*
            FrmViajes ventana = new FrmViajes();
            ventana.MdiParent = this;
            ventana.WindowState = FormWindowState.Maximized;
            ventana.Show();
             */
        }

        private void choferesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cerrarVentantas();
            FrmChoferes ventana = new FrmChoferes();
            ventana.MdiParent = this;
            ventana.WindowState = FormWindowState.Maximized;
            ventana.Show();
        }

        private void tractoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cerrarVentantas();
            FrmVehiculos ventana = new FrmVehiculos();
            ventana.MdiParent = this;
            ventana.WindowState = FormWindowState.Maximized;
            ventana.Show();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cerrarVentantas();
            /*
            FrmClientes ventana = new FrmClientes();
            ventana.MdiParent = this;
            ventana.WindowState = FormWindowState.Maximized;
            ventana.Show();
             */
        }

        private void otrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cerrarVentantas();
            /*
            FrmOtros ventana = new FrmOtros();
            ventana.MdiParent = this;
            ventana.WindowState = FormWindowState.Maximized;
            ventana.Show();
             */
        }
    }
}
