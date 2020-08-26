using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Entidades
{
    public class Seccion
    {
        public int id { get; set; }
        public int numero { get; set; }
        public int cantidadMesas { get; set; }
        public  Usuario salonero { get; set; }
        public  LinkedList<Mesa> mesas { get; set; }

        public Seccion()
        {
            mesas = new LinkedList<Mesa>();
            cantidadMesas = 6;
        }

    }
}
