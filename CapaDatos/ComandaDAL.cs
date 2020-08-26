using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Npgsql;

namespace CapaDatos
{
    public class ComandaDAL
    {
        public Comanda CargarComandaMesa(Mesa mesa)
        {
            
            Conexion conexion = new Conexion();

            String sqlCode = "SELECT id," +
                " EXTRACT(YEAR FROM tiempo)AS anno," +
                " EXTRACT(MONTH FROM tiempo)AS mes," +
                " EXTRACT(DAY FROM tiempo)AS dia," +
                " EXTRACT(HOUR FROM tiempo)AS hora," +
                " EXTRACT(MINUTE FROM tiempo)AS minuto" +
                " FROM comandas WHERE id_mesa = "+mesa.id+" AND pagado = false; ";
            try
            {
                conexion.Conectar();
                NpgsqlCommand command = new NpgsqlCommand(sqlCode, conexion.con);
                NpgsqlDataReader rs = command.ExecuteReader();
                if (rs.Read())
                {
                    return CargarNuevaComanda(rs);
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

       

        public Comanda CargarNuevaComanda(NpgsqlDataReader rs)
        {
            Comanda c = new Comanda();
            c.id = int.Parse(rs.GetValue(0).ToString());
            c.tiempo = new DateTime(int.Parse(rs.GetValue(1).ToString()),
                int.Parse(rs.GetValue(2).ToString()),
                int.Parse(rs.GetValue(3).ToString()),
                int.Parse(rs.GetValue(4).ToString()),
                int.Parse(rs.GetValue(5).ToString()),0);
            c.mesa = CargarMesaComanda(c);
            c.salonero = CargarSaloneroComanda(c);
            c.bebidas = CargarBebidas(c);
            c.comidas = CargarComidas(c);
            return c;
        }

        private Mesa CargarMesaComanda(Comanda c)
        {
            Conexion conexion = new Conexion();
            String sqlCode = "SELECT m.id,m.numero FROM comandas as c " +
               " INNER JOIN mesas as m ON c.id_mesa = m.id " +
               " WHERE c.id = " + c.id + ";";
            try
            {
                conexion.Conectar();
                NpgsqlCommand command = new NpgsqlCommand(sqlCode, conexion.con);
                NpgsqlDataReader rs = command.ExecuteReader();
                if (rs.Read())
                {
                    SalonDAL salDal = new SalonDAL();
                    return salDal.CargarNuevaMesa(rs);
                }
                else
                {
                    return new Mesa();
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

        private LinkedList<OrdenComida> CargarComidas(Comanda c)
        {
            Conexion conexion = new Conexion();
            LinkedList<OrdenComida> comidas = new LinkedList<OrdenComida>();
            String sqlCode = "SELECT oc.id,oc.cantidad,oc.preparado,EXTRACT(YEAR FROM oc.tiempo_servicio)AS anno," +
                " EXTRACT(MONTH FROM oc.tiempo_servicio)AS mes," +
                " EXTRACT(DAY FROM oc.tiempo_servicio)AS dia," +
                " EXTRACT(HOUR FROM oc.tiempo_servicio)AS hora," +
                " EXTRACT(MINUTE FROM oc.tiempo_servicio)AS minuto" +
                " FROM comandas as c" +
                " INNER JOIN ordenes_comida as oc ON oc.id_comanda = c.id" +
                " WHERE c.id = "+c.id+";";
            try
            {
                conexion.Conectar();
                NpgsqlCommand command = new NpgsqlCommand(sqlCode, conexion.con);
                NpgsqlDataReader rs = command.ExecuteReader();
                while (rs.Read())
                {
                    comidas.AddLast(NuevaOrdenComida(rs,c));
                }
                return comidas;
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

        
        private OrdenComida NuevaOrdenComida(NpgsqlDataReader rs,Comanda c)
        {
            OrdenComida oc = new OrdenComida();
            oc.id = int.Parse(rs.GetValue(0).ToString());
            oc.cantidad = int.Parse(rs.GetValue(1).ToString());
            oc.preparado = bool.Parse(rs.GetValue(2).ToString());
            oc.tiempoServicio = new DateTime(int.Parse(rs.GetValue(3).ToString()),
                int.Parse(rs.GetValue(4).ToString()),
                int.Parse(rs.GetValue(5).ToString()),
                int.Parse(rs.GetValue(6).ToString()),
                int.Parse(rs.GetValue(7).ToString()), 0);
            oc.comanda = c;
            oc.comida = CargarComidaOrden(oc);
            return oc;
        }

        public Comida CargarComidaOrden(OrdenComida oc)
        {
            Conexion conexion = new Conexion();
            String sqlCode = "SELECT c.id,c.codigo,c.nombre,c.categoria,c.descripcion, c.precio FROM ordenes_comida as oc " +
                " INNER JOIN comidas as c ON c.id = oc.id_comida " +
                " WHERE oc.id = "+oc.id+";";
            try
            {
                conexion.Conectar();
                NpgsqlCommand command = new NpgsqlCommand(sqlCode, conexion.con);
                NpgsqlDataReader rs = command.ExecuteReader();
                if (rs.Read())
                {
                    ComidaDAL comiDal = new ComidaDAL();
                    return comiDal.CargarComida(rs);
                }
                else
                {

                return new Comida();
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

        private LinkedList<OrdenBebida> CargarBebidas(Comanda c)
        {
            Conexion conexion = new Conexion();
            LinkedList<OrdenBebida> bebidas = new LinkedList<OrdenBebida>();
            String sqlCode = "SELECT ob.id,ob.cantidad,ob.preparado,EXTRACT(YEAR FROM ob.tiempo_servicio)AS anno," +
                " EXTRACT(MONTH FROM ob.tiempo_servicio)AS mes," +
                " EXTRACT(DAY FROM ob.tiempo_servicio)AS dia," +
                " EXTRACT(HOUR FROM ob.tiempo_servicio)AS hora," +
                " EXTRACT(MINUTE FROM ob.tiempo_servicio)AS minuto" +
                " FROM comandas as c" +
                " INNER JOIN ordenes_bebida as ob ON ob.id_comanda = c.id" +
                " WHERE c.id = " + c.id + ";";
            try
            {
                conexion.Conectar();
                NpgsqlCommand command = new NpgsqlCommand(sqlCode, conexion.con);
                NpgsqlDataReader rs = command.ExecuteReader();
                while (rs.Read())
                {
                    bebidas.AddLast(NuevaOrdenBebida(rs, c));
                }
                return bebidas;
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

        private OrdenBebida NuevaOrdenBebida(NpgsqlDataReader rs, Comanda c)
        {
            OrdenBebida ob = new OrdenBebida();
            ob.id = int.Parse(rs.GetValue(0).ToString());
            ob.cantidad = int.Parse(rs.GetValue(1).ToString());
            ob.preparado = bool.Parse(rs.GetValue(2).ToString());
            ob.tiempoServicio = new DateTime(int.Parse(rs.GetValue(3).ToString()),
                int.Parse(rs.GetValue(4).ToString()),
                int.Parse(rs.GetValue(5).ToString()),
                int.Parse(rs.GetValue(6).ToString()),
                int.Parse(rs.GetValue(7).ToString()), 0);
            ob.comanda = c;
            ob.bebida = CargarBebidaOrden(ob);
            return ob;
        }

        public Bebida CargarBebidaOrden(OrdenBebida ob)
        {
            Conexion conexion = new Conexion();
            String sqlCode = "SELECT b.id,b.codigo,b.nombre,b.categoria,b.descripcion, b.precio FROM ordenes_bebida as ob " +
                " INNER JOIN bebidas as b ON b.id = ob.id_bebida " +
                " WHERE ob.id = " + ob.id + ";";
            try
            {
                conexion.Conectar();
                NpgsqlCommand command = new NpgsqlCommand(sqlCode, conexion.con);
                NpgsqlDataReader rs = command.ExecuteReader();
                if (rs.Read())
                {
                    BebidaDAL bebiDal = new BebidaDAL();
                    return bebiDal.CargarBebida(rs);
                }
                else
                {
                    return new Bebida();
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

        private Usuario CargarSaloneroComanda(Comanda c)
        {
            Conexion conexion = new Conexion();

            String sqlCode = "SELECT u.id,u.codigo,u.cedula,u.nombre,u.contrasenna,u.tipo FROM comandas as c" +
                " INNER JOIN usuarios as u ON c.id_salonero = u.id" +
                " WHERE c.id = "+c.id+";";
            try
            {
                conexion.Conectar();
                NpgsqlCommand command = new NpgsqlCommand(sqlCode, conexion.con);
                NpgsqlDataReader rs = command.ExecuteReader();
                if (rs.Read())
                {
                    UsuarioDAL usuDal = new UsuarioDAL();
                    return usuDal.CargarNuevoUsuario(rs);
                }
                else
                {
                    return new Usuario();
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
        public void InsertarComanda(Comanda com)
        {
            Conexion conexion = new Conexion();

            String sqlCode = "INSERT INTO comandas(id_salonero,id_mesa,tiempo)" +
                " VALUES({0},{1},'{2}/{3}/{4} {5}:{6}:00.00');";
            sqlCode = string.Format(sqlCode, com.salonero.id, com.mesa.id,
                com.tiempo.Year,com.tiempo.Month,com.tiempo.Day,com.tiempo.Hour,com.tiempo.Minute);

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
        public void InsertarOrdenComida(OrdenComida oc)
        {
            Conexion conexion = new Conexion();

            String sqlCode = "INSERT INTO ordenes_comida(cantidad,id_comida,id_comanda,preparado,tiempo_servicio)" +
                " VALUES({0},{1},{2},{3},'{4}/{5}/{6} {7}:{8}:00.00');";
            sqlCode = string.Format(sqlCode, oc.cantidad,oc.comida.id,oc.comanda.id,oc.preparado,
                oc.tiempoServicio.Year, oc.tiempoServicio.Month, oc.tiempoServicio.Day,
                oc.tiempoServicio.Hour, oc.tiempoServicio.Minute);

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
        public void ActualizarOrdenComida(OrdenComida oc)
        {
            Conexion conexion = new Conexion();

            String sqlCode = "UPDATE ordenes_comida SET cantidad={0},preparado={1},tiempo_servicio='{2}/{3}/{4} {5}:{6}:00.00' WHERE id={7};";
            sqlCode = string.Format(sqlCode, oc.cantidad,oc.preparado,
                oc.tiempoServicio.Year, oc.tiempoServicio.Month, oc.tiempoServicio.Day,
                oc.tiempoServicio.Hour, oc.tiempoServicio.Minute, oc.id);

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
        public void InsertarOrdenBebida(OrdenBebida ob)
        {
            Conexion conexion = new Conexion();

            String sqlCode = "INSERT INTO ordenes_bebida(cantidad,id_bebida,id_comanda,preparado,tiempo_servicio)" +
                " VALUES({0},{1},{2},{3},'{4}/{5}/{6} {7}:{8}:00.00');";
            sqlCode = string.Format(sqlCode, ob.cantidad, ob.bebida.id, ob.comanda.id, ob.preparado,
                ob.tiempoServicio.Year, ob.tiempoServicio.Month, ob.tiempoServicio.Day,
                ob.tiempoServicio.Hour, ob.tiempoServicio.Minute);

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
        public void ActualizarOrdenBebida(OrdenBebida ob)
        {
            Conexion conexion = new Conexion();

            String sqlCode = "UPDATE ordenes_bebida SET cantidad={0},preparado={1},tiempo_servicio='{2}/{3}/{4} {5}:{6}:00.00' WHERE id={7};";
            sqlCode = string.Format(sqlCode, ob.cantidad, ob.preparado,
                ob.tiempoServicio.Year, ob.tiempoServicio.Month, ob.tiempoServicio.Day,
                ob.tiempoServicio.Hour, ob.tiempoServicio.Minute, ob.id);

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
        public void ActualizarComanda(Comanda com)
        {
            Conexion conexion = new Conexion();

            String sqlCode = "UPDATE comandas SET tiempo='{0}/{1}/{2} {3}:{4}:00.00',pagado={5} WHERE id={6};";
            sqlCode = string.Format(sqlCode, com.tiempo.Year, com.tiempo.Month, com.tiempo.Day,
                com.tiempo.Hour, com.tiempo.Minute, com.pagado, com.id);

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
        public LinkedList<OrdenComida> comidasListasSeccion(Seccion s)
        {
            Conexion conexion = new Conexion();
            LinkedList<OrdenComida> comidas = new LinkedList<OrdenComida>();
            String sqlCode = "SELECT oc.id,oc.cantidad,oc.preparado,EXTRACT(YEAR FROM oc.tiempo_servicio)AS anno," +
                " EXTRACT(MONTH FROM oc.tiempo_servicio)AS mes," +
                " EXTRACT(DAY FROM oc.tiempo_servicio)AS dia," +
                " EXTRACT(HOUR FROM oc.tiempo_servicio)AS hora," +
                " EXTRACT(MINUTE FROM oc.tiempo_servicio)AS minuto" +
                " FROM secciones as s" +
                " INNER JOIN mesas as m ON m.id_seccion = s.id" +
                " INNER JOIN comandas as c ON c.id_mesa = m.id" +
                " INNER JOIN ordenes_comida as oc ON oc.id_comanda = c.id" +
                " WHERE s.id = " + s.id + "AND oc.preparado = true;";
            try
            {
                conexion.Conectar();
                NpgsqlCommand command = new NpgsqlCommand(sqlCode, conexion.con);
                NpgsqlDataReader rs = command.ExecuteReader();
                while (rs.Read())
                {
                    CocinaDAL cocDal = new CocinaDAL();
                    comidas.AddLast(cocDal.NuevaOrdenComida(rs));
                }
                return comidas;
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
        public LinkedList<OrdenBebida> bebidasListasSeccion(Seccion s)
        {
            Conexion conexion = new Conexion();
            LinkedList<OrdenBebida> bebidas = new LinkedList<OrdenBebida>();
            String sqlCode = "SELECT oc.id,oc.cantidad,oc.preparado,EXTRACT(YEAR FROM oc.tiempo_servicio)AS anno," +
                " EXTRACT(MONTH FROM oc.tiempo_servicio)AS mes," +
                " EXTRACT(DAY FROM oc.tiempo_servicio)AS dia," +
                " EXTRACT(HOUR FROM oc.tiempo_servicio)AS hora," +
                " EXTRACT(MINUTE FROM oc.tiempo_servicio)AS minuto" +
                " FROM secciones as s" +
                " INNER JOIN mesas as m ON m.id_seccion = s.id" +
                " INNER JOIN comandas as c ON c.id_mesa = m.id" +
                " INNER JOIN ordenes_bebida as oc ON oc.id_comanda = c.id" +
                " WHERE s.id = " + s.id + "AND oc.preparado = true;";
            try
            {
                conexion.Conectar();
                NpgsqlCommand command = new NpgsqlCommand(sqlCode, conexion.con);
                NpgsqlDataReader rs = command.ExecuteReader();
                while (rs.Read())
                {
                    BarDAL barDal = new BarDAL();
                    bebidas.AddLast(barDal.NuevaOrdenBebida(rs));
                }
                return bebidas;
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
        public LinkedList<Comanda> CargarComandas()
        {
            Conexion conexion = new Conexion();
            LinkedList<Comanda> comandas = new LinkedList<Comanda>();
            String sqlCode = "SELECT id," +
                " EXTRACT(YEAR FROM tiempo)AS anno," +
                " EXTRACT(MONTH FROM tiempo)AS mes," +
                " EXTRACT(DAY FROM tiempo)AS dia," +
                " EXTRACT(HOUR FROM tiempo)AS hora," +
                " EXTRACT(MINUTE FROM tiempo)AS minuto" +
                " FROM comandas WHERE pagado = false; ";
            try
            {
                conexion.Conectar();
                NpgsqlCommand command = new NpgsqlCommand(sqlCode, conexion.con);
                NpgsqlDataReader rs = command.ExecuteReader();
                while (rs.Read())
                {
                    comandas.AddLast(CargarNuevaComanda(rs));
                }
                return comandas;
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
        public void EliminarOrdenComida(OrdenComida ordenc)
        {
            Conexion conexion = new Conexion();

            String sqlCode = "DELETE FROM ordenes_comida WHERE id =" + ordenc.id + ";" ;
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

        public void EliminarOrdenBebiida(OrdenBebida orden)
        {
            Conexion conexion = new Conexion();

            String sqlCode = "DELETE FROM ordenes_bebida WHERE id =" + orden.id + ";";
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


    }
}
