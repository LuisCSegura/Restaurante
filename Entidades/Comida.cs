using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Comida
    {

        public int id { get; set; }
        public string codigo { get; set; }
        public string nombre { get; set; }
        public string categoria { get; set; }
        public string descripcion { get; set; }
        public double precio { get; set; }
        public bool activo { get; set; }


        public Comida()
        {
            activo = true;
        }
        override
        public string ToString()
        {
            return "● "+nombre + " : " + codigo;
        }
        public bool Equals(Comida comida)
        {
            return (codigo == comida.codigo);
        }

    }
}
