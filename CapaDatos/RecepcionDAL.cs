using Entidades;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class RecepcionDAL
    {

        public LinkedList<Mesa> CargarTodos()
        {
            Conexion conexion = new Conexion();
            LinkedList<Mesa> mesas = new LinkedList<Mesa>();
            String sqlCode = "SELECT m.id, m.numero, m.id_seccion, s.numero  FROM mesas as m join secciones as s on s.id = m.id_seccion WHERE m.id  " +
                " IN (select id_mesa from comandas where pagado = false)";
            sqlCode = string.Format(sqlCode);
            try
            {
                conexion.Conectar();
                NpgsqlCommand command = new NpgsqlCommand(sqlCode, conexion.con);
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
        private Mesa CargarNuevaMesa(NpgsqlDataReader rs)
        {
            Mesa m = new Mesa();
            Seccion s = new Seccion();

            m.id = int.Parse(rs.GetValue(0).ToString());
            m.numero = int.Parse(rs.GetValue(1).ToString());
            s.id = int.Parse(rs.GetValue(2).ToString());
            s.numero = int.Parse(rs.GetValue(3).ToString());
            m.seccion = s;
            return m;
        }


        //public LinkedList<Mesa> CargarMesas(Seccion sec)
        //{
        //    Conexion conexion = new Conexion();
        //    LinkedList<Mesa> mesas = new LinkedList<Mesa>();
        //    String sqlCode = "SELECT m.id,m.numero FROM secciones as s " +
        //       " INNER JOIN mesas as m ON m.id_seccion = s.id " +
        //       " WHERE s.id = " + sec.id + " and m.ocupada = false;";
        //    try
        //    {
        //        conexion.Conectar();
        //        NpgsqlCommand command = new NpgsqlCommand(sqlCode, conexion.con);
        //        NpgsqlDataReader rs = command.ExecuteReader();
        //        while (rs.Read())
        //        {
        //            UsuarioDAL usuDal = new UsuarioDAL();
        //            mesas.AddLast(CargarMesa(rs));
        //        }
        //    }
        //    catch (Exception e)
        //    {
        //        throw new Exception(e.Message);
        //    }
        //    finally
        //    {
        //        conexion.Desconectar();
        //    }

        //    return mesas;
        //}



        public LinkedList<Mesa> CargarMesas(Seccion sec, DateTime fecha, string hora)
        {
            Conexion conexion = new Conexion();
            LinkedList<Mesa> mesas = new LinkedList<Mesa>();
            String sqlCode = "SELECT id, numero, id_seccion  FROM mesas WHERE id not IN " +
                " (SELECT id_mesa FROM reservas WHERE fecha_reserva = @fecha AND hora = @hora AND id_seccion = @seccion) " +
                " and id not in (select id_mesa from comandas where pagado = false) and id_seccion = @seccion ";
            try
            {
                conexion.Conectar();
                NpgsqlCommand command = new NpgsqlCommand(sqlCode, conexion.con);
                command.Parameters.AddWithValue("@fecha", fecha);
                command.Parameters.AddWithValue("@hora", hora);
                command.Parameters.AddWithValue("@seccion", sec.id);
                command.Parameters.AddWithValue("@seccion", sec.id);
                NpgsqlDataReader rs = command.ExecuteReader();
                while (rs.Read())
                {
                    UsuarioDAL usuDal = new UsuarioDAL();
                    mesas.AddLast(CargarMesa(rs));
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

        private Mesa CargarMesa(NpgsqlDataReader rs)
        {
            Mesa m = new Mesa();
            m.id = int.Parse(rs.GetValue(0).ToString());
            m.numero = int.Parse(rs.GetValue(1).ToString());
            return m;
        }





    }
}
