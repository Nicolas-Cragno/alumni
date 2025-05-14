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
    public partial class frmMovimientos : Form
    {
        private List<Movimiento> listadoMovimientos;
        public frmMovimientos()
        {
            InitializeComponent();
        }

        private void btnMovimientosClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmMovimientos_Load(object sender, EventArgs e)
        {
            cargar();
        }

        private void cargar()
        {
            MovimientoNegocio negocio = new MovimientoNegocio();
            listadoMovimientos = negocio.listarMovimientos();
            dgvMovimientos.DataSource = listadoMovimientos;
            ocultarColumnas();
        }

        private void ocultarColumnas()
        {
            dgvMovimientos.Columns["Id_Movimiento"].Visible = false;
            dgvMovimientos.Columns["Cliente"].Visible = false;
            dgvMovimientos.Columns["Destino"].Visible = false;
            dgvMovimientos.Columns["Observaciones"].Visible = false;
        }
    }
}
