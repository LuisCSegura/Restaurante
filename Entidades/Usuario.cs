using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Usuario
    {
        public int id { get; set; }
        public int tipo { get; set; }
        public string codigo { get; set; }
        public string cedula { get; set; }
        public string nombre { get; set; }
        public string contrasenna { get; set; }
        public bool activo { get; set; }
       

        public Usuario()
        {

            activo = true;
        }
        public string GetTipoNombre()
        {
            switch (tipo)
            {
                case 0:
                    return "Administrador";
                case 1:
                    return "Cajero";
                case 2:
                    return "Jefe de Saloneros";
                case 3:
                    return "Salonero";
                case 4:
                    return "Bartender";
                case 5:
                    return "Cocinero";
                default:
                    return "Invitado";
            }   
        } 
        override
        public string ToString()
        {
            return codigo + " " + nombre;
        }
        public bool Equals(Usuario u)
        {
            return u.nombre == nombre && u.codigo==codigo;
        }

    }
}
