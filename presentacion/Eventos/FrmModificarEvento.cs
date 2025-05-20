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
    public partial class FrmModificarEvento : Form
    {
        private Evento evento = null;
        public FrmModificarEvento(Evento eventoSeleccionado)
        {
            InitializeComponent();
            evento = eventoSeleccionado;
        }

        private void lblModificarEventoTitulo_Click(object sender, EventArgs e)
        {

        }

        private void FrmModificarEvento_Load(object sender, EventArgs e)
        {
            int idEvento;
            if(evento != null)
            {
                TractorNegocio tractorNegocio = new TractorNegocio();
                FurgonNegocio furgonNegocio = new FurgonNegocio();
                PersonaNegocio personaNegocio = new PersonaNegocio();

                idEvento = evento.Id_Evento;
                cbxModificarEventoChofer.DataSource = personaNegocio.nombreChoferes();
                cbxModificarEventoChofer.Text = evento.Persona;
                cbxModificarEventoInterno.DataSource = tractorNegocio.listarInternos();
                cbxModificarEventoInterno.Text = evento.Interno.ToString();
                cbxModificarEventoFurgon.DataSource = furgonNegocio.listarInternos();
                cbxModificarEventoFurgon.Text = evento.Furgon.ToString();
                tbxModificarEventoTipo.Text = evento.Tipo;
                tbxModificarEventoDetalle.Text = evento.Detalle;
            }
        }

        private void btnModificarEvento_Click(object sender, EventArgs e)
        {
            Evento modifEvento = new Evento();
            EventoNegocio negocio = new EventoNegocio();

            try
            {
                modifEvento.Id_Evento = evento.Id_Evento;
                modifEvento.Persona = cbxModificarEventoChofer.Text;
                modifEvento.Interno = int.Parse(cbxModificarEventoInterno.Text);
                modifEvento.Furgon = int.Parse(cbxModificarEventoFurgon.Text);
                modifEvento.Tipo = tbxModificarEventoTipo.Text;
                modifEvento.Detalle = tbxModificarEventoDetalle.Text;   

                negocio.modificarEvento(modifEvento);
                MessageBox.Show("Datos Actualizados.");
                Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnModificarEventoCerrar_Click(object sender, EventArgs e)
        {
            Close();    
        }
    }
}
