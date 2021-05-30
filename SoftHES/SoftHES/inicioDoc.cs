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
    public partial class inicioDoc : Form
    {
        //Visualiza el tipo de usuario y el nombre del usuario
        public inicioDoc(string nombre)
        {
            InitializeComponent();
            lblMensaje.Text = "BIENVENIDO!  " + nombre;
        }

        private void btnAD_Click(object sender, EventArgs e)
        {
            this.Hide();
            ActDatos act = new ActDatos();
            act.Show();
        }

        private void btnAC_Click(object sender, EventArgs e)
        {
            this.Hide();
            AgCitas agenda = new AgCitas();
            agenda.Show();
        }

        private void btnHC_Click(object sender, EventArgs e)
        {
            this.Hide();
            HistClin historia = new HistClin();
            historia.Show();
        }

        private void btnRD_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegCita reg = new RegCita();
            reg.Show();
        }

        private void btnMD_Click(object sender, EventArgs e)
        {
            this.Hide();
            ModDisp disp = new ModDisp();
            disp.Show();
        }

        private void btnCS_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void inicioDoc_Load(object sender, EventArgs e)
        {

        }
    }
}
