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

    class GS_OC_CAB_OBS_COMPORTAMIENTO_Dao
    {
        private SqlConnection conexion = new SqlConnection("Data Source = (local); Initial Catalog = PoderosaFocus; Integrated Security = true");
        private DataSet ds;

        public GS_OC_CAB_OBS_COMPORTAMIENTO_Dao() { }

        public GS_OC_CAB_OBS_COMPORTAMIENTO_Bean getGS_OC_CAB_OBS_COMPORTAMIENTO()
        {
            GS_OC_CAB_OBS_COMPORTAMIENTO_Bean cat_observaciones = new GS_OC_CAB_OBS_COMPORTAMIENTO_Bean();
            conexion.Open();
            SqlCommand cmd = new SqlCommand("SELECT TOP 20[CIA_ID],[ANNOMES],[OBSERVACION_ID]," +
                "[TRAB_ID],[PROVEEDOR_ID_OBSERVADOR],[DPTO_ID],[FECHA_OBSERVACION]," +
                "[ACTIVIDAD_ID],[ZONA_ID],[LABOR_ID],[ACCIONES_SEGURAS_OBS]," +
                "[ACTOS_INSEGUROS_OBS],[NRO_PERSONAS_CONTACTADAS],[NRO_PERSONAS_OBSERVADAS]," +
                "[OPERADOR_CREA],[FECHA_CREA],[OPERADOR_MODI],[FECHA_MODI],[TURNO]," +
                "[TIEMPO],[PROVEEDOR_ID_OBSERVADOS],[ESTADO] " +
                "FROM [PoderosaFocus].[dbo].[GS_OC_CAB_OBS_COMPORTAMIENTO]", conexion);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            SqlDataReader r = cmd.ExecuteReader();
            if (r.HasRows)
            {
                while (r.Read())
                {
                    cat_observaciones.CIA_ID                    = r["CIA_ID"].ToString();
                    cat_observaciones.ANNOMES                   = r["ANNOMES"].ToString();
                    cat_observaciones.OBSERVACION_ID            = r["OBSERVACION_ID"].ToString();
                    cat_observaciones.TRAB_ID                   = r["TRAB_ID"].ToString();
                    cat_observaciones.PROVEEDOR_ID_OBSERVADOR   = r["PROVEEDOR_ID_OBSERVADOR"].ToString();
                    cat_observaciones.DPTO_ID                   = r["DPTO_ID"].ToString();
                    cat_observaciones.FECHA_OBSERVACION         = r["FECHA_OBSERVACION"].ToString();
                    cat_observaciones.ACTIVIDAD_ID              = r["ACTIVIDAD_ID"].ToString();
                    cat_observaciones.ZONA_ID                   = r["ZONA_ID"].ToString();
                    cat_observaciones.LABOR_ID                  = r["LABOR_ID"].ToString();
                    cat_observaciones.ACCIONES_SEGURAS_OBS      = r["ACCIONES_SEGURAS_OBS"].ToString();
                    cat_observaciones.ACTOS_INSEGUROS_OBS       = r["ACTOS_INSEGUROS_OBS"].ToString();
                    cat_observaciones.NRO_PERSONAS_CONTACTADAS  = r["NRO_PERSONAS_CONTACTADAS"].ToString();
                    cat_observaciones.NRO_PERSONAS_OBSERVADAS   = r["NRO_PERSONAS_OBSERVADAS"].ToString();
                    cat_observaciones.OPERADOR_CREA             = r["OPERADOR_CREA"].ToString();
                    cat_observaciones.FECHA_CREA                = r["FECHA_CREA"].ToString();
                    cat_observaciones.OPERADOR_MODI             = r["OPERADOR_MODI"].ToString();
                    cat_observaciones.FECHA_MODI                = r["FECHA_MODI"].ToString();
                    cat_observaciones.TURNO                     = r["TURNO"].ToString();
                    cat_observaciones.TIEMPO                    = r["TIEMPO"].ToString();
                    cat_observaciones.PROVEEDOR_ID_OBSERVADOS   = r["PROVEEDOR_ID_OBSERVADOS"].ToString();
                    cat_observaciones.ESTADO                    = r["ESTADO"].ToString();
                }
            }

            return cat_observaciones;
        }

        public List<GS_OC_CAB_OBS_COMPORTAMIENTO_Bean> getGS_OC_CAB_OBS_COMPORTAMIENTO_Mes(String mes, String ano)
        {
            List<GS_OC_CAB_OBS_COMPORTAMIENTO_Bean> GS_OC_CAB_OBS_COMPORTAMIENTO_List = new List<GS_OC_CAB_OBS_COMPORTAMIENTO_Bean>();
            conexion.Open();
            SqlCommand cmd = new SqlCommand("SELECT [CIA_ID],[ANNOMES],[OBSERVACION_ID]," +
                "[TRAB_ID],[PROVEEDOR_ID_OBSERVADOR],[DPTO_ID],[FECHA_OBSERVACION]," +
                "[ACTIVIDAD_ID],[ZONA_ID],[LABOR_ID],[ACCIONES_SEGURAS_OBS]," +
                "[ACTOS_INSEGUROS_OBS],[NRO_PERSONAS_CONTACTADAS],[NRO_PERSONAS_OBSERVADAS]," +
                "[OPERADOR_CREA],[FECHA_CREA],[OPERADOR_MODI],[FECHA_MODI],[TURNO]," +
                "[TIEMPO],[PROVEEDOR_ID_OBSERVADOS],[ESTADO] " +
                "FROM [PoderosaFocus].[dbo].[GS_OC_CAB_OBS_COMPORTAMIENTO] " +
                "WHERE MONTH(FECHA_CREA) = '" + mes + "' AND " +
                "YEAR(FECHA_CREA) = '" + ano + "'", conexion);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            SqlDataReader r = cmd.ExecuteReader();
            if (r.HasRows)
            {
                while (r.Read())
                {
                    GS_OC_CAB_OBS_COMPORTAMIENTO_Bean cat_observaciones = new GS_OC_CAB_OBS_COMPORTAMIENTO_Bean();
                    cat_observaciones.CIA_ID = r["CIA_ID"].ToString();
                    cat_observaciones.ANNOMES = r["ANNOMES"].ToString();
                    cat_observaciones.OBSERVACION_ID = r["OBSERVACION_ID"].ToString();
                    cat_observaciones.TRAB_ID = r["TRAB_ID"].ToString();
                    cat_observaciones.PROVEEDOR_ID_OBSERVADOR = r["PROVEEDOR_ID_OBSERVADOR"].ToString();
                    cat_observaciones.DPTO_ID = r["DPTO_ID"].ToString();
                    cat_observaciones.FECHA_OBSERVACION = r["FECHA_OBSERVACION"].ToString();
                    cat_observaciones.ACTIVIDAD_ID = r["ACTIVIDAD_ID"].ToString();
                    cat_observaciones.ZONA_ID = r["ZONA_ID"].ToString();
                    cat_observaciones.LABOR_ID = r["LABOR_ID"].ToString();
                    cat_observaciones.ACCIONES_SEGURAS_OBS = r["ACCIONES_SEGURAS_OBS"].ToString();
                    cat_observaciones.ACTOS_INSEGUROS_OBS = r["ACTOS_INSEGUROS_OBS"].ToString();
                    cat_observaciones.NRO_PERSONAS_CONTACTADAS = r["NRO_PERSONAS_CONTACTADAS"].ToString();
                    cat_observaciones.NRO_PERSONAS_OBSERVADAS = r["NRO_PERSONAS_OBSERVADAS"].ToString();
                    cat_observaciones.OPERADOR_CREA = r["OPERADOR_CREA"].ToString();
                    cat_observaciones.FECHA_CREA = r["FECHA_CREA"].ToString();
                    cat_observaciones.OPERADOR_MODI = r["OPERADOR_MODI"].ToString();
                    cat_observaciones.FECHA_MODI = r["FECHA_MODI"].ToString();
                    cat_observaciones.TURNO = r["TURNO"].ToString();
                    cat_observaciones.TIEMPO = r["TIEMPO"].ToString();
                    cat_observaciones.PROVEEDOR_ID_OBSERVADOS = r["PROVEEDOR_ID_OBSERVADOS"].ToString();
                    cat_observaciones.ESTADO = r["ESTADO"].ToString();
                    GS_OC_CAB_OBS_COMPORTAMIENTO_List.Add(cat_observaciones);
                }
            }

            return GS_OC_CAB_OBS_COMPORTAMIENTO_List;
        }

        public List<GS_OC_CAB_OBS_COMPORTAMIENTO_Bean> getGS_OC_CAB_OBS_COMPORTAMIENTO_Dia(String mes, String ano, String dia)
        {
            List<GS_OC_CAB_OBS_COMPORTAMIENTO_Bean> GS_OC_CAB_OBS_COMPORTAMIENTO_List = new List<GS_OC_CAB_OBS_COMPORTAMIENTO_Bean>();
            conexion.Open(); 
            SqlCommand cmd = new SqlCommand("SELECT [CIA_ID],[ANNOMES],[OBSERVACION_ID]," +
                "[TRAB_ID],[PROVEEDOR_ID_OBSERVADOR],[DPTO_ID],[FECHA_OBSERVACION]," +
                "[ACTIVIDAD_ID],[ZONA_ID],[LABOR_ID],[ACCIONES_SEGURAS_OBS]," +
                "[ACTOS_INSEGUROS_OBS],[NRO_PERSONAS_CONTACTADAS],[NRO_PERSONAS_OBSERVADAS]," +
                "[OPERADOR_CREA],[FECHA_CREA],[OPERADOR_MODI],[FECHA_MODI],[TURNO]," +
                "[TIEMPO],[PROVEEDOR_ID_OBSERVADOS],[ESTADO] " +
                "FROM [PoderosaFocus].[dbo].[GS_OC_CAB_OBS_COMPORTAMIENTO] " +
                "WHERE MONTH(FECHA_CREA) = '" + mes + "' AND " +
                "YEAR(FECHA_CREA) = '" + ano + "' AND " +
                "DAY(FECHA_CREA) = '" + dia + "'", conexion);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            SqlDataReader r = cmd.ExecuteReader();
            if (r.HasRows)
            {
                while (r.Read())
                {
                    GS_OC_CAB_OBS_COMPORTAMIENTO_Bean cat_observaciones = new GS_OC_CAB_OBS_COMPORTAMIENTO_Bean();
                    cat_observaciones.CIA_ID = r["CIA_ID"].ToString();
                    cat_observaciones.ANNOMES = r["ANNOMES"].ToString();
                    cat_observaciones.OBSERVACION_ID = r["OBSERVACION_ID"].ToString();
                    cat_observaciones.TRAB_ID = r["TRAB_ID"].ToString();
                    cat_observaciones.PROVEEDOR_ID_OBSERVADOR = r["PROVEEDOR_ID_OBSERVADOR"].ToString();
                    cat_observaciones.DPTO_ID = r["DPTO_ID"].ToString();
                    cat_observaciones.FECHA_OBSERVACION = r["FECHA_OBSERVACION"].ToString();
                    cat_observaciones.ACTIVIDAD_ID = r["ACTIVIDAD_ID"].ToString();
                    cat_observaciones.ZONA_ID = r["ZONA_ID"].ToString();
                    cat_observaciones.LABOR_ID = r["LABOR_ID"].ToString();
                    cat_observaciones.ACCIONES_SEGURAS_OBS = r["ACCIONES_SEGURAS_OBS"].ToString();
                    cat_observaciones.ACTOS_INSEGUROS_OBS = r["ACTOS_INSEGUROS_OBS"].ToString();
                    cat_observaciones.NRO_PERSONAS_CONTACTADAS = r["NRO_PERSONAS_CONTACTADAS"].ToString();
                    cat_observaciones.NRO_PERSONAS_OBSERVADAS = r["NRO_PERSONAS_OBSERVADAS"].ToString();
                    cat_observaciones.OPERADOR_CREA = r["OPERADOR_CREA"].ToString();
                    cat_observaciones.FECHA_CREA = r["FECHA_CREA"].ToString();
                    cat_observaciones.OPERADOR_MODI = r["OPERADOR_MODI"].ToString();
                    cat_observaciones.FECHA_MODI = r["FECHA_MODI"].ToString();
                    cat_observaciones.TURNO = r["TURNO"].ToString();
                    cat_observaciones.TIEMPO = r["TIEMPO"].ToString();
                    cat_observaciones.PROVEEDOR_ID_OBSERVADOS = r["PROVEEDOR_ID_OBSERVADOS"].ToString();
                    cat_observaciones.ESTADO = r["ESTADO"].ToString();
                    GS_OC_CAB_OBS_COMPORTAMIENTO_List.Add(cat_observaciones);
                }
            }

            return GS_OC_CAB_OBS_COMPORTAMIENTO_List;
        }


        //consulta por id's
        public GS_OC_CAB_OBS_COMPORTAMIENTO_Bean getCompareID_GS_OC_CAB_OBS_COMPORTAMIENTO(GS_OC_CAB_OBS_COMPORTAMIENTO_Bean cat_observaciones)
        {
            GS_OC_CAB_OBS_COMPORTAMIENTO_Bean cat_observacionesTmp = new GS_OC_CAB_OBS_COMPORTAMIENTO_Bean();
            conexion.Open();
            SqlCommand cmd = new SqlCommand("SELECT [CIA_ID],[ANNOMES],[OBSERVACION_ID]," +
                "[TRAB_ID],[PROVEEDOR_ID_OBSERVADOR],[DPTO_ID],[FECHA_OBSERVACION]," +
                "[ACTIVIDAD_ID],[ZONA_ID],[LABOR_ID],[ACCIONES_SEGURAS_OBS]," +
                "[ACTOS_INSEGUROS_OBS],[NRO_PERSONAS_CONTACTADAS],[NRO_PERSONAS_OBSERVADAS]," +
                "[OPERADOR_CREA],[FECHA_CREA],[OPERADOR_MODI],[FECHA_MODI],[TURNO]," +
                "[TIEMPO],[PROVEEDOR_ID_OBSERVADOS],[ESTADO] " +
                "FROM [PoderosaFocus].[dbo].[GS_OC_CAB_OBS_COMPORTAMIENTO]  " +
                "where CIA_ID = '"+cat_observaciones.CIA_ID+"' and " +
                "ANNOMES = '"+cat_observaciones.ANNOMES+"' and " +
                "OBSERVACION_ID = '"+cat_observaciones.OBSERVACION_ID+"' ", conexion);

            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            SqlDataReader r = cmd.ExecuteReader();
            if (r.HasRows)
            {
                while (r.Read())
                {
                    cat_observacionesTmp.CIA_ID = r["CIA_ID"].ToString();
                    cat_observacionesTmp.ANNOMES = r["ANNOMES"].ToString();
                    cat_observacionesTmp.OBSERVACION_ID = r["OBSERVACION_ID"].ToString();
                    cat_observacionesTmp.TRAB_ID = r["TRAB_ID"].ToString();
                    cat_observacionesTmp.PROVEEDOR_ID_OBSERVADOR = r["PROVEEDOR_ID_OBSERVADOR"].ToString();
                    cat_observacionesTmp.DPTO_ID = r["DPTO_ID"].ToString();
                    cat_observacionesTmp.FECHA_OBSERVACION = r["FECHA_OBSERVACION"].ToString();
                    cat_observacionesTmp.ACTIVIDAD_ID = r["ACTIVIDAD_ID"].ToString();
                    cat_observacionesTmp.ZONA_ID = r["ZONA_ID"].ToString();
                    cat_observacionesTmp.LABOR_ID = r["LABOR_ID"].ToString();
                    cat_observacionesTmp.ACCIONES_SEGURAS_OBS = r["ACCIONES_SEGURAS_OBS"].ToString();
                    cat_observacionesTmp.ACTOS_INSEGUROS_OBS = r["ACTOS_INSEGUROS_OBS"].ToString();
                    cat_observacionesTmp.NRO_PERSONAS_CONTACTADAS = r["NRO_PERSONAS_CONTACTADAS"].ToString();
                    cat_observacionesTmp.NRO_PERSONAS_OBSERVADAS = r["NRO_PERSONAS_OBSERVADAS"].ToString();
                    cat_observacionesTmp.OPERADOR_CREA = r["OPERADOR_CREA"].ToString();
                    cat_observacionesTmp.FECHA_CREA = r["FECHA_CREA"].ToString();
                    cat_observacionesTmp.OPERADOR_MODI = r["OPERADOR_MODI"].ToString();
                    cat_observacionesTmp.FECHA_MODI = r["FECHA_MODI"].ToString();
                    cat_observacionesTmp.TURNO = r["TURNO"].ToString();
                    cat_observacionesTmp.TIEMPO = r["TIEMPO"].ToString();
                    cat_observacionesTmp.PROVEEDOR_ID_OBSERVADOS = r["PROVEEDOR_ID_OBSERVADOS"].ToString();
                    cat_observacionesTmp.ESTADO = r["ESTADO"].ToString();
                }
            }
            else
            {
                conexion.Close();
                return null;
            }
            conexion.Close();
            return cat_observacionesTmp;
        }



        //consulta valida para insertar o modificar
        public void updateOrCreate_GS_OC_CAB_OBS_COMPORTAMIENTO(GS_OC_CAB_OBS_COMPORTAMIENTO_Bean cab_observaciones)
        {
            GS_OC_CAB_OBS_COMPORTAMIENTO_Bean det_observacionesTmp = getCompareID_GS_OC_CAB_OBS_COMPORTAMIENTO(cab_observaciones);
            if (det_observacionesTmp != null) UpdateGS_OC_CAB_OBS_COMPORTAMIENTO(cab_observaciones);
            else InsertarGS_OC_CAB_OBS_COMPORTAMIENTO(cab_observaciones);
        }

        // inserta
        public bool InsertarGS_OC_CAB_OBS_COMPORTAMIENTO(GS_OC_CAB_OBS_COMPORTAMIENTO_Bean cab_observaciones)
        {
            Console.WriteLine("insertando cabezeras");
            conexion.Open();
            SqlCommand cmd = new SqlCommand("INSERT [PoderosaFocus].[dbo].[GS_OC_CAB_OBS_COMPORTAMIENTO] " +
                "([CIA_ID], [ANNOMES], [OBSERVACION_ID], " +
                "[TRAB_ID], [PROVEEDOR_ID_OBSERVADOR], [DPTO_ID], [FECHA_OBSERVACION], [ACTIVIDAD_ID], [ZONA_ID], [LABOR_ID],[ACCIONES_SEGURAS_OBS], " +
                "[ACTOS_INSEGUROS_OBS], [NRO_PERSONAS_CONTACTADAS], [NRO_PERSONAS_OBSERVADAS],[OPERADOR_CREA], [FECHA_CREA], [OPERADOR_MODI], " +
                "[FECHA_MODI], [TURNO], [TIEMPO], [PROVEEDOR_ID_OBSERVADOS], [ESTADO]) " +
                "VALUES('"+ cab_observaciones.CIA_ID+ "', '"+cab_observaciones.ANNOMES+"', '"+ cab_observaciones.OBSERVACION_ID+ "', '"+cab_observaciones.TRAB_ID + "', " +
                "'"+cab_observaciones.PROVEEDOR_ID_OBSERVADOR+"', '"+cab_observaciones.DPTO_ID + " ', " +
                "convert(datetime, '"+ cab_observaciones.FECHA_OBSERVACION + "'), '"+cab_observaciones.ACTIVIDAD_ID+"', '"+cab_observaciones.ZONA_ID+"', '"+cab_observaciones.LABOR_ID+"', " +
                "'"+cab_observaciones.ACCIONES_SEGURAS_OBS + "', '"+cab_observaciones.ACTOS_INSEGUROS_OBS + "', "+cab_observaciones.NRO_PERSONAS_CONTACTADAS + ", " +
                ""+cab_observaciones.NRO_PERSONAS_OBSERVADAS+", '"+cab_observaciones.OPERADOR_CREA+"', " +
                "convert(datetime, '"+cab_observaciones.FECHA_CREA + "'), '"+cab_observaciones.OPERADOR_MODI+"', " +
                "convert(datetime, '"+cab_observaciones.FECHA_MODI+"'), '"+cab_observaciones.TURNO+"', "+cab_observaciones.TIEMPO+", " +
                "'"+cab_observaciones.PROVEEDOR_ID_OBSERVADOS+"', '"+cab_observaciones.ESTADO+"')", conexion);

            int filasafectadas = cmd.ExecuteNonQuery();
            conexion.Close();
            if (filasafectadas > 0) return true;
            else return false;
        }

        // modifica
        public bool UpdateGS_OC_CAB_OBS_COMPORTAMIENTO(GS_OC_CAB_OBS_COMPORTAMIENTO_Bean cab_observaciones)
        {
            Console.WriteLine("modificando cabezeras");
            conexion.Open();
            SqlCommand cmd = new SqlCommand("" +
                "UPDATE [PoderosaFocus].[dbo].[GS_OC_CAB_OBS_COMPORTAMIENTO] SET " +
                "[CIA_ID] = '"+ cab_observaciones.CIA_ID+ "', " +
                "[ANNOMES] = '" + cab_observaciones.ANNOMES+ "', " +
                "[OBSERVACION_ID] = '" + cab_observaciones.OBSERVACION_ID+ "', " +
                "[TRAB_ID] = '" + cab_observaciones.TRAB_ID+ "', " +
                "[PROVEEDOR_ID_OBSERVADOR] = '" + cab_observaciones.PROVEEDOR_ID_OBSERVADOR+ "', " +
                "[DPTO_ID] = '" + cab_observaciones.DPTO_ID+ "', " +
                "[FECHA_OBSERVACION] = convert(datetime, '" + cab_observaciones.FECHA_OBSERVACION+ " '), " +
                "[ACTIVIDAD_ID] = '" + cab_observaciones.ACTIVIDAD_ID+ "', " +
                "[ZONA_ID] = '" + cab_observaciones.ZONA_ID+ "', " +
                "[LABOR_ID] = '" + cab_observaciones.LABOR_ID+ "', " +
                "[ACCIONES_SEGURAS_OBS] = '" + cab_observaciones.ACCIONES_SEGURAS_OBS+ "', " +
                "[ACTOS_INSEGUROS_OBS] = '" + cab_observaciones.ACTOS_INSEGUROS_OBS+ "', " +
                "[NRO_PERSONAS_CONTACTADAS] = '" + cab_observaciones.NRO_PERSONAS_CONTACTADAS+ "', " +
                "[NRO_PERSONAS_OBSERVADAS] = '" + cab_observaciones.NRO_PERSONAS_OBSERVADAS+ "', " +
                "[OPERADOR_CREA] = '" + cab_observaciones.OPERADOR_CREA+ "', " +
                "[FECHA_CREA] = convert(datetime, '" + cab_observaciones.FECHA_CREA+ " '), " +
                "[OPERADOR_MODI] = '" + cab_observaciones.OPERADOR_MODI+ "', " +
                "[FECHA_MODI] = convert(datetime, '" + cab_observaciones.FECHA_MODI+ " '), " +
                "[TURNO] = '" + cab_observaciones.TURNO+ "'," +
                "[TIEMPO] = '" + cab_observaciones.TIEMPO+ "', " +
                "[PROVEEDOR_ID_OBSERVADOS] = '" + cab_observaciones.PROVEEDOR_ID_OBSERVADOS+ "', " +
                "[ESTADO] = '" + cab_observaciones.ESTADO+ "' " +
                "where CIA_ID = '" + cab_observaciones.CIA_ID + "' and " +
                "ANNOMES = '" + cab_observaciones.ANNOMES + "' and " +
                "OBSERVACION_ID = '" + cab_observaciones.OBSERVACION_ID + "' ", conexion);

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
