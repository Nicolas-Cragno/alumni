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

namespace presentacion.Eventos
{
    public partial class FrmFichaMovimiento : Form
    {
        Movimiento movimiento = null;
        public FrmFichaMovimiento(Movimiento movimientoSeleccionado)
        {
            InitializeComponent();
            movimiento = movimientoSeleccionado;
        }

        private void FrmFichaMovimiento_Load(object sender, EventArgs e)
        {
            cargar();
        }

        private void cargar()
        {
            AccesoDatos datos = new AccesoDatos();

            if (movimiento != null)
            {
                lblFichaMovimientoTitulo.Text = movimiento.Id_Tipo;
                tbxFichaMovimientoFecha.Text = movimiento.Fecha.ToString();
                tbxFichaMovimientoChofer.Text = movimiento.Persona;
                tbxFichaMovimientoInterno.Text = movimiento.Interno.ToString();
                tbxFichaMovimientoFurgon.Text = movimiento.Furgon.ToString();
                tbxFichaMovimientoDetalle.Text = movimiento.Observaciones;
            }
        }

        private void btnFichaMovimientoCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnFichaMovimientoEditar_Click(object sender, EventArgs e)
        {
            FrmModificarMovimiento ventana = new FrmModificarMovimiento(movimiento);
            ventana.ShowDialog();
            cargar();
        }
    }
}
