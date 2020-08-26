using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Mesa
    {
        public int id { get; set; }
        public int numero { get; set; }
        public Seccion seccion { get; set; }

        public Mesa()
        {
        }

        override
        public string ToString()
        {
            return "M E S A   " + numero;
        }
    }
}
