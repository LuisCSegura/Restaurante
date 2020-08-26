using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using CapaDatos;


namespace CapaLogica
{
    public class CocinaBOL
    {
        CocinaDAL cocDal = new CocinaDAL();
        ComandaDAL comDal = new ComandaDAL();
        public LinkedList<OrdenComida> CargarOrdenesCocina()
        {
            try
            {
                LinkedList<OrdenComida> lista = cocDal.CargarOrdenesCocina();
                foreach (OrdenComida orden in lista)
                {
                    orden.tiempoServicio = DateTime.Now;
                    comDal.ActualizarOrdenComida(orden);
                }
                return cocDal.CargarOrdenesCocina();
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }
    }
}
