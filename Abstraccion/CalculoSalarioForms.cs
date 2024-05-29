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

namespace CalculoSalariaForms
{
    public partial class CalculoSalarioForms : Form
    {
        Nomina MyNomina = new Nomina();
        public CalculoSalarioForms()
        {
            InitializeComponent();
            
        }



    private void button1_Click(object sender, EventArgs e)
        {
            

            if (TxtIngresoIdentificacion.Text == "")
            {
                errorProviderIdentificacion.SetError(TxtIngresoIdentificacion, "no ingreso ninguna numero");
            }
            else
            {
                MyNomina.Identificacion = TxtIngresoIdentificacion.Text;
            }
            if (TxtIngresoNombre.Text == "")
            {
                errorProviderIdentificacion.SetError(TxtIngresoNombre, "no ingreso ninguna letra");
            }
            else 
            {
                MyNomina.Nombre = TxtIngresoNombre.Text;
            }
            if (CmbxGenero.Text == "")
            {
                errorProviderIdentificacion.SetError(CmbxGenero, "no ingreso ninguna letra");
            }
            else
            {
                MyNomina.Genero = CmbxGenero.Text;
            }

            if (ChkElectricista.Checked)
            {
                MyNomina.Cargo = ChkElectricista.Text;
                MyNomina.ValorDia = 60000;
                TxtSalarioDiaFalse.Text = MyNomina.ValorDia.ToString();
            }
            if (ChkMecanico.Checked)
            {
                MyNomina.Cargo = ChkMecanico.Text;
                MyNomina.ValorDia = 65000;
                TxtSalarioDiaFalse.Text = MyNomina.ValorDia.ToString();
            }
            if (ChkSoldador.Checked)
            {
                MyNomina.Cargo = ChkSoldador.Text;
                MyNomina.ValorDia = 70000;
                TxtSalarioDiaFalse.Text = MyNomina.ValorDia.ToString();
            }
            if (ChkServiciosGenerales.Checked)
            {
                MyNomina.Cargo = ChkServiciosGenerales.Text;
                MyNomina.ValorDia = 40000;
                TxtSalarioDiaFalse.Text = MyNomina.ValorDia.ToString();
            }
            if (ChkAdministrativo.Checked)
            {
                MyNomina.Cargo = ChkAdministrativo.Text;
                MyNomina.ValorDia = 50000;
                TxtSalarioDiaFalse.Text = MyNomina.ValorDia.ToString();
            }

            if (TxtDiasLaborados.Text == "")
            {
                errorProviderIdentificacion.SetError(TxtDiasLaborados, "no ingreso ninguna numero");
            }
            else
            {
                MyNomina.DiasTrabajados = int.Parse(TxtDiasLaborados.Text);
                
            }
            MessageBox.Show("Se guardo la informacion");


        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            FormsInicio MiForm1 = new FormsInicio();
            MiForm1.Show();
            Hide();
        }

        private void BtnCalcularSalario_Click(object sender, EventArgs e)
        {
            ResultadoCalculo MiForm3 = new ResultadoCalculo();
            MiForm3.Show();
            Hide();
            MiForm3.LblIdentificacion.Text = MyNomina.Identificacion;
            MiForm3.LblNombre.Text = MyNomina.Nombre;
            MiForm3.LblGenero.Text = MyNomina.Genero;
            MiForm3.LblCargo.Text = MyNomina.Cargo;
            MiForm3.LblDiasLaborados.Text = MyNomina.DiasTrabajados.ToString();
            MiForm3.LblSalarioDia.Text = MyNomina.ValorDia.ToString("C");
            MiForm3.LblSalarioTotal.Text = MyNomina.MtdoCalcularSalario(MyNomina.DiasTrabajados,MyNomina.ValorDia).ToString("C");
        }


    }
}
