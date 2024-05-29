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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }
        private void buttonEscenario1_Click(object sender, EventArgs e)
        {
            Escenario1 escenario1 = new Escenario1();
            escenario1.Show();
            Hide();
        }

        private void buttonEscenario2_Click(object sender, EventArgs e)
        {
            Escenario2 escenario2 = new Escenario2();
            escenario2.Show();
            Hide();
        }
        private void buttonSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
