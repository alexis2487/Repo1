using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstructuraDeDatosLineales
{
    
    public class Pila
    {

        public string Factura { get; set; }
        public string Matricula { get; set; }
        public string MesFacturado { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string Estrato { get; set; }
        public string Categoria { get; set; }
        public int MetrosCubicosMes { get; set; }
        public decimal ValorNeto { get; set; }
        public DateTime FechaSelected { get; set; }



        public decimal CalcularMes(int MetrosCubicosMes)
        { 
            ValorNeto = (MetrosCubicosMes * 2000) ;
            return ValorNeto;
        }

    }
       

}
