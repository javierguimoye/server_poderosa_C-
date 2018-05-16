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
    class ADM_Usuarios_Dao
    {

        private SqlConnection conexion = new SqlConnection("Data Source = (local); Initial Catalog = PoderosaFocus; Integrated Security = true");
        private DataSet ds;

        public ADM_Usuarios_Dao()
        {}

        public ADM_Usuarios_Bean getUsuario()
        {
            ADM_Usuarios_Bean usuario = new ADM_Usuarios_Bean();
            conexion.Open();
            SqlCommand cmd = new SqlCommand("SELECT TOP 20 Usuario_id ,Trab_id,Descr_Usuario," +
                "Grupo_Usuario,Password,Fec_password,DiasCaducidad,Proveedor_id,Email," +
                "Fec_creacion,Operador_id,Fec_Modi ,Operador_modi_id,Autorizacion,Estado_Trab," +
                "Estado_DB,Estado_SRV,st_adm,Anexo_Telf,Celular FROM PoderosaFocus.dbo.ADM_Usuarios", conexion);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            SqlDataReader r = cmd.ExecuteReader();
            if (r.HasRows)
            {
                while (r.Read())
                {
                    usuario.Usuario_id          = r["Usuario_id"].ToString();
                    usuario.Trab_id             = r["Trab_id"].ToString();
                    usuario.Descr_Usuario       = r["Descr_Usuario"].ToString();
                    usuario.Grupo_Usuario       = r["Grupo_Usuario"].ToString();
                    usuario.Password            = r["Password"].ToString();
                    usuario.Fec_password        = r["Fec_password"].ToString();
                    usuario.DiasCaducidad       = r["DiasCaducidad"].ToString();
                    usuario.Proveedor_id        = r["Proveedor_id"].ToString();
                    usuario.Email               = r["Email"].ToString();
                    usuario.Fec_creacion        = r["Fec_creacion"].ToString();
                    usuario.Operador_id         = r["Operador_id"].ToString();
                    usuario.Fec_Modi            = r["Fec_Modi"].ToString();
                    usuario.Operador_modi_id    = r["Operador_modi_id"].ToString();
                    usuario.Autorizacion        = r["Autorizacion"].ToString();
                    usuario.Estado_Trab         = r["Estado_Trab"].ToString();
                    usuario.Estado_DB           = r["Estado_DB"].ToString();
                    usuario.Estado_SRV          = r["Estado_SRV"].ToString();
                    usuario.st_adm              = r["st_adm"].ToString();
                    usuario.Anexo_Telf          = r["Anexo_Telf"].ToString();
                    usuario.Celular             = r["Celular"].ToString();

                }
            }

            return usuario;
        }


     
        public List<ADM_Usuarios_Bean> getDia_Usuario(String mes, String ano, String dia)
        {
            List<ADM_Usuarios_Bean> usuarioList = new List<ADM_Usuarios_Bean>();
            conexion.Open();
            SqlCommand cmd = new SqlCommand("SELECT Usuario_id ,Trab_id,Descr_Usuario," +
                "Grupo_Usuario,Password,Fec_password,DiasCaducidad,Proveedor_id,Email," +
                "Fec_creacion,Operador_id,Fec_Modi ,Operador_modi_id,Autorizacion,Estado_Trab," +
                "Estado_DB,Estado_SRV,st_adm,Anexo_Telf,Celular FROM PoderosaFocus.dbo.ADM_Usuarios " +
                "WHERE MONTH(Fec_creacion) = '" + mes + "' AND YEAR(Fec_creacion) = '" + ano + "' AND DAY(Fec_creacion) = '" + dia + "'", conexion);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            SqlDataReader r = cmd.ExecuteReader();
            if (r.HasRows)
            {
                while (r.Read())
                {
                    ADM_Usuarios_Bean usuario = new ADM_Usuarios_Bean();
                    usuario.Usuario_id = r["Usuario_id"].ToString();
                    usuario.Trab_id = r["Trab_id"].ToString();
                    usuario.Descr_Usuario = r["Descr_Usuario"].ToString();
                    usuario.Grupo_Usuario = r["Grupo_Usuario"].ToString();
                    usuario.Password = r["Password"].ToString();
                    usuario.Fec_password = r["Fec_password"].ToString();
                    usuario.DiasCaducidad = r["DiasCaducidad"].ToString();
                    usuario.Proveedor_id = r["Proveedor_id"].ToString();
                    usuario.Email = r["Email"].ToString();
                    usuario.Fec_creacion = r["Fec_creacion"].ToString();
                    usuario.Operador_id = r["Operador_id"].ToString();
                    usuario.Fec_Modi = r["Fec_Modi"].ToString();
                    usuario.Operador_modi_id = r["Operador_modi_id"].ToString();
                    usuario.Autorizacion = r["Autorizacion"].ToString();
                    usuario.Estado_Trab = r["Estado_Trab"].ToString();
                    usuario.Estado_DB = r["Estado_DB"].ToString();
                    usuario.Estado_SRV = r["Estado_SRV"].ToString();
                    usuario.st_adm = r["st_adm"].ToString();
                    usuario.Anexo_Telf = r["Anexo_Telf"].ToString();
                    usuario.Celular = r["Celular"].ToString();
                    usuarioList.Add(usuario);
                }
            }

            return usuarioList;
        }


        public List<ADM_Usuarios_Bean> getMes_Usuario(String mes, String ano)
        {
            List<ADM_Usuarios_Bean> usuarioList = new List<ADM_Usuarios_Bean>();
            conexion.Open();
            SqlCommand cmd = new SqlCommand("SELECT Usuario_id ,Trab_id,Descr_Usuario," +
                "Grupo_Usuario,Password,Fec_password,DiasCaducidad,Proveedor_id,Email," +
                "Fec_creacion,Operador_id,Fec_Modi ,Operador_modi_id,Autorizacion,Estado_Trab," +
                "Estado_DB,Estado_SRV,st_adm,Anexo_Telf,Celular FROM PoderosaFocus.dbo.ADM_Usuarios " +
                "WHERE MONTH(Fec_creacion) = '" + mes + "' AND YEAR(Fec_creacion) = '" + ano + "'", conexion);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            SqlDataReader r = cmd.ExecuteReader();
            if (r.HasRows)
            {
                while (r.Read())
                {
                    ADM_Usuarios_Bean usuario = new ADM_Usuarios_Bean();
                    usuario.Usuario_id = r["Usuario_id"].ToString();
                    usuario.Trab_id = r["Trab_id"].ToString();
                    usuario.Descr_Usuario = r["Descr_Usuario"].ToString();
                    usuario.Grupo_Usuario = r["Grupo_Usuario"].ToString();
                    usuario.Password = r["Password"].ToString();
                    usuario.Fec_password = r["Fec_password"].ToString();
                    usuario.DiasCaducidad = r["DiasCaducidad"].ToString();
                    usuario.Proveedor_id = r["Proveedor_id"].ToString();
                    usuario.Email = r["Email"].ToString();
                    usuario.Fec_creacion = r["Fec_creacion"].ToString();
                    usuario.Operador_id = r["Operador_id"].ToString();
                    usuario.Fec_Modi = r["Fec_Modi"].ToString();
                    usuario.Operador_modi_id = r["Operador_modi_id"].ToString();
                    usuario.Autorizacion = r["Autorizacion"].ToString();
                    usuario.Estado_Trab = r["Estado_Trab"].ToString();
                    usuario.Estado_DB = r["Estado_DB"].ToString();
                    usuario.Estado_SRV = r["Estado_SRV"].ToString();
                    usuario.st_adm = r["st_adm"].ToString();
                    usuario.Anexo_Telf = r["Anexo_Telf"].ToString();
                    usuario.Celular = r["Celular"].ToString();
                    usuarioList.Add(usuario);
                }
            }

            return usuarioList;
        }


        public void closeBD(){
            conexion.Close();
        }



    }
}
