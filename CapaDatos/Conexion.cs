using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace CapaDatos
{
    public class Conexion
    {
        public NpgsqlConnection con = new NpgsqlConnection("Server=localhost;" +
            " User Id = postgres;" +
            " Password = Postgres;" +
            " Database = restaurante");
        public void Conectar()
        {
            try
            {
                con.Open();

            }
            catch (Exception e)
            {
                throw new Exception("No se ha podido conectar con la base de datos");
            }
        }
        public void Desconectar()
        {
            con.Close();
        }
    }
}
