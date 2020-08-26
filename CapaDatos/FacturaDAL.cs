using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Npgsql;

namespace CapaDatos
{
    public class FacturaDAL
    {
        public Factura CargarFacturaComanda(Comanda c)
        {
            Conexion conexion = new Conexion();

            String sqlCode = "SELECT id,numero,total_sin_impuesto,total," +
                " EXTRACT(YEAR FROM fecha)AS anno," +
                " EXTRACT(MONTH FROM fecha)AS mes," +
                " EXTRACT(DAY FROM fecha)AS dia," +
                " EXTRACT(HOUR FROM fecha)AS hora, " +
                " EXTRACT(MINUTE FROM fecha)AS minuto" +
                " FROM facturas WHERE id_comanda = "+c.id+" AND facturado = false; ";
            try
            {
                conexion.Conectar();
                NpgsqlCommand command = new NpgsqlCommand(sqlCode, conexion.con);
                NpgsqlDataReader rs = command.ExecuteReader();
                if (rs.Read())
                {
                    return CargarNuevaFactura(rs);
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

        

        private Factura CargarNuevaFactura(NpgsqlDataReader rs)
        {
            Factura f = new Factura();
            f.id = int.Parse(rs.GetValue(0).ToString());
            f.numero = int.Parse(rs.GetValue(1).ToString());
            f.totalSinImpuesto = int.Parse(rs.GetValue(2).ToString());
            f.total = int.Parse(rs.GetValue(3).ToString());
            f.fecha = new DateTime(int.Parse(rs.GetValue(4).ToString()),
                int.Parse(rs.GetValue(5).ToString()),
                int.Parse(rs.GetValue(6).ToString()),
                int.Parse(rs.GetValue(7).ToString()),
                int.Parse(rs.GetValue(8).ToString()), 0);
            f.comanda = CargarComandaFactura(f);
            f.detalles = CargarDetallesFactura(f);
            return f;
        }

        

        private LinkedList<DetalleFactura> CargarDetallesFactura(Factura f)
        {
            Conexion conexion = new Conexion();
            LinkedList<DetalleFactura> detalles = new LinkedList < DetalleFactura > ();
            String sqlCode = "SELECT d.id,d.orden_refer,d.detalle,d.precio " +
                " FROM detalles_facturas as d" +
                " WHERE d.id_factura = "+f.id+"; ";
            try
            {
                conexion.Conectar();
                NpgsqlCommand command = new NpgsqlCommand(sqlCode, conexion.con);
                NpgsqlDataReader rs = command.ExecuteReader();
                while (rs.Read())
                {
                    detalles.AddLast(CargarNuevoDetalle(rs));
                }
                return detalles;
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

        private DetalleFactura CargarNuevoDetalle(NpgsqlDataReader rs)
        {
            DetalleFactura d = new DetalleFactura();
            d.id = int.Parse(rs.GetValue(0).ToString());
            d.ordenRefer = int.Parse(rs.GetValue(1).ToString());
            d.detalle = rs.GetValue(2).ToString();
            d.precio = int.Parse(rs.GetValue(3).ToString());
            return d;
        }

        private Comanda CargarComandaFactura(Factura f)
        {
            Conexion conexion = new Conexion();

            String sqlCode = "SELECT c.id," +
                " EXTRACT(YEAR FROM c.tiempo)AS anno," +
                " EXTRACT(MONTH FROM c.tiempo)AS mes," +
                " EXTRACT(DAY FROM c.tiempo)AS dia," +
                " EXTRACT(HOUR FROM c.tiempo)AS hora," +
                " EXTRACT(MINUTE FROM c.tiempo)AS minuto" +
                " FROM comandas as c" +
                " INNER JOIN facturas as f ON f.id_comanda = c.id" +
                " WHERE f.id = " + f.id + " AND pagado = false; ";
            try
            {
                conexion.Conectar();
                NpgsqlCommand command = new NpgsqlCommand(sqlCode, conexion.con);
                NpgsqlDataReader rs = command.ExecuteReader();
                if (rs.Read())
                {
                    ComandaDAL comDal = new ComandaDAL();
                    return comDal.CargarNuevaComanda(rs);
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
        public void InsertarFactura(Factura f)
        {
            Conexion conexion = new Conexion();

            String sqlCode = "INSERT INTO facturas(fecha,id_comanda)" +
                " VALUES('{0}/{1}/{2} {3}:{4}:00.00',{5});";
            sqlCode = string.Format(sqlCode,f.fecha.Year, f.fecha.Month, f.fecha.Day, f.fecha.Hour, f.fecha.Minute,f.comanda.id);

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
        public void InsertarDetalleFactura(DetalleFactura df, Factura factura)
        {
            Conexion conexion = new Conexion();

            String sqlCode = "INSERT INTO detalles_facturas(orden_refer,detalle,precio,id_factura)" +
                " VALUES({0},'{1}',{2},{3});";
            sqlCode = string.Format(sqlCode, df.ordenRefer,df.detalle,df.precio,factura.id);

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
        public void EliminarFactura(Factura factura)
        {
            Conexion conexion = new Conexion();

            String sqlCode = "DELETE FROM detalles_facturas WHERE id_factura=" + factura.id + ";"+
                " DELETE FROM facturas WHERE id="+factura.id+";" ;
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
        public void Facturar(Factura factura)
        {
            Conexion conexion = new Conexion();

            String sqlCode = "UPDATE facturas SET facturado=true WHERE id={0};";
            sqlCode = string.Format(sqlCode, factura.id);
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
