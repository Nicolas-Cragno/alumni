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
using presentacion.Tractores;
using presentacion.Furgones;

namespace presentacion.Vehiculos
{
    public partial class FrmVehiculos : Form
    {
        private List<Tractor> listadoTractores;
        private List<Furgon> listadoFurgones;
        public FrmVehiculos()
        {
            InitializeComponent();
        }

        private void ocultarColumnasT()
        {
            dgvVehiculosT.Columns["Empresa"].Visible = false;
            dgvVehiculosT.Columns["Satelital_Ubicacion"].Visible = false;
            dgvVehiculosT.Columns["Satelital_Combustible"].Visible = false;
            dgvVehiculosT.Columns["Chofer"].Visible = false;
            dgvVehiculosT.Columns["DNI_Chofer"].Visible = false;
            dgvVehiculosT.Columns["Modelo"].Visible = false;
            dgvVehiculosT.Columns["Marca"].Visible = false;
            dgvVehiculosT.Columns["Observaciones"].Visible = false;
            dgvVehiculosT.Columns["OK_Taller"].Visible = false;
            dgvVehiculosT.Columns["OK_Adm"].Visible = false;
            dgvVehiculosT.Columns["OK_Satelital"].Visible = false;
            dgvVehiculosT.Columns["OK_Trafico"].Visible = false;  
        }

        private void ocultarColumnasF()
        {
            dgvVehiculosF.Columns["Empresa"].Visible = false;
            dgvVehiculosF.Columns["OK_Taller"].Visible = false;
            dgvVehiculosF.Columns["Observaciones"].Visible=false;
            //dgvVehiculosF.Columns[""].Visible = false;
        }


        private void btnVehiculosCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgvVehiculosT_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Tractor seleccion = (Tractor)dgvVehiculosT.CurrentRow.DataBoundItem;

            FrmFichaTractor ficha = new FrmFichaTractor(seleccion);
            ficha.ShowDialog();
        }

        private void FrmVehiculos_Load(object sender, EventArgs e)
        {
            cargarTractores();
            cargarFurgones();
        }

        private void cargarTractores()
        {
            TractorNegocio negocio = new TractorNegocio();
            listadoTractores = negocio.listarTractores();
            dgvVehiculosT.DataSource = listadoTractores;
            ocultarColumnasT();
        }

        private void cargarFurgones()
        {
            FurgonNegocio negocio = new FurgonNegocio();
            listadoFurgones = negocio.listarFurgones();
            dgvVehiculosF.DataSource = listadoFurgones;
            ocultarColumnasF();
        }

        private void filtrarTractores()
        {
            List<Tractor> listaFiltradaT;
            string filtro = tbxVehiculosT.Text;

            if( filtro != "")
            {
                listaFiltradaT = listadoTractores.FindAll(ev => ev.Interno.ToString().Contains(filtro.ToUpper()) || ev.Dominio.ToString().Contains(filtro.ToUpper()));
            }
            else
            {
                listaFiltradaT = listadoTractores;
            }

            dgvVehiculosT.DataSource = null;
            dgvVehiculosT.DataSource = listaFiltradaT;
            ocultarColumnasT();
        }

        private void filtrarFurgones()
        {
            List<Furgon> listaFiltradaF;
            string filtro = tbxVehiculosF.Text;

            if (filtro != "")
            {
                listaFiltradaF = listadoFurgones.FindAll(ev => ev.Interno.ToString().Contains(filtro.ToUpper()) || ev.Dominio.ToString().Contains(filtro.ToUpper()));
            }
            else
            {
                listaFiltradaF = listadoFurgones;
            }

            dgvVehiculosF.DataSource = null;
            dgvVehiculosF.DataSource = listaFiltradaF;
            ocultarColumnasF();
        }

        private void tbxVehiculosT_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbxVehiculosT_KeyPress(object sender, KeyPressEventArgs e)
        {
           filtrarTractores();
        }

        private void tbxVehiculosF_KeyPress(object sender, KeyPressEventArgs e)
        {
            filtrarFurgones();
        }

        private void btnVehiculosT_Click(object sender, EventArgs e)
        {
            FrmAgregarTractor ventana = new FrmAgregarTractor();
            ventana.ShowDialog();
            cargarTractores();
        }

        private void btnVehiculosF_Click(object sender, EventArgs e)
        {
            FrmAgregarFurgon ventana = new FrmAgregarFurgon();
            ventana.ShowDialog();
            cargarFurgones();
        }

        private void dgvVehiculosT_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Tractor seleccion = (Tractor)dgvVehiculosT.CurrentRow.DataBoundItem;

            FrmFichaTractor ficha = new FrmFichaTractor(seleccion);
            ficha.ShowDialog();
            cargarTractores();
        }

        private void dgvVehiculosT_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvVehiculosF_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dgvVehiculosF_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dgvVehiculosF_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Furgon seleccion = (Furgon)dgvVehiculosF.CurrentRow.DataBoundItem;
            FrmFichaFurgon ficha = new FrmFichaFurgon(seleccion);
            ficha.ShowDialog();
            cargarFurgones();
        }
    }
}
