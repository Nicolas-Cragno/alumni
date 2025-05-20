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

namespace presentacion.Furgones
{
    public partial class FrmAgregarFurgon : Form
    {
        public FrmAgregarFurgon()
        {
            InitializeComponent();
        }

        private void FrmAgregarFurgon_Load(object sender, EventArgs e)
        {
            EmpresaNegocio empresaNegocio = new EmpresaNegocio();

            try
            {
                cbxAgregarFurgonEmpresa.DataSource = empresaNegocio.listarEmpresas();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnAgregarFurgonCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cbxAgregarFurgonEmpresa_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbxAgregarFurgonEmpresa.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void btnAgregarFurgon_Click(object sender, EventArgs e)
        {
            Furgon nuevoFurgon = new Furgon();
            FurgonNegocio negocio = new FurgonNegocio();
            Evento evento = new Evento();
            EventoNegocio eventoNegocio = new EventoNegocio();
            AccesoDatos datos = new AccesoDatos();
            int idEmpresa;

            try
            {
                nuevoFurgon.Interno = int.Parse(tbxAgregarFurgonInterno.Text);
                nuevoFurgon.Dominio = (string)tbxAgregarFurgonDominio.Text.ToUpper();
                nuevoFurgon.Empresa = (string)cbxAgregarFurgonEmpresa.Text.ToUpper();
                nuevoFurgon.Observaciones = (string)tbxAgregarFurgonObservaciones.Text.ToUpper();

                negocio.agregar(nuevoFurgon);
                MessageBox.Show("Furgón agregado.");

                idEmpresa = datos.buscarIdEmpresa(nuevoFurgon.Empresa);
                string empresa = datos.buscarEmpresaAbreviada(idEmpresa);
                evento.Furgon = nuevoFurgon.Interno;
                evento.Tipo = "ALTA FURGON " + empresa;
                evento.Detalle = "FURGÓN DADO DE ALTA POR SISTEMA.";
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
    }
}
