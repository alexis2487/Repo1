using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArbolBinario
{
    public partial class Ingreso : Form
    {
        public Ingreso()
        {
            InitializeComponent();
            textBoxIngreso.Focus();
        }

        private void buttonIngresar_Click(object sender, EventArgs e)
        {
            if(textBoxIngreso.Text == "")
            {
                errorProvider1.SetError(textBoxIngreso, "Debe Ingresar Clave");
                textBoxIngreso.Clear();
                textBoxIngreso.Focus();
            }
            if (textBoxIngreso.Text.ToUpperInvariant() == "UNAD")
            {
                Menu formmenu = new Menu();
                formmenu.Show();
                Hide();
            }
            else
            {
                errorProvider1.SetError(textBoxIngreso, "Clave Incorrecta");
                textBoxIngreso.Clear();
                textBoxIngreso.Focus();
            }
        }
        

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void KeyIngreso(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
               
                textBoxIngreso.BackColor = Color.Green;
            }
            else if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                textBoxIngreso.BackColor = Color.Red;
            }
        }

    }
}
