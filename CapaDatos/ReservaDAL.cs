using Entidades;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
     public class ReservaDAL
    {

        public LinkedList<Reserva> CargarTodos()
        {
            LinkedList<Reserva> reservas = new LinkedList<Reserva>();
            Conexion conexion = new Conexion();

            String sqlCode = "SELECT id, cedula, nombre, fecha, fecha_reserva, hora, telefono, cant_personas,id_seccion, id_mesa,seccion, mesa, estado, activo FROM reservas" +
                " WHERE activo = true;";
            try
            {
                conexion.Conectar();
                NpgsqlCommand command = new NpgsqlCommand(sqlCode, conexion.con);
                NpgsqlDataReader rs = command.ExecuteReader();
                while (rs.Read())
                {
                    reservas.AddLast(CargarReserva(rs));
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
            return reservas;

        }

        public Reserva CargarReserva(NpgsqlDataReader rs)
        {
            Reserva c = new Reserva();
            c.id = int.Parse(rs.GetValue(0).ToString());
            c.cedula = rs.GetValue(1).ToString();
            c.nombre = rs.GetValue(2).ToString();
            c.fecha = Convert.ToDateTime(rs.GetValue(3));
            c.fecha_reser = Convert.ToDateTime(rs.GetValue(4));
            c.hora = rs.GetValue(5).ToString();
            c.telefono = rs.GetValue(6).ToString();
            c.cant_personas = int.Parse(rs.GetValue(7).ToString());
            c.id_seccion = int.Parse(rs.GetValue(8).ToString());
            c.id_mesa = int.Parse(rs.GetValue(9).ToString());
            c.seccion = rs.GetValue(10).ToString();
            c.mesa = rs.GetValue(11).ToString();
            c.estado = rs.GetValue(12).ToString();
            c.activo = Boolean.Parse(rs.GetValue(13).ToString());
            return c;
        }





        public void Insertar(Reserva c)
        {

            Conexion conexion = new Conexion();

            String sqlCode = "INSERT INTO reservas(cedula, nombre, fecha, fecha_reserva, hora, telefono, cant_personas, id_seccion, id_mesa, seccion, mesa, estado, activo) " +
                " VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}','{12}');";
            sqlCode = string.Format(sqlCode, c.cedula, c.nombre, c.fecha, c.fecha_reser, c.hora, c.telefono, c.cant_personas, c.id_seccion, c.id_mesa, c.seccion, c.mesa, c.estado, c.activo);

            try
            {

                conexion.Conectar();
                NpgsqlCommand command = new NpgsqlCommand(sqlCode, conexion.con);
                command.ExecuteNonQuery();
            }
            catch (NpgsqlException e)
            {
               // throw new Exception("El codigo no esta disponible");
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

        public void Confirmar(Reserva r)
        {

            Conexion conexion = new Conexion();

            String sqlCode = "UPDATE reservas SET cedula='{0}',nombre='{1}',fecha='{2}',fecha_reserva='{3}',hora='{4}',telefono='{5}',cant_personas='{6}', id_seccion='{7}', id_mesa='{8}', seccion='{9}',mesa='{10}',estado='{11}',activo='{12}' " +
                " WHERE id = '{13}'; ";
            sqlCode = string.Format(sqlCode, r.cedula, r.nombre, r.fecha, r.fecha_reser, r.hora, r.telefono, r.cant_personas, r.id_seccion, r.id_mesa, r.seccion,r.mesa,r.estado, r.activo, r.id);

            try
            {
                conexion.Conectar();
                NpgsqlCommand command = new NpgsqlCommand(sqlCode, conexion.con);
                command.ExecuteNonQuery();
            }
            catch (NpgsqlException e)
            {
                //throw new Exception("El codigo no esta disponible");
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


        public void Eliminar(Reserva r)
        {
            Conexion conexion = new Conexion();

            String sqlCode = "DELETE FROM reservas " +
                " WHERE id = {0}";
            sqlCode = string.Format(sqlCode, r.id);

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


        public LinkedList<Reserva> Autenticar(Seccion sec, DateTime fecha, string hora)
        {
            LinkedList<Reserva> reservas = new LinkedList<Reserva>();
            Reserva r = new Reserva();
            Conexion conexion = new Conexion();

            String sqlCode = "SELECT id, id_seccion, id_mesa FROM reservas WHERE fecha_reserva = @fecha_reserva AND hora = @hora AND id_seccion = @sec";
            sqlCode = string.Format(sqlCode);

            try
            {
                conexion.Conectar();
                NpgsqlCommand command = new NpgsqlCommand(sqlCode, conexion.con);
                command.Parameters.AddWithValue("@fecha_reserva", fecha);
                command.Parameters.AddWithValue("@hora", hora);
                command.Parameters.AddWithValue("@sec", sec.id);
                NpgsqlDataReader rs = command.ExecuteReader();

                while (rs.Read())
                 {
                    
                    r.id = (int)rs.GetValue(0);
                    r.id_seccion = (int)rs.GetValue(1);
                    r.id_mesa = (int)rs.GetValue(2);
                    // return r;
                    reservas.AddLast(r);
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
            return reservas;

        }




        public LinkedList<Mesa> CargarMesas(Seccion sec, DateTime fecha, string hora)
        {
            Conexion conexion = new Conexion();
            LinkedList<Mesa> mesas = new LinkedList<Mesa>();
            String sqlCode = "SELECT id, numero FROM mesas WHERE id not IN (SELECT  id_mesa FROM reservas " +
                " WHERE fecha_reserva = @fecha AND hora = @hora AND id_seccion = @id_seccion) and id_seccion = @id_seccion ";
            sqlCode = string.Format(sqlCode);
            try
            {
                conexion.Conectar();
                NpgsqlCommand command = new NpgsqlCommand(sqlCode, conexion.con);
                command.Parameters.AddWithValue("@fecha", fecha);
                command.Parameters.AddWithValue("@hora", hora);
                command.Parameters.AddWithValue("@id_seccion", sec.id);
                command.Parameters.AddWithValue("@id_seccion", sec.id);
                NpgsqlDataReader rs = command.ExecuteReader();
                while (rs.Read())
                {
                    
                    mesas.AddLast(CargarNuevaMesa(rs));
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

            return mesas;
        }

        private Mesa CargarNuevaMesa( NpgsqlDataReader rs)
        {
            Mesa m = new Mesa();
            m.id = int.Parse(rs.GetValue(0).ToString());
            m.numero = int.Parse(rs.GetValue(1).ToString());
           // m.seccion = sec;
            return m;
        }








    }
}
