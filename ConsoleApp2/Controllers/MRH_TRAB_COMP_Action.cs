using ConsoleApp2.Dao;
using ConsoleApp2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Controllers
{
    class MRH_TRAB_COMP_Action
    {

        public MRH_TRAB_COMP_Bean ConsultarMRH_TRAB_COMPAction()
        {
            MRH_TRAB_COMP_Bean trab = null;
            MRH_TRAB_COMP_Dao trabDao = new MRH_TRAB_COMP_Dao();
            trab = trabDao.getMRH_TRAB_COMP();
            trabDao.closeBD();
            return trab;
        }

        public List<MRH_TRAB_COMP_Bean> ConsultarDia_MRH_TRAB_COMPDAction(String mes, String ano, String dia)
        {
            MRH_TRAB_COMP_Dao trabDao = new MRH_TRAB_COMP_Dao();
            List<MRH_TRAB_COMP_Bean> trabList = trabDao.getDia_MRH_TRAB_COMP(mes, ano, dia);
            trabDao.closeBD();
            return trabList;
        }

        public List<MRH_TRAB_COMP_Bean> ConsultarMes_MRH_TRAB_COMPDAction(String mes, String ano)
        {
            MRH_TRAB_COMP_Dao trabDao = new MRH_TRAB_COMP_Dao();
            List<MRH_TRAB_COMP_Bean> trabList = trabDao.getMes_MRH_TRAB_COMP(mes, ano);
            trabDao.closeBD();
            return trabList;
        }

    }
}
