using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ClassLibrary1
{
    public class Utilidades
    {
        
        public static DataSet Ejecutar(String cmd)
        {
            SqlConnection con = new SqlConnection("" +
                "Data Source =.; " +
                "Initial Catalog = PoderosaFocus; " +
                "Integrated Security = True");
            con.Open();
            Console.WriteLine("se ha conectado");
            DataSet DS = new DataSet();
            SqlDataAdapter DP = new SqlDataAdapter(cmd,con);
            DP.Fill(DS);
            con.Close();

            return DS;
        }

    }
}
