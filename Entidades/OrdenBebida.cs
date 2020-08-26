using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class OrdenBebida
    {

        public int id { get; set; }
        public int cantidad { get; set; }
        public Bebida bebida { get; set; }
        public bool preparado { get; set; }
        public Comanda comanda { get; set; }
        public DateTime tiempoServicio { get; set; }

        public OrdenBebida()
        {
            preparado = false;
            cantidad = 1;
            tiempoServicio = DateTime.Now;
        }
        public double GetPrecio()
        {
            return bebida.precio * cantidad;
        }
        override
        public string ToString()
        {
            return "  " + cantidad + "  " + bebida.nombre + " : " + bebida.codigo +
                "  -  Pedido: " + comanda.tiempo.Hour + ":" + comanda.tiempo.Minute + "   Salida: " + tiempoServicio.Hour + ":" + tiempoServicio.Minute;
        }
        public string ToShortString()
        {
            return "  " + cantidad + "   " + bebida.nombre + " : " + bebida.codigo;
        }
        public string ToStatusString()
        {
            if (preparado)
            {
                return " Listo " + cantidad + " " + bebida.codigo+ " Mesa "+comanda.mesa.numero+" ";
            }
            else
            {
                return "No listo";
            }
        }
    }
}
