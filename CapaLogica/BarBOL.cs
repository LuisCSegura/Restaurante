using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using CapaDatos;

namespace CapaLogica
{
    public class BarBOL
    {
        BarDAL barDal = new BarDAL();
        ComandaDAL comDal = new ComandaDAL();
        public LinkedList<OrdenBebida> CargarOrdenesBar()
        {
            try
            {
                LinkedList<OrdenBebida> lista = barDal.CargarOrdenesBar();
                foreach (OrdenBebida orden in lista)
                {
                    orden.tiempoServicio = DateTime.Now;
                    comDal.ActualizarOrdenBebida(orden);
                }
                return barDal.CargarOrdenesBar();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
