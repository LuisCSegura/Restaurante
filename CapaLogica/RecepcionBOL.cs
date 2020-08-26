using CapaDatos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class RecepcionBOL
    {
        private RecepcionDAL rdal = new RecepcionDAL();
        public LinkedList<Mesa> CargarTodos()
        {
            try
            {
                return rdal.CargarTodos();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }


        public void Validar(Mesa m)
        {
            if (m.seccion.id< 0 || string.IsNullOrEmpty(m.seccion.numero.ToString()))
            {
                throw new Exception("Seccion requerida");
            }
            if (m.id < 0 || string.IsNullOrEmpty(m.numero.ToString()))
            {
                throw new Exception("Numero de mesa requerido");
            }
        }

        public LinkedList<Mesa> CargarMesas(Seccion sec, DateTime fecha, string hora )
        {
            try
            {

                return rdal.CargarMesas(sec, fecha, hora);
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }


    }
}
