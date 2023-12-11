using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pjVentas
{
    public class venta
    {
        public venta(string nombre, int edad, double costo)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.costo = costo;
        }

        public string nombre { get; set; }
        public double costo { get; set; }
        public int edad { get; set; }
    }
}
