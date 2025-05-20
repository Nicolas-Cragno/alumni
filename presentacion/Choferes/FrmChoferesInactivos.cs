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

namespace presentacion.Choferes
{
    public partial class FrmChoferesInactivos : Form
    {
        private List<Persona> listadoChoferes;
        public FrmChoferesInactivos()
        {
            InitializeComponent();
        }

        private void ocultarColumnas()
        {
            dgvChoferesInactivos.Columns["Tipo_Empleado"].Visible = false;
            dgvChoferesInactivos.Columns["Empresa"].Visible = false;
            dgvChoferesInactivos.Columns["Viajes"].Visible = false;
            dgvChoferesInactivos.Columns["Promedio"].Visible = false;
            dgvChoferesInactivos.Columns["Observaciones"].Visible = false;
            dgvChoferesInactivos.Columns["OK_Adm"].Visible = false;
            dgvChoferesInactivos.Columns["OK_Trafico"].Visible = false;
            dgvChoferesInactivos.Columns["Ingreso"].Visible = false;
            //dgvChoferesInactivos.Columns["activo"].Visible = false;
            dgvChoferesInactivos.Columns["Interno"].Visible = false;
        }
        

        public void FrmChoferesInactivos_Load(object sender, EventArgs e)
        {
            cargar();
        }

        private void filtrarChoferes()
        {
            List<Persona> listaFiltrada;
            string filtro = tbxChoferesInactivosFiltro.Text;

            if (filtro != "")
            {
                // filtra por dni, apellido y/o nombres.
                listaFiltrada = listadoChoferes.FindAll(ev => ev.Dni.ToString().Contains(filtro.ToUpper()) || ev.Apellido.ToString().Contains(filtro.ToUpper()) || ev.Nombres.ToString().Contains(filtro.ToUpper()));
            }
            else
            {
                // si el filtro esta en blanco, devuelve la lista total
                listaFiltrada = listadoChoferes;
            }

            dgvChoferesInactivos.DataSource = null; // vaciarla primero para pisarla desp
            dgvChoferesInactivos.DataSource = listaFiltrada;
            ocultarColumnas();
        }

        private void btnChoferesClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cargar()
        {
            PersonaNegocio negocio = new PersonaNegocio();
            listadoChoferes = negocio.listarChoferesInactivos();
            dgvChoferesInactivos.DataSource = listadoChoferes;
            ocultarColumnas();
        }

        private void tbxChoferesInactivosFiltro_KeyPress(object sender, KeyPressEventArgs e)
        {
            filtrarChoferes();
        }

        private void dgvChoferesInactivos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Persona seleccion = (Persona)dgvChoferesInactivos.CurrentRow.DataBoundItem;


            FrmFichaChofer ficha = new FrmFichaChofer(seleccion);
            ficha.ShowDialog();
            //FrmModificarChofer modificar = new FrmModificarChofer(seleccion);
            //modificar.ShowDialog();
            cargar();
        }
    }
}
