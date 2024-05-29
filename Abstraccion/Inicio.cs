using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CalculoSalariaForms
{
    public partial class FormsInicio : Form
    {
        public FormsInicio()
        {
            InitializeComponent();
            ReproducirSonido();
        }

        
        private void BtnValidarIngreso_Click(object sender, EventArgs e)
        {
           
            if (TxtIngresoClave.Text == "")
            {
                errorProvider1.SetError(TxtIngresoClave, "No Se Ah Ingresado Clave");
            }
            else
            {
                if(TxtIngresoClave.Text == "123")
                {
                    MessageBox.Show("Clave Valida");
                    CalculoSalarioForms MiDatos = new CalculoSalarioForms();
                    MiDatos.Show();
                    Hide();
                }
                else 
                {
                    errorProvider1.SetError(TxtIngresoClave, "Clave Invalida");
                    TxtIngresoClave.Clear();
                }
                TxtIngresoClave.Focus();
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void ReproducirSonido()
        {
            SoundPlayer sonido = new SoundPlayer(Properties.Resources.babydolll);
            sonido.Play();
        }

    }
}
