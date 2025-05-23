﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;

namespace presentacion.Eventos
{
    public partial class FrmFichaEvento : Form
    {
        Evento evento = null;

        public FrmFichaEvento(Evento eventoSeleccionado)
        {
            InitializeComponent();
            evento = eventoSeleccionado;
            tbxFichaEventoFecha.TabIndex = 0;
            tbxFichaEventoChofer.TabIndex = 1;
            tbxFichaEventoTipo.TabIndex = 2;
            tbxFichaEventoInterno.TabIndex = 3;
            tbxFichaEventoFurgon.TabIndex = 4;
            tbxFichaEventoDetalle.TabIndex = 5;
            btnFichaEventoEditar.TabIndex = 6;
            btnFichaEventoCerrar.TabIndex = 7;
        }

        private void FrmFichaEvento_Load(object sender, EventArgs e)
        {
            cargar();
        }

        private void cargar()
        {
            if (evento != null)
            {
                tbxFichaEventoChofer.Text = evento.Persona;
                tbxFichaEventoInterno.Text = evento.Interno.ToString();
                tbxFichaEventoFurgon.Text = evento.Furgon.ToString();
                tbxFichaEventoFecha.Text = evento.Fecha.ToString();
                tbxFichaEventoTipo.Text = evento.Tipo;
                tbxFichaEventoDetalle.Text = evento.Detalle;
            }
        }

        private void btnFichaEventoCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnFichaEventoEditar_Click(object sender, EventArgs e)
        {
            FrmModificarEvento ventana = new FrmModificarEvento(evento);
            ventana.ShowDialog();
            Close();
        }
    }
}
