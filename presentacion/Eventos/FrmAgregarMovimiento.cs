using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using negocio;
using dominio;
using System.Data.SqlClient;

namespace presentacion.Eventos
{
    public partial class FrmAgregarMovimiento : Form
    {
        public FrmAgregarMovimiento()
        {
            InitializeComponent();
        }

        private void FrmAgregarMovimiento_Load(object sender, EventArgs e)
        {
            PersonaNegocio personaNegocio = new PersonaNegocio();
            TractorNegocio tractorNegocio = new TractorNegocio();
            MovimientoNegocio movimientoNegocio = new MovimientoNegocio();

            try
            {
                cbxAgregarMovimientoInterno.DataSource = tractorNegocio.listarInternos();
                cbxAgregarMovimientoChofer.DataSource = personaNegocio.nombreChoferes();
                cbxAgregarMovimientoTipo.DataSource = movimientoNegocio.tiposMovimientos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnAgregarMovimiento_Click(object sender, EventArgs e)
        {
            Movimiento nuevoMovimiento = new Movimiento();
            MovimientoNegocio negocio = new MovimientoNegocio();
            Evento nuevoEvento = new Evento();
            EventoNegocio eventoNegocio = new EventoNegocio();

            try
            {
                nuevoMovimiento.Id_Tipo = (string)cbxAgregarMovimientoTipo.Text.ToUpper();
                nuevoMovimiento.Persona = (string)cbxAgregarMovimientoChofer.Text.ToUpper();
                nuevoMovimiento.Interno = int.Parse(cbxAgregarMovimientoInterno.Text);
                nuevoMovimiento.Furgon = int.Parse(cbxAgregarMovimientoFurgon.Text);
                // nuevoMovimiento.Cliente = (string)cbxAgregarMovimientoCliente.Text.ToUpper();
                //nuevoMovimiento.Destino = (string)cbxAgregarMovimientoDestino.Text.ToUpper();
                nuevoMovimiento.Observaciones = (string)tbxAgregarMovimientoDetalle.Text.ToUpper();
                nuevoMovimiento.OK_Panico = cbxAgregarMovimientoPanico.Checked;
                nuevoMovimiento.OK_Corte = cbxAgregarMovimientoCorte.Checked;
                nuevoMovimiento.OK_Reporte = cbxAgregarMovimientoReporte.Checked;
                nuevoMovimiento.OK_Desenganche = cbxAgregarMovimientoDesenganche.Checked;
                nuevoMovimiento.OK_Cabina = cbxAgregarMovimientoCabina.Checked;
                nuevoMovimiento.OK_Antiv = cbxAgregarMovimientoAntivandalico.Checked;
                nuevoMovimiento.OK_Furgon = cbxAgregarMovimientoOkfurgon.Checked;

                negocio.agregarMovimiento(nuevoMovimiento);
                MessageBox.Show("Movimiento agregado.");

                // evento agregar
                nuevoEvento.Persona = nuevoMovimiento.Persona;
                nuevoEvento.Interno = nuevoMovimiento.Interno;
                nuevoEvento.Furgon = nuevoMovimiento.Furgon;
                nuevoEvento.Tipo = "NUEVO/A " + nuevoMovimiento.Id_Tipo;
                nuevoEvento.Detalle = "MOVIMIENTO AGREGADO POR SISTEMA";
                nuevoEvento.Fecha = nuevoMovimiento.Fecha;
                Close();
                
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error al cargar el movimiento. Contacte al técnico.");
            }
        }

        private void cbxAgregarMovimientoTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbxAgregarMovimientoTipo.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxAgregarMovimientoTipo.SelectedIndex = -1;
        }

        private void btnAgregarMovimientoCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cbxAgregarMovimientoChofer_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbxAgregarMovimientoChofer.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxAgregarMovimientoChofer.SelectedIndex = -1;
        }

        private void cbxAgregarMovimientoInterno_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbxAgregarMovimientoInterno.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxAgregarMovimientoInterno.SelectedIndex = -1;
        }

        private void cbxAgregarMovimientoFurgon_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbxAgregarMovimientoFurgon.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxAgregarMovimientoFurgon.SelectedIndex = -1;
        }
    }
}
