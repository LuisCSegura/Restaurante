using Entidades;
using Npgsql;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class ReportesDAL
    {


        public LinkedList<Reportes> primer_repo(DateTime fecha)
        {
            
            LinkedList<Reportes> reportes = new LinkedList<Reportes>();

            Conexion conexion = new Conexion();

            String sqlCode = "SELECT m.numero AS numero_mesa, s.numero AS numero_seccion FROM mesas AS m JOIN comandas AS c ON c.id_mesa = m.id join secciones AS s ON m.id_seccion = s.id WHERE c.tiempo::date= @fecha ;";
            sqlCode = string.Format(sqlCode);

            try
            {
                conexion.Conectar();
                NpgsqlCommand command = new NpgsqlCommand(sqlCode, conexion.con);
                command.Parameters.AddWithValue("@fecha", fecha);;
                NpgsqlDataReader rs = command.ExecuteReader();

                while (rs.Read())
                {

                    reportes.AddLast(CargarReportes(rs));

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

            return reportes;
        }

        private Reportes CargarReportes(NpgsqlDataReader rs)
        {
            Reportes r = new Reportes();

            r.mesa = int.Parse(rs.GetValue(0).ToString());
            r.seccion = int.Parse(rs.GetValue(1).ToString());
            return r;
        }



        public Reportes Segundo_repo(DateTime fecha)
        {
            Reportes r = new Reportes();
            ArrayList cantidad = new ArrayList();
            Conexion conexion = new Conexion();

            String sqlCode = "select count(f.id) from usuarios as u join comandas as c on u.id= c.id_salonero join facturas as f on c.id= f.id_comanda where u.tipo = 3 and f.fecha::date = @fecha ";
            sqlCode = string.Format(sqlCode);

            try
            {
                conexion.Conectar();
                NpgsqlCommand command = new NpgsqlCommand(sqlCode, conexion.con);
                command.Parameters.AddWithValue("@fecha", fecha); ;
                NpgsqlDataReader rs = command.ExecuteReader();

                while (rs.Read())
                {

                    cantidad.Add(rs.GetInt32(0));
               
                }
                r.cantidad = cantidad;

            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

            finally
            {
                conexion.Desconectar();
            }

            return r;
        }

        public Reportes Tercer_repo(DateTime fecha)
        {
            Reportes r = new Reportes();
            ArrayList cantidad = new ArrayList();
            Conexion conexion = new Conexion();

            String sqlCode = "select count(f.id) from usuarios as u join comandas as c on u.id= c.id_salonero join facturas as f on c.id= f.id_comanda where u.tipo = 4 and f.fecha::date = @fecha ";
            sqlCode = string.Format(sqlCode);

            try
            {
                conexion.Conectar();
                NpgsqlCommand command = new NpgsqlCommand(sqlCode, conexion.con);
                command.Parameters.AddWithValue("@fecha", fecha); ;
                NpgsqlDataReader rs = command.ExecuteReader();

                while (rs.Read())
                {

                    cantidad.Add(rs.GetInt32(0));

                }
                r.cantidad = cantidad;

            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

            finally
            {
                conexion.Desconectar();
            }

            return r;
        }

        public Reportes Cuarto_repo(DateTime fecha)
        {
            Reportes r = new Reportes();
            ArrayList cantidad = new ArrayList();
            Conexion conexion = new Conexion();

            String sqlCode = "select count(c.id) from comandas as c join usuarios as u on c.id_salonero = u.id  where c.tiempo::date = @fecha and u.tipo = 4; ";
            sqlCode = string.Format(sqlCode);

            try
            {
                conexion.Conectar();
                NpgsqlCommand command = new NpgsqlCommand(sqlCode, conexion.con);
                command.Parameters.AddWithValue("@fecha", fecha); ;
                NpgsqlDataReader rs = command.ExecuteReader();

                while (rs.Read())
                {
                    cantidad.Add(rs.GetInt32(0));
  

                }
                r.cantidad = cantidad;

            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

            finally
            {
                conexion.Desconectar();
            }

            return r;
        }



        public Reportes Quinto_repo(DateTime fecha)
        {
            Reportes r = new Reportes();
            ArrayList cantidad = new ArrayList();
            Conexion conexion = new Conexion();

            String sqlCode = "select count(b.id) from ordenes_bebida as b join comandas as c on c.id = b.id_comanda where c.tiempo::date = @fecha ";
            sqlCode = string.Format(sqlCode);

            try
            {
                conexion.Conectar();
                NpgsqlCommand command = new NpgsqlCommand(sqlCode, conexion.con);
                command.Parameters.AddWithValue("@fecha", fecha); ;
                NpgsqlDataReader rs = command.ExecuteReader();

                while (rs.Read())
                {
                    cantidad.Add(rs.GetInt32(0));
                    Console.WriteLine(rs.GetInt32(0));
                }

                r.cantidad = cantidad;
                Console.WriteLine(cantidad);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

            finally
            {
                conexion.Desconectar();
            }

            return r;
        }


        public Reportes Sexto_repo(DateTime fecha)
        {
            Reportes r = new Reportes();
            ArrayList cantidad = new ArrayList();
            Conexion conexion = new Conexion();

            String sqlCode = "select count(b.id) from ordenes_comida as b join comandas as c on c.id = b.id_comanda where c.tiempo::date = @fecha ";
            sqlCode = string.Format(sqlCode);

            try
            {
                conexion.Conectar();
                NpgsqlCommand command = new NpgsqlCommand(sqlCode, conexion.con);
                command.Parameters.AddWithValue("@fecha", fecha); ;
                NpgsqlDataReader rs = command.ExecuteReader();

                while (rs.Read())
                {
                    cantidad.Add(rs.GetInt32(0));

                }
                r.cantidad = cantidad;

            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

            finally
            {
                conexion.Desconectar();
            }

            return r;
        }


        public LinkedList<Reportes> Setimo_repo(DateTime fecha)
        {
            LinkedList<Reportes> reportes = new LinkedList<Reportes>();
            Conexion conexion = new Conexion();

            String sqlCode = "select s.numero as seccion, u.nombre from secciones as s " +
                " join usuarios as u on s.id_salonero = u.id group by s.id_salonero, s.numero, s.activo = true, u.nombre ";
            sqlCode = string.Format(sqlCode);

            try
            {
                conexion.Conectar();
                NpgsqlCommand command = new NpgsqlCommand(sqlCode, conexion.con);
                //command.Parameters.AddWithValue("@fecha", fecha); ;
                NpgsqlDataReader rs = command.ExecuteReader();

                while (rs.Read())
                {

                    reportes.AddLast(CargarReportes2(rs));
                    

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

            return reportes;
        }

        private Reportes CargarReportes2(NpgsqlDataReader rs)
        {
            Reportes r = new Reportes();

            r.seccion = int.Parse(rs.GetValue(0).ToString());
            r.nombre = rs.GetValue(1).ToString();
            return r;
        }


        public LinkedList<Reportes> Octavo_repo(DateTime fecha)
        {
            LinkedList<Reportes> reportes = new LinkedList<Reportes>();
            Conexion conexion = new Conexion();

            String sqlCode = "select count(c.id_mesa), u.nombre from comandas as c join usuarios as u on c.id_salonero = u.id and c.tiempo::date = @fecha group by c.id_salonero, u.nombre";
            sqlCode = string.Format(sqlCode);

            try
            {
                conexion.Conectar();
                NpgsqlCommand command = new NpgsqlCommand(sqlCode, conexion.con);
                command.Parameters.AddWithValue("@fecha", fecha); ;
                NpgsqlDataReader rs = command.ExecuteReader();

                while (rs.Read())
                {

                    reportes.AddLast(CargarReportes2(rs));

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

            return reportes;
        }



        public LinkedList<Reportes> Noveno_repo(DateTime fecha)
        {
            LinkedList<Reportes> reportes = new LinkedList<Reportes>();
            Conexion conexion = new Conexion();

            String sqlCode = "select c.tiempo, com.tiempo_servicio, be.tiempo_servicio from comandas as c join ordenes_comida as com on c.id = com.id_comanda " +
                " join ordenes_bebida as be on c.id = be.id_comanda where c.tiempo::date = @fecha ";
            sqlCode = string.Format(sqlCode);

            try
            {
                conexion.Conectar();
                NpgsqlCommand command = new NpgsqlCommand(sqlCode, conexion.con);
                command.Parameters.AddWithValue("@fecha", fecha); ;
                NpgsqlDataReader rs = command.ExecuteReader();

                while (rs.Read())
                {

                    reportes.AddLast(CargarReportes3(rs));

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

            return reportes;
        }
        private Reportes CargarReportes3(NpgsqlDataReader rs)
        {
            Reportes r = new Reportes();

            r.fecha1 = Convert.ToDateTime( rs.GetValue(0).ToString());
            r.fecha2 = Convert.ToDateTime(rs.GetValue(1).ToString());
            r.fecha3 = Convert.ToDateTime(rs.GetValue(2).ToString());
            return r;
        }
    }
}
