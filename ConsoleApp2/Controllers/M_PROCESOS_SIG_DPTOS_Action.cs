using ConsoleApp2.Dao;
using ConsoleApp2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Controllers
{
    class M_PROCESOS_SIG_DPTOS_Action
    {

        public M_PROCESOS_SIG_DPTOS_Bean ConsultarM_PROCESOS_SIG_DPTOSAction()
        {
            M_PROCESOS_SIG_DPTOS_Bean dpto = null;
            M_PROCESOS_SIG_DPTOS_Dao dptoDao = new M_PROCESOS_SIG_DPTOS_Dao();
            dpto = dptoDao.getM_PROCESOS_SIG_DPTOS();
            dptoDao.closeBD();

            return dpto;
        }

        public List<M_PROCESOS_SIG_DPTOS_Bean> ConsultarTODOS_M_PROCESOS_SIG_DPTOSAction()
        {
            M_PROCESOS_SIG_DPTOS_Dao dptoDao = new M_PROCESOS_SIG_DPTOS_Dao();
            List<M_PROCESOS_SIG_DPTOS_Bean> dptoList = dptoDao.getTODO_M_PROCESOS_SIG_DPTOS();
            dptoDao.closeBD();
            return dptoList;
        }


    }
}
