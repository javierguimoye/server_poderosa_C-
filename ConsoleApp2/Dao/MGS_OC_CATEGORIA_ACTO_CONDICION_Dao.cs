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
    class MGS_OC_CATEGORIA_ACTO_CONDICION_Dao
    {
        //private SqlConnection conexion = new SqlConnection("Data Source = GERRYSOFT; Initial Catalog = Tutoriales; Integrated Security = true");
        private SqlConnection conexion = new SqlConnection("Data Source = (local); Initial Catalog = PoderosaFocus; Integrated Security = true");
        private DataSet ds;

        public MGS_OC_CATEGORIA_ACTO_CONDICION_Dao()
        {
        }
      
        public MGS_OC_CATEGORIA_ACTO_CONDICION_Bean getMGS_OC_CATEGORIA_ACTO_CONDICION()
        {
            MGS_OC_CATEGORIA_ACTO_CONDICION_Bean categoria = new MGS_OC_CATEGORIA_ACTO_CONDICION_Bean();
            conexion.Open();
            SqlCommand cmd = new SqlCommand("SELECT [SET_ID],[CODIGO] ,[DESCRIPCION], " +
                "[TIPO] ,[NIVEL], [ESTADO], [NRO_VERSION],[OPERADOR_CREA],[FECHA_CREA] " +
                " FROM[PoderosaFocus].[dbo].[MGS_OC_CATEGORIA_ACTO_CONDICION]", conexion);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            SqlDataReader r = cmd.ExecuteReader();
            if (r.HasRows)
            {
                while (r.Read())
                {
                    categoria.SET_ID        = r["SET_ID"].ToString();
                    categoria.CODIGO        = r["CODIGO"].ToString();
                    categoria.DESCRIPCION   = r["DESCRIPCION"].ToString();
                    categoria.TIPO          = r["TIPO"].ToString();
                    categoria.NIVEL         = Convert.ToInt32(r["NIVEL"].ToString());
                    categoria.ESTADO        = r["ESTADO"].ToString();
                    categoria.NRO_VERSION   = Convert.ToInt32(r["NRO_VERSION"].ToString());
                    categoria.OPERADOR_CREA = r["OPERADOR_CREA"].ToString();
                    categoria.FECHA_CREA    = r["FECHA_CREA"].ToString();
                
                }
            }

            return categoria;
        }

        public List<MGS_OC_CATEGORIA_ACTO_CONDICION_Bean> getMGS_OC_CATEGORIA_ACTO_CONDICION_MES(String mes,String ano)
        {
            List<MGS_OC_CATEGORIA_ACTO_CONDICION_Bean> categoriaList = new List<MGS_OC_CATEGORIA_ACTO_CONDICION_Bean>();
            conexion.Open();
            SqlCommand cmd = new SqlCommand("SELECT [SET_ID],[CODIGO] ,[DESCRIPCION], " +
                "[TIPO] ,[NIVEL], [ESTADO], [NRO_VERSION],[OPERADOR_CREA],[FECHA_CREA] " +
                " FROM [PoderosaFocus].[dbo].[MGS_OC_CATEGORIA_ACTO_CONDICION] " +
                "WHERE MONTH(FECHA_CREA) = '"+mes+"' AND YEAR(FECHA_CREA) = '"+ano+"'", conexion);

            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            SqlDataReader r = cmd.ExecuteReader();
            if (r.HasRows)
            {
                while (r.Read())
                {
                    MGS_OC_CATEGORIA_ACTO_CONDICION_Bean categoria = new MGS_OC_CATEGORIA_ACTO_CONDICION_Bean();
                    categoria.SET_ID = r["SET_ID"].ToString();
                    categoria.CODIGO = r["CODIGO"].ToString();
                    categoria.DESCRIPCION = r["DESCRIPCION"].ToString();
                    categoria.TIPO = r["TIPO"].ToString();
                    categoria.NIVEL = Convert.ToInt32(r["NIVEL"].ToString());
                    categoria.ESTADO = r["ESTADO"].ToString();
                    categoria.NRO_VERSION = Convert.ToInt32(r["NRO_VERSION"].ToString());
                    categoria.OPERADOR_CREA = r["OPERADOR_CREA"].ToString();
                    categoria.FECHA_CREA = r["FECHA_CREA"].ToString();
                    categoriaList.Add(categoria);
                }
            }

            return categoriaList;
        }

        public List<MGS_OC_CATEGORIA_ACTO_CONDICION_Bean> getMGS_OC_CATEGORIA_ACTO_CONDICION_Dia(String mes,String ano, String dia)
        {
            List<MGS_OC_CATEGORIA_ACTO_CONDICION_Bean> categoriaList = new List<MGS_OC_CATEGORIA_ACTO_CONDICION_Bean>();
            conexion.Open();
            SqlCommand cmd = new SqlCommand("SELECT [SET_ID],[CODIGO] ,[DESCRIPCION], " +
                "[TIPO] ,[NIVEL], [ESTADO], [NRO_VERSION],[OPERADOR_CREA],[FECHA_CREA] " +
                " FROM[PoderosaFocus].[dbo].[MGS_OC_CATEGORIA_ACTO_CONDICION] " +
                "WHERE MONTH(FECHA_CREA) = '" + mes + "' AND YEAR(FECHA_CREA) = '" + ano + "' AND DAY(FECHA_CREA) = '"+dia+"'", conexion);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            SqlDataReader r = cmd.ExecuteReader();
            if (r.HasRows)
            {
                while (r.Read())
                {
                    MGS_OC_CATEGORIA_ACTO_CONDICION_Bean categoria = new MGS_OC_CATEGORIA_ACTO_CONDICION_Bean();
                    categoria.SET_ID = r["SET_ID"].ToString();
                    categoria.CODIGO = r["CODIGO"].ToString();
                    categoria.DESCRIPCION = r["DESCRIPCION"].ToString();
                    categoria.TIPO = r["TIPO"].ToString();
                    categoria.NIVEL = Convert.ToInt32(r["NIVEL"].ToString());
                    categoria.ESTADO = r["ESTADO"].ToString();
                    categoria.NRO_VERSION = Convert.ToInt32(r["NRO_VERSION"].ToString());
                    categoria.OPERADOR_CREA = r["OPERADOR_CREA"].ToString();
                    categoria.FECHA_CREA = r["FECHA_CREA"].ToString();
                    categoriaList.Add(categoria);
                }
            }

            return categoriaList;
        }

        public void closeBD(){
            conexion.Close();
        }



    }
}
