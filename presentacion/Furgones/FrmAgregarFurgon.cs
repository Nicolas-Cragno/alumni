using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        }

        private void btnAgregarTractorCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
