using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONTROLADOR
{
    public class Controaldor
    {
        MODELO.Modelo sn = new MODELO.Modelo();
        public DataTable llenarTbl(string tabla)
        {
            OdbcDataAdapter dt = sn.llenarTbl(tabla);
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }

        public void insert(string datos, string tipo, string tabla)
        {
            sn.insertar(datos, tipo, tabla);
        }

        public void update(string datos, string condicion, string tabla)
        {
            sn.actualizar(datos, condicion, tabla);
        }
        public void delete(string condicion, string tabla)
        {
            sn.eliminar(condicion, tabla);
        }



    }
}
