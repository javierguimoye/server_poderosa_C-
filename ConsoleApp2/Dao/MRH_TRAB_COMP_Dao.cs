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
    class MRH_TRAB_COMP_Dao
    {
        //private SqlConnection conexion = new SqlConnection("Data Source = GERRYSOFT; Initial Catalog = Tutoriales; Integrated Security = true");
        private SqlConnection conexion = new SqlConnection("Data Source = (local); Initial Catalog = PoderosaFocus; Integrated Security = true");
        private DataSet ds;

        public MRH_TRAB_COMP_Dao(){}


        public MRH_TRAB_COMP_Bean getMRH_TRAB_COMP()
        {
            MRH_TRAB_COMP_Bean trab = new MRH_TRAB_COMP_Bean();
            conexion.Open();
            SqlCommand cmd = new SqlCommand("SELECT TOP 20 [SET_ID],[TRAB_ID],[UBICA_ID]," +
                "[PLANILLA_ID],[PROVEEDOR_ID],[DESCR_CORTA],[ZONA_ID]," +
                "[ACTIVIDAD_ID],[DPTO_ID],[CUENTA_ID],[NOANX],[APELL_PATERNO]," +
                "[APELL_MATERNO],[NOMBRES],[LIB_ELEC],[FEC_INGRESO]," +
                "[FEC_CESE],[DESCR_CORTA_PROV],[TIPO_TRAB],[TIPO_REGPENSIONARIO]," +
                "[AFP_ID],[FEC_AFP],[NRO_AFP_ID],[RESP_TAREO],[SEC_TAREO]," +
                "[UBICACION_LABORAL],[OPERADOR_ID],[FECHA_CREA],[OPERADOR_MODI_ID]," +
                "[FECHA_MODI],[ESTADO_TRAB],[TIPO_TAREO],[DESTINO_TRAB],[PESO_TRAB]," +
                "[CATEG_ID],[ST_SENATI],[NRO_IPSS_VIDA],[FEC_IPSS_VIDA],[JEFE_ID]," +
                "[RUTA_FOTO],[USUARIO_ID],[ST_QUINCENA],[ST_TRANSFERENCIA]," +
                "[ST_TRANSF_SPT],[ST_AFP_LEY_27252],[PROVEEDOR_ANT],[DPTO_ANT]," +
                "[ACTIVIDAD_ANT],[CONDUCIR_CTA],[CONDUCIR_CAL],[CONDUCIR_CAP]," +
                "[CONDUCIR_EQP],[MANIPULEO_EXPLOSIVOS],[TIPO_TRANSPORTE]," +
                "[TIPO_CONSUMO],[STATUS_TRABAJADOR],[COD_FOTOCHECK],[FEC_VIGENCIA_FOTOCHECK]," +
                "[ST_ESSALUD],[ST_ASIGFAM],[ST_SINDICATO],[ST_DIR_SINDICATO]," +
                "[NIVEL_ACCESO_FOTOCHECK],[ST_DECL_QUINTA],[ST_LAB_OTRAEMPRESA]," +
                "[PUESTO_ID],[AREA_ID],[APROX_PUESTO],[JEFE_ADM_ID],[COMP_NOBOLEO]," +
                "[DOMINIO_USUARIO],[ST_FCJMS] FROM [PoderosaFocus].[dbo].[MRH_TRAB_COMP]", conexion);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            SqlDataReader r = cmd.ExecuteReader();
            if (r.HasRows)
            {
                while (r.Read())
                {
                    trab.SET_ID                 = r["SET_ID"].ToString();
                    trab.TRAB_ID                = r["TRAB_ID"].ToString();
                    trab.UBICA_ID               = r["UBICA_ID"].ToString();
                    trab.PLANILLA_ID            = r["PLANILLA_ID"].ToString();
                    trab.PROVEEDOR_ID           = r["PROVEEDOR_ID"].ToString();
                    trab.DESCR_CORTA            = r["DESCR_CORTA"].ToString();
                    trab.ZONA_ID                = r["ZONA_ID"].ToString();
                    trab.ACTIVIDAD_ID           = r["ACTIVIDAD_ID"].ToString();
                    trab.DPTO_ID                = r["DPTO_ID"].ToString();
                    trab.CUENTA_ID              = r["CUENTA_ID"].ToString();
                    trab.NOANX                  = r["NOANX"].ToString();
                    trab.APELL_PATERNO          = r["APELL_PATERNO"].ToString();
                    trab.APELL_MATERNO          = r["APELL_MATERNO"].ToString();
                    trab.NOMBRES                = r["NOMBRES"].ToString();
                    trab.LIB_ELEC               = r["LIB_ELEC"].ToString();
                    trab.FEC_INGRESO            = r["FEC_INGRESO"].ToString();
                    trab.FEC_CESE               = r["FEC_CESE"].ToString();
                    trab.DESCR_CORTA_PROV       = r["DESCR_CORTA_PROV"].ToString();
                    trab.TIPO_TRAB              = r["TIPO_TRAB"].ToString();
                    trab.TIPO_REGPENSIONARIO    = r["TIPO_REGPENSIONARIO"].ToString();
                    trab.AFP_ID                 = r["AFP_ID"].ToString();
                    trab.FEC_AFP                = r["FEC_AFP"].ToString();
                    trab.NRO_AFP_ID             = r["NRO_AFP_ID"].ToString();
                    trab.RESP_TAREO             = r["RESP_TAREO"].ToString();
                    trab.SEC_TAREO              = r["SEC_TAREO"].ToString();
                    trab.UBICACION_LABORAL      = r["UBICACION_LABORAL"].ToString();
                    trab.OPERADOR_ID            = r["OPERADOR_ID"].ToString();
                    trab.FECHA_CREA             = r["FECHA_CREA"].ToString();
                    trab.OPERADOR_MODI_ID       = r["OPERADOR_MODI_ID"].ToString();
                    trab.FECHA_MODI             = r["FECHA_MODI"].ToString();
                    trab.ESTADO_TRAB            = r["ESTADO_TRAB"].ToString();
                    trab.TIPO_TAREO             = r["TIPO_TAREO"].ToString();
                    trab.DESTINO_TRAB           = r["DESTINO_TRAB"].ToString();
                    trab.PESO_TRAB              = r["PESO_TRAB"].ToString();
                    trab.CATEG_ID               = r["CATEG_ID"].ToString();
                    trab.ST_SENATI              = r["ST_SENATI"].ToString();
                    trab.NRO_IPSS_VIDA          = r["NRO_IPSS_VIDA"].ToString();
                    trab.FEC_IPSS_VIDA          = r["FEC_IPSS_VIDA"].ToString();
                    trab.JEFE_ID                = r["JEFE_ID"].ToString();
                    trab.RUTA_FOTO              = r["RUTA_FOTO"].ToString();
                    trab.USUARIO_ID             = r["USUARIO_ID"].ToString();
                    trab.ST_QUINCENA            = r["ST_QUINCENA"].ToString();
                    trab.ST_TRANSFERENCIA       = r["ST_TRANSFERENCIA"].ToString();
                    trab.ST_TRANSF_SPT          = r["ST_TRANSF_SPT"].ToString();
                    trab.ST_AFP_LEY_27252       = r["ST_AFP_LEY_27252"].ToString();
                    trab.PROVEEDOR_ANT          = r["PROVEEDOR_ANT"].ToString();
                    trab.DPTO_ANT               = r["DPTO_ANT"].ToString();
                    trab.ACTIVIDAD_ANT          = r["ACTIVIDAD_ANT"].ToString();
                    trab.CONDUCIR_CTA           = r["CONDUCIR_CTA"].ToString();
                    trab.CONDUCIR_CAL           = r["CONDUCIR_CAL"].ToString();
                    trab.CONDUCIR_CAP           = r["CONDUCIR_CAP"].ToString();
                    trab.CONDUCIR_EQP           = r["CONDUCIR_EQP"].ToString();
                    trab.MANIPULEO_EXPLOSIVOS   = r["MANIPULEO_EXPLOSIVOS"].ToString();
                    trab.TIPO_TRANSPORTE        = r["TIPO_TRANSPORTE"].ToString();
                    trab.TIPO_CONSUMO           = r["TIPO_CONSUMO"].ToString();
                    trab.STATUS_TRABAJADOR      = r["STATUS_TRABAJADOR"].ToString();
                    trab.COD_FOTOCHECK          = r["COD_FOTOCHECK"].ToString();
                    trab.FEC_VIGENCIA_FOTOCHECK = r["FEC_VIGENCIA_FOTOCHECK"].ToString();
                    trab.ST_ESSALUD             = r["ST_ESSALUD"].ToString();
                    trab.ST_ASIGFAM             = r["ST_ASIGFAM"].ToString();
                    trab.ST_SINDICATO           = r["ST_SINDICATO"].ToString();
                    trab.ST_DIR_SINDICATO       = r["ST_DIR_SINDICATO"].ToString();
                    trab.NIVEL_ACCESO_FOTOCHECK = r["NIVEL_ACCESO_FOTOCHECK"].ToString();
                    trab.ST_DECL_QUINTA         = r["ST_DECL_QUINTA"].ToString();
                    trab.ST_LAB_OTRAEMPRESA     = r["ST_LAB_OTRAEMPRESA"].ToString();
                    trab.PUESTO_ID              = r["PUESTO_ID"].ToString();
                    trab.AREA_ID                = r["AREA_ID"].ToString();
                    trab.APROX_PUESTO           = r["APROX_PUESTO"].ToString();
                    trab.JEFE_ADM_ID            = r["JEFE_ADM_ID"].ToString();
                    trab.COMP_NOBOLEO           = r["COMP_NOBOLEO"].ToString();
                    trab.DOMINIO_USUARIO        = r["DOMINIO_USUARIO"].ToString();
                    trab.ST_FCJMS               = r["ST_FCJMS"].ToString();

                }
            }

            return trab;
        }



           public List<MRH_TRAB_COMP_Bean> getDia_MRH_TRAB_COMP(String mes, String ano, String dia)
        {
            List<MRH_TRAB_COMP_Bean> trabList = new List<MRH_TRAB_COMP_Bean>();
           
            conexion.Open();
            SqlCommand cmd = new SqlCommand("SELECT [SET_ID],[TRAB_ID],[UBICA_ID]," +
                "[PLANILLA_ID],[PROVEEDOR_ID],[DESCR_CORTA],[ZONA_ID]," +
                "[ACTIVIDAD_ID],[DPTO_ID],[CUENTA_ID],[NOANX],[APELL_PATERNO]," +
                "[APELL_MATERNO],[NOMBRES],[LIB_ELEC],[FEC_INGRESO]," +
                "[FEC_CESE],[DESCR_CORTA_PROV],[TIPO_TRAB],[TIPO_REGPENSIONARIO]," +
                "[AFP_ID],[FEC_AFP],[NRO_AFP_ID],[RESP_TAREO],[SEC_TAREO]," +
                "[UBICACION_LABORAL],[OPERADOR_ID],[FECHA_CREA],[OPERADOR_MODI_ID]," +
                "[FECHA_MODI],[ESTADO_TRAB],[TIPO_TAREO],[DESTINO_TRAB],[PESO_TRAB]," +
                "[CATEG_ID],[ST_SENATI],[NRO_IPSS_VIDA],[FEC_IPSS_VIDA],[JEFE_ID]," +
                "[RUTA_FOTO],[USUARIO_ID],[ST_QUINCENA],[ST_TRANSFERENCIA]," +
                "[ST_TRANSF_SPT],[ST_AFP_LEY_27252],[PROVEEDOR_ANT],[DPTO_ANT]," +
                "[ACTIVIDAD_ANT],[CONDUCIR_CTA],[CONDUCIR_CAL],[CONDUCIR_CAP]," +
                "[CONDUCIR_EQP],[MANIPULEO_EXPLOSIVOS],[TIPO_TRANSPORTE]," +
                "[TIPO_CONSUMO],[STATUS_TRABAJADOR],[COD_FOTOCHECK],[FEC_VIGENCIA_FOTOCHECK]," +
                "[ST_ESSALUD],[ST_ASIGFAM],[ST_SINDICATO],[ST_DIR_SINDICATO]," +
                "[NIVEL_ACCESO_FOTOCHECK],[ST_DECL_QUINTA],[ST_LAB_OTRAEMPRESA]," +
                "[PUESTO_ID],[AREA_ID],[APROX_PUESTO],[JEFE_ADM_ID],[COMP_NOBOLEO]," +
                "[DOMINIO_USUARIO],[ST_FCJMS] FROM [PoderosaFocus].[dbo].[MRH_TRAB_COMP] " +
                "WHERE MONTH(FECHA_CREA) = '" + mes + "' AND YEAR(FECHA_CREA) = '" + ano + "' AND DAY(FECHA_CREA) = '" + dia + "'", conexion);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            SqlDataReader r = cmd.ExecuteReader();
            if (r.HasRows)
            {
                while (r.Read())
                {
                    MRH_TRAB_COMP_Bean trab = new MRH_TRAB_COMP_Bean();
                    trab.SET_ID = r["SET_ID"].ToString();
                    trab.TRAB_ID = r["TRAB_ID"].ToString();
                    trab.UBICA_ID = r["UBICA_ID"].ToString();
                    trab.PLANILLA_ID = r["PLANILLA_ID"].ToString();
                    trab.PROVEEDOR_ID = r["PROVEEDOR_ID"].ToString();
                    trab.DESCR_CORTA = r["DESCR_CORTA"].ToString();
                    trab.ZONA_ID = r["ZONA_ID"].ToString();
                    trab.ACTIVIDAD_ID = r["ACTIVIDAD_ID"].ToString();
                    trab.DPTO_ID = r["DPTO_ID"].ToString();
                    trab.CUENTA_ID = r["CUENTA_ID"].ToString();
                    trab.NOANX = r["NOANX"].ToString();
                    trab.APELL_PATERNO = r["APELL_PATERNO"].ToString();
                    trab.APELL_MATERNO = r["APELL_MATERNO"].ToString();
                    trab.NOMBRES = r["NOMBRES"].ToString();
                    trab.LIB_ELEC = r["LIB_ELEC"].ToString();
                    trab.FEC_INGRESO = r["FEC_INGRESO"].ToString();
                    trab.FEC_CESE = r["FEC_CESE"].ToString();
                    trab.DESCR_CORTA_PROV = r["DESCR_CORTA_PROV"].ToString();
                    trab.TIPO_TRAB = r["TIPO_TRAB"].ToString();
                    trab.TIPO_REGPENSIONARIO = r["TIPO_REGPENSIONARIO"].ToString();
                    trab.AFP_ID = r["AFP_ID"].ToString();
                    trab.FEC_AFP = r["FEC_AFP"].ToString();
                    trab.NRO_AFP_ID = r["NRO_AFP_ID"].ToString();
                    trab.RESP_TAREO = r["RESP_TAREO"].ToString();
                    trab.SEC_TAREO = r["SEC_TAREO"].ToString();
                    trab.UBICACION_LABORAL = r["UBICACION_LABORAL"].ToString();
                    trab.OPERADOR_ID = r["OPERADOR_ID"].ToString();
                    trab.FECHA_CREA = r["FECHA_CREA"].ToString();
                    trab.OPERADOR_MODI_ID = r["OPERADOR_MODI_ID"].ToString();
                    trab.FECHA_MODI = r["FECHA_MODI"].ToString();
                    trab.ESTADO_TRAB = r["ESTADO_TRAB"].ToString();
                    trab.TIPO_TAREO = r["TIPO_TAREO"].ToString();
                    trab.DESTINO_TRAB = r["DESTINO_TRAB"].ToString();
                    trab.PESO_TRAB = r["PESO_TRAB"].ToString();
                    trab.CATEG_ID = r["CATEG_ID"].ToString();
                    trab.ST_SENATI = r["ST_SENATI"].ToString();
                    trab.NRO_IPSS_VIDA = r["NRO_IPSS_VIDA"].ToString();
                    trab.FEC_IPSS_VIDA = r["FEC_IPSS_VIDA"].ToString();
                    trab.JEFE_ID = r["JEFE_ID"].ToString();
                    trab.RUTA_FOTO = r["RUTA_FOTO"].ToString();
                    trab.USUARIO_ID = r["USUARIO_ID"].ToString();
                    trab.ST_QUINCENA = r["ST_QUINCENA"].ToString();
                    trab.ST_TRANSFERENCIA = r["ST_TRANSFERENCIA"].ToString();
                    trab.ST_TRANSF_SPT = r["ST_TRANSF_SPT"].ToString();
                    trab.ST_AFP_LEY_27252 = r["ST_AFP_LEY_27252"].ToString();
                    trab.PROVEEDOR_ANT = r["PROVEEDOR_ANT"].ToString();
                    trab.DPTO_ANT = r["DPTO_ANT"].ToString();
                    trab.ACTIVIDAD_ANT = r["ACTIVIDAD_ANT"].ToString();
                    trab.CONDUCIR_CTA = r["CONDUCIR_CTA"].ToString();
                    trab.CONDUCIR_CAL = r["CONDUCIR_CAL"].ToString();
                    trab.CONDUCIR_CAP = r["CONDUCIR_CAP"].ToString();
                    trab.CONDUCIR_EQP = r["CONDUCIR_EQP"].ToString();
                    trab.MANIPULEO_EXPLOSIVOS = r["MANIPULEO_EXPLOSIVOS"].ToString();
                    trab.TIPO_TRANSPORTE = r["TIPO_TRANSPORTE"].ToString();
                    trab.TIPO_CONSUMO = r["TIPO_CONSUMO"].ToString();
                    trab.STATUS_TRABAJADOR = r["STATUS_TRABAJADOR"].ToString();
                    trab.COD_FOTOCHECK = r["COD_FOTOCHECK"].ToString();
                    trab.FEC_VIGENCIA_FOTOCHECK = r["FEC_VIGENCIA_FOTOCHECK"].ToString();
                    trab.ST_ESSALUD = r["ST_ESSALUD"].ToString();
                    trab.ST_ASIGFAM = r["ST_ASIGFAM"].ToString();
                    trab.ST_SINDICATO = r["ST_SINDICATO"].ToString();
                    trab.ST_DIR_SINDICATO = r["ST_DIR_SINDICATO"].ToString();
                    trab.NIVEL_ACCESO_FOTOCHECK = r["NIVEL_ACCESO_FOTOCHECK"].ToString();
                    trab.ST_DECL_QUINTA = r["ST_DECL_QUINTA"].ToString();
                    trab.ST_LAB_OTRAEMPRESA = r["ST_LAB_OTRAEMPRESA"].ToString();
                    trab.PUESTO_ID = r["PUESTO_ID"].ToString();
                    trab.AREA_ID = r["AREA_ID"].ToString();
                    trab.APROX_PUESTO = r["APROX_PUESTO"].ToString();
                    trab.JEFE_ADM_ID = r["JEFE_ADM_ID"].ToString();
                    trab.COMP_NOBOLEO = r["COMP_NOBOLEO"].ToString();
                    trab.DOMINIO_USUARIO = r["DOMINIO_USUARIO"].ToString();
                    trab.ST_FCJMS = r["ST_FCJMS"].ToString();
                    trabList.Add(trab);
                }
            }

            return trabList;
        }

        public List<MRH_TRAB_COMP_Bean> getMes_MRH_TRAB_COMP(String mes, String ano)
        {
            List<MRH_TRAB_COMP_Bean> trabList = new List<MRH_TRAB_COMP_Bean>();

            conexion.Open();
            SqlCommand cmd = new SqlCommand("SELECT [SET_ID],[TRAB_ID],[UBICA_ID]," +
                "[PLANILLA_ID],[PROVEEDOR_ID],[DESCR_CORTA],[ZONA_ID]," +
                "[ACTIVIDAD_ID],[DPTO_ID],[CUENTA_ID],[NOANX],[APELL_PATERNO]," +
                "[APELL_MATERNO],[NOMBRES],[LIB_ELEC],[FEC_INGRESO]," +
                "[FEC_CESE],[DESCR_CORTA_PROV],[TIPO_TRAB],[TIPO_REGPENSIONARIO]," +
                "[AFP_ID],[FEC_AFP],[NRO_AFP_ID],[RESP_TAREO],[SEC_TAREO]," +
                "[UBICACION_LABORAL],[OPERADOR_ID],[FECHA_CREA],[OPERADOR_MODI_ID]," +
                "[FECHA_MODI],[ESTADO_TRAB],[TIPO_TAREO],[DESTINO_TRAB],[PESO_TRAB]," +
                "[CATEG_ID],[ST_SENATI],[NRO_IPSS_VIDA],[FEC_IPSS_VIDA],[JEFE_ID]," +
                "[RUTA_FOTO],[USUARIO_ID],[ST_QUINCENA],[ST_TRANSFERENCIA]," +
                "[ST_TRANSF_SPT],[ST_AFP_LEY_27252],[PROVEEDOR_ANT],[DPTO_ANT]," +
                "[ACTIVIDAD_ANT],[CONDUCIR_CTA],[CONDUCIR_CAL],[CONDUCIR_CAP]," +
                "[CONDUCIR_EQP],[MANIPULEO_EXPLOSIVOS],[TIPO_TRANSPORTE]," +
                "[TIPO_CONSUMO],[STATUS_TRABAJADOR],[COD_FOTOCHECK],[FEC_VIGENCIA_FOTOCHECK]," +
                "[ST_ESSALUD],[ST_ASIGFAM],[ST_SINDICATO],[ST_DIR_SINDICATO]," +
                "[NIVEL_ACCESO_FOTOCHECK],[ST_DECL_QUINTA],[ST_LAB_OTRAEMPRESA]," +
                "[PUESTO_ID],[AREA_ID],[APROX_PUESTO],[JEFE_ADM_ID],[COMP_NOBOLEO]," +
                "[DOMINIO_USUARIO],[ST_FCJMS] FROM [PoderosaFocus].[dbo].[MRH_TRAB_COMP] " +
                "WHERE MONTH(FECHA_CREA) = '" + mes + "' AND YEAR(FECHA_CREA) = '" + ano + "'", conexion);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            SqlDataReader r = cmd.ExecuteReader();
            if (r.HasRows)
            {
                while (r.Read())
                {
                    MRH_TRAB_COMP_Bean trab = new MRH_TRAB_COMP_Bean();
                    trab.SET_ID = r["SET_ID"].ToString();
                    trab.TRAB_ID = r["TRAB_ID"].ToString();
                    trab.UBICA_ID = r["UBICA_ID"].ToString();
                    trab.PLANILLA_ID = r["PLANILLA_ID"].ToString();
                    trab.PROVEEDOR_ID = r["PROVEEDOR_ID"].ToString();
                    trab.DESCR_CORTA = r["DESCR_CORTA"].ToString();
                    trab.ZONA_ID = r["ZONA_ID"].ToString();
                    trab.ACTIVIDAD_ID = r["ACTIVIDAD_ID"].ToString();
                    trab.DPTO_ID = r["DPTO_ID"].ToString();
                    trab.CUENTA_ID = r["CUENTA_ID"].ToString();
                    trab.NOANX = r["NOANX"].ToString();
                    trab.APELL_PATERNO = r["APELL_PATERNO"].ToString();
                    trab.APELL_MATERNO = r["APELL_MATERNO"].ToString();
                    trab.NOMBRES = r["NOMBRES"].ToString();
                    trab.LIB_ELEC = r["LIB_ELEC"].ToString();
                    trab.FEC_INGRESO = r["FEC_INGRESO"].ToString();
                    trab.FEC_CESE = r["FEC_CESE"].ToString();
                    trab.DESCR_CORTA_PROV = r["DESCR_CORTA_PROV"].ToString();
                    trab.TIPO_TRAB = r["TIPO_TRAB"].ToString();
                    trab.TIPO_REGPENSIONARIO = r["TIPO_REGPENSIONARIO"].ToString();
                    trab.AFP_ID = r["AFP_ID"].ToString();
                    trab.FEC_AFP = r["FEC_AFP"].ToString();
                    trab.NRO_AFP_ID = r["NRO_AFP_ID"].ToString();
                    trab.RESP_TAREO = r["RESP_TAREO"].ToString();
                    trab.SEC_TAREO = r["SEC_TAREO"].ToString();
                    trab.UBICACION_LABORAL = r["UBICACION_LABORAL"].ToString();
                    trab.OPERADOR_ID = r["OPERADOR_ID"].ToString();
                    trab.FECHA_CREA = r["FECHA_CREA"].ToString();
                    trab.OPERADOR_MODI_ID = r["OPERADOR_MODI_ID"].ToString();
                    trab.FECHA_MODI = r["FECHA_MODI"].ToString();
                    trab.ESTADO_TRAB = r["ESTADO_TRAB"].ToString();
                    trab.TIPO_TAREO = r["TIPO_TAREO"].ToString();
                    trab.DESTINO_TRAB = r["DESTINO_TRAB"].ToString();
                    trab.PESO_TRAB = r["PESO_TRAB"].ToString();
                    trab.CATEG_ID = r["CATEG_ID"].ToString();
                    trab.ST_SENATI = r["ST_SENATI"].ToString();
                    trab.NRO_IPSS_VIDA = r["NRO_IPSS_VIDA"].ToString();
                    trab.FEC_IPSS_VIDA = r["FEC_IPSS_VIDA"].ToString();
                    trab.JEFE_ID = r["JEFE_ID"].ToString();
                    trab.RUTA_FOTO = r["RUTA_FOTO"].ToString();
                    trab.USUARIO_ID = r["USUARIO_ID"].ToString();
                    trab.ST_QUINCENA = r["ST_QUINCENA"].ToString();
                    trab.ST_TRANSFERENCIA = r["ST_TRANSFERENCIA"].ToString();
                    trab.ST_TRANSF_SPT = r["ST_TRANSF_SPT"].ToString();
                    trab.ST_AFP_LEY_27252 = r["ST_AFP_LEY_27252"].ToString();
                    trab.PROVEEDOR_ANT = r["PROVEEDOR_ANT"].ToString();
                    trab.DPTO_ANT = r["DPTO_ANT"].ToString();
                    trab.ACTIVIDAD_ANT = r["ACTIVIDAD_ANT"].ToString();
                    trab.CONDUCIR_CTA = r["CONDUCIR_CTA"].ToString();
                    trab.CONDUCIR_CAL = r["CONDUCIR_CAL"].ToString();
                    trab.CONDUCIR_CAP = r["CONDUCIR_CAP"].ToString();
                    trab.CONDUCIR_EQP = r["CONDUCIR_EQP"].ToString();
                    trab.MANIPULEO_EXPLOSIVOS = r["MANIPULEO_EXPLOSIVOS"].ToString();
                    trab.TIPO_TRANSPORTE = r["TIPO_TRANSPORTE"].ToString();
                    trab.TIPO_CONSUMO = r["TIPO_CONSUMO"].ToString();
                    trab.STATUS_TRABAJADOR = r["STATUS_TRABAJADOR"].ToString();
                    trab.COD_FOTOCHECK = r["COD_FOTOCHECK"].ToString();
                    trab.FEC_VIGENCIA_FOTOCHECK = r["FEC_VIGENCIA_FOTOCHECK"].ToString();
                    trab.ST_ESSALUD = r["ST_ESSALUD"].ToString();
                    trab.ST_ASIGFAM = r["ST_ASIGFAM"].ToString();
                    trab.ST_SINDICATO = r["ST_SINDICATO"].ToString();
                    trab.ST_DIR_SINDICATO = r["ST_DIR_SINDICATO"].ToString();
                    trab.NIVEL_ACCESO_FOTOCHECK = r["NIVEL_ACCESO_FOTOCHECK"].ToString();
                    trab.ST_DECL_QUINTA = r["ST_DECL_QUINTA"].ToString();
                    trab.ST_LAB_OTRAEMPRESA = r["ST_LAB_OTRAEMPRESA"].ToString();
                    trab.PUESTO_ID = r["PUESTO_ID"].ToString();
                    trab.AREA_ID = r["AREA_ID"].ToString();
                    trab.APROX_PUESTO = r["APROX_PUESTO"].ToString();
                    trab.JEFE_ADM_ID = r["JEFE_ADM_ID"].ToString();
                    trab.COMP_NOBOLEO = r["COMP_NOBOLEO"].ToString();
                    trab.DOMINIO_USUARIO = r["DOMINIO_USUARIO"].ToString();
                    trab.ST_FCJMS = r["ST_FCJMS"].ToString();
                    trabList.Add(trab);
                }
            }

            return trabList;
        }
        public void closeBD()
        {
            conexion.Close();
        }
    }
}
