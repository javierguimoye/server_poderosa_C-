using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace MiLibreria
{
    public class Utilidades
    {
        static SqlConnection con    =   null;
        static DataSet DS           =   null;
        static SqlCommand cmd2      =   null;
        static SqlDataAdapter DP    =   null;

        public static DataSet Ejecutar(String cmd)
        {

            con = new SqlConnection("" +
                "Data Source =.; " +
                "Initial Catalog = PoderosaFocus; " +
                "Integrated Security = True");
            con.Open();
            cmd2 = new SqlCommand(cmd,con);
          
            Console.WriteLine("se ha conectado");
            DS = new DataSet();
            DP = new SqlDataAdapter(cmd, con);
            DP.Fill(DS);

            return DS;
        }

        public static SqlCommand getSqlCommand()
        {
            return cmd2;
        }

        public static SqlConnection getSqlConnection()
        {
            return con;
        }
    }
}

