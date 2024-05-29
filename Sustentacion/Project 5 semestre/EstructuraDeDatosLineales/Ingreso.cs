using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstructuraDeDatosLineales
{
    public partial class INGRESO : Form
    {
        public INGRESO()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
            if (textIngreso.Text == "")
            {
                errorProvider1.SetError(textIngreso,"No se Permite campos vacios");
            }
            if(textIngreso.Text == "123")
            {
                Menu FormMenu = new Menu();
                FormMenu.Show();
                Hide();
            }
            else
            {
                errorProvider1.SetError(textIngreso, "Clave Invalida");
                textIngreso.Clear();
                textIngreso.Focus();

            }

        }

        private void btonSalida_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ByonKey(object sender, KeyPressEventArgs e)
        {
            if(char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                textIngreso.BackColor = Color.Red;
            }
            else if(char.IsDigit(e.KeyChar))
            {
                textIngreso.BackColor = Color.Green;
            }
        }
    }
}
