using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
     public class Reportes
    {
       
        //ArrayList secciones = new ArrayList();
       // ArrayList cantidad = new ArrayList();
        public ArrayList secciones { get; set; }
        public ArrayList cantidad { get; set; }
        public ArrayList mesas { get; set; }
        public int mesa { get; set; }
        public int seccion { get; set; }
        public string nombre { get; set; }

        public DateTime fecha1 { get; set; }
        public DateTime fecha2 { get; set; }
        public DateTime fecha3 { get; set; }
        public Reportes()
        {
        }





    }
}
