using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Npgsql;

namespace CapaDatos
{
    public class CocinaDAL
    {
        ComandaDAL comanDal;
        public CocinaDAL()
        {
            comanDal = new ComandaDAL();
        }
        public LinkedList<OrdenComida> CargarOrdenesCocina()
        {
            Conexion conexion = new Conexion();
            LinkedList<OrdenComida> comidas = new LinkedList<OrdenComida>();
            String sqlCode = "SELECT oc.id,oc.cantidad,oc.preparado,EXTRACT(YEAR FROM oc.tiempo_servicio)AS anno," +
                " EXTRACT(MONTH FROM oc.tiempo_servicio)AS mes," +
                " EXTRACT(DAY FROM oc.tiempo_servicio)AS dia," +
                " EXTRACT(HOUR FROM oc.tiempo_servicio)AS hora," +
                " EXTRACT(MINUTE FROM oc.tiempo_servicio)AS minuto" +
                " FROM ordenes_comida as oc" +
                " WHERE oc.preparado = false ;";
            try
            {
                conexion.Conectar();
                NpgsqlCommand command = new NpgsqlCommand(sqlCode, conexion.con);
                NpgsqlDataReader rs = command.ExecuteReader();
                while (rs.Read())
                {
                    comidas.AddLast(NuevaOrdenComida(rs));
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
        public OrdenComida NuevaOrdenComida(NpgsqlDataReader rs)
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
            oc.comanda = CargarComandaOrden(oc);
            oc.comida = comanDal.CargarComidaOrden(oc);
            return oc;
        }

        private Comanda CargarComandaOrden(OrdenComida oc)
        {
            Conexion conexion = new Conexion();
            String sqlCode = "SELECT c.id," +
                " EXTRACT(YEAR FROM c.tiempo)AS anno," +
                " EXTRACT(MONTH FROM c.tiempo)AS mes," +
                " EXTRACT(DAY FROM c.tiempo)AS dia," +
                " EXTRACT(HOUR FROM c.tiempo)AS hora," +
                " EXTRACT(MINUTE FROM c.tiempo)AS minuto" +
                " FROM comandas as c" +
                " INNER JOIN ordenes_comida as oc ON oc.id_comanda = c.id" +
                " WHERE oc.id = " + oc.id + ";";
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
