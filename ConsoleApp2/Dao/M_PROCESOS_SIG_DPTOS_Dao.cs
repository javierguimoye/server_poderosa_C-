using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using ConsoleApp2.Models;

namespace ConsoleApp2.Dao
{
    class M_PROCESOS_SIG_DPTOS_Dao
    {
        //private SqlConnection conexion = new SqlConnection("Data Source = GERRYSOFT; Initial Catalog = Tutoriales; Integrated Security = true");
        private SqlConnection conexion = new SqlConnection("Data Source = (local); Initial Catalog = PoderosaFocus; Integrated Security = true");
        private DataSet ds;

        public M_PROCESOS_SIG_DPTOS_Dao()
        {
        }

        public M_PROCESOS_SIG_DPTOS_Bean getM_PROCESOS_SIG_DPTOS()
        {
            M_PROCESOS_SIG_DPTOS_Bean dpto = new M_PROCESOS_SIG_DPTOS_Bean();
            conexion.Open();
            SqlCommand cmd = new SqlCommand("SELECT TOP 20 [Cod_Proceso],[Dpto_id],[Descr_Dpto] FROM " +
                "[PoderosaFocus].[dbo].[M_PROCESOS_SIG_DPTOS]", conexion);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            SqlDataReader r = cmd.ExecuteReader();
            if (r.HasRows)
            {
                while (r.Read())
                {
                    dpto.Cod_Proceso    = r["Cod_Proceso"].ToString();
                    dpto.Dpto_id        = r["Dpto_id"].ToString();
                    dpto.Descr_Dpto     = r["Descr_Dpto"].ToString();

                }
            }

            return dpto;
        }



        public List<M_PROCESOS_SIG_DPTOS_Bean> getTODO_M_PROCESOS_SIG_DPTOS()
        {
            List<M_PROCESOS_SIG_DPTOS_Bean> dptoList = new List<M_PROCESOS_SIG_DPTOS_Bean>();
            conexion.Open();
            SqlCommand cmd = new SqlCommand("SELECT [Cod_Proceso],[Dpto_id],[Descr_Dpto] FROM " +
                "[PoderosaFocus].[dbo].[M_PROCESOS_SIG_DPTOS]", conexion);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            SqlDataReader r = cmd.ExecuteReader();
            if (r.HasRows)
            {
                while (r.Read())
                {
                    M_PROCESOS_SIG_DPTOS_Bean dpto  = new M_PROCESOS_SIG_DPTOS_Bean();
                    dpto.Cod_Proceso                = r["Cod_Proceso"].ToString();
                    dpto.Dpto_id                    = r["Dpto_id"].ToString();
                    dpto.Descr_Dpto                 = r["Descr_Dpto"].ToString();
                    dptoList.Add(dpto);
                }
            }

            return dptoList;
        }


        public void closeBD(){
            conexion.Close();
        }



    }
}
