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

namespace presentacion.Tractores
{
    public partial class FrmFichaTractor : Form
    {
        private Tractor tractor = null;
        private List<Evento> listadoEventosTractor;
        private int internoTractor;
        public FrmFichaTractor(Tractor tractorSeleccionado)
        {
            InitializeComponent();
            this.tractor = tractorSeleccionado;
            internoTractor = tractorSeleccionado.Interno;
        }

        private void FrmFichaTractor_Load(object sender, EventArgs e)
        {
            cargar();
            cargarEventos();
        }

        private void cargar()
        {
            if(tractor != null)
            {
                bool estado = tractor.Activo;
                tbxFichaTractorInterno.Text = tractor.Interno.ToString();
                tbxFichaTractorDominio.Text = tractor.Dominio;
                tbxFichaTractorEmpresa.Text = tractor.Empresa;
                tbxFichaTractorModelo.Text = tractor.Modelo.ToString();
                tbxFichaTractorMarca.Text = tractor.Marca;
                if (estado)
                {
                    tbxFichaTractorEstado.Text = "Activo";
                }
                else
                {
                    tbxFichaTractorEstado.Text = "Inactivo";
                }
                tbxFichaTractorSatUb.Text = tractor.Satelital_Ubicacion;
                tbxFichaTractorSatCb.Text = tractor.Satelital_Combustible;
                tbxFichaTractorObservaciones.Text = tractor.Observaciones;
            }
        }

        private void ocultarColumnasEventos()
        {
            dgvFichaTractorEventos.Columns["Id_Evento"].Visible = false;
            dgvFichaTractorEventos.Columns["Persona"].Visible = false;
            dgvFichaTractorEventos.Columns["Interno"].Visible = false;
        }

        private void cargarEventos()
        {
            EventoNegocio negocio = new EventoNegocio();
            listadoEventosTractor = negocio.listarEventosTractor(internoTractor);
            dgvFichaTractorEventos.DataSource = listadoEventosTractor;

            ocultarColumnasEventos();
        }

        private void btnFichaTractorCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bntFichaTractorEditar_Click(object sender, EventArgs e)
        {
            FrmModificarTractor modificar = new FrmModificarTractor(tractor);
            modificar.ShowDialog();
            Close();
        }
    }
}
