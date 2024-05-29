using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculoSalariaForms
{
    public class Nomina
    {
        public string Identificacion { get; set; }
        public string Nombre { get; set; }
        public string Genero {  get; set; }
        public string Cargo { get; set; }
        public int DiasTrabajados { get; set; }
        public decimal ValorDia { get; set; }


        //metodo
        public decimal MtdoCalcularSalario(int DiasTrabajados, decimal ValorDia)
        {
            
            decimal SalarioDevengado = 0;

            SalarioDevengado = (DiasTrabajados * ValorDia);
            return SalarioDevengado;
            
        }
    }
}
