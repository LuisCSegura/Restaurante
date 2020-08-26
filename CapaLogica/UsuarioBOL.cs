using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using Entidades;
using System.Windows.Forms;

namespace CapaLogica
{
    public class UsuarioBOL
    {
        UsuarioDAL usuDal = new CapaDatos.UsuarioDAL();
        public LinkedList<Usuario> CargarTodos()
        {
            try
            {
                return usuDal.CargarTodos();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public LinkedList<Usuario> CargarSaloneros()
        {
            try
            {
                return usuDal.CargarSaloneros();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public void InsertarNuevo(Usuario u)
        {
            try
            {
                Validar(u);
                AsignarCodigo(u);
                u.contrasenna=Encriptar(u.contrasenna);
                usuDal.InsertarNuevo(u);
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }

        }
        private void Validar(Usuario u)
        {
            if (string.IsNullOrEmpty(u.nombre)||u.nombre=="USUARIO")
            {
                throw new Exception("Debe digitar un nombre de usuario valido");
            }
            if (u.cedula==null||u.cedula.Length<3)
            {
                throw new Exception("Debe digitar una cedula valida");
            }
            if (u.contrasenna==null || (!(u.contrasenna.Length >= 8)) || u.contrasenna=="CONTRASEÑA")
            {
                throw new Exception("Debe digitar una conotraseña valida");
            }
            if (u.tipo < 0)
            {
                throw new Exception("Debe seleccionar un tipo de usuario");
            }
        }
        private void AsignarCodigo(Usuario u)
        {
            string codigo = "";
            codigo += u.GetTipoNombre()[0];
            codigo += u.GetTipoNombre()[1];
            codigo += u.GetTipoNombre()[2];
            codigo += u.cedula[u.cedula.Length-3];
            codigo += u.cedula[u.cedula.Length-2];
            codigo += u.cedula[u.cedula.Length-1];
            u.codigo = codigo.ToUpper();
        }
        private string Encriptar(string contrasenna)
        {
            string result = string.Empty;
            byte[] encryted = System.Text.Encoding.Unicode.GetBytes(contrasenna);
            result = Convert.ToBase64String(encryted);
            return result;
        }
        public void Editar(Usuario u)
        {
            try
            {
                Validar(u);
                AsignarCodigo(u);
                u.contrasenna = Encriptar(u.contrasenna);
                usuDal.Editar(u);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public void Eliminar(Usuario u)
        {
            try
            {
                usuDal.Eliminar(u);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }



        public bool Autenticar(Usuario b)
        {
            return usuDal.Autenticar(b);
        }


        public void Restaurar(Usuario b)
        {
            try
            {
                Validar(b);
                AsignarCodigo(b);
                b.contrasenna = Encriptar(b.contrasenna);
                usuDal.Restaurar(b);


            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public void Loguear(Usuario b)
        {
            try
            {
                Validar(b);
                b.contrasenna = Encriptar(b.contrasenna);
                usuDal.Loguear(b);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

    }
}
