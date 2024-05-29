using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstructuraDeDatosLineales
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void buttonPila_Click(object sender, EventArgs e)
        {
            RegistroDeDatosPila Form1 = new RegistroDeDatosPila();
            Form1.Show();
            Hide();
        }

        private void buttonCola_Click(object sender, EventArgs e)
        {
            RegistroDeDatosCola Form2 = new RegistroDeDatosCola();
            Form2.Show();
            Hide();
        }

        private void buttonList_Click(object sender, EventArgs e)
        {
            EstructuraDeDatosLienalesList form3 = new EstructuraDeDatosLienalesList();
            form3.Show();
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
