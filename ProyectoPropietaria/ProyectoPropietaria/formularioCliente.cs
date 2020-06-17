﻿using ProyectoPropietaria.Cliente;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoPropietaria
{
    public partial class formularioCliente : Form
    {
        public formularioCliente()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var frm = new GestionTipoCliente();
            this.Hide();
            frm.Show();
        }

        private void formularioCliente_FormClosed(object sender, FormClosedEventArgs e)
        {
            var frm = new Inicio();
            
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var frm = new GestionCliente();
            this.Hide();
            frm.Show();

        }
    }
}
