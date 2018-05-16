using ConsoleApp2.Dao;
using ConsoleApp2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp2.Controllers
{
    class GS_OC_CAB_OBS_COMPORTAMIENTO_Action
    {
        public GS_OC_CAB_OBS_COMPORTAMIENTO_Bean ConsultarGS_OC_CAB_OBS_COMPORTAMIENTOAction()
        {
            GS_OC_CAB_OBS_COMPORTAMIENTO_Bean cab_observaciones = null;
            GS_OC_CAB_OBS_COMPORTAMIENTO_Dao cab_observacionesDao = new GS_OC_CAB_OBS_COMPORTAMIENTO_Dao();
            cab_observaciones = cab_observacionesDao.getGS_OC_CAB_OBS_COMPORTAMIENTO();
            cab_observacionesDao.closeBD();

            return cab_observaciones;
        }

        
        public void updateOrCreate_GS_OC_CAB_OBS_COMPORTAMIENTO(List<GS_OC_CAB_OBS_COMPORTAMIENTO_Bean> lista){
            foreach (GS_OC_CAB_OBS_COMPORTAMIENTO_Bean bean in lista){
                GS_OC_CAB_OBS_COMPORTAMIENTO_Dao det_observacionsDao = new GS_OC_CAB_OBS_COMPORTAMIENTO_Dao();
                det_observacionsDao.updateOrCreate_GS_OC_CAB_OBS_COMPORTAMIENTO(bean);
                det_observacionsDao.closeBD();
            }
        }

        public List<GS_OC_CAB_OBS_COMPORTAMIENTO_Bean> ConsultarDia_GS_OC_CAB_OBS_COMPORTAMIENTOAction(String mes, String ano, String dia)
        {
            GS_OC_CAB_OBS_COMPORTAMIENTO_Dao cab_observacionsDao = new GS_OC_CAB_OBS_COMPORTAMIENTO_Dao();
            List<GS_OC_CAB_OBS_COMPORTAMIENTO_Bean> GS_OC_CAB_OBS_COMPORTAMIENTO_BeanList = cab_observacionsDao.getGS_OC_CAB_OBS_COMPORTAMIENTO_Dia(mes, ano, dia);
            cab_observacionsDao.closeBD();
            return GS_OC_CAB_OBS_COMPORTAMIENTO_BeanList;
        }

        public List<GS_OC_CAB_OBS_COMPORTAMIENTO_Bean> ConsultarMes_GS_OC_CAB_OBS_COMPORTAMIENTOAction(String mes, String ano)
        {
            GS_OC_CAB_OBS_COMPORTAMIENTO_Dao cab_observacionsDao = new GS_OC_CAB_OBS_COMPORTAMIENTO_Dao();
            List<GS_OC_CAB_OBS_COMPORTAMIENTO_Bean> GS_OC_CAB_OBS_COMPORTAMIENTO_BeanList = cab_observacionsDao.getGS_OC_CAB_OBS_COMPORTAMIENTO_Mes(mes, ano);
            cab_observacionsDao.closeBD();
            return GS_OC_CAB_OBS_COMPORTAMIENTO_BeanList;
        }
    }
}
