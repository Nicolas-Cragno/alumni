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

namespace presentacion.Furgones
{
    public partial class FrmFichaFurgon : Form
    {
        private Furgon furgon = null;
        private List<Evento> listadoEventosFurgon;
        private int internoFurgon;
        public FrmFichaFurgon(Furgon furgonSeleccionado)
        {
            InitializeComponent();
            this.furgon = furgonSeleccionado;
            internoFurgon = furgonSeleccionado.Interno;
        }

        private void FrmFichaFurgon_Load(object sender, EventArgs e)
        {
            cargar();
            cargarEventos();
        }

        private void cargar()
        {
            if(furgon != null)
            {
                bool estado = furgon.Activo;
                tbxFichaFurgonInterno.Text = furgon.Interno.ToString();
                tbxFichaFurgonDominio.Text = furgon.Dominio;
                tbxFichaFurgonEmpresa.Text = furgon.Empresa;
                if (estado)
                {
                    tbxFichaFurgonEstado.Text = "Activo";
                }
                else
                {
                    tbxFichaFurgonEstado.Text = "Inactivo";
                }
                tbxFichaFurgonObservaciones.Text = furgon.Observaciones;
            }
        }

        private void cargarEventos()
        {
            EventoNegocio negocio = new EventoNegocio();
            listadoEventosFurgon = negocio.listarEventosFurgon(internoFurgon);
            dgvFichaFurgonEventos.DataSource = listadoEventosFurgon;

            ocultarColumnasEventos();
        }

        private void btnFichaFurgonCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bntFichaFurgonEditar_Click(object sender, EventArgs e)
        {
            frmModificarFurgon modificar = new frmModificarFurgon(furgon);
            modificar.ShowDialog();
            Close();
        }

        private void btnAgregarFichaFurgonEventos_Click(object sender, EventArgs e)
        {
            char tipo = 'F';
            int interno = furgon.Interno;
            FrmAgregarEvento ventana = new FrmAgregarEvento(tipo, interno);
            ventana.ShowDialog();
            cargarEventos();
        }

        private void ocultarColumnasEventos()
        {
            dgvFichaFurgonEventos.Columns["Id_Evento"].Visible = false;
            dgvFichaFurgonEventos.Columns["Dni"].Visible = false;
            dgvFichaFurgonEventos.Columns["Persona"].Visible = false;
            dgvFichaFurgonEventos.Columns["Interno"].Visible = false;
            dgvFichaFurgonEventos.Columns["Furgon"].Visible = false;
        }

        private void filtrarEventos()
        {
            
            List<Evento> listaFiltrada;
            string filtro = tbxFichaFurgonEventosFiltro.Text;

            if (filtro != "")
            {
                listaFiltrada = listadoEventosFurgon.FindAll(ev => ev.Tipo.ToString().Contains(filtro.ToUpper()) || ev.Detalle.ToString().Contains(filtro.ToUpper()) || ev.Fecha.ToString().Contains(filtro.ToUpper()));
            }
            else
            {
                listaFiltrada = listaFiltrada = listadoEventosFurgon.FindAll(ev => ev.Tipo.ToString().Contains(filtro.ToUpper()) || ev.Detalle.ToString().Contains(filtro.ToUpper()) || ev.Fecha.ToString().Contains(filtro.ToUpper()));
                ;
            }

            dgvFichaFurgonEventos.DataSource = null;
            dgvFichaFurgonEventos.DataSource = listaFiltrada;
            ocultarColumnasEventos();
        }

        private void tbxFichaFurgonEventosFiltro_KeyPress(object sender, KeyPressEventArgs e)
        {
            filtrarEventos();
        }

        private void dgvFichaFurgonEventos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Evento seleccion = (Evento)dgvFichaFurgonEventos.CurrentRow.DataBoundItem;

            FrmFichaEvento evento = new FrmFichaEvento(seleccion);
            evento.ShowDialog();
            cargarEventos();
        }
    }
}
