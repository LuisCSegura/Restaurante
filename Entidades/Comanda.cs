using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Comanda
    {
        public int id { get; set; }
        public Usuario salonero { get; set; }
        public Mesa mesa { get; set; }
        public DateTime tiempo { get; set; }
        public bool pagado { get; set; }
        public LinkedList<OrdenComida> comidas { get; set; }
        public LinkedList<OrdenBebida> bebidas { get; set; }

        public Comanda()
        {
            tiempo = DateTime.Now;
            pagado = false;
            comidas = new LinkedList<OrdenComida>();
            bebidas = new LinkedList<OrdenBebida>();
        }
        override
        public string ToString()
        {
            return "  Seccion " + mesa.seccion.numero + "  Mesa " + mesa.numero;
        }
        public string GetTexto()
        {
            string txt = "   "+mesa.ToString()+"\n";
            txt += "\n  Salonero: " + salonero.nombre + " : " + salonero.codigo+"\n";
            txt += "\n  COMIDAS\n";
            foreach (OrdenComida comida in comidas)
            {
                txt+="  "+comida.ToShortString()+"\n";
            }
            txt += "\n  BEBIDAS\n";
            foreach (OrdenBebida bebida in bebidas)
            {
                txt += "  " + bebida.ToShortString();
            }
            return txt;
        }
    }
}
