using ConsoleApp2.Dao;
using ConsoleApp2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Controllers
{
    class MCP_PROVEEDORES_Action
    {

        public MCP_PROVEEDORES_Bean ConsultarMCP_PROVEEDORESAction()
        {
            MCP_PROVEEDORES_Bean provedores = null;
            MCP_PROVEEDORES_Dao provedoresDao = new MCP_PROVEEDORES_Dao();
            provedores = provedoresDao.getMCP_PROVEEDORES();
            provedoresDao.closeBD();

            return provedores;
        }

        public List<MCP_PROVEEDORES_Bean> ConsultarDia_MCP_PROVEEDORESAction(String mes, String ano, String dia)
        {
            MCP_PROVEEDORES_Dao provedoresDao = new MCP_PROVEEDORES_Dao();
            List<MCP_PROVEEDORES_Bean> provedoresList = provedoresDao.getDia_MCP_PROVEEDORES(mes, ano, dia); ;
            provedoresDao.closeBD();
            return provedoresList;
        }

        public List<MCP_PROVEEDORES_Bean> ConsultarMes_MCP_PROVEEDORESAction(String mes, String ano)
        {
            MCP_PROVEEDORES_Dao provedoresDao = new MCP_PROVEEDORES_Dao();
            List<MCP_PROVEEDORES_Bean> provedoresList = provedoresDao.getMes_MCP_PROVEEDORES(mes, ano); ;
            provedoresDao.closeBD();
            return provedoresList;
        }

    }
}
