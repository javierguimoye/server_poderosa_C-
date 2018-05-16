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
    class M_ZONAS_Dao
    {
        private SqlConnection conexion = new SqlConnection("Data Source = (local); Initial Catalog = PoderosaFocus; Integrated Security = true");
        private DataSet ds;

        public M_ZONAS_Dao()
        {
        }

        public M_ZONAS_Bean getM_ZONAS()
        {
            M_ZONAS_Bean zonas = new M_ZONAS_Bean();
            conexion.Open();
            SqlCommand cmd = new SqlCommand("SELECT TOP 20[SET_ID],[ZONA_ID] ,[NIVEL] ,[FEC_EFECTIVA] ," +
                "[DESCR_ZONA] ,[DESCR_CORTA] ,[DESCR_CORTA_VETA],[DESCR_CORTA_UND_PROD]," +
                "[DESCR_UND_PROD],[UBICACION],[CAPP],[OPERADOR_ID] ,[FECHA_CREA] ," +
                "[OPERADOR_MODI_ID],[FECHA_MODI] ,[ST_ESTADO] ,[ST_TRANSFERENCIA]," +
                "[ANNO_MES_BLOQUEO] FROM [PoderosaFocus].[dbo].[M_ZONAS]", conexion);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            SqlDataReader r = cmd.ExecuteReader();
            if (r.HasRows)
            {
                while (r.Read())
                {
                    zonas.SET_ID                = r["SET_ID"].ToString();
                    zonas.ZONA_ID               = r["ZONA_ID"].ToString();
                    zonas.NIVEL                 = r["NIVEL"].ToString();
                    zonas.FEC_EFECTIVA          = r["FEC_EFECTIVA"].ToString();
                    zonas.DESCR_ZONA            = r["DESCR_ZONA"].ToString();
                    zonas.DESCR_CORTA           = r["DESCR_CORTA"].ToString();
                    zonas.DESCR_CORTA_VETA      = r["DESCR_CORTA_VETA"].ToString();
                    zonas.DESCR_CORTA_UND_PROD  = r["DESCR_CORTA_UND_PROD"].ToString();
                    zonas.DESCR_UND_PROD        = r["DESCR_UND_PROD"].ToString();
                    zonas.UBICACION             = r["UBICACION"].ToString();
                    zonas.CAPP                  = r["CAPP"].ToString();
                    zonas.OPERADOR_ID           = r["OPERADOR_ID"].ToString();
                    zonas.FECHA_CREA            = r["FECHA_CREA"].ToString();
                    zonas.OPERADOR_MODI_ID      = r["OPERADOR_MODI_ID"].ToString();
                    zonas.FECHA_MODI            = r["FECHA_MODI"].ToString();
                    zonas.ST_ESTADO             = r["ST_ESTADO"].ToString();
                    zonas.ST_TRANSFERENCIA      = r["ST_TRANSFERENCIA"].ToString();
                    zonas.ANNO_MES_BLOQUEO      = r["ANNO_MES_BLOQUEO"].ToString();

                }
            }

            return zonas;
        }

        public List<M_ZONAS_Bean> getDia_M_ZONAS(String mes, String ano, String dia)
        {
            List<M_ZONAS_Bean> zonasList = new List<M_ZONAS_Bean>();
            conexion.Open();
            SqlCommand cmd = new SqlCommand("SELECT [SET_ID],[ZONA_ID] ,[NIVEL] ,[FEC_EFECTIVA] ," +
                "[DESCR_ZONA] ,[DESCR_CORTA] ,[DESCR_CORTA_VETA],[DESCR_CORTA_UND_PROD]," +
                "[DESCR_UND_PROD],[UBICACION],[CAPP],[OPERADOR_ID] ,[FECHA_CREA] ," +
                "[OPERADOR_MODI_ID],[FECHA_MODI] ,[ST_ESTADO] ,[ST_TRANSFERENCIA]," +
                "[ANNO_MES_BLOQUEO] FROM [PoderosaFocus].[dbo].[M_ZONAS] " +
                "WHERE MONTH(FECHA_CREA) = '" + mes + "' AND YEAR(FECHA_CREA) = '" + ano + "' AND DAY(FECHA_CREA) = '" + dia + "'", conexion);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            SqlDataReader r = cmd.ExecuteReader();
            if (r.HasRows)
            {
                while (r.Read())
                {
                    M_ZONAS_Bean zonas = new M_ZONAS_Bean();
                    zonas.SET_ID = r["SET_ID"].ToString();
                    zonas.ZONA_ID = r["ZONA_ID"].ToString();
                    zonas.NIVEL = r["NIVEL"].ToString();
                    zonas.FEC_EFECTIVA = r["FEC_EFECTIVA"].ToString();
                    zonas.DESCR_ZONA = r["DESCR_ZONA"].ToString();
                    zonas.DESCR_CORTA = r["DESCR_CORTA"].ToString();
                    zonas.DESCR_CORTA_VETA = r["DESCR_CORTA_VETA"].ToString();
                    zonas.DESCR_CORTA_UND_PROD = r["DESCR_CORTA_UND_PROD"].ToString();
                    zonas.DESCR_UND_PROD = r["DESCR_UND_PROD"].ToString();
                    zonas.UBICACION = r["UBICACION"].ToString();
                    zonas.CAPP = r["CAPP"].ToString();
                    zonas.OPERADOR_ID = r["OPERADOR_ID"].ToString();
                    zonas.FECHA_CREA = r["FECHA_CREA"].ToString();
                    zonas.OPERADOR_MODI_ID = r["OPERADOR_MODI_ID"].ToString();
                    zonas.FECHA_MODI = r["FECHA_MODI"].ToString();
                    zonas.ST_ESTADO = r["ST_ESTADO"].ToString();
                    zonas.ST_TRANSFERENCIA = r["ST_TRANSFERENCIA"].ToString();
                    zonas.ANNO_MES_BLOQUEO = r["ANNO_MES_BLOQUEO"].ToString();
                    zonasList.Add(zonas);
                }
            }

            return zonasList;
        }

        public List<M_ZONAS_Bean> getMes_M_ZONAS(String mes, String ano)
        {
            List<M_ZONAS_Bean> zonasList = new List<M_ZONAS_Bean>();
            conexion.Open();
            SqlCommand cmd = new SqlCommand("SELECT [SET_ID],[ZONA_ID] ,[NIVEL] ,[FEC_EFECTIVA] ," +
                "[DESCR_ZONA] ,[DESCR_CORTA] ,[DESCR_CORTA_VETA],[DESCR_CORTA_UND_PROD]," +
                "[DESCR_UND_PROD],[UBICACION],[CAPP],[OPERADOR_ID] ,[FECHA_CREA] ," +
                "[OPERADOR_MODI_ID],[FECHA_MODI] ,[ST_ESTADO] ,[ST_TRANSFERENCIA]," +
                "[ANNO_MES_BLOQUEO] FROM [PoderosaFocus].[dbo].[M_ZONAS] WHERE MONTH(FECHA_CREA) = '" + mes + "' AND YEAR(FECHA_CREA) = '" + ano + "'", conexion);
         
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            SqlDataReader r = cmd.ExecuteReader();
            if (r.HasRows)
            {
                while (r.Read())
                {
                    M_ZONAS_Bean zonas = new M_ZONAS_Bean();
                    zonas.SET_ID = r["SET_ID"].ToString();
                    zonas.ZONA_ID = r["ZONA_ID"].ToString();
                    zonas.NIVEL = r["NIVEL"].ToString();
                    zonas.FEC_EFECTIVA = r["FEC_EFECTIVA"].ToString();
                    zonas.DESCR_ZONA = r["DESCR_ZONA"].ToString();
                    zonas.DESCR_CORTA = r["DESCR_CORTA"].ToString();
                    zonas.DESCR_CORTA_VETA = r["DESCR_CORTA_VETA"].ToString();
                    zonas.DESCR_CORTA_UND_PROD = r["DESCR_CORTA_UND_PROD"].ToString();
                    zonas.DESCR_UND_PROD = r["DESCR_UND_PROD"].ToString();
                    zonas.UBICACION = r["UBICACION"].ToString();
                    zonas.CAPP = r["CAPP"].ToString();
                    zonas.OPERADOR_ID = r["OPERADOR_ID"].ToString();
                    zonas.FECHA_CREA = r["FECHA_CREA"].ToString();
                    zonas.OPERADOR_MODI_ID = r["OPERADOR_MODI_ID"].ToString();
                    zonas.FECHA_MODI = r["FECHA_MODI"].ToString();
                    zonas.ST_ESTADO = r["ST_ESTADO"].ToString();
                    zonas.ST_TRANSFERENCIA = r["ST_TRANSFERENCIA"].ToString();
                    zonas.ANNO_MES_BLOQUEO = r["ANNO_MES_BLOQUEO"].ToString();
                    zonasList.Add(zonas);

                }
            }

            return zonasList;
        }

        public void closeBD(){
            conexion.Close();
        }



    }
}
