using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Npgsql;

namespace CapaDatos
{
    public class UsuarioDAL
    {
        public LinkedList<Usuario> CargarTodos()
        {
            LinkedList<Usuario> usuarios = new LinkedList<Usuario>();
            Conexion conexion = new Conexion();
            
                String sqlCode = "SELECT id,codigo,cedula,nombre,contrasenna,tipo FROM usuarios" +
                    " WHERE activo = true; ";
                try
                {
                    conexion.Conectar();
                    NpgsqlCommand command = new NpgsqlCommand(sqlCode, conexion.con);
                    NpgsqlDataReader rs = command.ExecuteReader();
                    while (rs.Read())
                    {
                        usuarios.AddLast(CargarNuevoUsuario(rs));
                    }
                }
                catch (Exception e)
                {
                    throw new Exception(e.Message);
                }
                finally
                {
                    conexion.Desconectar();
                }
                return usuarios;
            
        }

        public LinkedList<Usuario> CargarSaloneros()
        {
            LinkedList<Usuario> usuarios = new LinkedList<Usuario>();
            Conexion conexion = new Conexion();

            String sqlCode = "SELECT id,codigo,cedula,nombre,contrasenna,tipo FROM usuarios" +
                " WHERE activo = true AND tipo = 3; ";
            try
            {
                conexion.Conectar();
                NpgsqlCommand command = new NpgsqlCommand(sqlCode, conexion.con);
                NpgsqlDataReader rs = command.ExecuteReader();
                while (rs.Read())
                {
                    usuarios.AddLast(CargarNuevoUsuario(rs));
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                conexion.Desconectar();
            }
            return usuarios;
        }

        public Usuario CargarNuevoUsuario(NpgsqlDataReader rs)
        {
            Usuario u = new Usuario();
            u.id= int.Parse(rs.GetValue(0).ToString());
            u.codigo = rs.GetValue(1).ToString();
            u.cedula = rs.GetValue(2).ToString();
            u.nombre = rs.GetValue(3).ToString();
            u.contrasenna = rs.GetValue(4).ToString();
            u.tipo = int.Parse(rs.GetValue(5).ToString());
            return u;
        }
        public void InsertarNuevo(Usuario u)
        {
            
            Conexion conexion = new Conexion();

            String sqlCode = "INSERT INTO usuarios(codigo,cedula,nombre,contrasenna,tipo) " +
                "VALUES ('{0}','{1}','{2}','{3}',{4});";
            sqlCode=string.Format(sqlCode,u.codigo,u.cedula,u.nombre,u.contrasenna,u.tipo);

            try
            {
                conexion.Conectar();
                NpgsqlCommand command = new NpgsqlCommand(sqlCode, conexion.con);
                command.ExecuteNonQuery();
            }
            catch(NpgsqlException sqle)
            {
                throw new Exception("El nombre de usuario no esta disponble");
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                conexion.Desconectar();
            }

        }
        public void Editar(Usuario u)
        {
            
            Conexion conexion = new Conexion();

            String sqlCode = "UPDATE usuarios SET codigo='{0}',cedula='{1}',nombre='{2}',contrasenna='{3}',tipo={4}" +
                " WHERE id = {5}; ";
            sqlCode = string.Format(sqlCode, u.codigo, u.cedula, u.nombre, u.contrasenna, u.tipo,u.id);

            try
            {
                conexion.Conectar();
                NpgsqlCommand command = new NpgsqlCommand(sqlCode, conexion.con);
                command.ExecuteNonQuery();
            }
            catch (NpgsqlException sqle)
            {
                throw new Exception("El nombre de usuario no esta disponble");
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                conexion.Desconectar();
            }
        }
        public void Eliminar(Usuario u)
        {
            
            Conexion conexion = new Conexion();

            String sqlCode = "UPDATE usuarios SET activo=false" +
                " WHERE id = {0}; ";
            sqlCode = string.Format(sqlCode, u.id);

            try
            {
                conexion.Conectar();
                NpgsqlCommand command = new NpgsqlCommand(sqlCode, conexion.con);
                command.ExecuteNonQuery();
            }
            catch (NpgsqlException sqle)
            {
                throw new Exception("Error al eliminiar el registro");
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                conexion.Desconectar();
            }
        }




        public bool Autenticar(Usuario c)
        {
            Conexion conexion = new Conexion();

            String sqlCode = "SELECT nombre, activo FROM usuarios WHERE nombre = @nombre and activo = false ";
            sqlCode = string.Format(sqlCode);

            try
            {
                conexion.Conectar();
                NpgsqlCommand command = new NpgsqlCommand(sqlCode, conexion.con);
                command.Parameters.AddWithValue("@nombre", c.nombre);
                NpgsqlDataReader rs = command.ExecuteReader();

                if (rs.Read())
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

            finally
            {
                conexion.Desconectar();
            }


        }



        public void Restaurar(Usuario c)
        {


            Conexion conexion = new Conexion();

            String sqlCode = "UPDATE usuarios SET codigo='{0}', cedula='{1}', contrasenna='{2}', tipo = '{3}', activo = true WHERE nombre = '{4}' ";
            sqlCode = string.Format(sqlCode,c.codigo, c.cedula, c.contrasenna, c.tipo, c.nombre);

            try
            {
                conexion.Conectar();
                NpgsqlCommand command = new NpgsqlCommand(sqlCode, conexion.con);
                command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                conexion.Desconectar();
            }
        }
        public void Loguear(Usuario c)
        {
            Conexion conexion = new Conexion();

            String sqlCode = "SELECT id,codigo,cedula,nombre,contrasenna,tipo FROM usuarios" +
                    " WHERE activo = true AND nombre = '{0}' AND contrasenna = '{1}'; ";
            sqlCode = string.Format(sqlCode, c.nombre, c.contrasenna);

            try
            {
                conexion.Conectar();
                NpgsqlCommand command = new NpgsqlCommand(sqlCode, conexion.con);
                NpgsqlDataReader rs = command.ExecuteReader();

                if (rs.Read())
                {
                    Usuario nuevo = CargarNuevoUsuario(rs);
                    c.id = nuevo.id;
                    c.tipo = nuevo.tipo;
                    c.codigo = nuevo.codigo;
                    c.cedula = nuevo.cedula;
                }
                else
                {
                    c.id = 0;
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

            finally
            {
                conexion.Desconectar();
            }


        }

    }
}
