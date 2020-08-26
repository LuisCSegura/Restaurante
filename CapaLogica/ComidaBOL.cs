using CapaDatos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class ComidaBOL
    {
        ComidaDAL cdal = new ComidaDAL();


        public LinkedList<Comida> CargarTodos()
        {
            try
            {
                return cdal.CargarTodos();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }


        private void Validar(Comida c)
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
            if(c.precio < 0)
            {
                throw new Exception("Precio requerido");
            }
        }

        public void Guardar(Comida c)
        {
            try
            {
                Validar(c);

                if(c.id > 0)
                {
                    cdal.Modificar(c);
                }
                else
                {
                    cdal.Insertar(c);
                    
                }
                
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
           
        }


        public void Eliminar(Comida c)
        {
            try
            {
                cdal.Eliminar(c);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }



        public bool Autenticar(Comida b)
        {
            return cdal.Autenticar(b); 
        }


        public void Restaurar(Comida b)
        {
            try
            {
                Validar(b);
                cdal.Restaurar(b);

            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }


    }
}
