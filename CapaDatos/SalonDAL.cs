using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Npgsql;

namespace CapaDatos
{
    public class SalonDAL
    {
        public LinkedList<Seccion> CargarTodas()
        {
            LinkedList<Seccion> secciones = new LinkedList<Seccion>();
            Conexion conexion = new Conexion();

            String sqlCode = "SELECT id,numero,cantidad_mesas,id_salonero FROM secciones" +
                " WHERE activo = true AND id <> 7; ";
            try
            {
                conexion.Conectar();
                NpgsqlCommand command = new NpgsqlCommand(sqlCode, conexion.con);
                NpgsqlDataReader rs = command.ExecuteReader();
                while (rs.Read())
                {
                    secciones.AddLast(CargarNuevaSeccion(rs));
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
            return secciones;

        }

        

        private Seccion CargarNuevaSeccion(NpgsqlDataReader rs)
        {
            try
            {
                Seccion sec = CargarDatosSeccion(rs);
                sec.mesas = CargarMesas(sec);
                return sec;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            
        }
        private Seccion CargarDatosSeccion(NpgsqlDataReader rs)
        {
            try
            {
                Seccion sec = new Seccion();
                sec.id = int.Parse(rs.GetValue(0).ToString());
                sec.numero = int.Parse(rs.GetValue(1).ToString());
                sec.cantidadMesas = int.Parse(rs.GetValue(2).ToString());
                sec.salonero = CargarSalonero(sec);
                return sec;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

        }



        public LinkedList<Mesa> CargarMesas(Seccion sec)
        {
            Conexion conexion = new Conexion();
            LinkedList<Mesa> mesas = new LinkedList<Mesa>();
            String sqlCode = "SELECT m.id,m.numero FROM secciones as s " +
               " INNER JOIN mesas as m ON m.id_seccion = s.id " +
               " WHERE s.id = " + sec.id + ";";
            try
            {
                conexion.Conectar();
                NpgsqlCommand command = new NpgsqlCommand(sqlCode, conexion.con);
                NpgsqlDataReader rs = command.ExecuteReader();
                while (rs.Read())
                {
                    UsuarioDAL usuDal = new UsuarioDAL();
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

        public Mesa CargarNuevaMesa(NpgsqlDataReader rs)
        {
            Mesa m = new Mesa();
            m.id = int.Parse(rs.GetValue(0).ToString());
            m.numero = int.Parse(rs.GetValue(1).ToString());
            m.seccion = CargarSeccionMesa(m);
            return m;
        }
        private Seccion CargarSeccionMesa(Mesa mesa)
        {
            
            Conexion conexion = new Conexion();

            String sqlCode = "SELECT s.id,s.numero,s.cantidad_mesas FROM mesas as m" +
                " INNER JOIN secciones as s ON m.id_seccion = s.id" +
                " WHERE m.id ="+mesa.id+";";
            try
            {
                conexion.Conectar();
                NpgsqlCommand command = new NpgsqlCommand(sqlCode, conexion.con);
                NpgsqlDataReader rs = command.ExecuteReader();
                if (rs.Read())
                {
                    return CargarDatosSeccion(rs);
                }
                else
                {
                    return new Seccion();
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


        private Usuario CargarSalonero(Seccion sec)
        {
            Conexion conexion = new Conexion();
            Usuario u = new Usuario();
            String sqlCode = "SELECT u.id,u.codigo,u.cedula,u.nombre,u.contrasenna,u.tipo FROM secciones as s " +
                " INNER JOIN usuarios as u ON u.id = s.id_salonero " +
                " WHERE s.id = "+sec.id+";";
            try
            {
                conexion.Conectar();
                NpgsqlCommand command = new NpgsqlCommand(sqlCode,conexion.con);
                NpgsqlDataReader rs = command.ExecuteReader();
                if (rs.Read())
                {
                    UsuarioDAL usuDal = new UsuarioDAL();
                    u=usuDal.CargarNuevoUsuario(rs);
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
            return u;
        }
        public void InsertarNueva(Seccion s)
        {
            Conexion conexion = new Conexion();

            String sqlCode = "INSERT INTO secciones(numero,cantidad_mesas,id_salonero) " +
                "VALUES ('{0}','{1}','{2}');";
            sqlCode = string.Format(sqlCode,s.numero,s.cantidadMesas,s.salonero.id);

            try
            {
                conexion.Conectar();
                NpgsqlCommand command = new NpgsqlCommand(sqlCode, conexion.con);
                command.ExecuteNonQuery();
                InsertarMesas(s);
            }
            catch (NpgsqlException sqle)
            {
                throw new Exception("El numero de seccion no esta disponible");
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
        private int ObtIdSec(Seccion s)
        {
            Conexion conexion = new Conexion();

            String sqlCode = "SELECT id FROM secciones" +
                " WHERE activo = true AND numero = "+s.numero+"; ";
            try
            {
                conexion.Conectar();
                NpgsqlCommand command = new NpgsqlCommand(sqlCode, conexion.con);
                NpgsqlDataReader rs = command.ExecuteReader();
                if (rs.Read())
                {
                    return int.Parse(rs.GetValue(0).ToString());
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
            return 1;
        }

        private void InsertarMesas(Seccion s)
        {
            Conexion conexion = new Conexion();
            s.id = ObtIdSec(s);

            String sqlCode = "INSERT  INTO mesas(numero,id_seccion) VALUES (1,{0}),(2,{1}),(3,{2}),(4,{3}),(5,{4}),(6,{5});";
            sqlCode = string.Format(sqlCode, s.id, s.id, s.id, s.id, s.id, s.id);

            try
            {
                conexion.Conectar();
                NpgsqlCommand command = new NpgsqlCommand(sqlCode, conexion.con);
                command.ExecuteNonQuery();
            }
            catch (NpgsqlException sqle)
            {
                throw new Exception(sqle.Message);
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
        public void Actualizar(Seccion s)
        {
            Conexion conexion = new Conexion();

            String sqlCode = "UPDATE secciones SET numero={0},id_salonero={1} WHERE id={2};";
            sqlCode = string.Format(sqlCode, s.numero, s.salonero.id, s.id);

            try
            {
                conexion.Conectar();
                NpgsqlCommand command = new NpgsqlCommand(sqlCode, conexion.con);
                command.ExecuteNonQuery();
            }
            catch (NpgsqlException sqle)
            {
                throw new Exception("El numero no esta disponible");
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
        public void Eliminar(Seccion s)
        {
            Conexion conexion = new Conexion();

            String sqlCode = "UPDATE secciones SET activo=false WHERE id={0};" +
                "UPDATE mesas SET activo = false WHERE id_seccion = {1}; ";
            sqlCode = string.Format(sqlCode, s.id,s.id);

            try
            {
                conexion.Conectar();
                NpgsqlCommand command = new NpgsqlCommand(sqlCode, conexion.con);
                command.ExecuteNonQuery();
            }
            catch (NpgsqlException sqle)
            {
                throw new Exception("Problemas en la base de datos");
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
        public Seccion CargarSeccionSalonero(Usuario sal)
        {
            Conexion conexion = new Conexion();

            String sqlCode = "SELECT id,numero,cantidad_mesas,id_salonero FROM secciones" +
                " WHERE activo = true AND id_salonero = "+sal.id+";";
            try
            {
                conexion.Conectar();
                NpgsqlCommand command = new NpgsqlCommand(sqlCode, conexion.con);
                NpgsqlDataReader rs = command.ExecuteReader();
                if (rs.Read())
                {
                    return CargarNuevaSeccion(rs);
                }
                else
                {
                    return null;
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
