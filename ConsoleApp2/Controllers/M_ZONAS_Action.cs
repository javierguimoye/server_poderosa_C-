using ConsoleApp2.Dao;
using ConsoleApp2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Controllers
{
    class M_ZONAS_Action
    {

        public M_ZONAS_Bean ConsultarM_ZONASAction()
        {
            M_ZONAS_Bean zonas = null;
            M_ZONAS_Dao zonasDao = new M_ZONAS_Dao();
            zonas = zonasDao.getM_ZONAS();
            zonasDao.closeBD();

            return zonas;
        }


        public List<M_ZONAS_Bean> ConsultarMes_M_ZONASAction(String mes, String ano)
        {
            M_ZONAS_Dao zonasDao = new M_ZONAS_Dao();
            List<M_ZONAS_Bean> zonaList = zonasDao.getMes_M_ZONAS(mes, ano);
            zonasDao.closeBD();
            return zonaList;
        }

        public List<M_ZONAS_Bean> ConsultarDia_M_ZONASAction(String mes, String ano, String dia)
        {

            M_ZONAS_Dao zonasDao = new M_ZONAS_Dao();
            List<M_ZONAS_Bean> zonaList = zonasDao.getDia_M_ZONAS(mes, ano,dia);
            zonasDao.closeBD();
            return zonaList;
        }


    }
}
