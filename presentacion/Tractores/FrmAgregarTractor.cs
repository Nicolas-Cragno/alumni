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

namespace presentacion.Tractores
{
    public partial class FrmAgregarTractor : Form
    {
        public FrmAgregarTractor()
        {
            InitializeComponent();
        }

        private void btnAgregarChoferCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmAgregarTractor_Load(object sender, EventArgs e)
        {
            EmpresaNegocio empresaNegocio = new EmpresaNegocio();
            Satelital_UbicacionNegocio satelital_UbicacionNegocio = new Satelital_UbicacionNegocio();
            Satelital_CombustibleNegocio satelital_CombustibleNegocio = new Satelital_CombustibleNegocio();

            try
            {
                cbxAgregarTractorEmpresa.DataSource = empresaNegocio.listarEmpresas();
                cbxAgregarTractorSatUb.DataSource = satelital_UbicacionNegocio.listarSatelital();
                cbxAgregarTractorSatCb.DataSource = satelital_CombustibleNegocio.listarSatelital();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnAgregarTractor_Click(object sender, EventArgs e)
        {
            Tractor nuevoTractor = new Tractor();
            TractorNegocio negocio = new TractorNegocio();
            Evento evento = new Evento();
            EventoNegocio eventoNegocio = new EventoNegocio();
            AccesoDatos datos = new AccesoDatos();
            int idEmpresa;

            try
            {
                nuevoTractor.Interno = int.Parse(tbxAgregarTractorInterno.Text);
                nuevoTractor.Empresa = (string)cbxAgregarTractorEmpresa.Text.ToUpper();
                nuevoTractor.Satelital_Ubicacion = (string)cbxAgregarTractorSatUb.Text.ToUpper();
                nuevoTractor.Satelital_Combustible = (string)cbxAgregarTractorSatCb.Text.ToUpper();
                nuevoTractor.Dominio = (string)tbxAgregarTractorDominio.Text.ToUpper();
                nuevoTractor.Modelo = (string)tbxAgregarTractorModelo.Text.ToUpper();
                nuevoTractor.Marca = (string)tbxAgregarTractorMarca.Text.ToUpper();
                nuevoTractor.Observaciones = (string)tbxAgregarTractorObservaciones.Text.ToUpper();

                negocio.agregar(nuevoTractor);
                MessageBox.Show("Tractor agregado.");

                // Registar como evento ↓↓
                idEmpresa = datos.buscarIdEmpresa(nuevoTractor.Empresa);
                string empresa = datos.buscarEmpresaAbreviada(idEmpresa);
                evento.Interno = nuevoTractor.Interno;
                evento.Tipo = "ALTA TRACTOR " + empresa;
                evento.Detalle = "TRACTOR DADO DE ALTA POR SISTEMA.";
                eventoNegocio.registrarEvento(evento);

                Close();
            }
            catch(SqlException ex)
            {
                if(ex.Number == 2627)
                {
                    MessageBox.Show("El número de interno ya está registrado.");
                }
            }
        }

        private void cbxAgregarTractorSatUb_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbxAgregarTractorSatUb.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void cbxAgregarTractorSatCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbxAgregarTractorSatCb.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void cbxAgregarTractorEmpresa_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbxAgregarTractorEmpresa.DropDownStyle = ComboBoxStyle.DropDownList;
        }
    }
}
