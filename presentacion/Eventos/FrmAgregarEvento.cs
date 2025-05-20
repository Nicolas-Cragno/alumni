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
    public partial class FrmAgregarEvento : Form
    {
        char tipoEspecifico;
        int idEspecifico;
        public FrmAgregarEvento()
        {
            InitializeComponent();
            cbxAgregarEventoChofer.TabIndex = 0;
            tbxAgregarEventoTipo.TabIndex = 2;
            cbxAgregarEventoInterno.TabIndex = 2;
            cbxAgregarEventoFurgon.TabIndex = 3;
            tbxAgregarEventoDetalle.TabIndex = 4;
            btnAgregarEvento.TabIndex = 5;
            btnAgregarEventoCerrar.TabIndex = 6;
        }
        public FrmAgregarEvento(char tipo, int id)
        {
            tipoEspecifico = tipo;
            idEspecifico = id;
            InitializeComponent();
            cbxAgregarEventoChofer.TabIndex = 0;
            tbxAgregarEventoTipo.TabIndex = 2;
            cbxAgregarEventoInterno.TabIndex = 2;
            cbxAgregarEventoFurgon.TabIndex = 3;
            tbxAgregarEventoDetalle.TabIndex = 4;
            btnAgregarEvento.TabIndex = 5;
            btnAgregarEventoCerrar.TabIndex = 6;
        }


        private void FrmAgregarEvento_Load(object sender, EventArgs e)
        {
            PersonaNegocio personaNegocio = new PersonaNegocio();
            TractorNegocio tractorNegocio = new TractorNegocio();
            FurgonNegocio furgonNegocio = new FurgonNegocio();
            AccesoDatos datos = new AccesoDatos();

                try
                {
                    switch (tipoEspecifico)
                    {
                        case 'C':
                            cbxAgregarEventoChofer.Text = datos.buscarChofer(idEspecifico);
                            cbxAgregarEventoChofer.Enabled = false;
                            cbxAgregarEventoInterno.DataSource = tractorNegocio.listarInternos();
                            cbxAgregarEventoFurgon.DataSource = furgonNegocio.listarInternos();
                            break;
                        case 'T':
                            cbxAgregarEventoInterno.Text = idEspecifico.ToString();
                            cbxAgregarEventoChofer.DataSource = personaNegocio.nombreChoferes();
                            cbxAgregarEventoFurgon.DataSource = furgonNegocio.listarInternos();
                            cbxAgregarEventoInterno.Enabled = false;
                            break;
                        case 'F':
                            cbxAgregarEventoFurgon.Text = idEspecifico.ToString();
                            cbxAgregarEventoChofer.DataSource = personaNegocio.nombreChoferes();
                            cbxAgregarEventoInterno.DataSource = tractorNegocio.listarInternos();
                            cbxAgregarEventoFurgon.Enabled = false;
                            break;
                        default:
                            cbxAgregarEventoChofer.DataSource = personaNegocio.nombreChoferes();
                            cbxAgregarEventoInterno.DataSource = tractorNegocio.listarInternos();
                            cbxAgregarEventoFurgon.DataSource = furgonNegocio.listarInternos();
                            break;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
        }

        private void btnAgregarEvento_Click_1(object sender, EventArgs e)
        {
            Evento nuevoEvento = new Evento();
            EventoNegocio negocio = new EventoNegocio();

            try
            {
                nuevoEvento.Persona = (string)cbxAgregarEventoChofer.Text.ToUpper();
                nuevoEvento.Interno = int.Parse(cbxAgregarEventoInterno.Text);
                nuevoEvento.Furgon = int.Parse(cbxAgregarEventoFurgon.Text);
                nuevoEvento.Tipo = (string)tbxAgregarEventoTipo.Text.ToUpper();
                nuevoEvento.Detalle = (string)tbxAgregarEventoDetalle.Text.ToUpper();
                nuevoEvento.Fecha = DateTime.Now;

                negocio.agregarEvento(nuevoEvento);
                MessageBox.Show("Evento agregado.");

                Close();
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627)
                {
                    MessageBox.Show("Evento duplicado");
                }
            }
        }

        private void btnAgregarEventoCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tbxAgregarEventoTipo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
