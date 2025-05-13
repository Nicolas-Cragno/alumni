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

        }

        private void btnFichaFurgonCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
