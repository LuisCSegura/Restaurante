using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Reserva
    {
        public int id { get; set; }
        public string cedula { get; set; }
        public string nombre { get; set; }
        public DateTime fecha { get; set; }
        public string hora { get; set; }
        public DateTime fecha_reser { get; set; }
        public string telefono { get; set; }
        public int cant_personas { get; set; }
        public int id_seccion { get; set; }
        public int id_mesa { get; set; }
        public string seccion { get; set; }
        public string mesa { get; set; }
        public string estado { get; set; }
        public bool activo { get; set; }

        public Reserva()
        {
            activo = true;
        }





    }
}
