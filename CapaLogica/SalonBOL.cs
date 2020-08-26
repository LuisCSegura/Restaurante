using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using CapaDatos;

namespace CapaLogica
{
    public class SalonBOL
    {
        private SalonDAL salDal = new SalonDAL();

        public LinkedList<Seccion> CargarTodas()
        {
            try
            {
                return salDal.CargarTodas();
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }


        public LinkedList<Mesa> CargarMesas(Seccion s)
        {
            try
            {
                return salDal.CargarMesas(s);
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }

        public void InsertarNuevo(Seccion s)
        {
            try
            {
                Validar(s);
                salDal.InsertarNueva(s);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        private void Validar(Seccion s)
        {
            if (s.numero <= 0)
            {
                throw new Exception("El numero de seccionn debe ser mayor a cero");
            }
            if (s.salonero == null)
            {
                throw new Exception("debe seleccionar un salonero");
            }
        }

        public void Actualizar(Seccion s)
        {
            try
            {
                Validar(s);
                salDal.Actualizar(s);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public void Eliminar(Seccion seleccionada)
        {
            try
            {
                salDal.Eliminar(seleccionada);
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }
        public Seccion CargarSeccionSalonero(Usuario sal)
        {
            try
            {
               return salDal.CargarSeccionSalonero(sal);
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }
    }
}
