using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Npgsql;

namespace CapaDatos
{
    public class BarDAL
    {
        ComandaDAL comanDal = new ComandaDAL();
        public LinkedList<OrdenBebida> CargarOrdenesBar()
        {
            Conexion conexion = new Conexion();
            LinkedList<OrdenBebida> bebidas = new LinkedList<OrdenBebida>();
            String sqlCode = "SELECT ob.id,ob.cantidad,ob.preparado,EXTRACT(YEAR FROM ob.tiempo_servicio)AS anno," +
                " EXTRACT(MONTH FROM ob.tiempo_servicio)AS mes," +
                " EXTRACT(DAY FROM ob.tiempo_servicio)AS dia," +
                " EXTRACT(HOUR FROM ob.tiempo_servicio)AS hora," +
                " EXTRACT(MINUTE FROM ob.tiempo_servicio)AS minuto" +
                " FROM ordenes_bebida as ob" +
                " WHERE ob.preparado = false ;";
            try
            {
                conexion.Conectar();
                NpgsqlCommand command = new NpgsqlCommand(sqlCode, conexion.con);
                NpgsqlDataReader rs = command.ExecuteReader();
                while (rs.Read())
                {
                    bebidas.AddLast(NuevaOrdenBebida(rs));
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

        public OrdenBebida NuevaOrdenBebida(NpgsqlDataReader rs)
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
            ob.comanda = CargarComandaOrden(ob);
            ob.bebida = comanDal.CargarBebidaOrden(ob);
            return ob;
        }

        private Comanda CargarComandaOrden(OrdenBebida ob)
        {
            Conexion conexion = new Conexion();
            String sqlCode = "SELECT c.id," +
                " EXTRACT(YEAR FROM c.tiempo)AS anno," +
                " EXTRACT(MONTH FROM c.tiempo)AS mes," +
                " EXTRACT(DAY FROM c.tiempo)AS dia," +
                " EXTRACT(HOUR FROM c.tiempo)AS hora," +
                " EXTRACT(MINUTE FROM c.tiempo)AS minuto" +
                " FROM comandas as c" +
                " INNER JOIN ordenes_bebida as ob ON ob.id_comanda = c.id" +
                " WHERE ob.id = " + ob.id + ";";
            try
            {
                conexion.Conectar();
                NpgsqlCommand command = new NpgsqlCommand(sqlCode, conexion.con);
                NpgsqlDataReader rs = command.ExecuteReader();
                if (rs.Read())
                {
                    return (comanDal.CargarNuevaComanda(rs));
                }
                else
                {
                    return new Comanda();
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
