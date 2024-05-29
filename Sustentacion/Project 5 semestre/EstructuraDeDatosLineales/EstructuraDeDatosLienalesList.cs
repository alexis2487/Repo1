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
    public partial class EstructuraDeDatosLienalesList : Form
    {
        List<ListaEstudiante> List = new List<ListaEstudiante>();
        public EstructuraDeDatosLienalesList()
        {
            InitializeComponent();
            consultarToolStripMenuItem.Enabled = false;
            eliminarToolStripMenuItem.Enabled = false;
        }
        private bool ValidarCampo()
        {
            if (string.IsNullOrEmpty(textboxIdentificacion.Text))
            {
                MessageBox.Show("Todos los campos deben estar completados", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (string.IsNullOrEmpty(textboxNombre.Text))
            {
                MessageBox.Show("Todos los campos deben estar completados", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (string.IsNullOrEmpty(textBoxEdad.Text))
            {
                MessageBox.Show("Todos los campos deben estar completados", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (string.IsNullOrEmpty(comboBoxEstrato.Text))
            {
                MessageBox.Show("Todos los campos deben estar completados", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (string.IsNullOrEmpty(comboBoxProgramaUniversitario.Text))
            {
                MessageBox.Show("Todos los campos deben estar completados", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (string.IsNullOrEmpty(comboBoxNombreUniversidad.Text))
            {
                MessageBox.Show("Todos los campos deben estar completados", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (string.IsNullOrEmpty(dateTimePicker1.Text))
            //Validar datetimepicker 
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
                ListaEstudiante Lista_E = new ListaEstudiante();

                Lista_E.Identificacion = int.Parse(textboxIdentificacion.Text);
                Lista_E.Nombre = textboxNombre.Text;
                Lista_E.Edad = int.Parse(textBoxEdad.Text);
                Lista_E.Estrato = comboBoxEstrato.Text;
                Lista_E.ProgramaUniversitario = comboBoxProgramaUniversitario.Text;
                Lista_E.NombreUniversidad = comboBoxNombreUniversidad.Text;
                Lista_E.FechaSelected = dateTimePicker1.Value;

                List.Add(Lista_E);

                dataGridView1.DataSource = null;
                dataGridView1.DataSource = List.ToArray();
                MessageBox.Show("Se guardo la informacion");
                consultarToolStripMenuItem.Enabled = true;

                Limpiar();
            }
        }

        private void consultarToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            ListaEstudiante Lista_E = GetEstudiante(textBoxConsulta.Text);
            if (Lista_E == null)
            {
                MessageBox.Show(textBoxConsulta, " el estudiante no esta registrado en la lista");
                Limpiar();
                textBoxConsulta.Focus();
                return;

            }
            else
            {
                MessageBox.Show(textBoxConsulta, " Estudiante encontrado");
                textboxNombre.Text = Lista_E.Nombre;
                textboxIdentificacion.Text = Lista_E.Identificacion.ToString();
                textBoxEdad.Text = Lista_E.Edad.ToString();
                comboBoxEstrato.Text = Lista_E.Estrato;
                comboBoxProgramaUniversitario.Text = Lista_E.ProgramaUniversitario;
                comboBoxNombreUniversidad.Text = Lista_E.NombreUniversidad;
                dateTimePicker1.Value = Lista_E.FechaSelected;
                eliminarToolStripMenuItem.Enabled = true;
            }
        }
        private ListaEstudiante GetEstudiante(string Nombre)
        {
            return List.Find(Estudiante => Estudiante.Nombre.Contains(Nombre));
        }
        private void reporteToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (List.Count != 0)
            {
                if (MessageBox.Show("Desea Ejecutar El Reporte?", "Alerta", MessageBoxButtons
                    .YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    textBoxCount.Text = List.Count().ToString();
                }
            }
            else
            {
                MessageBox.Show("No Hay Datos Para Reportar", "Alerta");
            }
                            
                   
        }

        private void eliminarToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (textboxNombre.Text == "")
            {
                MessageBox.Show("Debe consultar primero para eliminar");
                textboxNombre.Focus();
                Limpiar();
                return;
            }
            else
            {
                DialogResult Respuesta = MessageBox.Show("Esta seguro de eliminar registro?", "Confirmacion",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question,
               MessageBoxDefaultButton.Button2);
                if (Respuesta == DialogResult.Yes)
                {
                    foreach (ListaEstudiante Estudiante in List)
                    {
                        if (Estudiante.Nombre == textboxNombre.Text)
                        {
                            List.Remove(Estudiante);
                            break;
                        }
                    }
                    Limpiar();
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = List;
                }

            }
        }
   
        private void Limpiar()
        {
            textboxIdentificacion.Text = "";
            textboxNombre.Text = "";
            textBoxEdad.Text = "";
            comboBoxEstrato.Text = "";
            comboBoxProgramaUniversitario.Text = "";
            comboBoxNombreUniversidad.Text = "";
            textBoxEdad.BackColor = Color.White;
            textboxIdentificacion.BackColor = Color.White;
            errorProvider1.Clear();



        }
        private void limpiarToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Limpiar();
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

        private void key(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                textBoxConsulta.BackColor = Color.Green;
            }
            else if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                textBoxConsulta.BackColor = Color.Red;
            }
        }

        private void keyedad(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                textBoxEdad.BackColor = Color.Red;
                errorProvider1.SetError(textBoxEdad, "Solo Se Permite Datos Numericos");
            }
            else if (char.IsDigit(e.KeyChar))
            {
                
                textBoxEdad.BackColor = Color.Green;
            }
        }

        private void keyindentificacion(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                textboxIdentificacion.BackColor = Color.Red;
                errorProvider1.SetError(textboxIdentificacion, "Solo Se Permite Datos Numericos");
            }
            else if (char.IsDigit(e.KeyChar))
            {

                textboxIdentificacion.BackColor = Color.Green;
            }
          
        }
    }
}
