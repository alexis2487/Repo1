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
    public partial class RegistroDeDatosPila : Form
    {
        

        Stack<Pila> pila = new Stack<Pila>();

        public RegistroDeDatosPila()
        {
            InitializeComponent();
        }
        private bool ValidarCampo()
        {
            if (string.IsNullOrEmpty(textBoxMatricula.Text))
            {
                MessageBox.Show("Todos los campos deben estar completados", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (string.IsNullOrEmpty(textboxFactura.Text))
            {
                MessageBox.Show("Todos los campos deben estar completados", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (string.IsNullOrEmpty(comboBoxMesFacturado.Text))
            {
                MessageBox.Show("Todos los campos deben estar completados", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (string.IsNullOrEmpty(textNombre.Text))
            {
                MessageBox.Show("Todos los campos deben estar completados", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (string.IsNullOrEmpty(textBoxDireccion.Text))
            {
                MessageBox.Show("Todos los campos deben estar completados", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (string.IsNullOrEmpty(comboBoxEstrato.Text))
            {
                MessageBox.Show("Todos los campos deben estar completados", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (string.IsNullOrEmpty(comboBoxCategoria.Text))
            {
                MessageBox.Show("Todos los campos deben estar completados", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (string.IsNullOrEmpty(textMetroCubico.Text))
            {
                MessageBox.Show("Todos los campos deben estar completados", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }  
            return true;
        }
        private void registrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ValidarCampo())
            {
                Pila _Pila = new Pila();

                _Pila.Factura = textboxFactura.Text;
                _Pila.Matricula = textBoxMatricula.Text;
                _Pila.MesFacturado = comboBoxMesFacturado.Text;
                _Pila.Nombre = textNombre.Text;
                _Pila.Direccion = textBoxDireccion.Text;
                _Pila.Estrato = comboBoxEstrato.Text;
                _Pila.Categoria = comboBoxCategoria.Text;
                _Pila.MetrosCubicosMes = int.Parse(textMetroCubico.Text);
                _Pila.FechaSelected = dateTimePicker1.Value;

                pila.Push(_Pila);

                dataGridView1.DataSource= null;
                dataGridView1.DataSource = pila.ToArray();
                MessageBox.Show("Se guardo la informacion");
                Limpiar();
                textValorMetroCubico.Text =  _Pila.CalcularMes(_Pila.MetrosCubicosMes).ToString("C");
            }
        }
        
        private void reporteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pila.Count != 0)
            {
                if (MessageBox.Show("Desea Ejecutar El Reporte?", "Alerta", MessageBoxButtons.YesNo
                    , MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int TotalFacturas = 0;
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        TotalFacturas += int.Parse(row.Cells["ValorNeto"].Value.ToString());
                    }
                    string meses = "";
                    foreach (DataGridViewRow roww in dataGridView1.Rows)
                    {
                        meses += roww.Cells["MesFacturado"].Value;
                    }
                    textValorNetoTotal.Text = TotalFacturas.ToString();
                    textBoxMeses.Text = pila.Count().ToString();

                }

            }
            else
            {
                MessageBox.Show("No Hay Datos Para Reportar", "Alerta");
            }



        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if(pila.Count != 0)
            {
                if(MessageBox.Show("Desea eliminar el registro?", "Alerta", MessageBoxButtons.YesNo
                    , MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Pila _Pila = new Pila();
                    _Pila = pila.Pop();
                    textboxFactura.Text = _Pila.Factura;
                    textBoxMatricula.Text =  _Pila.Matricula;
                    comboBoxMesFacturado.Text = _Pila.MesFacturado;
                    textNombre.Text =  _Pila.Nombre;
                    textBoxDireccion.Text =  _Pila.Direccion;
                    comboBoxEstrato.Text = _Pila.Estrato;
                    comboBoxCategoria.Text = _Pila.Categoria;
                    textMetroCubico.Text =  _Pila.MetrosCubicosMes.ToString();
                    textValorMetroCubico.Text =  _Pila.CalcularMes(_Pila.MetrosCubicosMes).ToString("C");
                    dataGridView1.DataSource = pila.ToArray();
                    MessageBox.Show("Se elimino de la lista");
                    Limpiar();
                }
        
            }
            else 
            {
                MessageBox.Show("No Hay Datos Para Eliminar","Alerta");
            }
          
        }
        private void limpiarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
        private void Limpiar()
        {
            textboxFactura.Text = "";
            textBoxMatricula.Text = "";
            comboBoxMesFacturado.Text = "";
            textNombre.Text = "";
            textBoxDireccion.Text = "";
            comboBoxEstrato.Text ="";
            comboBoxCategoria.Text = "";
            textMetroCubico.Text =  "";
            textValorMetroCubico.Text ="";
            textValorNetoTotal.Text = "";
            textboxFactura.BackColor = Color.White;
            textBoxMatricula.BackColor = Color.White;
            textMetroCubico.BackColor = Color.White;
            errorProvider1.Clear();
        }
        private void KEy_Metros(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                textMetroCubico.BackColor = Color.Red;
            }
            else if (char.IsDigit(e.KeyChar))
            {
                textMetroCubico.BackColor = Color.Green;
            }
        }

        private void volverToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Menu FormMenu = new Menu();
            FormMenu.Show();
            Hide();
        }

        private void KEYFACTURA(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                textboxFactura.BackColor = Color.Red;
                errorProvider1.SetError(textboxFactura, "Solo Se Permite Datos Numericos");
            }
            else if (char.IsDigit(e.KeyChar))
            {

                textboxFactura.BackColor = Color.Green;
            }
        }

        private void keyMatricula(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                
                textBoxMatricula.BackColor = Color.Red;
                errorProvider1.SetError(textBoxMatricula, "Solo Se Permite Datos Numericos");
            }
            else if (char.IsDigit(e.KeyChar))
            {

                textBoxMatricula.BackColor = Color.Green;
            }
        }
    }
}
