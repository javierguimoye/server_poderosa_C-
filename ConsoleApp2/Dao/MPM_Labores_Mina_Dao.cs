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
    class MPM_Labores_Mina_Dao
    {
        private SqlConnection conexion = new SqlConnection("Data Source = (local); Initial Catalog = PoderosaFocus; Integrated Security = true");
        private DataSet ds;

        public MPM_Labores_Mina_Dao(){}

        public MPM_Labores_Mina_Bean getMCO_ACTIVIDAD()
        {
            MPM_Labores_Mina_Bean mina = new MPM_Labores_Mina_Bean();
            conexion.Open();
            SqlCommand cmd = new SqlCommand("SELECT TOP 20 [SET_ID],[ZONA_ID],[NIVEL],[TIPO_LABOR_ID]," +
                "[NRO_CORR_LABOR],[ANEXO],[DESCR_LABOR],[COD_ANT],[ETAPA],[SECTOR_ID],[FEC_INIC]," +
                "[FEC_TERM],[ESTADO_IC],[ESTADO_BD],[TIPOGASTO],[ANEXO_REF]," +
                "[CONCESION_ID],[OPERADOR_ID],[FEC_CREA],[OPERADOR_MODI_ID]," +
                "[FEC_MODI],[ST_TRANSFERENCIA],[Corr_Anexo],[AnnoPresupuesto] FROM " +
                "[PoderosaFocus].[dbo].[MPM_Labores_Mina]", conexion);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            SqlDataReader r = cmd.ExecuteReader();
            if (r.HasRows)
            {
                while (r.Read())
                {
                    mina.SET_ID             = r["SET_ID"].ToString();
                    mina.ZONA_ID            = r["ZONA_ID"].ToString();
                    mina.NIVEL              = r["NIVEL"].ToString();
                    mina.TIPO_LABOR_ID      = r["TIPO_LABOR_ID"].ToString();
                    mina.NRO_CORR_LABOR     = r["NRO_CORR_LABOR"].ToString();
                    mina.ANEXO              = r["ANEXO"].ToString();
                    mina.DESCR_LABOR        = r["DESCR_LABOR"].ToString();
                    mina.COD_ANT            = r["COD_ANT"].ToString();
                    mina.ETAPA              = r["ETAPA"].ToString();
                    mina.SECTOR_ID          = r["SECTOR_ID"].ToString();
                    mina.FEC_INIC           = r["FEC_INIC"].ToString();
                    mina.FEC_TERM           = r["FEC_TERM"].ToString();
                    mina.ESTADO_IC          = r["ESTADO_IC"].ToString();
                    mina.ESTADO_BD          = r["ESTADO_BD"].ToString();
                    mina.TIPOGASTO          = r["TIPOGASTO"].ToString();
                    mina.ANEXO_REF          = r["ANEXO_REF"].ToString();
                    mina.CONCESION_ID       = r["CONCESION_ID"].ToString();
                    mina.OPERADOR_ID        = r["OPERADOR_ID"].ToString();
                    mina.FEC_CREA           = r["FEC_CREA"].ToString();
                    mina.OPERADOR_MODI_ID   = r["OPERADOR_MODI_ID"].ToString();
                    mina.FEC_MODI           = r["FEC_MODI"].ToString();
                    mina.ST_TRANSFERENCIA   = r["ST_TRANSFERENCIA"].ToString();
                    mina.Corr_Anexo         = r["Corr_Anexo"].ToString();
                    mina.AnnoPresupuesto    = r["AnnoPresupuesto"].ToString();

                }
            }

            return mina;
        }

        
        public List<MPM_Labores_Mina_Bean> getDia_MCO_ACTIVIDAD(String mes, String ano, String dia)
        {
            List<MPM_Labores_Mina_Bean> minaList = new List<MPM_Labores_Mina_Bean>();
            conexion.Open();
            SqlCommand cmd = new SqlCommand("SELECT [SET_ID],[ZONA_ID],[NIVEL],[TIPO_LABOR_ID]," +
                "[NRO_CORR_LABOR],[ANEXO],[DESCR_LABOR],[COD_ANT],[ETAPA],[SECTOR_ID],[FEC_INIC]," +
                "[FEC_TERM],[ESTADO_IC],[ESTADO_BD],[TIPOGASTO],[ANEXO_REF]," +
                "[CONCESION_ID],[OPERADOR_ID],[FEC_CREA],[OPERADOR_MODI_ID]," +
                "[FEC_MODI],[ST_TRANSFERENCIA],[Corr_Anexo],[AnnoPresupuesto] FROM " +
                "[PoderosaFocus].[dbo].[MPM_Labores_Mina] " +
                "WHERE " +
                "MONTH(FEC_CREA) = '"+ mes + "' AND " +
                "YEAR(FEC_CREA) = '"+ano+"' AND " +
                "DAY(FEC_CREA) = '"+dia+"'", conexion);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            SqlDataReader r = cmd.ExecuteReader();
            if (r.HasRows)
            {
                while (r.Read())
                {
                    MPM_Labores_Mina_Bean mina = new MPM_Labores_Mina_Bean();
                    mina.SET_ID = r["SET_ID"].ToString();
                    mina.ZONA_ID = r["ZONA_ID"].ToString();
                    mina.NIVEL = r["NIVEL"].ToString();
                    mina.TIPO_LABOR_ID = r["TIPO_LABOR_ID"].ToString();
                    mina.NRO_CORR_LABOR = r["NRO_CORR_LABOR"].ToString();
                    mina.ANEXO = r["ANEXO"].ToString();
                    mina.DESCR_LABOR = r["DESCR_LABOR"].ToString();
                    mina.COD_ANT = r["COD_ANT"].ToString();
                    mina.ETAPA = r["ETAPA"].ToString();
                    mina.SECTOR_ID = r["SECTOR_ID"].ToString();
                    mina.FEC_INIC = r["FEC_INIC"].ToString();
                    mina.FEC_TERM = r["FEC_TERM"].ToString();
                    mina.ESTADO_IC = r["ESTADO_IC"].ToString();
                    mina.ESTADO_BD = r["ESTADO_BD"].ToString();
                    mina.TIPOGASTO = r["TIPOGASTO"].ToString();
                    mina.ANEXO_REF = r["ANEXO_REF"].ToString();
                    mina.CONCESION_ID = r["CONCESION_ID"].ToString();
                    mina.OPERADOR_ID = r["OPERADOR_ID"].ToString();
                    mina.FEC_CREA = r["FEC_CREA"].ToString();
                    mina.OPERADOR_MODI_ID = r["OPERADOR_MODI_ID"].ToString();
                    mina.FEC_MODI = r["FEC_MODI"].ToString();
                    mina.ST_TRANSFERENCIA = r["ST_TRANSFERENCIA"].ToString();
                    mina.Corr_Anexo = r["Corr_Anexo"].ToString();
                    mina.AnnoPresupuesto = r["AnnoPresupuesto"].ToString();
                    minaList.Add(mina);
                }
            }

            return minaList;
        }

        public List<MPM_Labores_Mina_Bean> getMes_MCO_ACTIVIDAD(String mes, String ano)
        {
            List<MPM_Labores_Mina_Bean> minaList = new List<MPM_Labores_Mina_Bean>();
            conexion.Open();
            SqlCommand cmd = new SqlCommand("SELECT [SET_ID],[ZONA_ID],[NIVEL],[TIPO_LABOR_ID]," +
                "[NRO_CORR_LABOR],[ANEXO],[DESCR_LABOR],[COD_ANT],[ETAPA],[SECTOR_ID],[FEC_INIC]," +
                "[FEC_TERM],[ESTADO_IC],[ESTADO_BD],[TIPOGASTO],[ANEXO_REF]," +
                "[CONCESION_ID],[OPERADOR_ID],[FEC_CREA],[OPERADOR_MODI_ID]," +
                "[FEC_MODI],[ST_TRANSFERENCIA],[Corr_Anexo],[AnnoPresupuesto] FROM " +
                "[PoderosaFocus].[dbo].[MPM_Labores_Mina] " +
                "WHERE " +
                "MONTH(FEC_CREA) = '" + mes + "' AND " +
                "YEAR(FEC_CREA) = '" + ano + "'", conexion);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            SqlDataReader r = cmd.ExecuteReader();
            if (r.HasRows)
            {
                while (r.Read())
                {
                    MPM_Labores_Mina_Bean mina = new MPM_Labores_Mina_Bean();
                    mina.SET_ID = r["SET_ID"].ToString();
                    mina.ZONA_ID = r["ZONA_ID"].ToString();
                    mina.NIVEL = r["NIVEL"].ToString();
                    mina.TIPO_LABOR_ID = r["TIPO_LABOR_ID"].ToString();
                    mina.NRO_CORR_LABOR = r["NRO_CORR_LABOR"].ToString();
                    mina.ANEXO = r["ANEXO"].ToString();
                    mina.DESCR_LABOR = r["DESCR_LABOR"].ToString();
                    mina.COD_ANT = r["COD_ANT"].ToString();
                    mina.ETAPA = r["ETAPA"].ToString();
                    mina.SECTOR_ID = r["SECTOR_ID"].ToString();
                    mina.FEC_INIC = r["FEC_INIC"].ToString();
                    mina.FEC_TERM = r["FEC_TERM"].ToString();
                    mina.ESTADO_IC = r["ESTADO_IC"].ToString();
                    mina.ESTADO_BD = r["ESTADO_BD"].ToString();
                    mina.TIPOGASTO = r["TIPOGASTO"].ToString();
                    mina.ANEXO_REF = r["ANEXO_REF"].ToString();
                    mina.CONCESION_ID = r["CONCESION_ID"].ToString();
                    mina.OPERADOR_ID = r["OPERADOR_ID"].ToString();
                    mina.FEC_CREA = r["FEC_CREA"].ToString();
                    mina.OPERADOR_MODI_ID = r["OPERADOR_MODI_ID"].ToString();
                    mina.FEC_MODI = r["FEC_MODI"].ToString();
                    mina.ST_TRANSFERENCIA = r["ST_TRANSFERENCIA"].ToString();
                    mina.Corr_Anexo = r["Corr_Anexo"].ToString();
                    mina.AnnoPresupuesto = r["AnnoPresupuesto"].ToString();
                    minaList.Add(mina);
                }
            }

            return minaList;
        }


        public void closeBD(){
            conexion.Close();
        }



    }
}
