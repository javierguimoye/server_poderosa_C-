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
    class MCO_ACTIVIDAD_Dao
    {
        private SqlConnection conexion = new SqlConnection("Data Source = (local); Initial Catalog = PoderosaFocus; Integrated Security = true");
        private DataSet ds;

        public MCO_ACTIVIDAD_Dao()
        {  }


        public MCO_ACTIVIDAD_Bean getMCO_ACTIVIDAD()
        {
            MCO_ACTIVIDAD_Bean actividad = new MCO_ACTIVIDAD_Bean();
            conexion.Open();
            SqlCommand cmd = new SqlCommand("SELECT TOP 20[SET_ID] ,[ACTIVIDAD_ID] ,[DESCR_ACTIVIDAD]," +
                "[DPTO_ID] ,[FEC_EFECTIVA] ,[ANNO_MES_BLOQUEO] ,[ST_TIPO_ACTIVIDAD]," +
                "[ST_ESTADO],[ACT_2001],[ACTIVIDAD_ANT] ,[VISUALIZA] ,[OPERADOR_ID]," +
                "[FECHA_CREA],[OPERADOR_MODI_ID] ,[FECHA_MODI] ,[DESCR_CORTA] " +
                "FROM [PoderosaFocus].[dbo].[MCO_ACTIVIDAD]", conexion);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            SqlDataReader r = cmd.ExecuteReader();
            if (r.HasRows)
            {
                while (r.Read())
                {
                    actividad.SET_ID            = r["SET_ID"].ToString();
                    actividad.ACTIVIDAD_ID      = r["ACTIVIDAD_ID"].ToString();
                    actividad.DESCR_ACTIVIDAD   = r["DESCR_ACTIVIDAD"].ToString();
                    actividad.DPTO_ID           = r["DPTO_ID"].ToString();
                    actividad.FEC_EFECTIVA      = r["FEC_EFECTIVA"].ToString();
                    actividad.ANNO_MES_BLOQUEO  = r["ANNO_MES_BLOQUEO"].ToString();
                    actividad.ST_TIPO_ACTIVIDAD = r["ST_TIPO_ACTIVIDAD"].ToString();
                    actividad.ST_ESTADO         = r["ST_ESTADO"].ToString();
                    actividad.ACT_2001          = r["ACT_2001"].ToString();
                    actividad.ACTIVIDAD_ANT     = r["ACTIVIDAD_ANT"].ToString();
                    actividad.VISUALIZA         = r["VISUALIZA"].ToString();
                    actividad.OPERADOR_ID       = r["OPERADOR_ID"].ToString();
                    actividad.FECHA_CREA        = r["FECHA_CREA"].ToString();
                    actividad.OPERADOR_MODI_ID  = r["OPERADOR_MODI_ID"].ToString();
                    actividad.FECHA_MODI        = r["FECHA_MODI"].ToString();
                    actividad.DESCR_CORTA       = r["DESCR_CORTA"].ToString();

                }
            }

            return actividad;
        }


        public List<MCO_ACTIVIDAD_Bean> getDia_MCO_ACTIVIDAD(String mes, String ano, String dia)
        {
            List<MCO_ACTIVIDAD_Bean> actividadList = new List<MCO_ACTIVIDAD_Bean>();
            conexion.Open();
            SqlCommand cmd = new SqlCommand("SELECT [SET_ID] ,[ACTIVIDAD_ID] ,[DESCR_ACTIVIDAD]," +
                "[DPTO_ID] ,[FEC_EFECTIVA] ,[ANNO_MES_BLOQUEO] ,[ST_TIPO_ACTIVIDAD]," +
                "[ST_ESTADO],[ACT_2001],[ACTIVIDAD_ANT] ,[VISUALIZA] ,[OPERADOR_ID]," +
                "[FECHA_CREA],[OPERADOR_MODI_ID] ,[FECHA_MODI] ,[DESCR_CORTA] " +
                "FROM [PoderosaFocus].[dbo].[MCO_ACTIVIDAD] " +
                "WHERE MONTH(FECHA_CREA) = '" + mes + "' AND YEAR(FECHA_CREA) = '" + ano + "' AND DAY(FECHA_CREA) = '" + dia + "'", conexion);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            SqlDataReader r = cmd.ExecuteReader();
            if (r.HasRows)
            {
                while (r.Read())
                {
                    MCO_ACTIVIDAD_Bean actividad = new MCO_ACTIVIDAD_Bean();
                    actividad.SET_ID = r["SET_ID"].ToString();
                    actividad.ACTIVIDAD_ID = r["ACTIVIDAD_ID"].ToString();
                    actividad.DESCR_ACTIVIDAD = r["DESCR_ACTIVIDAD"].ToString();
                    actividad.DPTO_ID = r["DPTO_ID"].ToString();
                    actividad.FEC_EFECTIVA = r["FEC_EFECTIVA"].ToString();
                    actividad.ANNO_MES_BLOQUEO = r["ANNO_MES_BLOQUEO"].ToString();
                    actividad.ST_TIPO_ACTIVIDAD = r["ST_TIPO_ACTIVIDAD"].ToString();
                    actividad.ST_ESTADO = r["ST_ESTADO"].ToString();
                    actividad.ACT_2001 = r["ACT_2001"].ToString();
                    actividad.ACTIVIDAD_ANT = r["ACTIVIDAD_ANT"].ToString();
                    actividad.VISUALIZA = r["VISUALIZA"].ToString();
                    actividad.OPERADOR_ID = r["OPERADOR_ID"].ToString();
                    actividad.FECHA_CREA = r["FECHA_CREA"].ToString();
                    actividad.OPERADOR_MODI_ID = r["OPERADOR_MODI_ID"].ToString();
                    actividad.FECHA_MODI = r["FECHA_MODI"].ToString();
                    actividad.DESCR_CORTA = r["DESCR_CORTA"].ToString();
                    actividadList.Add(actividad);
                }
            }

            return actividadList;
        }

        public List<MCO_ACTIVIDAD_Bean> getMes_MCO_ACTIVIDAD(String mes, String ano)
        {
            List<MCO_ACTIVIDAD_Bean> actividadList = new List<MCO_ACTIVIDAD_Bean>();
            conexion.Open();
            SqlCommand cmd = new SqlCommand("SELECT [SET_ID] ,[ACTIVIDAD_ID] ,[DESCR_ACTIVIDAD]," +
                "[DPTO_ID] ,[FEC_EFECTIVA] ,[ANNO_MES_BLOQUEO] ,[ST_TIPO_ACTIVIDAD]," +
                "[ST_ESTADO],[ACT_2001],[ACTIVIDAD_ANT] ,[VISUALIZA] ,[OPERADOR_ID]," +
                "[FECHA_CREA],[OPERADOR_MODI_ID] ,[FECHA_MODI] ,[DESCR_CORTA] " +
                "FROM [PoderosaFocus].[dbo].[MCO_ACTIVIDAD] " +
                "WHERE MONTH(FECHA_CREA) = '" + mes + "' AND YEAR(FECHA_CREA) = '" + ano + "'", conexion);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            SqlDataReader r = cmd.ExecuteReader();
            if (r.HasRows)
            {
                while (r.Read())
                {
                    MCO_ACTIVIDAD_Bean actividad = new MCO_ACTIVIDAD_Bean();
                    actividad.SET_ID = r["SET_ID"].ToString();
                    actividad.ACTIVIDAD_ID = r["ACTIVIDAD_ID"].ToString();
                    actividad.DESCR_ACTIVIDAD = r["DESCR_ACTIVIDAD"].ToString();
                    actividad.DPTO_ID = r["DPTO_ID"].ToString();
                    actividad.FEC_EFECTIVA = r["FEC_EFECTIVA"].ToString();
                    actividad.ANNO_MES_BLOQUEO = r["ANNO_MES_BLOQUEO"].ToString();
                    actividad.ST_TIPO_ACTIVIDAD = r["ST_TIPO_ACTIVIDAD"].ToString();
                    actividad.ST_ESTADO = r["ST_ESTADO"].ToString();
                    actividad.ACT_2001 = r["ACT_2001"].ToString();
                    actividad.ACTIVIDAD_ANT = r["ACTIVIDAD_ANT"].ToString();
                    actividad.VISUALIZA = r["VISUALIZA"].ToString();
                    actividad.OPERADOR_ID = r["OPERADOR_ID"].ToString();
                    actividad.FECHA_CREA = r["FECHA_CREA"].ToString();
                    actividad.OPERADOR_MODI_ID = r["OPERADOR_MODI_ID"].ToString();
                    actividad.FECHA_MODI = r["FECHA_MODI"].ToString();
                    actividad.DESCR_CORTA = r["DESCR_CORTA"].ToString();
                    actividadList.Add(actividad);
                }
            }

            return actividadList;
        }


        public void closeBD(){
            conexion.Close();
        }



    }
}
