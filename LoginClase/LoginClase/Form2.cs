﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginClase
{ 
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 formulario = new Form1();
            formulario.Visible = true;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int conteo = 0;
            string seleccion;
            if(cbCS.Checked == true)
            {
                conteo++;
            }
            if(cbB.Checked == true)
            {
                conteo++;
            }
            if(rbTarjeta.Checked == true)
            {
                seleccion = "Tarjeta de Credito";
            }
            else
            {
                seleccion = "PayPal";
            }
        }
    }
}
