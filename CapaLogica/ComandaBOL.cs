using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using CapaDatos;

namespace CapaLogica
{
    public class ComandaBOL
    {
        ComandaDAL comanDAL=new ComandaDAL();
        public Comanda CargarComandaMesa(Mesa mesa)
        {
            try
            {
               return comanDAL.CargarComandaMesa(mesa);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public void InsertarComanda(Comanda com)
        {
            try
            {
               comanDAL.InsertarComanda(com);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public LinkedList<Comanda> CargarComandas()
        {
            try
            {
                return comanDAL.CargarComandas();
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }

        public void ActualizarOrdenComida(OrdenComida orden)
        {
            try
            {
                comanDAL.ActualizarOrdenComida(orden);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public void InsertarOrdenComida(OrdenComida oc)
        {
            try
            {
                comanDAL.InsertarOrdenComida(oc);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public void ActualizarOrdenBebida(OrdenBebida orden)
        {
            try
            {
                comanDAL.ActualizarOrdenBebida(orden);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public void InsertarOrdenBebida(OrdenBebida ob)
        {
            try
            {
                comanDAL.InsertarOrdenBebida(ob);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public void ActualizarComanda(Comanda comanda)
        {
            try
            {
                comanDAL.ActualizarComanda(comanda);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public LinkedList<OrdenComida> CargarNotificacionesComidas(Seccion s)
        {
            try
            {
                return comanDAL.comidasListasSeccion(s);
                
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public LinkedList<OrdenBebida> CargarNotificacionesBebidas(Seccion s)
        {
            try
            {
                return comanDAL.bebidasListasSeccion(s);

            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public void EliminarOrdenBebida(OrdenBebida orden)
        {
            try
            {
                comanDAL.EliminarOrdenBebiida(orden);

            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public void EliminarOrdenComida(OrdenComida ordenc)
        {
            try
            {
               comanDAL.EliminarOrdenComida(ordenc);

            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
