using ConsoleApp2.Dao;
using ConsoleApp2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Controllers
{
    class MCO_ACTIVIDAD_Action
    {

        public MCO_ACTIVIDAD_Bean ConsultarMCO_ACTIVIDADAction()
        {
            MCO_ACTIVIDAD_Bean actividad = null;
            MCO_ACTIVIDAD_Dao actividadDao = new MCO_ACTIVIDAD_Dao();
            actividad = actividadDao.getMCO_ACTIVIDAD();
            actividadDao.closeBD();

            return actividad;
        }

        public List<MCO_ACTIVIDAD_Bean> ConsultarDia_MCO_ACTIVIDADAction(String mes, String ano, String dia)
        {
            MCO_ACTIVIDAD_Dao actividadDao = new MCO_ACTIVIDAD_Dao();
            List<MCO_ACTIVIDAD_Bean> actividadList = actividadDao.getDia_MCO_ACTIVIDAD(mes, ano, dia);
            actividadDao.closeBD();
            return actividadList;
        }


        public List<MCO_ACTIVIDAD_Bean> ConsultarMes_MCO_ACTIVIDADAction(String mes, String ano)
        {
            MCO_ACTIVIDAD_Dao actividadDao = new MCO_ACTIVIDAD_Dao();
            List<MCO_ACTIVIDAD_Bean> actividadList = actividadDao.getMes_MCO_ACTIVIDAD(mes, ano);
            actividadDao.closeBD();
            return actividadList;
        }

    }
}
