using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Models
{
   // [JsonObject("GS_OC_DET_OBS_COMPORTAMIENTO")]
    class GS_OC_DET_OBS_COMPORTAMIENTO_BeanJSON
    {

        String id;
        String sync;
        String sync_insert;
        String CIA_ID;
        String ANNOMES;
        String OBSERVACION_ID;
        String DETALLE_ID;
        String NRO_VERSION;
        String NRO_INSEGUROS;
        String NRO_SEGUROS;
        String TODO_ES_SEGURO;
        String OBSERVACION;
        String OPERADOR_CREA;
        String FECHA_CREA;
        String OPERADOR_MODI;
        String FECHA_MODI;

       // [JsonProperty("id")]
        public string Id { get => id; set => id = value; }
        public string Sync { get => sync; set => sync = value; }
        public string Sync_insert { get => sync_insert; set => sync_insert = value; }
        public string CIA_ID1 { get => CIA_ID; set => CIA_ID = value; }
        public string ANNOMES1 { get => ANNOMES; set => ANNOMES = value; }
        public string OBSERVACION_ID1 { get => OBSERVACION_ID; set => OBSERVACION_ID = value; }
        public string DETALLE_ID1 { get => DETALLE_ID; set => DETALLE_ID = value; }
        public string NRO_VERSION1 { get => NRO_VERSION; set => NRO_VERSION = value; }
        public string NRO_INSEGUROS1 { get => NRO_INSEGUROS; set => NRO_INSEGUROS = value; }
        public string NRO_SEGUROS1 { get => NRO_SEGUROS; set => NRO_SEGUROS = value; }
        public string TODO_ES_SEGURO1 { get => TODO_ES_SEGURO; set => TODO_ES_SEGURO = value; }
        public string OBSERVACION1 { get => OBSERVACION; set => OBSERVACION = value; }
        public string OPERADOR_CREA1 { get => OPERADOR_CREA; set => OPERADOR_CREA = value; }
        public string FECHA_CREA1 { get => FECHA_CREA; set => FECHA_CREA = value; }
        public string OPERADOR_MODI1 { get => OPERADOR_MODI; set => OPERADOR_MODI = value; }
        public string FECHA_MODI1 { get => FECHA_MODI; set => FECHA_MODI = value; }

        /*
        public String id { get; set; }
        public String sync { get; set; }
        public String sync_insert { get; set; }
        public String CIA_ID { get; set; }
        public String ANNOMES { get; set; }
        public String OBSERVACION_ID { get; set; }
        public String DETALLE_ID { get; set; }
        public String NRO_VERSION { get; set; }
        public String NRO_INSEGUROS { get; set; }
        public String NRO_SEGUROS { get; set; }
        public String TODO_ES_SEGURO { get; set; }
        public String OBSERVACION { get; set; }
        public String OPERADOR_CREA { get; set; }
        public String FECHA_CREA { get; set; }
        public String OPERADOR_MODI { get; set; }
        public String FECHA_MODI { get; set; }

        */
    }
}
