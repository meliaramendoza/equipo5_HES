﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftHES
{
    public partial class ActDatos : Form
    {
        public ActDatos()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnAtras_Click(object sender, EventArgs e,string nombre)
        {
            this.Hide();
            inicioDoc inicio = new inicioDoc(nombre);
            inicio.Show();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //inicioDoc inicio = new inicioDoc();
            //inicio.Show();
        }
    }
}
