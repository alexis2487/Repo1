﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculoSalariaForms
{
    public partial class ResultadoCalculo : Form
    {
        public ResultadoCalculo()
        {
            InitializeComponent();
        }


        private void Btn3Salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Btn3Volver_Click(object sender, EventArgs e)
        {
            CalculoSalarioForms MiDatos = new CalculoSalarioForms();
            MiDatos.Show();
            Hide();
        }


    }
}
