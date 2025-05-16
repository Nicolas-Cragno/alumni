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
                cbxModificarMovimientoPanico.Checked = movimiento.OK_Panico;
                cbxModificarMovimientoCorte.Checked = movimiento.OK_Corte;
                cbxModificarMovimientoReporte.Checked = movimiento.OK_Reporte;
                cbxModificarMovimientoDesenganche.Checked = movimiento.OK_Desenganche;
                cbxModificarMovimientoCabina.Checked = movimiento.OK_Cabina;
                cbxModificarMovimientoAntivandalico.Checked = movimiento.OK_Antiv;
                cbxModificarMovimientoOkfurgon.Checked = movimiento.OK_Furgon;
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
                modifMovimiento.OK_Panico = cbxModificarMovimientoPanico.Checked;
                modifMovimiento.OK_Corte = cbxModificarMovimientoCorte.Checked;
                modifMovimiento.OK_Reporte = cbxModificarMovimientoReporte.Checked;
                modifMovimiento.OK_Desenganche = cbxModificarMovimientoDesenganche.Checked;
                modifMovimiento.OK_Cabina = cbxModificarMovimientoCabina.Checked;
                modifMovimiento.OK_Antiv = cbxModificarMovimientoAntivandalico.Checked;
                modifMovimiento.OK_Furgon = cbxModificarMovimientoOkfurgon.Checked;

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
