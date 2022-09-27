using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;

namespace MODELO
{
    class Conexion
    {
        public OdbcConnection conexion()
        {

            OdbcConnection conn = new OdbcConnection("Dsn=2P");
            try
            {
                conn.Open();
            }
            catch (OdbcException)
            {
                Console.WriteLine("Error al conectar");
            }
            return conn;
        }


        public void desconexion(OdbcConnection conn)
        {
            try
            {
                conn.Close();
            }
            catch (OdbcException)
            {
                Console.WriteLine("Error al desconectar");
            }
        }
    }
}
