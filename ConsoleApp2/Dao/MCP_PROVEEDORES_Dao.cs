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
    class MCP_PROVEEDORES_Dao
    {
        private SqlConnection conexion = new SqlConnection("Data Source = (local); Initial Catalog = PoderosaFocus; Integrated Security = true");
        private DataSet ds;

        public MCP_PROVEEDORES_Dao(){}


        public MCP_PROVEEDORES_Bean getMCP_PROVEEDORES()
        {
            MCP_PROVEEDORES_Bean provedores = new MCP_PROVEEDORES_Bean();
            conexion.Open();
            SqlCommand cmd = new SqlCommand("SELECT TOP 20 [SET_ID],[DESCR_CORTA],[DESCR_PROV]," +
                "[PAIS],[CIUDAD],[DIREC_PROV],[DIREC2_PROV],[DIREC_ENTREGA]," +
                "[COD_POSTAL],[TELF1],[TELF2],[TELF_FAX1],[TELF_FAX2],[TIPO_PROV]," +
                "[PROVEEDOR_ID],[GIRO_NEGOCIO],[UBICA_ID],[CUENTA_ID],[ST_COMEDOR]," +
                "[ST_TIPO_SUBVENCION],[ST_COMEDOR_CTA_EMPRESA],[DIREC_INTERNET],[DIREC_CORREO]," +
                "[SOLIC_APERTURA],[OPERADOR_ID],[FECHA_CREA],[OPERADOR_MODI_ID],[FECHA_MODI]," +
                "[ESTADO_PROVEEDOR],[ST_TRANSFERENCIA],[TIPO_PERSONA],[PROVEEDOR_ANT]," +
                "[DESCR_PROV_ANT],[ST_AGENTE_RETENEDOR],[ST_BCONTRIBUYENTE],[ST_SUBVENCION_TP]," +
                "[ST_DETRACCION],[ST_EXCL_RETENCION],[ST_COMERCIALIZA],[ST_COBERTURA],[ST_GTOSCOMP]," +
                "[INI_COBERTURA],[DIA_CONCLU],[NRO_REG_DETRACCION],[ST_CONDICION_DOM],[ACTIVIDAD_ECONOMICA]," +
                "[FECNAC],[SEXO],[NACIONALIDAD],[ST_AGENTE_PERCEPCION],[SITUACION_PROV],[CLASIFICACION_FINANCIERA]," +
                "[UBIGEO_ID],[URBANIZACION] FROM [PoderosaFocus].[dbo].[MCP_PROVEEDORES]", conexion);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            SqlDataReader r = cmd.ExecuteReader();
            if (r.HasRows)
            {
                while (r.Read())
                {
                    provedores.SET_ID                   = r["SET_ID"].ToString();
                    provedores.DESCR_CORTA              = r["DESCR_CORTA"].ToString();
                    provedores.DESCR_PROV               = r["DESCR_PROV"].ToString();
                    provedores.PAIS                     = r["PAIS"].ToString();
                    provedores.CIUDAD                   = r["CIUDAD"].ToString();
                    provedores.DIREC_PROV               = r["DIREC_PROV"].ToString();
                    provedores.DIREC2_PROV              = r["DIREC2_PROV"].ToString();
                    provedores.DIREC_ENTREGA            = r["DIREC_ENTREGA"].ToString();
                    provedores.COD_POSTAL               = r["COD_POSTAL"].ToString();
                    provedores.TELF1                    = r["TELF1"].ToString();
                    provedores.TELF2                    = r["TELF2"].ToString();
                    provedores.TELF_FAX1                = r["TELF_FAX1"].ToString();
                    provedores.TELF_FAX2                = r["TELF_FAX2"].ToString();
                    provedores.TIPO_PROV                = r["TIPO_PROV"].ToString();
                    provedores.PROVEEDOR_ID             = r["PROVEEDOR_ID"].ToString();
                    provedores.GIRO_NEGOCIO             = r["GIRO_NEGOCIO"].ToString();
                    provedores.UBICA_ID                 = r["UBICA_ID"].ToString();
                    provedores.CUENTA_ID                = r["CUENTA_ID"].ToString();
                    provedores.ST_COMEDOR               = r["ST_COMEDOR"].ToString();
                    provedores.ST_TIPO_SUBVENCION       = r["ST_TIPO_SUBVENCION"].ToString();
                    provedores.ST_COMEDOR_CTA_EMPRESA   = r["ST_COMEDOR_CTA_EMPRESA"].ToString();
                    provedores.DIREC_INTERNET           = r["DIREC_INTERNET"].ToString();
                    provedores.DIREC_CORREO             = r["DIREC_CORREO"].ToString();
                    provedores.SOLIC_APERTURA           = r["SOLIC_APERTURA"].ToString();
                    provedores.OPERADOR_ID              = r["OPERADOR_ID"].ToString();
                    provedores.FECHA_CREA               = r["FECHA_CREA"].ToString();
                    provedores.OPERADOR_MODI_ID         = r["OPERADOR_MODI_ID"].ToString();
                    provedores.FECHA_MODI               = r["FECHA_MODI"].ToString();
                    provedores.ESTADO_PROVEEDOR         = r["ESTADO_PROVEEDOR"].ToString();
                    provedores.ST_TRANSFERENCIA         = r["ST_TRANSFERENCIA"].ToString();
                    provedores.TIPO_PERSONA             = r["TIPO_PERSONA"].ToString();
                    provedores.PROVEEDOR_ANT            = r["PROVEEDOR_ANT"].ToString();
                    provedores.DESCR_PROV_ANT           = r["DESCR_PROV_ANT"].ToString();
                    provedores.ST_AGENTE_RETENEDOR      = r["ST_AGENTE_RETENEDOR"].ToString();
                    provedores.ST_BCONTRIBUYENTE        = r["ST_BCONTRIBUYENTE"].ToString();
                    provedores.ST_SUBVENCION_TP         = r["ST_SUBVENCION_TP"].ToString();
                    provedores.ST_DETRACCION            = r["ST_DETRACCION"].ToString();
                    provedores.ST_EXCL_RETENCION        = r["ST_EXCL_RETENCION"].ToString();
                    provedores.ST_COMERCIALIZA          = r["ST_COMERCIALIZA"].ToString();
                    provedores.ST_COBERTURA             = r["ST_COBERTURA"].ToString();
                    provedores.ST_GTOSCOMP              = r["ST_GTOSCOMP"].ToString();
                    provedores.INI_COBERTURA            = r["INI_COBERTURA"].ToString();
                    provedores.DIA_CONCLU               = r["DIA_CONCLU"].ToString();
                    provedores.NRO_REG_DETRACCION       = r["NRO_REG_DETRACCION"].ToString();
                    provedores.ST_CONDICION_DOM         = r["ST_CONDICION_DOM"].ToString();
                    provedores.ACTIVIDAD_ECONOMICA      = r["ACTIVIDAD_ECONOMICA"].ToString();
                    provedores.FECNAC                   = r["FECNAC"].ToString();
                    provedores.SEXO                     = r["SEXO"].ToString();
                    provedores.NACIONALIDAD             = r["NACIONALIDAD"].ToString();
                    provedores.ST_AGENTE_PERCEPCION     = r["ST_AGENTE_PERCEPCION"].ToString();
                    provedores.SITUACION_PROV           = r["SITUACION_PROV"].ToString();
                    provedores.CLASIFICACION_FINANCIERA = r["CLASIFICACION_FINANCIERA"].ToString();
                    provedores.UBIGEO_ID                = r["UBIGEO_ID"].ToString();
                    provedores.URBANIZACION             = r["URBANIZACION"].ToString();


                }
            }

            return provedores;
        }


        public List<MCP_PROVEEDORES_Bean> getMes_MCP_PROVEEDORES(String mes, String ano)
        {
            List<MCP_PROVEEDORES_Bean> provedoresList = new List<MCP_PROVEEDORES_Bean>();
            conexion.Open();
            SqlCommand cmd = new SqlCommand("SELECT [SET_ID],[DESCR_CORTA],[DESCR_PROV]," +
                "[PAIS],[CIUDAD],[DIREC_PROV],[DIREC2_PROV],[DIREC_ENTREGA]," +
                "[COD_POSTAL],[TELF1],[TELF2],[TELF_FAX1],[TELF_FAX2],[TIPO_PROV]," +
                "[PROVEEDOR_ID],[GIRO_NEGOCIO],[UBICA_ID],[CUENTA_ID],[ST_COMEDOR]," +
                "[ST_TIPO_SUBVENCION],[ST_COMEDOR_CTA_EMPRESA],[DIREC_INTERNET],[DIREC_CORREO]," +
                "[SOLIC_APERTURA],[OPERADOR_ID],[FECHA_CREA],[OPERADOR_MODI_ID],[FECHA_MODI]," +
                "[ESTADO_PROVEEDOR],[ST_TRANSFERENCIA],[TIPO_PERSONA],[PROVEEDOR_ANT]," +
                "[DESCR_PROV_ANT],[ST_AGENTE_RETENEDOR],[ST_BCONTRIBUYENTE],[ST_SUBVENCION_TP]," +
                "[ST_DETRACCION],[ST_EXCL_RETENCION],[ST_COMERCIALIZA],[ST_COBERTURA],[ST_GTOSCOMP]," +
                "[INI_COBERTURA],[DIA_CONCLU],[NRO_REG_DETRACCION],[ST_CONDICION_DOM],[ACTIVIDAD_ECONOMICA]," +
                "[FECNAC],[SEXO],[NACIONALIDAD],[ST_AGENTE_PERCEPCION],[SITUACION_PROV],[CLASIFICACION_FINANCIERA]," +
                "[UBIGEO_ID],[URBANIZACION] FROM [PoderosaFocus].[dbo].[MCP_PROVEEDORES] " +
                "WHERE MONTH(FECHA_CREA) = '"+ mes + "' AND YEAR(FECHA_CREA) = '"+ ano + "'", conexion);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            SqlDataReader r = cmd.ExecuteReader();
            if (r.HasRows)
            {
                while (r.Read())
                {
                    MCP_PROVEEDORES_Bean provedores = new MCP_PROVEEDORES_Bean();
                    provedores.SET_ID = r["SET_ID"].ToString();
                    provedores.DESCR_CORTA = r["DESCR_CORTA"].ToString();
                    provedores.DESCR_PROV = r["DESCR_PROV"].ToString();
                    provedores.PAIS = r["PAIS"].ToString();
                    provedores.CIUDAD = r["CIUDAD"].ToString();
                    provedores.DIREC_PROV = r["DIREC_PROV"].ToString();
                    provedores.DIREC2_PROV = r["DIREC2_PROV"].ToString();
                    provedores.DIREC_ENTREGA = r["DIREC_ENTREGA"].ToString();
                    provedores.COD_POSTAL = r["COD_POSTAL"].ToString();
                    provedores.TELF1 = r["TELF1"].ToString();
                    provedores.TELF2 = r["TELF2"].ToString();
                    provedores.TELF_FAX1 = r["TELF_FAX1"].ToString();
                    provedores.TELF_FAX2 = r["TELF_FAX2"].ToString();
                    provedores.TIPO_PROV = r["TIPO_PROV"].ToString();
                    provedores.PROVEEDOR_ID = r["PROVEEDOR_ID"].ToString();
                    provedores.GIRO_NEGOCIO = r["GIRO_NEGOCIO"].ToString();
                    provedores.UBICA_ID = r["UBICA_ID"].ToString();
                    provedores.CUENTA_ID = r["CUENTA_ID"].ToString();
                    provedores.ST_COMEDOR = r["ST_COMEDOR"].ToString();
                    provedores.ST_TIPO_SUBVENCION = r["ST_TIPO_SUBVENCION"].ToString();
                    provedores.ST_COMEDOR_CTA_EMPRESA = r["ST_COMEDOR_CTA_EMPRESA"].ToString();
                    provedores.DIREC_INTERNET = r["DIREC_INTERNET"].ToString();
                    provedores.DIREC_CORREO = r["DIREC_CORREO"].ToString();
                    provedores.SOLIC_APERTURA = r["SOLIC_APERTURA"].ToString();
                    provedores.OPERADOR_ID = r["OPERADOR_ID"].ToString();
                    provedores.FECHA_CREA = r["FECHA_CREA"].ToString();
                    provedores.OPERADOR_MODI_ID = r["OPERADOR_MODI_ID"].ToString();
                    provedores.FECHA_MODI = r["FECHA_MODI"].ToString();
                    provedores.ESTADO_PROVEEDOR = r["ESTADO_PROVEEDOR"].ToString();
                    provedores.ST_TRANSFERENCIA = r["ST_TRANSFERENCIA"].ToString();
                    provedores.TIPO_PERSONA = r["TIPO_PERSONA"].ToString();
                    provedores.PROVEEDOR_ANT = r["PROVEEDOR_ANT"].ToString();
                    provedores.DESCR_PROV_ANT = r["DESCR_PROV_ANT"].ToString();
                    provedores.ST_AGENTE_RETENEDOR = r["ST_AGENTE_RETENEDOR"].ToString();
                    provedores.ST_BCONTRIBUYENTE = r["ST_BCONTRIBUYENTE"].ToString();
                    provedores.ST_SUBVENCION_TP = r["ST_SUBVENCION_TP"].ToString();
                    provedores.ST_DETRACCION = r["ST_DETRACCION"].ToString();
                    provedores.ST_EXCL_RETENCION = r["ST_EXCL_RETENCION"].ToString();
                    provedores.ST_COMERCIALIZA = r["ST_COMERCIALIZA"].ToString();
                    provedores.ST_COBERTURA = r["ST_COBERTURA"].ToString();
                    provedores.ST_GTOSCOMP = r["ST_GTOSCOMP"].ToString();
                    provedores.INI_COBERTURA = r["INI_COBERTURA"].ToString();
                    provedores.DIA_CONCLU = r["DIA_CONCLU"].ToString();
                    provedores.NRO_REG_DETRACCION = r["NRO_REG_DETRACCION"].ToString();
                    provedores.ST_CONDICION_DOM = r["ST_CONDICION_DOM"].ToString();
                    provedores.ACTIVIDAD_ECONOMICA = r["ACTIVIDAD_ECONOMICA"].ToString();
                    provedores.FECNAC = r["FECNAC"].ToString();
                    provedores.SEXO = r["SEXO"].ToString();
                    provedores.NACIONALIDAD = r["NACIONALIDAD"].ToString();
                    provedores.ST_AGENTE_PERCEPCION = r["ST_AGENTE_PERCEPCION"].ToString();
                    provedores.SITUACION_PROV = r["SITUACION_PROV"].ToString();
                    provedores.CLASIFICACION_FINANCIERA = r["CLASIFICACION_FINANCIERA"].ToString();
                    provedores.UBIGEO_ID = r["UBIGEO_ID"].ToString();
                    provedores.URBANIZACION = r["URBANIZACION"].ToString();
                    provedoresList.Add(provedores);

                }
            }

            return provedoresList;
        }


        public List<MCP_PROVEEDORES_Bean> getDia_MCP_PROVEEDORES(String mes, String ano, String dia)
        {
            List<MCP_PROVEEDORES_Bean> provedoresList = new List<MCP_PROVEEDORES_Bean>();
            conexion.Open();
            SqlCommand cmd = new SqlCommand("SELECT [SET_ID],[DESCR_CORTA],[DESCR_PROV]," +
                "[PAIS],[CIUDAD],[DIREC_PROV],[DIREC2_PROV],[DIREC_ENTREGA]," +
                "[COD_POSTAL],[TELF1],[TELF2],[TELF_FAX1],[TELF_FAX2],[TIPO_PROV]," +
                "[PROVEEDOR_ID],[GIRO_NEGOCIO],[UBICA_ID],[CUENTA_ID],[ST_COMEDOR]," +
                "[ST_TIPO_SUBVENCION],[ST_COMEDOR_CTA_EMPRESA],[DIREC_INTERNET],[DIREC_CORREO]," +
                "[SOLIC_APERTURA],[OPERADOR_ID],[FECHA_CREA],[OPERADOR_MODI_ID],[FECHA_MODI]," +
                "[ESTADO_PROVEEDOR],[ST_TRANSFERENCIA],[TIPO_PERSONA],[PROVEEDOR_ANT]," +
                "[DESCR_PROV_ANT],[ST_AGENTE_RETENEDOR],[ST_BCONTRIBUYENTE],[ST_SUBVENCION_TP]," +
                "[ST_DETRACCION],[ST_EXCL_RETENCION],[ST_COMERCIALIZA],[ST_COBERTURA],[ST_GTOSCOMP]," +
                "[INI_COBERTURA],[DIA_CONCLU],[NRO_REG_DETRACCION],[ST_CONDICION_DOM],[ACTIVIDAD_ECONOMICA]," +
                "[FECNAC],[SEXO],[NACIONALIDAD],[ST_AGENTE_PERCEPCION],[SITUACION_PROV],[CLASIFICACION_FINANCIERA]," +
                "[UBIGEO_ID],[URBANIZACION] FROM [PoderosaFocus].[dbo].[MCP_PROVEEDORES] " +
                "WHERE MONTH(FECHA_CREA) = '" + mes + "' AND " +
                "YEAR(FECHA_CREA) = '" + ano + "' AND " +
                "DAY(FECHA_CREA) = '"+dia+"'", conexion);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            SqlDataReader r = cmd.ExecuteReader();
            if (r.HasRows)
            {
                while (r.Read())
                {
                    MCP_PROVEEDORES_Bean provedores = new MCP_PROVEEDORES_Bean();
                    provedores.SET_ID = r["SET_ID"].ToString();
                    provedores.DESCR_CORTA = r["DESCR_CORTA"].ToString();
                    provedores.DESCR_PROV = r["DESCR_PROV"].ToString();
                    provedores.PAIS = r["PAIS"].ToString();
                    provedores.CIUDAD = r["CIUDAD"].ToString();
                    provedores.DIREC_PROV = r["DIREC_PROV"].ToString();
                    provedores.DIREC2_PROV = r["DIREC2_PROV"].ToString();
                    provedores.DIREC_ENTREGA = r["DIREC_ENTREGA"].ToString();
                    provedores.COD_POSTAL = r["COD_POSTAL"].ToString();
                    provedores.TELF1 = r["TELF1"].ToString();
                    provedores.TELF2 = r["TELF2"].ToString();
                    provedores.TELF_FAX1 = r["TELF_FAX1"].ToString();
                    provedores.TELF_FAX2 = r["TELF_FAX2"].ToString();
                    provedores.TIPO_PROV = r["TIPO_PROV"].ToString();
                    provedores.PROVEEDOR_ID = r["PROVEEDOR_ID"].ToString();
                    provedores.GIRO_NEGOCIO = r["GIRO_NEGOCIO"].ToString();
                    provedores.UBICA_ID = r["UBICA_ID"].ToString();
                    provedores.CUENTA_ID = r["CUENTA_ID"].ToString();
                    provedores.ST_COMEDOR = r["ST_COMEDOR"].ToString();
                    provedores.ST_TIPO_SUBVENCION = r["ST_TIPO_SUBVENCION"].ToString();
                    provedores.ST_COMEDOR_CTA_EMPRESA = r["ST_COMEDOR_CTA_EMPRESA"].ToString();
                    provedores.DIREC_INTERNET = r["DIREC_INTERNET"].ToString();
                    provedores.DIREC_CORREO = r["DIREC_CORREO"].ToString();
                    provedores.SOLIC_APERTURA = r["SOLIC_APERTURA"].ToString();
                    provedores.OPERADOR_ID = r["OPERADOR_ID"].ToString();
                    provedores.FECHA_CREA = r["FECHA_CREA"].ToString();
                    provedores.OPERADOR_MODI_ID = r["OPERADOR_MODI_ID"].ToString();
                    provedores.FECHA_MODI = r["FECHA_MODI"].ToString();
                    provedores.ESTADO_PROVEEDOR = r["ESTADO_PROVEEDOR"].ToString();
                    provedores.ST_TRANSFERENCIA = r["ST_TRANSFERENCIA"].ToString();
                    provedores.TIPO_PERSONA = r["TIPO_PERSONA"].ToString();
                    provedores.PROVEEDOR_ANT = r["PROVEEDOR_ANT"].ToString();
                    provedores.DESCR_PROV_ANT = r["DESCR_PROV_ANT"].ToString();
                    provedores.ST_AGENTE_RETENEDOR = r["ST_AGENTE_RETENEDOR"].ToString();
                    provedores.ST_BCONTRIBUYENTE = r["ST_BCONTRIBUYENTE"].ToString();
                    provedores.ST_SUBVENCION_TP = r["ST_SUBVENCION_TP"].ToString();
                    provedores.ST_DETRACCION = r["ST_DETRACCION"].ToString();
                    provedores.ST_EXCL_RETENCION = r["ST_EXCL_RETENCION"].ToString();
                    provedores.ST_COMERCIALIZA = r["ST_COMERCIALIZA"].ToString();
                    provedores.ST_COBERTURA = r["ST_COBERTURA"].ToString();
                    provedores.ST_GTOSCOMP = r["ST_GTOSCOMP"].ToString();
                    provedores.INI_COBERTURA = r["INI_COBERTURA"].ToString();
                    provedores.DIA_CONCLU = r["DIA_CONCLU"].ToString();
                    provedores.NRO_REG_DETRACCION = r["NRO_REG_DETRACCION"].ToString();
                    provedores.ST_CONDICION_DOM = r["ST_CONDICION_DOM"].ToString();
                    provedores.ACTIVIDAD_ECONOMICA = r["ACTIVIDAD_ECONOMICA"].ToString();
                    provedores.FECNAC = r["FECNAC"].ToString();
                    provedores.SEXO = r["SEXO"].ToString();
                    provedores.NACIONALIDAD = r["NACIONALIDAD"].ToString();
                    provedores.ST_AGENTE_PERCEPCION = r["ST_AGENTE_PERCEPCION"].ToString();
                    provedores.SITUACION_PROV = r["SITUACION_PROV"].ToString();
                    provedores.CLASIFICACION_FINANCIERA = r["CLASIFICACION_FINANCIERA"].ToString();
                    provedores.UBIGEO_ID = r["UBIGEO_ID"].ToString();
                    provedores.URBANIZACION = r["URBANIZACION"].ToString();
                    provedoresList.Add(provedores);
                }
            }

            return provedoresList;
        }



        public void closeBD()
        {
            conexion.Close();
        }

    }
}
