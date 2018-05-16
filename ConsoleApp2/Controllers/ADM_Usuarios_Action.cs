using ConsoleApp2.Dao;
using ConsoleApp2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Controllers
{
    class ADM_Usuarios_Action
    {

        public ADM_Usuarios_Bean ConsultarUsuarioAction()
        {
            ADM_Usuarios_Bean usuarioBean = null;
            ADM_Usuarios_Dao usuarioDao = new ADM_Usuarios_Dao();
            usuarioBean = usuarioDao.getUsuario();
            usuarioDao.closeBD();

            return usuarioBean;
        }

        public List<ADM_Usuarios_Bean> ConsultarDia_MCO_ACTIVIDADAction(String mes, String ano, String dia)
        {
            ADM_Usuarios_Dao usuarioDao = new ADM_Usuarios_Dao();
            List<ADM_Usuarios_Bean> usuarioList = usuarioDao.getDia_Usuario(mes, ano, dia);
            usuarioDao.closeBD();
            return usuarioList;
        }


        public List<ADM_Usuarios_Bean> ConsultarMes_MCO_ACTIVIDADAction(String mes, String ano)
        {
            ADM_Usuarios_Dao usuarioDao = new ADM_Usuarios_Dao();
            List<ADM_Usuarios_Bean> usuarioList = usuarioDao.getMes_Usuario(mes, ano);
            usuarioDao.closeBD();
            return usuarioList;
        }


    }
}
