using ConsoleApp2.Dao;
using ConsoleApp2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Controllers
{
    class GS_OC_DET_OBS_COMPORTAMIENTO_Action
    {
        public GS_OC_DET_OBS_COMPORTAMIENTO_Bean ConsultarGS_OC_DET_OBS_COMPORTAMIENTOAction()
        {
            GS_OC_DET_OBS_COMPORTAMIENTO_Bean det_observacions = null;
            GS_OC_DET_OBS_COMPORTAMIENTO_Dao det_observacionsDao = new GS_OC_DET_OBS_COMPORTAMIENTO_Dao();
            det_observacions = det_observacionsDao.getGS_OC_DET_OBS_COMPORTAMIENTOS();
            det_observacionsDao.closeBD();

            return det_observacions;
        }

                   
        public void updateOrCreate_GS_OC_DET_OBS_COMPORTAMIENTO (List<GS_OC_DET_OBS_COMPORTAMIENTO_Bean> lista) {
     // public void updateOrCreate_GS_OC_DET_OBS_COMPORTAMIENTO (GS_OC_DET_OBS_COMPORTAMIENTO_Bean bea) {
            foreach (GS_OC_DET_OBS_COMPORTAMIENTO_Bean bean in lista){   
                GS_OC_DET_OBS_COMPORTAMIENTO_Dao det_observacionsDao = new GS_OC_DET_OBS_COMPORTAMIENTO_Dao();
                det_observacionsDao.updateOrCreate_GS_OC_DET_OBS_COMPORTAMIENTO(bean);
                det_observacionsDao.closeBD();
            }
        }


        public List<GS_OC_DET_OBS_COMPORTAMIENTO_Bean> ConsultarDia_GS_OC_DET_OBS_COMPORTAMIENTOAction(String mes, String ano, String dia)
        {
            GS_OC_DET_OBS_COMPORTAMIENTO_Dao det_observacionsDao = new GS_OC_DET_OBS_COMPORTAMIENTO_Dao();
            List<GS_OC_DET_OBS_COMPORTAMIENTO_Bean> GS_OC_DET_OBS_COMPORTAMIENTO_BeanList = det_observacionsDao.getGS_OC_DET_OBS_COMPORTAMIENTOS_Dia(mes, ano, dia);
            det_observacionsDao.closeBD();
            return GS_OC_DET_OBS_COMPORTAMIENTO_BeanList;
        }

        public List<GS_OC_DET_OBS_COMPORTAMIENTO_Bean> ConsultarMes_GS_OC_DET_OBS_COMPORTAMIENTOAction(String mes, String ano)
        {
            GS_OC_DET_OBS_COMPORTAMIENTO_Dao det_observacionsDao = new GS_OC_DET_OBS_COMPORTAMIENTO_Dao();
            List<GS_OC_DET_OBS_COMPORTAMIENTO_Bean> GS_OC_DET_OBS_COMPORTAMIENTO_BeanList = det_observacionsDao.getGS_OC_DET_OBS_COMPORTAMIENTOS_Mes(mes, ano);
            det_observacionsDao.closeBD();
            return GS_OC_DET_OBS_COMPORTAMIENTO_BeanList;
        }


    }
}
