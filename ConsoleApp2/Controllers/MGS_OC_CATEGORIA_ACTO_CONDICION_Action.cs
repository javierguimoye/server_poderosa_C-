using ConsoleApp2.Dao;
using ConsoleApp2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Controllers
{
    class MGS_OC_CATEGORIA_ACTO_CONDICION_Action
    {

        public MGS_OC_CATEGORIA_ACTO_CONDICION_Bean ConsultarMGS_OC_CATEGORIA_ACTO_CONDICIONAction()
        {
            MGS_OC_CATEGORIA_ACTO_CONDICION_Bean categoria = null;
            MGS_OC_CATEGORIA_ACTO_CONDICION_Dao categoriaDao = new MGS_OC_CATEGORIA_ACTO_CONDICION_Dao();
            categoria = categoriaDao.getMGS_OC_CATEGORIA_ACTO_CONDICION();
            categoriaDao.closeBD();

            return categoria;
        }

        public List<MGS_OC_CATEGORIA_ACTO_CONDICION_Bean> ConsultarMes_MGS_OC_CATEGORIA_ACTO_CONDICIONAction(String mes, String ano)
        { 
          
            MGS_OC_CATEGORIA_ACTO_CONDICION_Dao categoriaDao = new MGS_OC_CATEGORIA_ACTO_CONDICION_Dao();
            List<MGS_OC_CATEGORIA_ACTO_CONDICION_Bean> categoriaList = categoriaDao.getMGS_OC_CATEGORIA_ACTO_CONDICION_MES(mes,ano);
            categoriaDao.closeBD();
            return categoriaList;
        }

        public List<MGS_OC_CATEGORIA_ACTO_CONDICION_Bean> ConsultarDia_MGS_OC_CATEGORIA_ACTO_CONDICIONAction(String mes, String ano, String dia)
        {
            MGS_OC_CATEGORIA_ACTO_CONDICION_Dao categoriaDao = new MGS_OC_CATEGORIA_ACTO_CONDICION_Dao();
            List<MGS_OC_CATEGORIA_ACTO_CONDICION_Bean> categoriaList = categoriaDao.getMGS_OC_CATEGORIA_ACTO_CONDICION_Dia(mes, ano, dia);
            categoriaDao.closeBD();
            return categoriaList;
        }

    }
}
