using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sustentacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           if (textBoxIngreso.Text == "")
           {
               errorProvider1.SetError(textBoxIngreso,"No ah ingresado clave");
           }
           else if (textBoxIngreso.Text == "123")
           {
                MENU FORM2 = new MENU();
                FORM2.Show();
                Hide();
           }
           else 
           {
                errorProvider1.SetError(textBoxIngreso, "clave incorrecta");
           }
        }
    }
}
