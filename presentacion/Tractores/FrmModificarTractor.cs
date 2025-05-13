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
    public partial class FrmModificarTractor : Form
    {
        private Tractor tractor = null;
        public FrmModificarTractor(Tractor tractorSeleccionado)
        {
            InitializeComponent();
            this.tractor = tractorSeleccionado;
        }

        private void ModificarTractor_Load(object sender, EventArgs e)
        {
            if(tractor != null)
            {
                int interno = tractor.Interno;
                string dominio = tractor.Dominio;
                EmpresaNegocio empresaNegocio = new EmpresaNegocio();
                PersonaNegocio personaNegocio = new PersonaNegocio();

                lblModificarTractorTitulo.Text = interno + " - " + dominio;
                tbxModificarTractorDominio.Text = dominio;
                tbxModificarTractorMarca.Text = tractor.Marca;
                tbxModificarTractorModelo.Text = tractor.Modelo;
                tbxModificarTractorObservaciones.Text = tractor.Observaciones;
                //cbxModificarTractorUbicacion.DataSource = satelitalNegocio.listarSatUb();
                //cbxModificarTractorCombustible.DataSource = satelitalNegocio.listarSatCb();
                cbxModificarTractorEmpresa.DataSource = empresaNegocio.listarEmpresas();
                cbxModificarTractorChofer.DataSource = personaNegocio.nombreChoferes();

                cbxModificarTractorUbicacion.Text = tractor.Satelital_Ubicacion;
                cbxModificarTractorCombustible.Text = tractor.Satelital_Combustible;
                cbxModificarTractorEmpresa.Text = tractor.Empresa;
                cbxModificarTractorChofer.Text = tractor.Chofer;

                cbxModificarTractorADM.Checked = tractor.OK_Adm;
                cbxModificarTractorTrafico.Checked = tractor.OK_Trafico;
                cbxModificarTractorTaller.Checked = tractor.OK_Taller;
                cbxModificarTractorSat.Checked = tractor.OK_Satelital;
                cbxModificarTractorActivo.Checked = tractor.Activo;
            }

        }

        private void lblModificarChoferTipo_Click(object sender, EventArgs e)
        {

        }

        private void btnModificarTractor_Click(object sender, EventArgs e)
        {
            Tractor modifTractor = new Tractor();
            TractorNegocio negocio = new TractorNegocio();
            Evento evento = new Evento();
            EventoNegocio eventoNegocio = new EventoNegocio();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                modifTractor.Interno = tractor.Interno;
                modifTractor.Dominio = (string)tbxModificarTractorDominio.Text; 
                modifTractor.Marca = (string)tbxModificarTractorMarca.Text;
                modifTractor.Modelo = (string)tbxModificarTractorModelo.Text;
                modifTractor.Satelital_Ubicacion = (string)cbxModificarTractorUbicacion.Text;
                modifTractor.Satelital_Combustible = (string)cbxModificarTractorCombustible.Text;
                modifTractor.Empresa = (string)cbxModificarTractorEmpresa.Text;
                modifTractor.Observaciones = (string)tbxModificarTractorObservaciones.Text;
                modifTractor.Activo = cbxModificarTractorActivo.Checked;
                modifTractor.OK_Adm = cbxModificarTractorADM.Checked;
                modifTractor.OK_Trafico = cbxModificarTractorTrafico.Checked;
                modifTractor.OK_Taller = cbxModificarTractorTaller.Checked;
                modifTractor.OK_Satelital = cbxModificarTractorSat.Checked;

                evento.Interno = modifTractor.Interno;
                evento.Tipo = "MODIFICACIÓN";
                evento.Detalle = "MODIFICACIÓN DE DATOS POR SISTEMA.";
                eventoNegocio.registrarEvento(evento);

                negocio.modificar(modifTractor);
                MessageBox.Show("Datos actualizados");
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
