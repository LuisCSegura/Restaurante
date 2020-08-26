using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class OrdenComida
    {
        public int id { get; set; }
        public int cantidad { get; set; }
        public Comida comida { get; set; }
        public bool preparado { get; set; }
        public Comanda comanda { get; set; }
        public DateTime tiempoServicio { get; set; }

        public OrdenComida()
        {
            preparado = false;
            cantidad = 1;
            tiempoServicio =DateTime.Now;
        }
        public double GetPrecio()
        {
            return comida.precio * cantidad;
        }
        override
        public string ToString()
        {
            return "  " + cantidad + "  " + comida.nombre + " : " + comida.codigo +
                "  -  Pedido: " + comanda.tiempo.Hour + ":" + comanda.tiempo.Minute + "   Salida: " + tiempoServicio.Hour + ":" + tiempoServicio.Minute;
        }
        public string ToShortString()
        {
            return "  " + cantidad + "   " + comida.nombre + " : " + comida.codigo;
        }
        public string ToStatusString()
        {
            if (preparado)
            {
                return " Listo " + cantidad + " " + comida.codigo + " Mesa "+comanda.mesa.numero+" " ;
            }
            else
            {
                return "No listo";
            }
        }
    }
}
