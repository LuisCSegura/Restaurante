using Entidades;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class ComidaDAL
    {


        public LinkedList<Comida> CargarTodos()
        {
            LinkedList<Comida> comidas = new LinkedList<Comida>();
            Conexion conexion = new Conexion();

            String sqlCode = "SELECT id,codigo,nombre,categoria,descripcion, precio FROM comidas" +
                " WHERE activo = true; ";
            try
            {
                conexion.Conectar();
                NpgsqlCommand command = new NpgsqlCommand(sqlCode, conexion.con);
                NpgsqlDataReader rs = command.ExecuteReader();
                while (rs.Read())
                {
                    comidas.AddLast(CargarComida(rs));
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
            return comidas;

        }




        public Comida CargarComida(NpgsqlDataReader rs)
        {
            Comida c = new Comida();
            c.id = int.Parse(rs.GetValue(0).ToString());
            c.codigo = rs.GetValue(1).ToString();
            c.nombre = rs.GetValue(2).ToString();
            c.categoria = rs.GetValue(3).ToString();
            c.descripcion = rs.GetValue(4).ToString();
            c.precio = double.Parse(rs.GetValue(5).ToString());
            return c;
        }


        public void Insertar(Comida c)
        {

            Conexion conexion = new Conexion();

            String sqlCode = "INSERT INTO comidas(codigo,nombre,categoria,descripcion,precio) " +
                "VALUES ('{0}','{1}','{2}','{3}',{4});";
            sqlCode = string.Format(sqlCode, c.codigo, c.nombre, c.categoria, c.descripcion, c.precio);

            try
            {

                conexion.Conectar();
                NpgsqlCommand command = new NpgsqlCommand(sqlCode, conexion.con);
                command.ExecuteNonQuery();
            }
            catch (NpgsqlException e)
            {
                throw new Exception("El codigo no esta disponible");
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


        public void Modificar(Comida c)
        {

            Conexion conexion = new Conexion();

            String sqlCode = "UPDATE comidas SET codigo='{0}',nombre='{1}',categoria='{2}',descripcion='{3}',precio={4}" +
                " WHERE id = {5}; ";
            sqlCode = string.Format(sqlCode, c.codigo, c.nombre, c.categoria, c.descripcion, c.precio, c.id);

            try
            {
                conexion.Conectar();
                NpgsqlCommand command = new NpgsqlCommand(sqlCode, conexion.con);
                command.ExecuteNonQuery();
            }
            catch (NpgsqlException e)
            {
                throw new Exception("El codigo no esta disponible");
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


       

        public void Eliminar(Comida c)
        {
            Conexion conexion = new Conexion();

            String sqlCode = "UPDATE comidas SET activo=false" +
                " WHERE id = {0}";
            sqlCode = string.Format(sqlCode, c.id);

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



        public bool Autenticar(Comida c)
        {
            Conexion conexion = new Conexion();

            String sqlCode = "SELECT codigo, activo FROM comidas WHERE codigo = @codigo and activo = false ";
            sqlCode = string.Format(sqlCode);

            try
            {
                conexion.Conectar();
                NpgsqlCommand command = new NpgsqlCommand(sqlCode, conexion.con);
                command.Parameters.AddWithValue("@codigo", c.codigo);
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



        public void Restaurar(Comida c)
        {

            Conexion conexion = new Conexion();

            String sqlCode = "UPDATE comidas SET nombre='{0}',categoria='{1}',descripcion='{2}',precio='{3}', activo = true WHERE codigo = '{4}' ";
            sqlCode = string.Format(sqlCode, c.nombre, c.categoria, c.descripcion, c.precio, c.codigo);

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

    }
}
