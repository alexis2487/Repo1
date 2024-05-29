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
    public partial class RegistroDeDatosCola : Form
    {
        Queue<ColaAeroCola> Cola = new Queue<ColaAeroCola>();
        public RegistroDeDatosCola()
        {
            InitializeComponent();
        }
        private bool ValidarCampo()
        {
            if (string.IsNullOrEmpty(textNombre.Text))
            {
                MessageBox.Show("aTodos los campos deben estar completados", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (string.IsNullOrEmpty(textboxVuelo.Text))
            {
                MessageBox.Show("Todos los campos deben estar completados", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (string.IsNullOrEmpty(textNombre.Text))
            {
                MessageBox.Show("Todos los campos deben estar completados", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (string.IsNullOrEmpty(comboBoxAereolinea.Text))
            {
                MessageBox.Show("Todos los campos deben estar completados", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (string.IsNullOrEmpty(comboBoxDestinos.Text))
            {
                MessageBox.Show("Todos los campos deben estar completados", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        private void registrarToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (ValidarCampo())
            {
                ColaAeroCola _Cola = new ColaAeroCola();
                _Cola.NumeroDeVuelo = textboxVuelo.Text;
                _Cola.Identificacion = textBoxId.Text;
                _Cola.Nombre = textNombre.Text;
                _Cola.NombreAereolinea = comboBoxAereolinea.Text;
                _Cola.Destino = comboBoxDestinos.Text;
                _Cola.FechaSelected = dateTimePicker1.Value;
                Cola.Enqueue(_Cola);
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = Cola.ToArray();
                MessageBox.Show("Se guardo la informacion");
                Limpiar();
            }
        }

        private void reporteToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (Cola.Count != 0)
            {
                if (MessageBox.Show("Desea Ejecutar El Reporte?", "Alerta", MessageBoxButtons
                    .YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    textBoxCount.Text = Cola.Count().ToString();
                }
            }
            else
            {
                MessageBox.Show("No Hay Datos Para Reportar", "Alerta");
            }
        }

        private void eliminarToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (Cola.Count != 0)
            {
                if (MessageBox.Show("Desea eliminar el registro?", "Alerta", MessageBoxButtons
                    .YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    ColaAeroCola _Cola = new ColaAeroCola();
                    _Cola = Cola.Dequeue();
                    textboxVuelo.Text = _Cola.NumeroDeVuelo;
                    textBoxId.Text = _Cola.Identificacion;
                    textNombre.Text = _Cola.Nombre;
                    comboBoxAereolinea.Text = _Cola.NombreAereolinea;
                    comboBoxDestinos.Text = _Cola.Destino;
                    dataGridView1.DataSource = Cola.ToArray();
                    MessageBox.Show("Se elimino de la lista");
                    Limpiar();
                }

            }
            else
            {
                MessageBox.Show("No Hay Datos Para Eliminar", "Alerta");
            }

        }

        private void limpiarToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Limpiar();
        }
        private void Limpiar()
        {
            textboxVuelo.Text = "";
            textBoxId.Text = "";
            textNombre.Text = "";
            comboBoxAereolinea.Text = "";
            comboBoxDestinos.Text = "";
            textBoxId.BackColor = Color.White;
            textboxVuelo.BackColor = Color.White;
            errorProvider1.Clear();
        }

        private void salirToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void volverToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Menu FormMenu = new Menu();
            FormMenu.Show();
            Hide();
        }

        private void KeyVuelo(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;

                textboxVuelo.BackColor = Color.Red;
                errorProvider1.SetError(textboxVuelo, "Solo Se Permite Datos Numericos");
            }
            else if (char.IsDigit(e.KeyChar))
            {

                textboxVuelo.BackColor = Color.Green;
            }
        }

        private void keyid(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;

                textBoxId.BackColor = Color.Red;
                errorProvider1.SetError(textBoxId, "Solo Se Permite Datos Numericos");
            }
            else if (char.IsDigit(e.KeyChar))
            {

                textBoxId.BackColor = Color.Green;
            }
        }
    }
}
