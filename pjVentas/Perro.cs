using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pjVentas
{
    public class Perro:venta
    {
       public raza raza { get; set; }

        public Perro(string nombre, int edad, double costo, raza raza):base(nombre, edad, costo)
        {
            raza = raza;
        }

    }
}
