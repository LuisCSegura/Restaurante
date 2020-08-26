using CapaDatos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class BebidaBOL
    {

        BebidaDAL bdal = new BebidaDAL();


        public LinkedList<Bebida> CargarTodos()
        {
            try
            {
                return bdal.CargarTodos();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }


        private void Validar(Bebida c)
        {
            if (string.IsNullOrEmpty(c.nombre))
            {
                throw new Exception("Nombre requerido");
            }
            if (string.IsNullOrEmpty(c.codigo))
            {
                throw new Exception("Código requerido");
            }
            if (string.IsNullOrEmpty(c.descripcion))
            {
                throw new Exception("Descripción requerida");
            }
            if (string.IsNullOrEmpty(c.categoria))
            {
                throw new Exception("Categoría requerida");
            }
            if (c.precio < 0)
            {
                throw new Exception("Precio requerido");
            }
        }

        public void Guardar(Bebida c)
        {
            try
            {
                Validar(c);

                if (c.id > 0)
                {
                    bdal.Modificar(c);
                }
                else
                {
                    bdal.Insertar(c);

                }

            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

        }

        public bool Autenticar(Bebida b)
        {
            return bdal.Autenticar(b);
        }


        public void Restaurar(Bebida b)
        {
            try
            {
                Validar(b);
                bdal.Restaurar(b);

            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }



        public void Eliminar(Bebida c)
        {
            try
            {
                bdal.Eliminar(c);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

    }



}

