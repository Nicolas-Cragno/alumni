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
    public partial class frmModificarFurgon : Form
    {
        private Furgon furgon = null; 
        public frmModificarFurgon(Furgon furgonSeleccionado)
        {
            InitializeComponent();
            this.furgon = furgonSeleccionado;
        }

        private void btnModificarFurgonCerrar_Click(object sender, EventArgs e)
        {
            
        }

        private void frmModificarFurgon_Load(object sender, EventArgs e)
        {
            if(furgon!=null)
            {
                int interno = furgon.Interno;
                string dominio = furgon.Dominio;
                EmpresaNegocio empresaNegocio = new EmpresaNegocio();
                
                lblModificarFurgonTitulo.Text = interno + " - " + dominio;
                tbxModificarFurgonDominio.Text = dominio;
                cbxModificarFurgonEmpresa.DataSource = empresaNegocio.listarEmpresas();
                cbxModificarFurgonEmpresa.Text = furgon.Empresa;
                tbxModificarFurgonObservaciones.Text = furgon.Observaciones;

                cbxModificarFurgonTaller.Checked = furgon.OK_Taller;
                cbxModificarFurgonActivo.Checked = furgon.Activo;
            }
        }

        private void btnModificarFurgon_Click(object sender, EventArgs e)
        {
            Furgon modifFurgon = new Furgon();
            FurgonNegocio negocio = new FurgonNegocio();    
            Evento evento = new Evento();
            EventoNegocio eventoNegocio = new EventoNegocio();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                modifFurgon.Interno = furgon.Interno;
                modifFurgon.Dominio = (string)tbxModificarFurgonDominio.Text;
                modifFurgon.Empresa = (string)cbxModificarFurgonEmpresa.Text;
                modifFurgon.Observaciones = (string)tbxModificarFurgonObservaciones.Text;
                modifFurgon.OK_Taller = cbxModificarFurgonTaller.Checked;
                modifFurgon.Activo = cbxModificarFurgonActivo.Checked;

                evento.Furgon = modifFurgon.Interno;
                evento.Tipo = "MODIFICACIÓN";
                evento.Detalle = "MODIFICACIÓN DE DATOS POR SISTEMA";
                eventoNegocio.registrarEvento(evento);

                negocio.modificar(modifFurgon);
                MessageBox.Show("Datos actualizados.");
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
