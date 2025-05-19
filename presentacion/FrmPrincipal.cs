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

        private void cerrarVentantas()
        {
            foreach (Form v in this.MdiChildren)
            {
                v.Close();
            }
        }

       

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void movimientosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cerrarVentantas();
            frmMovimientos ventana = new frmMovimientos();
            ventana.MdiParent = this;
            ventana.WindowState = FormWindowState.Maximized;
            ventana.Show();
        }

        private void tsmEventos_Click(object sender, EventArgs e)
        {
            cerrarVentantas();
            FrmEventos ventana = new FrmEventos();
            ventana.MdiParent = this;
            ventana.WindowState = FormWindowState.Maximized;
            ventana.Show();
        }

        private void tsmViajes_Click(object sender, EventArgs e)
        {
            cerrarVentantas();
            /*
            FrmViajes ventana = new FrmViajes();
            ventana.MdiParent = this;
            ventana.WindowState = FormWindowState.Maximized;
            ventana.Show();
             */
        }

        private void tsmChoferes_Click(object sender, EventArgs e)
        {
            
        }

        private void tsmTractoresFurgones_Click(object sender, EventArgs e)
        {
            cerrarVentantas();
            FrmVehiculos ventana = new FrmVehiculos();
            ventana.MdiParent = this;
            ventana.WindowState = FormWindowState.Maximized;
            ventana.Show();
        }

        private void tsmOtrosVehiculos_Click(object sender, EventArgs e)
        {
            cerrarVentantas();
            /*
            FrmOtros ventana = new FrmOtros();
            ventana.MdiParent = this;
            ventana.WindowState = FormWindowState.Maximized;
            ventana.Show();
             */
        }

        private void tsmClientes_Click(object sender, EventArgs e)
        {
            cerrarVentantas();
            /*
            FrmClientes ventana = new FrmClientes();
            ventana.MdiParent = this;
            ventana.WindowState = FormWindowState.Maximized;
            ventana.Show();
             */
        }

        private void gestionarRecursosToolStripMenuItem_Click(object sender, EventArgs e)
        {

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

        private void furgonesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cerrarVentantas();
            /*
            FrmFurgones ventana = new FrmFurgones();
            ventana.MdiParent = this;
            ventana.WindowState = FormWindowState.Maximized;
            ventana.Show();
             */
        }

        private void otrosVehiculosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cerrarVentantas();
            /*
            FrmOtros ventana = new FrmOtros();
            ventana.MdiParent = this;
            ventana.WindowState = FormWindowState.Maximized;
            ventana.Show();
             */
        }

        private void empresasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cerrarVentantas();
            /*
            FrmEmpresas ventana = new FrmEmpresas();
            ventana.MdiParent = this;
            ventana.WindowState = FormWindowState.Maximized;
            ventana.Show();
             */
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cerrarVentantas();
            /*
            FrmEmpresas ventana = new FrmEmpresas();
            ventana.MdiParent = this;
            ventana.WindowState = FormWindowState.Maximized;
            ventana.Show();
             */
        }
    }
}
