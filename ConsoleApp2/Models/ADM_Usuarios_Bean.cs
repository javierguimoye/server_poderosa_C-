using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Models
{
    class ADM_Usuarios_Bean
    {

        public String Usuario_id { get; set; }
        public String Trab_id { get; set; }
        public String Descr_Usuario { get; set; }
        public String Grupo_Usuario { get; set; }
        public String Password { get; set; }
        public String Fec_password { get; set; }
        public String DiasCaducidad { get; set; }
        public String Proveedor_id { get; set; }
        public String Email { get; set; }
        public String Fec_creacion { get; set; }
        public String Operador_id { get; set; }
        public String Fec_Modi { get; set; }
        public String Operador_modi_id { get; set; }
        public String Autorizacion { get; set; }
        public String Estado_Trab { get; set; }
        public String Estado_DB { get; set; }
        public String Estado_SRV { get; set; }
        public String st_adm { get; set; }
        public String Anexo_Telf { get; set; }
        public String Celular { get; set; }
    }
}
