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
    public partial class MENU : Form
    {
        public MENU()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CalculoSalariaForms.FormsInicio form1 = new CalculoSalariaForms.FormsInicio();
            form1.ShowDialog();
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EstructuraDeDatosLineales.INGRESO form2 = new EstructuraDeDatosLineales.INGRESO();
            form2.ShowDialog();
            Hide();
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ArbolBinario.Ingreso form3 = new ArbolBinario.Ingreso();
            form3.ShowDialog();
            Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
