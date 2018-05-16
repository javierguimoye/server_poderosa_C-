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
    class GS_OC_DET_OBS_COMPORTAMIENTO_Dao
    {
        private SqlConnection conexion = new SqlConnection("Data Source = (local); Initial Catalog = PoderosaFocus; Integrated Security = true");
        private DataSet ds;

        public GS_OC_DET_OBS_COMPORTAMIENTO_Dao() { }

        public GS_OC_DET_OBS_COMPORTAMIENTO_Bean getGS_OC_DET_OBS_COMPORTAMIENTOS()
        {
            GS_OC_DET_OBS_COMPORTAMIENTO_Bean det_observaciones = new GS_OC_DET_OBS_COMPORTAMIENTO_Bean();
            conexion.Open();
            SqlCommand cmd = new SqlCommand("SELECT TOP 20 [CIA_ID],[ANNOMES],[OBSERVACION_ID],[DETALLE_ID]," +
                "[NRO_VERSION],[NRO_INSEGUROS],[NRO_SEGUROS],[TODO_ES_SEGURO]," +
                "[OBSERVACION],[OPERADOR_CREA],[FECHA_CREA],[OPERADOR_MODI]," +
                "[FECHA_MODI] FROM [PoderosaFocus].[dbo].[GS_OC_DET_OBS_COMPORTAMIENTO]", conexion);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            SqlDataReader r = cmd.ExecuteReader();
            if (r.HasRows)
            {
                while (r.Read())
                {
                    det_observaciones.CIA_ID            = r["CIA_ID"].ToString();
                    det_observaciones.ANNOMES           = r["ANNOMES"].ToString();
                    det_observaciones.OBSERVACION_ID    = r["OBSERVACION_ID"].ToString();
                    det_observaciones.DETALLE_ID        = r["DETALLE_ID"].ToString();
                    det_observaciones.NRO_VERSION       = r["NRO_VERSION"].ToString();
                    det_observaciones.NRO_INSEGUROS     = r["NRO_INSEGUROS"].ToString();
                    det_observaciones.NRO_SEGUROS       = r["NRO_SEGUROS"].ToString();
                    det_observaciones.TODO_ES_SEGURO    = r["TODO_ES_SEGURO"].ToString();
                    det_observaciones.OBSERVACION       = r["OBSERVACION"].ToString();
                    det_observaciones.OPERADOR_CREA     = r["OPERADOR_CREA"].ToString();
                    det_observaciones.FECHA_CREA        = r["FECHA_CREA"].ToString();
                    det_observaciones.OPERADOR_MODI     = r["OPERADOR_MODI"].ToString();
                    det_observaciones.FECHA_MODI        = r["FECHA_MODI"].ToString();

                }
            }

            return det_observaciones;
        }


           public List<GS_OC_DET_OBS_COMPORTAMIENTO_Bean> getGS_OC_DET_OBS_COMPORTAMIENTOS_Dia(String mes, String ano, String dia)
        {
            List<GS_OC_DET_OBS_COMPORTAMIENTO_Bean> det_observacionesList = new List<GS_OC_DET_OBS_COMPORTAMIENTO_Bean>();
            conexion.Open();
            SqlCommand cmd = new SqlCommand("SELECT [CIA_ID],[ANNOMES],[OBSERVACION_ID],[DETALLE_ID]," +
                "[NRO_VERSION],[NRO_INSEGUROS],[NRO_SEGUROS],[TODO_ES_SEGURO]," +
                "[OBSERVACION],[OPERADOR_CREA],[FECHA_CREA],[OPERADOR_MODI]," +
                "[FECHA_MODI] FROM [PoderosaFocus].[dbo].[GS_OC_DET_OBS_COMPORTAMIENTO]  " +
                "WHERE MONTH(FECHA_CREA) = '" + mes + "' AND " +
                "YEAR(FECHA_CREA) = '" + ano + "' AND " +
                "DAY(FECHA_CREA) = '" + dia + "'", conexion);


            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            SqlDataReader r = cmd.ExecuteReader();
            if (r.HasRows)
            {
                while (r.Read())
                {
                    GS_OC_DET_OBS_COMPORTAMIENTO_Bean det_observaciones = new GS_OC_DET_OBS_COMPORTAMIENTO_Bean();
                    det_observaciones.CIA_ID = r["CIA_ID"].ToString();
                    det_observaciones.ANNOMES = r["ANNOMES"].ToString();
                    det_observaciones.OBSERVACION_ID = r["OBSERVACION_ID"].ToString();
                    det_observaciones.DETALLE_ID = r["DETALLE_ID"].ToString();
                    det_observaciones.NRO_VERSION = r["NRO_VERSION"].ToString();
                    det_observaciones.NRO_INSEGUROS = r["NRO_INSEGUROS"].ToString();
                    det_observaciones.NRO_SEGUROS = r["NRO_SEGUROS"].ToString();
                    det_observaciones.TODO_ES_SEGURO = r["TODO_ES_SEGURO"].ToString();
                    det_observaciones.OBSERVACION = r["OBSERVACION"].ToString();
                    det_observaciones.OPERADOR_CREA = r["OPERADOR_CREA"].ToString();
                    det_observaciones.FECHA_CREA = r["FECHA_CREA"].ToString();
                    det_observaciones.OPERADOR_MODI = r["OPERADOR_MODI"].ToString();
                    det_observaciones.FECHA_MODI = r["FECHA_MODI"].ToString();
                    det_observacionesList.Add(det_observaciones);
                }
            }

            return det_observacionesList;
        }


        public List<GS_OC_DET_OBS_COMPORTAMIENTO_Bean> getGS_OC_DET_OBS_COMPORTAMIENTOS_Mes(String mes, String ano)
        {
            List<GS_OC_DET_OBS_COMPORTAMIENTO_Bean> det_observacionesList = new List<GS_OC_DET_OBS_COMPORTAMIENTO_Bean>();
            conexion.Open();
            SqlCommand cmd = new SqlCommand("SELECT [CIA_ID],[ANNOMES],[OBSERVACION_ID],[DETALLE_ID]," +
                "[NRO_VERSION],[NRO_INSEGUROS],[NRO_SEGUROS],[TODO_ES_SEGURO]," +
                "[OBSERVACION],[OPERADOR_CREA],[FECHA_CREA],[OPERADOR_MODI]," +
                "[FECHA_MODI] FROM [PoderosaFocus].[dbo].[GS_OC_DET_OBS_COMPORTAMIENTO]  " +
                "WHERE MONTH(FECHA_CREA) = '" + mes + "' AND " +
                "YEAR(FECHA_CREA) = '" + ano + "'", conexion);


            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            SqlDataReader r = cmd.ExecuteReader();
            if (r.HasRows)
            {
                while (r.Read())
                {
                    GS_OC_DET_OBS_COMPORTAMIENTO_Bean det_observaciones = new GS_OC_DET_OBS_COMPORTAMIENTO_Bean();
                    det_observaciones.CIA_ID = r["CIA_ID"].ToString();
                    det_observaciones.ANNOMES = r["ANNOMES"].ToString();
                    det_observaciones.OBSERVACION_ID = r["OBSERVACION_ID"].ToString();
                    det_observaciones.DETALLE_ID = r["DETALLE_ID"].ToString();
                    det_observaciones.NRO_VERSION = r["NRO_VERSION"].ToString();
                    det_observaciones.NRO_INSEGUROS = r["NRO_INSEGUROS"].ToString();
                    det_observaciones.NRO_SEGUROS = r["NRO_SEGUROS"].ToString();
                    det_observaciones.TODO_ES_SEGURO = r["TODO_ES_SEGURO"].ToString();
                    det_observaciones.OBSERVACION = r["OBSERVACION"].ToString();
                    det_observaciones.OPERADOR_CREA = r["OPERADOR_CREA"].ToString();
                    det_observaciones.FECHA_CREA = r["FECHA_CREA"].ToString();
                    det_observaciones.OPERADOR_MODI = r["OPERADOR_MODI"].ToString();
                    det_observaciones.FECHA_MODI = r["FECHA_MODI"].ToString();
                    det_observacionesList.Add(det_observaciones);
                }
            }

            return det_observacionesList;
        }



        public GS_OC_DET_OBS_COMPORTAMIENTO_Bean getCompareID_GS_OC_DET_OBS_COMPORTAMIENTO(GS_OC_DET_OBS_COMPORTAMIENTO_Bean det_observaciones)
        {
            GS_OC_DET_OBS_COMPORTAMIENTO_Bean det_observacionesTmp = new GS_OC_DET_OBS_COMPORTAMIENTO_Bean();
            conexion.Open();

            SqlCommand cmd = new SqlCommand("SELECT [CIA_ID] ,[ANNOMES],[OBSERVACION_ID],[DETALLE_ID]," +
                "[NRO_VERSION],[NRO_INSEGUROS],[NRO_SEGUROS],[TODO_ES_SEGURO]," +
                "[OBSERVACION],[OPERADOR_CREA],[FECHA_CREA],[OPERADOR_MODI],[FECHA_MODI] " +
                "FROM [PoderosaFocus].[dbo].[GS_OC_DET_OBS_COMPORTAMIENTO] " +
                "where " +
                "CIA_ID = '"+ det_observaciones.CIA_ID+ "' and " +
                "ANNOMES = '"+ det_observaciones.ANNOMES + "' and " +
                "OBSERVACION_ID = '"+ det_observaciones .OBSERVACION_ID+ "' and " +
                "DETALLE_ID = '"+ det_observaciones .DETALLE_ID+ "' ", conexion);

            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            SqlDataReader r = cmd.ExecuteReader();
            if (r.HasRows)
            {
                while (r.Read())
                {
                    det_observacionesTmp.CIA_ID = r["CIA_ID"].ToString();
                    det_observacionesTmp.ANNOMES = r["ANNOMES"].ToString();
                    det_observacionesTmp.OBSERVACION_ID = r["OBSERVACION_ID"].ToString();
                    det_observacionesTmp.DETALLE_ID = r["DETALLE_ID"].ToString();
                    det_observacionesTmp.NRO_VERSION = r["NRO_VERSION"].ToString();
                    det_observacionesTmp.NRO_INSEGUROS = r["NRO_INSEGUROS"].ToString();
                    det_observacionesTmp.NRO_SEGUROS = r["NRO_SEGUROS"].ToString();
                    det_observacionesTmp.TODO_ES_SEGURO = r["TODO_ES_SEGURO"].ToString();
                    det_observacionesTmp.OBSERVACION = r["OBSERVACION"].ToString();
                    det_observacionesTmp.OPERADOR_CREA = r["OPERADOR_CREA"].ToString();
                    det_observacionesTmp.FECHA_CREA = r["FECHA_CREA"].ToString();
                    det_observacionesTmp.OPERADOR_MODI = r["OPERADOR_MODI"].ToString();
                    det_observacionesTmp.FECHA_MODI = r["FECHA_MODI"].ToString();
                }
            }
            else
            {
                conexion.Close();
                return null;
            }
            conexion.Close();
            return det_observacionesTmp;
        }

       
         public void updateOrCreate_GS_OC_DET_OBS_COMPORTAMIENTO(GS_OC_DET_OBS_COMPORTAMIENTO_Bean det_observaciones){
            GS_OC_DET_OBS_COMPORTAMIENTO_Bean det_observacionesTmp = getCompareID_GS_OC_DET_OBS_COMPORTAMIENTO(det_observaciones);
            if (det_observacionesTmp != null) UpdateGS_OC_DET_OBS_COMPORTAMIENTO(det_observaciones);
            else InsertarGS_OC_DET_OBS_COMPORTAMIENTO(det_observaciones);
        }

        public bool InsertarGS_OC_DET_OBS_COMPORTAMIENTO(GS_OC_DET_OBS_COMPORTAMIENTO_Bean det_observaciones)
        {
            Console.WriteLine("insertando detalles");
            conexion.Open();
       
            SqlCommand cmd = new SqlCommand("INSERT [PoderosaFocus].[dbo].[GS_OC_DET_OBS_COMPORTAMIENTO]" +
                "([CIA_ID], [ANNOMES], [OBSERVACION_ID], [DETALLE_ID], [NRO_VERSION], [NRO_INSEGUROS], [NRO_SEGUROS], " +
                "[TODO_ES_SEGURO], [OBSERVACION], [OPERADOR_CREA], [FECHA_CREA], [OPERADOR_MODI], [FECHA_MODI]) " +
                "VALUES ('"+ det_observaciones.CIA_ID+ "', '"+det_observaciones.ANNOMES + "', '"+det_observaciones.OBSERVACION_ID + "'," +
                " '"+det_observaciones.DETALLE_ID + "', "+det_observaciones.NRO_VERSION + ", "+det_observaciones.NRO_INSEGUROS + ", " +
                ""+det_observaciones.NRO_SEGUROS + ", "+det_observaciones.TODO_ES_SEGURO+", '"+det_observaciones.OBSERVACION+"', " +
                "'"+det_observaciones.OPERADOR_CREA+"', convert(datetime,'"+det_observaciones.FECHA_CREA+"'), " +
                "'"+det_observaciones.OPERADOR_MODI+"', convert(datetime, '"+det_observaciones.FECHA_MODI+"'))", conexion);

            int filasafectadas = cmd.ExecuteNonQuery();
            conexion.Close();
            if (filasafectadas > 0) return true;
            else return false;
        }

        public bool UpdateGS_OC_DET_OBS_COMPORTAMIENTO(GS_OC_DET_OBS_COMPORTAMIENTO_Bean det_observaciones)
        {
            Console.WriteLine("modificando detalles");
            conexion.Open();
            SqlCommand cmd = new SqlCommand("" +
                "UPDATE [PoderosaFocus].[dbo].[GS_OC_DET_OBS_COMPORTAMIENTO] SET " +
                "[CIA_ID] = '"+det_observaciones.CIA_ID+"', " +
                "[ANNOMES] = '"+det_observaciones.ANNOMES+"', " +
                "[OBSERVACION_ID] = '"+det_observaciones.OBSERVACION_ID+"', " +
                "[DETALLE_ID] = '"+det_observaciones.DETALLE_ID+"', " +
                "[NRO_VERSION] = "+det_observaciones.NRO_VERSION+", " +
                "[NRO_INSEGUROS] = "+det_observaciones.NRO_INSEGUROS+", " +
                "[NRO_SEGUROS] = "+det_observaciones.NRO_SEGUROS+", " +
                "[TODO_ES_SEGURO] = "+det_observaciones.TODO_ES_SEGURO+", " +
                "[OBSERVACION] = '"+det_observaciones.OBSERVACION+"', " +
                "[OPERADOR_CREA] = '"+det_observaciones.OPERADOR_CREA+"', " +
                "[FECHA_CREA] = convert(datetime, '"+det_observaciones.FECHA_CREA+"'), " +
                "[OPERADOR_MODI] = '"+det_observaciones.OPERADOR_MODI+"', " +
                "[FECHA_MODI] = convert(datetime, '"+det_observaciones.FECHA_MODI+"') " +
                "WHERE " +
                "CIA_ID = '"+det_observaciones.CIA_ID+"' and " +
                "ANNOMES = '"+det_observaciones.ANNOMES+"' and " +
                "OBSERVACION_ID = '"+det_observaciones.OBSERVACION_ID+"' and " +
                "DETALLE_ID = '"+det_observaciones.DETALLE_ID+"'", conexion);


            int filasafectadas = cmd.ExecuteNonQuery();
            conexion.Close();
            if (filasafectadas > 0) return true;
            else return false;
        }


        public void closeBD()
        {
            conexion.Close();
        }

    }
}
