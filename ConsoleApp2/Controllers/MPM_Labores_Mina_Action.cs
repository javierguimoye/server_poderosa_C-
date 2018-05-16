using ConsoleApp2.Dao;
using ConsoleApp2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Controllers
{
    class MPM_Labores_Mina_Action
    {

        public MPM_Labores_Mina_Bean ConsultarMPM_Labores_MinaAction()
        {
            MPM_Labores_Mina_Bean mina = null;
            MPM_Labores_Mina_Dao minaDao = new MPM_Labores_Mina_Dao();
            mina = minaDao.getMCO_ACTIVIDAD();
            minaDao.closeBD();

            return mina;
        }


        public List<MPM_Labores_Mina_Bean> ConsultarDia_MPM_Labores_MinaAction(String mes, String ano, String dia)
        {
            MPM_Labores_Mina_Dao minaDao = new MPM_Labores_Mina_Dao();
            List<MPM_Labores_Mina_Bean> minaList = minaDao.getDia_MCO_ACTIVIDAD(mes, ano, dia);
            minaDao.closeBD();
            return minaList;
        }

        public List<MPM_Labores_Mina_Bean> ConsultarMes_MPM_Labores_MinaAction(String mes, String ano)
        {
            MPM_Labores_Mina_Dao minaDao = new MPM_Labores_Mina_Dao();
            List<MPM_Labores_Mina_Bean> minaList = minaDao.getMes_MCO_ACTIVIDAD(mes, ano);
            minaDao.closeBD();
            return minaList;
        }

    }
}
