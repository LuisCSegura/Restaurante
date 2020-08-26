using CapaDatos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class ReservaBOL
    {
        private ReservaDAL rdal = new ReservaDAL();
        public LinkedList<Reserva> CargarTodos()
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



        public LinkedList<Reserva> Autenticar(Seccion s, DateTime fecha, string hora )
        {
            try
            {
               
                return rdal.Autenticar(s, fecha, hora);
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }

        public LinkedList<Mesa> CargarMesas(Seccion sec, DateTime fecha, string hora)
        {
            try
            {

                return rdal.CargarMesas(sec , fecha,hora);
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }




        public void Guardar(Reserva r)
        {
            try
            {
                Validar(r);
                rdal.Insertar(r);

            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

        }


        private void Validar(Reserva r)
        {
            if (string.IsNullOrEmpty(r.cedula))
            {
                throw new Exception("Cédula requerida");
            }
            if (string.IsNullOrEmpty(r.nombre))
            {
                throw new Exception("Nombre requerido");
            }
            if (string.IsNullOrEmpty(r.fecha_reser.ToString()))
            {
                throw new Exception("Fecha requerida");
            }
            if (string.IsNullOrEmpty(r.telefono))
            {
                throw new Exception("Teléfono requerido");
            }
            if (r.cant_personas < 0)
            {
                throw new Exception("Cantidad de personas requerida");
            }
            if (r.id_seccion < 0 || string.IsNullOrEmpty(r.seccion))
            {
                throw new Exception("Seccion requerida");
            }
            if (r.id_mesa < 0 || string.IsNullOrEmpty(r.mesa) )
            {
                throw new Exception("Numero de mesa requerido");
            }
            if (string.IsNullOrEmpty(r.estado))
            {
                throw new Exception("Estado requerido");
            }
        }


        public void Confirmar(Reserva r)
        {
            try
            {
                Validar(r);
                rdal.Confirmar(r);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public void Eliminar(Reserva r)
        {
            try
            {
                Validar(r);
                rdal.Eliminar(r);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        

    }
}
