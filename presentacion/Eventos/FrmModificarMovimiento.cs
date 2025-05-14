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
    public partial class FrmModificarMovimiento : Form
    {
        private Movimiento movimiento = null;
        public FrmModificarMovimiento(Movimiento movimientoSeleccionado)
        {
            InitializeComponent();
            movimiento = movimientoSeleccionado;
        }

        private void btnModificarMovimientoCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmModificarMovimiento_Load(object sender, EventArgs e)
        {
            int idMovimiento;
            string tipo;
            if(movimiento != null )
            {
                TractorNegocio tractorNegocio = new TractorNegocio();
                FurgonNegocio furgonNegocio = new FurgonNegocio();
                idMovimiento = movimiento.Id_Movimiento;
                tipo = movimiento.Id_Tipo;

                lblModificarMovimientoTitulo.Text = idMovimiento + " - " + tipo;
                lblModificarMovimientoFecha.Text = movimiento.Fecha.ToString();
                cbxModificarMovimientoChofer.Text = movimiento.Persona;
                cbxModificarMovimientoInterno.DataSource = tractorNegocio.listarInternos();
                cbxModificarMovimientoInterno.Text = movimiento.Interno.ToString();
                cbxModificarMovimientoFurgon.DataSource =  furgonNegocio.listarInternos();
                cbxModificarMovimientoFurgon.Text = movimiento.Furgon.ToString();
                tbxModificarMovimientoDetalle.Text = movimiento.Observaciones;
            }
        }

        private void btnModificarMovimiento_Click(object sender, EventArgs e)
        {
            Movimiento modifMovimiento = new Movimiento();
            MovimientoNegocio negocio = new MovimientoNegocio();

            try
            {
                modifMovimiento.Id_Movimiento = movimiento.Id_Movimiento;
                modifMovimiento.Persona = cbxModificarMovimientoChofer.Text;
                modifMovimiento.Interno = int.Parse(cbxModificarMovimientoInterno.Text);
                modifMovimiento.Furgon = int.Parse(cbxModificarMovimientoFurgon.Text);
                modifMovimiento.Observaciones = tbxModificarMovimientoDetalle.Text;
                modifMovimiento.Id_Tipo = movimiento.Id_Tipo;

                negocio.modificarMovimiento(modifMovimiento);
                MessageBox.Show("Datos actualizados");
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void cbxModificarMovimientoChofer_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbxModificarMovimientoChofer.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void cbxModificarMovimientoInterno_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbxModificarMovimientoInterno.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void cbxModificarMovimientoFurgon_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbxModificarMovimientoFurgon.DropDownStyle = ComboBoxStyle.DropDownList;
        }
    }
}
