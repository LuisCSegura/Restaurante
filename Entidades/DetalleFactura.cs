using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class DetalleFactura
    {
        public int id { get; set; }
        public int ordenRefer { get; set; }
        public string detalle { get; set; }
        public double precio { get; set; }
        public DetalleFactura()
        {
            detalle = "No especicficado";
        }
        override
        public string ToString()
        {
            string txt = detalle;
            while (txt.Length < 36)
            {
                txt += " . ";
            }
            txt += precio;
            return txt;
        }

    }
}
