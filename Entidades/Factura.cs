using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Factura
    {
        public int id { get; set; }
        public int numero { get; set; }
        public DateTime fecha { get; set; }
        public Comanda comanda { get; set; }
        public double totalSinImpuesto { get; set; }
        public double total { get; set; }
        public bool facturado { get; set; }
        public LinkedList<DetalleFactura> detalles{ get; set; }
        public Factura()
        {
            fecha = DateTime.Now;
            detalles = new LinkedList<DetalleFactura>();
        }

        public string GetTexto()
        {
            string separador = "---------------------------------------------" + "\n";
            string txt = "  FACTURA NO " + numero+"\n";
            txt += "  Fecha: " + fecha.Year + "/" + fecha.Month + "/" + fecha.Day+"\n";
            txt += "  Atendido por: " + comanda.salonero.codigo + "\n";
            txt+= comanda.ToString()+"\n";
            txt += separador;
            txt += "  CANTIDAD     DESCRIPCIÓN     PRECIO" + "\n";
            txt += separador;
            foreach (DetalleFactura detalle in detalles)
            {
                txt += detalle.ToString() + "\n";
            }
            txt += separador;
            txt += "  Total sin impuesto: " + totalSinImpuesto + "\n";
            txt += "  TOTAL: " + total + "\n";

            return txt;
        }
        public double GetPrecio()
        {
            double precio = 0;
            foreach (DetalleFactura detalle in detalles)
            {
                precio += detalle.precio;
            }
            return precio;
        }
    }
}
