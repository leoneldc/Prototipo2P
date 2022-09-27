using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO
{
    public class Modelo
    {
        Conexion con = new Conexion();

        public OdbcDataAdapter llenarTbl(string tabla)        {
            string sql = "SELECT * FROM " + tabla + "  ;";
            OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, con.conexion());
            return dataTable;
        }

        public void insertar(string datos, string tipo, string tabla)
        {
            string sql = "INSERT INTO " + tabla + tipo +" values (" + datos + ")";
            try
            {
                OdbcCommand cmd = new OdbcCommand(sql, con.conexion());
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al insertar en "+tabla);
            }
            
        }

        public void actualizar(string datos, string condicion, string tabla)
        {
            try
            {
                string sql = "UPDATE " + tabla + " SET " + datos + " WHERE " + condicion + "; ";
                OdbcCommand cmd = new OdbcCommand(sql, con.conexion());
                cmd.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                Console.WriteLine("error en actualizar en" + tabla);
            }
        }

        public void eliminar(string condicion, string tabla)
        {
            try
            {
                string sql = "DELETE FROM " + tabla + " WHERE " + condicion +";";
                OdbcCommand cmd = new OdbcCommand(sql, con.conexion());
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine("error en eliminar en " + tabla);
            }
        }



    }
}
