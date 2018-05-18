using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using MiLibreria;
using System.Data;
using c_sahrp;
using ConsoleApp2.Controllers;
using ConsoleApp2.Models;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;
using System.Threading;
using ConsoleApp2.Dao;

using System.Runtime.Serialization;
using Newtonsoft.Json.Linq;
using System.IO;

//using System.Web.Script;
//using System.Web.Script.Serialization;

namespace ConsoleApp2
{
    class Program
    {

        static bool syncMes = true;
        static DateTime fecha;
        static MGS_OC_CATEGORIA_ACTO_CONDICION_Action ca;
        static M_PROCESOS_SIG_DPTOS_Action sd;
        static M_ZONAS_Action za;
        static MCO_ACTIVIDAD_Action ma;
        static ADM_Usuarios_Action ua;
        static MRH_TRAB_COMP_Action mt;
        static MPM_Labores_Mina_Action ml;
        static MCP_PROVEEDORES_Action mp;
        static GS_OC_CAB_OBS_COMPORTAMIENTO_Action cc;
        static GS_OC_DET_OBS_COMPORTAMIENTO_Action dc;
        static int cont = 0;
        static int contTotal = 0;
        static int queda = 0;
        static int auxCont = 0;

        static void Main(string[] args)
        {
            var th = new Thread(ExecuteInForeground);
            th.Start();
        }


        private static void ExecuteInForeground()
        {

            while (true)
            {

                fecha = DateTime.Now;
                ca = new MGS_OC_CATEGORIA_ACTO_CONDICION_Action();
                sd = new M_PROCESOS_SIG_DPTOS_Action();
                za = new M_ZONAS_Action();
                ma = new MCO_ACTIVIDAD_Action();
                ua = new ADM_Usuarios_Action();
                mt = new MRH_TRAB_COMP_Action();
                ml = new MPM_Labores_Mina_Action();
                mp = new MCP_PROVEEDORES_Action();
                cc = new GS_OC_CAB_OBS_COMPORTAMIENTO_Action();
                dc = new GS_OC_DET_OBS_COMPORTAMIENTO_Action();

                List<M_PROCESOS_SIG_DPTOS_Bean> lstM_PROCESOS_SIG_DPTOS = sd.ConsultarTODOS_M_PROCESOS_SIG_DPTOSAction();
                /*
                if (syncMes)
                {
                    Console.WriteLine("\n**** ENVIANDO DATOS DEL MES ***");

                    List<MGS_OC_CATEGORIA_ACTO_CONDICION_Bean> lstMes_MGS_OC_CATEGORIA_ACTO_CONDICION_Bean = ca.ConsultarMes_MGS_OC_CATEGORIA_ACTO_CONDICIONAction(fecha.Month + "", fecha.Year + "");
                    List<M_ZONAS_Bean> lstMes_m_ZONAS_Beans = za.ConsultarMes_M_ZONASAction(fecha.Month + "", fecha.Year + "");
                    List<MCO_ACTIVIDAD_Bean> lstMes_MCO_ACTIVIDAD_Bean = ma.ConsultarMes_MCO_ACTIVIDADAction(fecha.Month + "", fecha.Year + "");
                    List<ADM_Usuarios_Bean> lstMes_ADM_Usuarios_Bean = ua.ConsultarMes_MCO_ACTIVIDADAction(fecha.Month + "", fecha.Year + "");
                    List<MRH_TRAB_COMP_Bean> lstMes_MRH_TRAB_COMP_Bean = mt.ConsultarMes_MRH_TRAB_COMPDAction(fecha.Month + "", fecha.Year + "");
                    List<MPM_Labores_Mina_Bean> lstMes_MPM_Labores_Mina_Bean = ml.ConsultarMes_MPM_Labores_MinaAction(fecha.Month + "", fecha.Year + "");
                    List<MCP_PROVEEDORES_Bean> lstMes_MCP_PROVEEDORES_Bean = mp.ConsultarMes_MCP_PROVEEDORESAction(fecha.Month + "", fecha.Year + "");
                    List<GS_OC_DET_OBS_COMPORTAMIENTO_Bean> lstGSMes_OC_DET_OBS_COMPORTAMIENTO_Bean = dc.ConsultarMes_GS_OC_DET_OBS_COMPORTAMIENTOAction(fecha.Month + "", fecha.Year + "");
                    List<GS_OC_CAB_OBS_COMPORTAMIENTO_Bean> lstGSMes_GS_OC_CAB_OBS_COMPORTAMIENTO_Bean = cc.ConsultarMes_GS_OC_CAB_OBS_COMPORTAMIENTOAction(fecha.Month + "", fecha.Year + "");

                    Console.WriteLine("cantidad total de categorias del mes: " + lstMes_MGS_OC_CATEGORIA_ACTO_CONDICION_Bean.Count);
                    Console.WriteLine("cantidad total de zonas del mes: " + lstMes_m_ZONAS_Beans.Count);
                    Console.WriteLine("cantidad total de actividad del mes: " + lstMes_MCO_ACTIVIDAD_Bean.Count);
                    Console.WriteLine("cantidad total de usuarios del mes: " + lstMes_ADM_Usuarios_Bean.Count);
                    Console.WriteLine("cantidad total de trab del mes: " + lstMes_MRH_TRAB_COMP_Bean.Count);
                    Console.WriteLine("cantidad total de labores mina del mes: " + lstMes_MPM_Labores_Mina_Bean.Count);
                    Console.WriteLine("cantidad total de provedores del mes: " + lstMes_MCP_PROVEEDORES_Bean.Count);
                    Console.WriteLine("cantidad total de detalles del mes: " + lstGSMes_OC_DET_OBS_COMPORTAMIENTO_Bean.Count);
                    Console.WriteLine("cantidad total de cabeceras del mes: " + lstGSMes_GS_OC_CAB_OBS_COMPORTAMIENTO_Bean.Count);
                    Console.WriteLine("cantidad total de procesos: " + lstM_PROCESOS_SIG_DPTOS.Count);
                    ///*********************** ENVIANDO  CATEGORIAS **************************

                    List<MGS_OC_CATEGORIA_ACTO_CONDICION_Bean> lstMes_MGS_OC_CATEGORIA_ACTO_CONDICION_Bean_send = new List<MGS_OC_CATEGORIA_ACTO_CONDICION_Bean>();
                    contTotal = lstMes_MGS_OC_CATEGORIA_ACTO_CONDICION_Bean.Count;
                    Console.WriteLine("\n");
                    auxCont = 0;
                    Console.WriteLine("--> enviando datos de categorias");
                    foreach (MGS_OC_CATEGORIA_ACTO_CONDICION_Bean bean in lstMes_MGS_OC_CATEGORIA_ACTO_CONDICION_Bean)
                    {
                        if (lstMes_MGS_OC_CATEGORIA_ACTO_CONDICION_Bean.Count > 20)
                        {
                            if (cont < 20)
                            {
                                lstMes_MGS_OC_CATEGORIA_ACTO_CONDICION_Bean_send.Add(bean);
                                cont++;
                            }
                            else
                            {
                                lstMes_MGS_OC_CATEGORIA_ACTO_CONDICION_Bean_send.Add(bean);
                                contTotal = contTotal - (cont + 1);
                                PostRequest("http://beta.focusit.pe/poderosa/ext/setData/MGS_OC_CATEGORIA_ACTO_CONDICION", JsonConvert.SerializeObject(lstMes_MGS_OC_CATEGORIA_ACTO_CONDICION_Bean_send));
                                cont = 0;
                                lstMes_MGS_OC_CATEGORIA_ACTO_CONDICION_Bean_send = new List<MGS_OC_CATEGORIA_ACTO_CONDICION_Bean>();
                            }

                            if (cont <= 19 && contTotal < 20)
                            {
                                if (auxCont == contTotal) PostRequest("http://beta.focusit.pe/poderosa/ext/setData/MGS_OC_CATEGORIA_ACTO_CONDICION", JsonConvert.SerializeObject(lstMes_MGS_OC_CATEGORIA_ACTO_CONDICION_Bean_send));
                                auxCont++;
                            }
                        }
                        else
                        {
                            lstMes_MGS_OC_CATEGORIA_ACTO_CONDICION_Bean_send.Add(bean);
                            PostRequest("http://beta.focusit.pe/poderosa/ext/setData/MGS_OC_CATEGORIA_ACTO_CONDICION", JsonConvert.SerializeObject(lstMes_MGS_OC_CATEGORIA_ACTO_CONDICION_Bean_send));
                        }
                    }
                    Console.WriteLine("<-- datos de categorias enviados ");
                    cont = 0;

                    ///********************** ENVIANDO ZONAS **************************

                    List<M_ZONAS_Bean> m_ZONAS_Beans_send = new List<M_ZONAS_Bean>();
                    contTotal = lstMes_m_ZONAS_Beans.Count;
                    Console.WriteLine("\n");
                    auxCont = 0;
                    Console.WriteLine("--> enviando datos de zonas");
                    foreach (M_ZONAS_Bean bean in lstMes_m_ZONAS_Beans)
                    {
                        if (lstMes_m_ZONAS_Beans.Count > 20)
                        {

                            if (cont < 20)
                            {
                                m_ZONAS_Beans_send.Add(bean);
                                cont++;
                            }
                            else
                            {
                                m_ZONAS_Beans_send.Add(bean);
                                contTotal = contTotal - (cont + 1);
                                PostRequest("http://beta.focusit.pe/poderosa/ext/setData/M_ZONAS", JsonConvert.SerializeObject(m_ZONAS_Beans_send));
                                cont = 0;
                                m_ZONAS_Beans_send = new List<M_ZONAS_Bean>();
                            }

                            if (cont <= 19 && contTotal < 20)
                            {
                                if (auxCont == contTotal) PostRequest("http://beta.focusit.pe/poderosa/ext/setData/M_ZONAS", JsonConvert.SerializeObject(m_ZONAS_Beans_send));
                                auxCont++;
                            }
                        }
                        else
                        {
                            m_ZONAS_Beans_send.Add(bean);
                            PostRequest("http://beta.focusit.pe/poderosa/ext/setData/M_ZONAS", JsonConvert.SerializeObject(m_ZONAS_Beans_send));
                        }
                    }
                    Console.WriteLine("<-- datos de zonas enviados ");
                    cont = 0;


                    ///*********************** ENVIANDO ACTIVIDAD **************************

                    List<MCO_ACTIVIDAD_Bean> MCO_ACTIVIDAD_Bean_send = new List<MCO_ACTIVIDAD_Bean>();
                    contTotal = lstMes_MCO_ACTIVIDAD_Bean.Count;
                    Console.WriteLine("\n");
                    auxCont = 0;
                    Console.WriteLine("--> enviando datos de actividad");
                    foreach (MCO_ACTIVIDAD_Bean bean in lstMes_MCO_ACTIVIDAD_Bean)
                    {

                        if (lstMes_MCO_ACTIVIDAD_Bean.Count > 20)
                        {
                            if (cont < 20)
                            {
                                MCO_ACTIVIDAD_Bean_send.Add(bean);
                                cont++;
                            }
                            else
                            {
                                MCO_ACTIVIDAD_Bean_send.Add(bean);
                                contTotal = contTotal - (cont + 1);
                                PostRequest("http://beta.focusit.pe/poderosa/ext/setData/MCO_ACTIVIDAD", JsonConvert.SerializeObject(MCO_ACTIVIDAD_Bean_send));
                                cont = 0;
                                MCO_ACTIVIDAD_Bean_send = new List<MCO_ACTIVIDAD_Bean>();
                            }

                            if (cont <= 19 && contTotal < 20)
                            {
                                if (auxCont == contTotal) PostRequest("http://beta.focusit.pe/poderosa/ext/setData/MCO_ACTIVIDAD", JsonConvert.SerializeObject(MCO_ACTIVIDAD_Bean_send));
                                auxCont++;
                            }

                        }
                        else
                        {
                            MCO_ACTIVIDAD_Bean_send.Add(bean);
                            PostRequest("http://beta.focusit.pe/poderosa/ext/setData/MCO_ACTIVIDAD", JsonConvert.SerializeObject(MCO_ACTIVIDAD_Bean_send));
                        }
                    }
                    Console.WriteLine("<-- datos de actividad enviados ");
                    cont = 0;


                    ///*********************** ENVIANDO USUARIOS **************************

                    List<ADM_Usuarios_Bean> ADM_Usuarios_Bean_send = new List<ADM_Usuarios_Bean>();
                    contTotal = lstMes_ADM_Usuarios_Bean.Count;
                    Console.WriteLine("\n");
                    auxCont = 0;
                    Console.WriteLine("--> enviando datos de usuario");
                    foreach (ADM_Usuarios_Bean bean in lstMes_ADM_Usuarios_Bean)
                    {
                        if (lstMes_ADM_Usuarios_Bean.Count > 20)
                        {
                            if (cont < 20)
                            {
                                ADM_Usuarios_Bean_send.Add(bean);
                                cont++;
                            }
                            else
                            {
                                ADM_Usuarios_Bean_send.Add(bean);
                                contTotal = contTotal - (cont + 1);
                                PostRequest("http://beta.focusit.pe/poderosa/ext/setData/ADM_Usuarios", JsonConvert.SerializeObject(ADM_Usuarios_Bean_send));
                                cont = 0;
                                ADM_Usuarios_Bean_send = new List<ADM_Usuarios_Bean>();
                            }

                            if (cont <= 19 && contTotal < 20)
                            {
                                if (auxCont == contTotal) PostRequest("http://beta.focusit.pe/poderosa/ext/setData/ADM_Usuarios", JsonConvert.SerializeObject(ADM_Usuarios_Bean_send));
                                auxCont++;
                            }
                        }
                        else
                        {
                            ADM_Usuarios_Bean_send.Add(bean);
                            PostRequest("http://beta.focusit.pe/poderosa/ext/setData/ADM_Usuarios", JsonConvert.SerializeObject(ADM_Usuarios_Bean_send));
                        }
                    }
                    Console.WriteLine("<--  datos de usuarios enviados ");
                    cont = 0;

                    ///************************ ENVIANDO trabajos **************************

                    List<MRH_TRAB_COMP_Bean> MRH_TRAB_COMP_Bean_send = new List<MRH_TRAB_COMP_Bean>();
                    contTotal = lstMes_MRH_TRAB_COMP_Bean.Count;
                    Console.WriteLine("\n");
                    auxCont = 0;
                    Console.WriteLine("--> enviando datos de trabajos");
                    foreach (MRH_TRAB_COMP_Bean bean in lstMes_MRH_TRAB_COMP_Bean)
                    {
                        if (lstMes_MRH_TRAB_COMP_Bean.Count > 20)
                        {
                            if (cont < 20)
                            {
                                MRH_TRAB_COMP_Bean_send.Add(bean);
                                cont++;
                            }
                            else
                            {
                                MRH_TRAB_COMP_Bean_send.Add(bean);
                                contTotal = contTotal - (cont + 1);
                                PostRequest("http://beta.focusit.pe/poderosa/ext/setData/MRH_TRAB_COMP", JsonConvert.SerializeObject(MRH_TRAB_COMP_Bean_send));
                                cont = 0;
                                MRH_TRAB_COMP_Bean_send = new List<MRH_TRAB_COMP_Bean>();
                            }

                            if (cont <= 19 && contTotal < 20)
                            {
                                if (auxCont == contTotal) PostRequest("http://beta.focusit.pe/poderosa/ext/setData/MRH_TRAB_COMP", JsonConvert.SerializeObject(MRH_TRAB_COMP_Bean_send));
                                auxCont++;
                            }
                        }
                        else
                        {
                            MRH_TRAB_COMP_Bean_send.Add(bean);
                            PostRequest("http://beta.focusit.pe/poderosa/ext/setData/MRH_TRAB_COMP", JsonConvert.SerializeObject(MRH_TRAB_COMP_Bean_send));
                        }
                    }
                    Console.WriteLine("<--  datos de trabajos enviados ");
                    cont = 0;

                    ///*********************** ENVIANDO Labores **************************
                    List<MPM_Labores_Mina_Bean> MPM_Labores_Mina_Bean_send = new List<MPM_Labores_Mina_Bean>();
                    contTotal = lstMes_MPM_Labores_Mina_Bean.Count;
                    Console.WriteLine("\n");
                    auxCont = 0;
                    Console.WriteLine("--> enviando datos de minas");
                    foreach (MPM_Labores_Mina_Bean bean in lstMes_MPM_Labores_Mina_Bean)
                    {
                        if (lstMes_MPM_Labores_Mina_Bean.Count > 20)
                        {
                            if (cont < 20)
                            {
                                MPM_Labores_Mina_Bean_send.Add(bean);
                                cont++;
                            }
                            else
                            {
                                MPM_Labores_Mina_Bean_send.Add(bean);
                                contTotal = contTotal - (cont + 1);
                                PostRequest("http://beta.focusit.pe/poderosa/ext/setData/MPM_Labores_Mina", JsonConvert.SerializeObject(MPM_Labores_Mina_Bean_send));
                                cont = 0;
                                MPM_Labores_Mina_Bean_send = new List<MPM_Labores_Mina_Bean>();
                            }

                            if (cont <= 19 && contTotal < 20)
                            {
                                if (auxCont == contTotal) PostRequest("http://beta.focusit.pe/poderosa/ext/setData/MPM_Labores_Mina", JsonConvert.SerializeObject(MPM_Labores_Mina_Bean_send));
                                auxCont++;
                            }
                        }
                        else
                        {
                            MPM_Labores_Mina_Bean_send.Add(bean);
                            PostRequest("http://beta.focusit.pe/poderosa/ext/setData/MPM_Labores_Mina", JsonConvert.SerializeObject(MPM_Labores_Mina_Bean_send));
                        }
                    }
                    Console.WriteLine("<--  datos de trabajos minas ");
                    cont = 0;

                    ///************************ ENVIANDO Proveedores **************************

                    List<MCP_PROVEEDORES_Bean> MCP_PROVEEDORES_Bean_send = new List<MCP_PROVEEDORES_Bean>();
                    contTotal = lstMes_MCP_PROVEEDORES_Bean.Count;
                    Console.WriteLine("\n");
                    auxCont = 0;
                    Console.WriteLine("--> enviando datos de proveedores");
                    foreach (MCP_PROVEEDORES_Bean bean in lstMes_MCP_PROVEEDORES_Bean)
                    {

                        if (lstMes_MCP_PROVEEDORES_Bean.Count > 20)
                        {
                            if (cont < 20)
                            {
                                MCP_PROVEEDORES_Bean_send.Add(bean);
                                cont++;
                            }
                            else
                            {
                                MCP_PROVEEDORES_Bean_send.Add(bean);
                                contTotal = contTotal - (cont + 1);
                                PostRequest("http://beta.focusit.pe/poderosa/ext/setData/MCP_PROVEEDORES", JsonConvert.SerializeObject(MCP_PROVEEDORES_Bean_send));
                                cont = 0;
                                MCP_PROVEEDORES_Bean_send = new List<MCP_PROVEEDORES_Bean>();
                            }

                            if (cont <= 19 && contTotal < 20)
                            {
                                if (auxCont == contTotal) PostRequest("http://beta.focusit.pe/poderosa/ext/setData/MCP_PROVEEDORES", JsonConvert.SerializeObject(MCP_PROVEEDORES_Bean_send));
                                auxCont++;
                            }
                        }
                        else
                        {
                            MCP_PROVEEDORES_Bean_send.Add(bean);
                            PostRequest("http://beta.focusit.pe/poderosa/ext/setData/MCP_PROVEEDORES", JsonConvert.SerializeObject(MCP_PROVEEDORES_Bean_send));
                        }

                    }
                    Console.WriteLine("<--  datos de proveedores enviados ");
                    cont = 0;

                    ///************************ ENVIANDO detalles comportamiento **************************
                    List<GS_OC_DET_OBS_COMPORTAMIENTO_Bean> GS_OC_DET_OBS_COMPORTAMIENTO_Bean_send = new List<GS_OC_DET_OBS_COMPORTAMIENTO_Bean>();
                    contTotal = lstGSMes_OC_DET_OBS_COMPORTAMIENTO_Bean.Count;
                    Console.WriteLine("\n ");
                    auxCont = 0;
                    Console.WriteLine("--> enviando datos de detalles");
                    foreach (GS_OC_DET_OBS_COMPORTAMIENTO_Bean bean in lstGSMes_OC_DET_OBS_COMPORTAMIENTO_Bean)
                    {

                        if (lstGSMes_OC_DET_OBS_COMPORTAMIENTO_Bean.Count > 20)
                        {
                            if (cont < 20)
                            {
                                GS_OC_DET_OBS_COMPORTAMIENTO_Bean_send.Add(bean);
                                cont++;
                            }
                            else
                            {
                                GS_OC_DET_OBS_COMPORTAMIENTO_Bean_send.Add(bean);
                                contTotal = contTotal - (cont + 1);
                                PostRequest("http://beta.focusit.pe/poderosa/ext/setData/GS_OC_DET_OBS_COMPORTAMIENTO", JsonConvert.SerializeObject(GS_OC_DET_OBS_COMPORTAMIENTO_Bean_send));
                                cont = 0;
                                GS_OC_DET_OBS_COMPORTAMIENTO_Bean_send = new List<GS_OC_DET_OBS_COMPORTAMIENTO_Bean>();
                            }

                            if (cont <= 19 && contTotal < 20)
                            {
                                if (auxCont == contTotal) PostRequest("http://beta.focusit.pe/poderosa/ext/setData/GS_OC_DET_OBS_COMPORTAMIENTO", JsonConvert.SerializeObject(GS_OC_DET_OBS_COMPORTAMIENTO_Bean_send));
                                auxCont++;
                            }
                        }
                        else
                        {
                            GS_OC_DET_OBS_COMPORTAMIENTO_Bean_send.Add(bean);
                            PostRequest("http://beta.focusit.pe/poderosa/ext/setData/GS_OC_DET_OBS_COMPORTAMIENTO", JsonConvert.SerializeObject(GS_OC_DET_OBS_COMPORTAMIENTO_Bean_send));

                        }
                    }
                    Console.WriteLine("<--  datos de detalles enviados ");
                    cont = 0;


                    ///*********************** ENVIANDO cabecera **************************
                    List<GS_OC_CAB_OBS_COMPORTAMIENTO_Bean> GS_OC_CAB_OBS_COMPORTAMIENTO_Bean_send = new List<GS_OC_CAB_OBS_COMPORTAMIENTO_Bean>();
                    contTotal = lstGSMes_GS_OC_CAB_OBS_COMPORTAMIENTO_Bean.Count;
                    Console.WriteLine("\n ");
                    auxCont = 0;
                    Console.WriteLine("--> enviando datos de cabeceras");
                    foreach (GS_OC_CAB_OBS_COMPORTAMIENTO_Bean bean in lstGSMes_GS_OC_CAB_OBS_COMPORTAMIENTO_Bean)
                    {
                        if (lstGSMes_GS_OC_CAB_OBS_COMPORTAMIENTO_Bean.Count > 20)
                        {
                            if (cont < 20)
                            {
                                GS_OC_CAB_OBS_COMPORTAMIENTO_Bean_send.Add(bean);
                                cont++;
                            }
                            else
                            {
                                GS_OC_CAB_OBS_COMPORTAMIENTO_Bean_send.Add(bean);
                                contTotal = contTotal - (cont + 1);
                                PostRequest("http://beta.focusit.pe/poderosa/ext/setData/GS_OC_CAB_OBS_COMPORTAMIENTO", JsonConvert.SerializeObject(GS_OC_CAB_OBS_COMPORTAMIENTO_Bean_send));
                                cont = 0;
                                GS_OC_CAB_OBS_COMPORTAMIENTO_Bean_send = new List<GS_OC_CAB_OBS_COMPORTAMIENTO_Bean>();
                            }

                            if (cont <= 19 && contTotal < 20)
                            {
                                if (auxCont == contTotal) PostRequest("http://beta.focusit.pe/poderosa/ext/setData/GS_OC_CAB_OBS_COMPORTAMIENTO", JsonConvert.SerializeObject(GS_OC_CAB_OBS_COMPORTAMIENTO_Bean_send));
                                auxCont++;
                            }
                        }
                        else
                        {
                            GS_OC_CAB_OBS_COMPORTAMIENTO_Bean_send.Add(bean);
                            PostRequest("http://beta.focusit.pe/poderosa/ext/setData/GS_OC_CAB_OBS_COMPORTAMIENTO", JsonConvert.SerializeObject(GS_OC_CAB_OBS_COMPORTAMIENTO_Bean_send));
                        }

                    }
                    Console.WriteLine("<--  datos de cabeceras enviados ");
                    cont = 0;


                    syncMes = false;
                }
                else
                {
                    Console.WriteLine("\n**** ENVIANDO DATOS DIARIOS ***");
                    List<MGS_OC_CATEGORIA_ACTO_CONDICION_Bean> lstDia_MGS_OC_CATEGORIA_ACTO_CONDICION_Bean = ca.ConsultarDia_MGS_OC_CATEGORIA_ACTO_CONDICIONAction(fecha.Month + "", fecha.Year + "", fecha.Day + "");
                    List<M_ZONAS_Bean> lstDia_m_ZONAS_Beans = za.ConsultarDia_M_ZONASAction(fecha.Month + "", fecha.Year + "", fecha.Day + "");
                    List<MCO_ACTIVIDAD_Bean> lstDia_MCO_ACTIVIDAD_Bean = ma.ConsultarDia_MCO_ACTIVIDADAction(fecha.Month + "", fecha.Year + "", fecha.Day + "");
                    List<ADM_Usuarios_Bean> lstDia_ADM_Usuarios_Bean = ua.ConsultarDia_MCO_ACTIVIDADAction(fecha.Month + "", fecha.Year + "", fecha.Day + "");
                    List<MRH_TRAB_COMP_Bean> lstDia_MRH_TRAB_COMP_Bean = mt.ConsultarDia_MRH_TRAB_COMPDAction(fecha.Month + "", fecha.Year + "", fecha.Day + "");
                    List<MPM_Labores_Mina_Bean> lstDia_MPM_Labores_Mina_Bean = ml.ConsultarDia_MPM_Labores_MinaAction(fecha.Month + "", fecha.Year + "", fecha.Day + "");
                    List<MCP_PROVEEDORES_Bean> lstDia_MCP_PROVEEDORES_Bean = mp.ConsultarDia_MCP_PROVEEDORESAction(fecha.Month + "", fecha.Year + "", fecha.Day + "");
                    List<GS_OC_DET_OBS_COMPORTAMIENTO_Bean> lstGSDia_OC_DET_OBS_COMPORTAMIENTO_Bean = dc.ConsultarDia_GS_OC_DET_OBS_COMPORTAMIENTOAction(fecha.Month + "", fecha.Year + "", fecha.Day + "");
                    List<GS_OC_CAB_OBS_COMPORTAMIENTO_Bean> lstGSDia_GS_OC_CAB_OBS_COMPORTAMIENTO_Bean = cc.ConsultarDia_GS_OC_CAB_OBS_COMPORTAMIENTOAction(fecha.Month + "", fecha.Year + "", fecha.Day + "");


                    Console.WriteLine("cantidad total de categorias del dia de hoy: " + lstDia_MGS_OC_CATEGORIA_ACTO_CONDICION_Bean.Count);
                    Console.WriteLine("cantidad total de zonas del dia de hoy: " + lstDia_m_ZONAS_Beans.Count);
                    Console.WriteLine("cantidad total de actividad del dia de hoy: " + lstDia_MCO_ACTIVIDAD_Bean.Count);
                    Console.WriteLine("cantidad total de usuarios del dia de hoy: " + lstDia_ADM_Usuarios_Bean.Count);
                    Console.WriteLine("cantidad total de trab del dia de hoy: " + lstDia_MRH_TRAB_COMP_Bean.Count);
                    Console.WriteLine("cantidad total de labores mina del dia de hoy: " + lstDia_MPM_Labores_Mina_Bean.Count);
                    Console.WriteLine("cantidad total de provedores del dia hoy: " + lstDia_MCP_PROVEEDORES_Bean.Count);
                    Console.WriteLine("cantidad total de detalles del dia de hoy: " + lstGSDia_OC_DET_OBS_COMPORTAMIENTO_Bean.Count);
                    Console.WriteLine("cantidad total de cabeceras del dia de hoy: " + lstGSDia_GS_OC_CAB_OBS_COMPORTAMIENTO_Bean.Count);
                    Console.WriteLine("cantidad total de procesos: " + lstM_PROCESOS_SIG_DPTOS.Count);

                    ///************************ ENVIANDO  CATEGORIAS DIARIO**************************

                    List<MGS_OC_CATEGORIA_ACTO_CONDICION_Bean> lstMes_MGS_OC_CATEGORIA_ACTO_CONDICION_Bean_send = new List<MGS_OC_CATEGORIA_ACTO_CONDICION_Bean>();
                    contTotal = lstDia_MGS_OC_CATEGORIA_ACTO_CONDICION_Bean.Count;
                    Console.WriteLine("\n");
                    auxCont = 0;
                    Console.WriteLine("--> enviando datos de categorias");
                    foreach (MGS_OC_CATEGORIA_ACTO_CONDICION_Bean bean in lstDia_MGS_OC_CATEGORIA_ACTO_CONDICION_Bean)
                    {
                        if (lstDia_MGS_OC_CATEGORIA_ACTO_CONDICION_Bean.Count > 20)
                        {
                            if (cont < 20)
                            {
                                lstMes_MGS_OC_CATEGORIA_ACTO_CONDICION_Bean_send.Add(bean);
                                cont++;
                            }
                            else
                            {
                                lstMes_MGS_OC_CATEGORIA_ACTO_CONDICION_Bean_send.Add(bean);
                                contTotal = contTotal - (cont + 1);
                                PostRequest("http://beta.focusit.pe/poderosa/ext/setData/MGS_OC_CATEGORIA_ACTO_CONDICION", JsonConvert.SerializeObject(lstMes_MGS_OC_CATEGORIA_ACTO_CONDICION_Bean_send));
                                cont = 0;
                                lstMes_MGS_OC_CATEGORIA_ACTO_CONDICION_Bean_send = new List<MGS_OC_CATEGORIA_ACTO_CONDICION_Bean>();
                            }

                            if (cont <= 19 && contTotal < 20)
                            {
                                if (auxCont == contTotal) PostRequest("http://beta.focusit.pe/poderosa/ext/setData/MGS_OC_CATEGORIA_ACTO_CONDICION", JsonConvert.SerializeObject(lstMes_MGS_OC_CATEGORIA_ACTO_CONDICION_Bean_send));
                                auxCont++;
                            }
                        }
                        else
                        {
                            lstMes_MGS_OC_CATEGORIA_ACTO_CONDICION_Bean_send.Add(bean);
                            PostRequest("http://beta.focusit.pe/poderosa/ext/setData/MGS_OC_CATEGORIA_ACTO_CONDICION", JsonConvert.SerializeObject(lstMes_MGS_OC_CATEGORIA_ACTO_CONDICION_Bean_send));
                        }
                    }
                    Console.WriteLine("<-- datos de categorias enviados ");
                    cont = 0;

                    ///*********************** ENVIANDO ZONAS DIARIO **************************

                    List<M_ZONAS_Bean> m_ZONAS_Beans_send = new List<M_ZONAS_Bean>();
                    contTotal = lstDia_m_ZONAS_Beans.Count;
                    Console.WriteLine("\n");
                    auxCont = 0;
                    Console.WriteLine("--> enviando datos de zonas");
                    foreach (M_ZONAS_Bean bean in lstDia_m_ZONAS_Beans)
                    {
                        if (lstDia_m_ZONAS_Beans.Count > 20)
                        {
                            if (cont < 20)
                            {
                                m_ZONAS_Beans_send.Add(bean);
                                cont++;
                            }
                            else
                            {
                                m_ZONAS_Beans_send.Add(bean);
                                contTotal = contTotal - (cont + 1);
                                PostRequest("http://beta.focusit.pe/poderosa/ext/setData/M_ZONAS", JsonConvert.SerializeObject(m_ZONAS_Beans_send));
                                cont = 0;
                                m_ZONAS_Beans_send = new List<M_ZONAS_Bean>();
                            }

                            if (cont <= 19 && contTotal < 20)
                            {
                                if (auxCont == contTotal) PostRequest("http://beta.focusit.pe/poderosa/ext/setData/M_ZONAS", JsonConvert.SerializeObject(m_ZONAS_Beans_send));
                                auxCont++;
                            }
                        }
                        else
                        {
                            m_ZONAS_Beans_send.Add(bean);
                            PostRequest("http://beta.focusit.pe/poderosa/ext/setData/M_ZONAS", JsonConvert.SerializeObject(m_ZONAS_Beans_send));

                        }
                    }
                    Console.WriteLine("<-- datos de zonas enviados ");
                    cont = 0;


                    ///*********************** ENVIANDO ACTIVIDAD DIARIO **************************

                    List<MCO_ACTIVIDAD_Bean> MCO_ACTIVIDAD_Bean_send = new List<MCO_ACTIVIDAD_Bean>();
                    contTotal = lstDia_MCO_ACTIVIDAD_Bean.Count;
                    Console.WriteLine("\n");
                    auxCont = 0;
                    Console.WriteLine("--> enviando datos de actividad");
                    foreach (MCO_ACTIVIDAD_Bean bean in lstDia_MCO_ACTIVIDAD_Bean)
                    {
                        if (lstDia_MCO_ACTIVIDAD_Bean.Count > 20)
                        {
                            if (cont < 20)
                            {
                                MCO_ACTIVIDAD_Bean_send.Add(bean);
                                cont++;
                            }
                            else
                            {
                                MCO_ACTIVIDAD_Bean_send.Add(bean);
                                contTotal = contTotal - (cont + 1);
                                PostRequest("http://beta.focusit.pe/poderosa/ext/setData/MCO_ACTIVIDAD", JsonConvert.SerializeObject(MCO_ACTIVIDAD_Bean_send));
                                cont = 0;
                                MCO_ACTIVIDAD_Bean_send = new List<MCO_ACTIVIDAD_Bean>();
                            }

                            if (cont <= 19 && contTotal < 20)
                            {
                                if (auxCont == contTotal) PostRequest("http://beta.focusit.pe/poderosa/ext/setData/MCO_ACTIVIDAD", JsonConvert.SerializeObject(MCO_ACTIVIDAD_Bean_send));
                                auxCont++;
                            }
                        }
                        else
                        {
                            MCO_ACTIVIDAD_Bean_send.Add(bean);
                            PostRequest("http://beta.focusit.pe/poderosa/ext/setData/MCO_ACTIVIDAD", JsonConvert.SerializeObject(MCO_ACTIVIDAD_Bean_send));
                        }
                    }
                    Console.WriteLine("<-- datos de actividad enviados ");
                    cont = 0;


                    ///************************ ENVIANDO USUARIOS DIARIO **************************

                    List<ADM_Usuarios_Bean> ADM_Usuarios_Bean_send = new List<ADM_Usuarios_Bean>();
                    contTotal = lstDia_ADM_Usuarios_Bean.Count;
                    Console.WriteLine("\n");
                    auxCont = 0;
                    Console.WriteLine("--> enviando datos de usuario");
                    foreach (ADM_Usuarios_Bean bean in lstDia_ADM_Usuarios_Bean)
                    {
                        if (lstDia_ADM_Usuarios_Bean.Count > 20)
                        {
                            if (cont < 20)
                            {
                                ADM_Usuarios_Bean_send.Add(bean);
                                cont++;
                            }
                            else
                            {
                                ADM_Usuarios_Bean_send.Add(bean);
                                contTotal = contTotal - (cont + 1);
                                PostRequest("http://beta.focusit.pe/poderosa/ext/setData/ADM_Usuarios", JsonConvert.SerializeObject(ADM_Usuarios_Bean_send));
                                cont = 0;
                                ADM_Usuarios_Bean_send = new List<ADM_Usuarios_Bean>();
                            }

                            if (cont <= 19 && contTotal < 20)
                            {
                                if (auxCont == contTotal) PostRequest("http://beta.focusit.pe/poderosa/ext/setData/ADM_Usuarios", JsonConvert.SerializeObject(ADM_Usuarios_Bean_send));
                                auxCont++;
                            }
                        }
                        else
                        {
                            ADM_Usuarios_Bean_send.Add(bean);
                            PostRequest("http://beta.focusit.pe/poderosa/ext/setData/ADM_Usuarios", JsonConvert.SerializeObject(ADM_Usuarios_Bean_send));
                        }
                    }
                    Console.WriteLine("<--  datos de usuarios enviados ");
                    cont = 0;

                    ///************************ ENVIANDO trabajos DIARIO *************************

                    List<MRH_TRAB_COMP_Bean> MRH_TRAB_COMP_Bean_send = new List<MRH_TRAB_COMP_Bean>();
                    contTotal = lstDia_MRH_TRAB_COMP_Bean.Count;
                    Console.WriteLine("\n");
                    auxCont = 0;
                    Console.WriteLine("--> enviando datos de trabajos");
                    foreach (MRH_TRAB_COMP_Bean bean in lstDia_MRH_TRAB_COMP_Bean)
                    {
                        if (lstDia_MRH_TRAB_COMP_Bean.Count > 20)
                        {
                            if (cont < 20)
                            {
                                MRH_TRAB_COMP_Bean_send.Add(bean);
                                cont++;
                            }
                            else
                            {
                                MRH_TRAB_COMP_Bean_send.Add(bean);
                                contTotal = contTotal - (cont + 1);
                                PostRequest("http://beta.focusit.pe/poderosa/ext/setData/MRH_TRAB_COMP", JsonConvert.SerializeObject(MRH_TRAB_COMP_Bean_send));
                                cont = 0;
                                MRH_TRAB_COMP_Bean_send = new List<MRH_TRAB_COMP_Bean>();
                            }

                            if (cont <= 19 && contTotal < 20)
                            {
                                if (auxCont == contTotal) PostRequest("http://beta.focusit.pe/poderosa/ext/setData/MRH_TRAB_COMP", JsonConvert.SerializeObject(MRH_TRAB_COMP_Bean_send));
                                auxCont++;
                            }
                        }
                        else
                        {
                            MRH_TRAB_COMP_Bean_send.Add(bean);
                            PostRequest("http://beta.focusit.pe/poderosa/ext/setData/MRH_TRAB_COMP", JsonConvert.SerializeObject(MRH_TRAB_COMP_Bean_send));
                        }
                    }
                    Console.WriteLine("<--  datos de trabajos enviados ");
                    cont = 0;

                    ///************************ ENVIANDO Labores DIARIO **************************
                    List<MPM_Labores_Mina_Bean> MPM_Labores_Mina_Bean_send = new List<MPM_Labores_Mina_Bean>();
                    contTotal = lstDia_MPM_Labores_Mina_Bean.Count;
                    Console.WriteLine("\n");
                    auxCont = 0;
                    Console.WriteLine("--> enviando datos de minas");
                    foreach (MPM_Labores_Mina_Bean bean in lstDia_MPM_Labores_Mina_Bean)
                    {
                        if (lstDia_MPM_Labores_Mina_Bean.Count > 20)
                        {

                            if (cont < 20)
                            {
                                MPM_Labores_Mina_Bean_send.Add(bean);
                                cont++;
                            }
                            else
                            {
                                MPM_Labores_Mina_Bean_send.Add(bean);
                                contTotal = contTotal - (cont + 1);
                                PostRequest("http://beta.focusit.pe/poderosa/ext/setData/MPM_Labores_Mina", JsonConvert.SerializeObject(MPM_Labores_Mina_Bean_send));
                                cont = 0;
                                MPM_Labores_Mina_Bean_send = new List<MPM_Labores_Mina_Bean>();
                            }

                            if (cont <= 19 && contTotal < 20)
                            {
                                if (auxCont == contTotal) PostRequest("http://beta.focusit.pe/poderosa/ext/setData/MPM_Labores_Mina", JsonConvert.SerializeObject(MPM_Labores_Mina_Bean_send));
                                auxCont++;
                            }

                        }
                        else
                        {
                            MPM_Labores_Mina_Bean_send.Add(bean);
                            PostRequest("http://beta.focusit.pe/poderosa/ext/setData/MPM_Labores_Mina", JsonConvert.SerializeObject(MPM_Labores_Mina_Bean_send));
                        }
                    }
                    Console.WriteLine("<--  datos de trabajos minas ");
                    cont = 0;

                    ///************************ ENVIANDO Proveedores DIARIO **************************

                    List<MCP_PROVEEDORES_Bean> MCP_PROVEEDORES_Bean_send = new List<MCP_PROVEEDORES_Bean>();
                    contTotal = lstDia_MCP_PROVEEDORES_Bean.Count;
                    Console.WriteLine("\n");
                    auxCont = 0;
                    Console.WriteLine("--> enviando datos de proveedores");
                    foreach (MCP_PROVEEDORES_Bean bean in lstDia_MCP_PROVEEDORES_Bean)
                    {
                        if (lstDia_MCP_PROVEEDORES_Bean.Count > 20)
                        {
                            if (cont < 20)
                            {
                                MCP_PROVEEDORES_Bean_send.Add(bean);
                                cont++;
                            }
                            else
                            {
                                MCP_PROVEEDORES_Bean_send.Add(bean);
                                contTotal = contTotal - (cont + 1);
                                PostRequest("http://beta.focusit.pe/poderosa/ext/setData/MCP_PROVEEDORES", JsonConvert.SerializeObject(MCP_PROVEEDORES_Bean_send));
                                cont = 0;
                                MCP_PROVEEDORES_Bean_send = new List<MCP_PROVEEDORES_Bean>();
                            }

                            if (cont <= 19 && contTotal < 20)
                            {
                                if (auxCont == contTotal) PostRequest("http://beta.focusit.pe/poderosa/ext/setData/MCP_PROVEEDORES", JsonConvert.SerializeObject(MCP_PROVEEDORES_Bean_send));
                                auxCont++;
                            }
                        }
                        else
                        {
                            MCP_PROVEEDORES_Bean_send.Add(bean);
                            PostRequest("http://beta.focusit.pe/poderosa/ext/setData/MCP_PROVEEDORES", JsonConvert.SerializeObject(MCP_PROVEEDORES_Bean_send));
                        }
                    }
                    Console.WriteLine("<--  datos de proveedores enviados ");
                    cont = 0;

                    ///*********************** ENVIANDO detalles comportamiento DIARIO **************************
                    List<GS_OC_DET_OBS_COMPORTAMIENTO_Bean> GS_OC_DET_OBS_COMPORTAMIENTO_Bean_send = new List<GS_OC_DET_OBS_COMPORTAMIENTO_Bean>();
                    contTotal = lstGSDia_OC_DET_OBS_COMPORTAMIENTO_Bean.Count;
                    Console.WriteLine("\n");
                    auxCont = 0;
                    Console.WriteLine("--> enviando datos de detalles");
                    foreach (GS_OC_DET_OBS_COMPORTAMIENTO_Bean bean in lstGSDia_OC_DET_OBS_COMPORTAMIENTO_Bean)
                    {
                        if (lstGSDia_OC_DET_OBS_COMPORTAMIENTO_Bean.Count > 20)
                        {
                            if (cont < 20)
                            {
                                GS_OC_DET_OBS_COMPORTAMIENTO_Bean_send.Add(bean);
                                cont++;
                            }
                            else
                            {
                                GS_OC_DET_OBS_COMPORTAMIENTO_Bean_send.Add(bean);
                                contTotal = contTotal - (cont + 1);
                                PostRequest("http://beta.focusit.pe/poderosa/ext/setData/GS_OC_DET_OBS_COMPORTAMIENTO", JsonConvert.SerializeObject(GS_OC_DET_OBS_COMPORTAMIENTO_Bean_send));
                                cont = 0;
                                GS_OC_DET_OBS_COMPORTAMIENTO_Bean_send = new List<GS_OC_DET_OBS_COMPORTAMIENTO_Bean>();
                            }

                            if (cont <= 19 && contTotal < 20)
                            {
                                if (auxCont == contTotal) PostRequest("http://beta.focusit.pe/poderosa/ext/setData/GS_OC_DET_OBS_COMPORTAMIENTO", JsonConvert.SerializeObject(GS_OC_DET_OBS_COMPORTAMIENTO_Bean_send));
                                auxCont++;
                            }
                        }
                        else
                        {
                            GS_OC_DET_OBS_COMPORTAMIENTO_Bean_send.Add(bean);
                            PostRequest("http://beta.focusit.pe/poderosa/ext/setData/GS_OC_DET_OBS_COMPORTAMIENTO", JsonConvert.SerializeObject(GS_OC_DET_OBS_COMPORTAMIENTO_Bean_send));

                        }
                    }
                    Console.WriteLine("<--  datos de detalles enviados ");
                    cont = 0;


                    //*********************** ENVIANDO cabecera DIARIO *************************
                    List<GS_OC_CAB_OBS_COMPORTAMIENTO_Bean> GS_OC_CAB_OBS_COMPORTAMIENTO_Bean_send = new List<GS_OC_CAB_OBS_COMPORTAMIENTO_Bean>();
                    contTotal = lstGSDia_GS_OC_CAB_OBS_COMPORTAMIENTO_Bean.Count;
                    Console.WriteLine("\n");
                    auxCont = 0;
                    Console.WriteLine("--> enviando datos de cabeceras");
                    foreach (GS_OC_CAB_OBS_COMPORTAMIENTO_Bean bean in lstGSDia_GS_OC_CAB_OBS_COMPORTAMIENTO_Bean)
                    {
                        if (lstGSDia_GS_OC_CAB_OBS_COMPORTAMIENTO_Bean.Count > 20)
                        {
                            if (cont < 20)
                            {
                                GS_OC_CAB_OBS_COMPORTAMIENTO_Bean_send.Add(bean);
                                cont++;
                            }
                            else
                            {
                                GS_OC_CAB_OBS_COMPORTAMIENTO_Bean_send.Add(bean);
                                contTotal = contTotal - (cont + 1);
                                PostRequest("http://beta.focusit.pe/poderosa/ext/setData/GS_OC_CAB_OBS_COMPORTAMIENTO", JsonConvert.SerializeObject(GS_OC_CAB_OBS_COMPORTAMIENTO_Bean_send));
                                cont = 0;
                                GS_OC_CAB_OBS_COMPORTAMIENTO_Bean_send = new List<GS_OC_CAB_OBS_COMPORTAMIENTO_Bean>();
                            }

                            if (cont <= 19 && contTotal < 20)
                            {
                                if (auxCont == contTotal) PostRequest("http://beta.focusit.pe/poderosa/ext/setData/GS_OC_CAB_OBS_COMPORTAMIENTO", JsonConvert.SerializeObject(GS_OC_CAB_OBS_COMPORTAMIENTO_Bean_send));
                                auxCont++;
                            }
                        }
                        else
                        {
                            GS_OC_CAB_OBS_COMPORTAMIENTO_Bean_send.Add(bean);
                            PostRequest("http://beta.focusit.pe/poderosa/ext/setData/GS_OC_CAB_OBS_COMPORTAMIENTO", JsonConvert.SerializeObject(GS_OC_CAB_OBS_COMPORTAMIENTO_Bean_send));

                        }
                    }
                    Console.WriteLine("<--  datos de cabeceras enviados ");
                    cont = 0;


                }

                //*********************** ENVIANDO PROCESOS *************************

                List<M_PROCESOS_SIG_DPTOS_Bean> lstM_PROCESOS_SIG_DPTOS_send = new List<M_PROCESOS_SIG_DPTOS_Bean>();
                contTotal = lstM_PROCESOS_SIG_DPTOS.Count;
                Console.WriteLine("\n");
                auxCont = 0;
                Console.WriteLine("--> enviando datos de procesos");
                foreach (M_PROCESOS_SIG_DPTOS_Bean bean in lstM_PROCESOS_SIG_DPTOS)
                {

                    if (lstM_PROCESOS_SIG_DPTOS.Count > 20)
                    {
                        if (cont < 20)
                        {
                            lstM_PROCESOS_SIG_DPTOS_send.Add(bean);
                            cont++;
                        }
                        else
                        {
                            lstM_PROCESOS_SIG_DPTOS_send.Add(bean);
                            contTotal = contTotal - (cont + 1);
                            PostRequest("http://beta.focusit.pe/poderosa/ext/setData/M_PROCESOS_SIG_DPTOS", JsonConvert.SerializeObject(lstM_PROCESOS_SIG_DPTOS_send));
                            cont = 0;
                            lstM_PROCESOS_SIG_DPTOS_send = new List<M_PROCESOS_SIG_DPTOS_Bean>();
                        }

                        if (cont <= 19 && contTotal < 20)
                        {
                            if (auxCont == contTotal) PostRequest("http://beta.focusit.pe/poderosa/ext/setData/M_PROCESOS_SIG_DPTOS", JsonConvert.SerializeObject(lstM_PROCESOS_SIG_DPTOS_send));
                            auxCont++;
                        }
                    }
                    else
                    {
                        lstM_PROCESOS_SIG_DPTOS_send.Add(bean);
                        PostRequest("http://beta.focusit.pe/poderosa/ext/setData/M_PROCESOS_SIG_DPTOS", JsonConvert.SerializeObject(lstM_PROCESOS_SIG_DPTOS_send));

                    }
                }
                Console.WriteLine("<-- datos de procesos enviados ");
                cont = 0;
                */

                 GetRequest("http://beta.focusit.pe/poderosa/ext/getData?token=BAE3B2E77A959BABFC1161C6874");
                Thread.Sleep(99999999);
            }
            Console.ReadKey();
        }

        //get
        async static void GetRequest(string url)
        {
            Console.WriteLine("**** RECIBIENDO DATOS DE DETALLE Y CABEZERA DE LA NUBE ***");
            using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage response = await client.GetAsync(url))
                {
                    using (HttpContent content = response.Content)
                    {
                        string mycontent = await content.ReadAsStringAsync();
                        var responsee = JsonConvert.DeserializeObject<JObject>(mycontent);
                        var data_GS_OC_CAB_OBS_COMPORTAMIENTO = (JArray)responsee["GS_OC_CAB_OBS_COMPORTAMIENTO"];
                        var data_GS_OC_DET_OBS_COMPORTAMIENTO = (JArray)responsee["GS_OC_DET_OBS_COMPORTAMIENTO"];

                        JArray ja_GS_OC_CAB_OBS_COMPORTAMIENTO = data_GS_OC_CAB_OBS_COMPORTAMIENTO;
                        JArray ja_GS_OC_DET_OBS_COMPORTAMIENTO = data_GS_OC_DET_OBS_COMPORTAMIENTO;

                        List<GS_OC_DET_OBS_COMPORTAMIENTO_Bean> lista_det = new List<GS_OC_DET_OBS_COMPORTAMIENTO_Bean>();
                        List<GS_OC_CAB_OBS_COMPORTAMIENTO_Bean> lista_cab = new List<GS_OC_CAB_OBS_COMPORTAMIENTO_Bean>();
                        List<string> idCab = new List<string>();
                        List<string> idDet = new List<string>();


                        //deserializa json de cabeceras
                        foreach (JObject item in ja_GS_OC_CAB_OBS_COMPORTAMIENTO.Children())
                        {
                            GS_OC_CAB_OBS_COMPORTAMIENTO_Bean cat_observaciones = new GS_OC_CAB_OBS_COMPORTAMIENTO_Bean();
                            //cat_observaciones.ID = ;
                            idCab.Add(item.GetValue("id") + "");
                            cat_observaciones.CIA_ID = item.GetValue("CIA_ID") + "";
                            cat_observaciones.ANNOMES = item.GetValue("ANNOMES") + "";
                            cat_observaciones.OBSERVACION_ID = item.GetValue("OBSERVACION_ID") + "";
                            cat_observaciones.TRAB_ID = item.GetValue("TRAB_ID") + "";
                            cat_observaciones.PROVEEDOR_ID_OBSERVADOR = item.GetValue("PROVEEDOR_ID_OBSERVADOR") + "";
                            cat_observaciones.DPTO_ID = item.GetValue("DPTO_ID") + "";
                            cat_observaciones.FECHA_OBSERVACION = item.GetValue("FECHA_OBSERVACION") + "";
                            cat_observaciones.ACTIVIDAD_ID = item.GetValue("ACTIVIDAD_ID") + "";
                            cat_observaciones.ZONA_ID = item.GetValue("ZONA_ID") + "";
                            cat_observaciones.LABOR_ID = item.GetValue("LABOR_ID") + "";
                            cat_observaciones.ACCIONES_SEGURAS_OBS = item.GetValue("ACCIONES_SEGURAS_OBS") + "";
                            cat_observaciones.ACTOS_INSEGUROS_OBS = item.GetValue("ACTOS_INSEGUROS_OBS") + "";
                            cat_observaciones.NRO_PERSONAS_CONTACTADAS = item.GetValue("NRO_PERSONAS_CONTACTADAS") + "";
                            cat_observaciones.NRO_PERSONAS_OBSERVADAS = item.GetValue("NRO_PERSONAS_OBSERVADAS") + "";
                            cat_observaciones.OPERADOR_CREA = item.GetValue("OPERADOR_CREA") + "";
                            cat_observaciones.FECHA_CREA = item.GetValue("FECHA_CREA") + "";
                            cat_observaciones.OPERADOR_MODI = item.GetValue("OPERADOR_MODI") + "";
                            cat_observaciones.FECHA_MODI = item.GetValue("FECHA_MODI") + "";
                            cat_observaciones.TURNO = item.GetValue("TURNO") + "";
                            cat_observaciones.TIEMPO = item.GetValue("TIEMPO") + "";
                            cat_observaciones.PROVEEDOR_ID_OBSERVADOS = item.GetValue("PROVEEDOR_ID_OBSERVADOS") + "";
                            cat_observaciones.ESTADO = item.GetValue("ESTADO") + "";
                            lista_cab.Add(cat_observaciones);
                        }


                        //deserializa json de detalles
                        foreach (JObject item in ja_GS_OC_DET_OBS_COMPORTAMIENTO.Children())
                        {
                            GS_OC_DET_OBS_COMPORTAMIENTO_Bean det_observacion = new GS_OC_DET_OBS_COMPORTAMIENTO_Bean();

                           // det_observacion.ID = item.GetValue("id") + "";
                            idDet.Add(item.GetValue("id") + "");
                            det_observacion.CIA_ID = item.GetValue("CIA_ID") + "";
                            det_observacion.ANNOMES = item.GetValue("ANNOMES") + "";
                            det_observacion.OBSERVACION_ID = item.GetValue("OBSERVACION_ID") + "";
                            det_observacion.DETALLE_ID = item.GetValue("DETALLE_ID") + "";
                            det_observacion.NRO_VERSION = item.GetValue("NRO_VERSION") + "";
                            det_observacion.NRO_INSEGUROS = item.GetValue("NRO_INSEGUROS") + "";
                            det_observacion.NRO_SEGUROS = item.GetValue("NRO_SEGUROS") + "";
                            det_observacion.TODO_ES_SEGURO = item.GetValue("TODO_ES_SEGURO") + "";
                            det_observacion.OBSERVACION = item.GetValue("OBSERVACION") + "";
                            det_observacion.OPERADOR_CREA = item.GetValue("OPERADOR_CREA") + "";
                            det_observacion.FECHA_CREA = item.GetValue("FECHA_CREA") + "";
                            det_observacion.OPERADOR_MODI = item.GetValue("OPERADOR_MODI") + "";
                            det_observacion.FECHA_MODI = item.GetValue("FECHA_MODI") + "";
                            lista_det.Add(det_observacion);
                        }


                        cc.updateOrCreate_GS_OC_CAB_OBS_COMPORTAMIENTO(lista_cab);
                        dc.updateOrCreate_GS_OC_DET_OBS_COMPORTAMIENTO(lista_det);
                        Console.WriteLine("cantidad de detalles registrados/modificados :  " + lista_det.Count);
                        Console.WriteLine("cantidad de cabeceras registradas/modificados:  " + lista_cab.Count);
                       // Console.WriteLine("ids det: "+idDet.Count+" id cab: "+idCab.Count);
                        PostRequestState("http://beta.focusit.pe/poderosa/ext/setState?token=BAE3B2E77A959BABFC1161C6874", JsonConvert.SerializeObject(idCab), JsonConvert.SerializeObject(idDet));
                    
                    }
                }
            }
        }

        //post
        async static void PostRequest(string url, String items)
        {
            IEnumerable<KeyValuePair<string, string>> queries = new List<KeyValuePair<string, string>>()
            {

                new KeyValuePair<string, string>("items",items),
                new KeyValuePair<string, string>("token","BAE3B2E77A959BABFC1161C6874")

            };
            HttpContent q = new FormUrlEncodedContent(queries);

            using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage response = await client.PostAsync(url, q))
                {
                    using (HttpContent content = response.Content)
                    {
                        string mycontent = await content.ReadAsStringAsync();
                        HttpContentHeaders headers = content.Headers;
                        // Console.WriteLine(mycontent);
                    }
                }
            }
        }

        //post
        async static void PostRequestState(string url, String cab, String det)
        {
           
            IEnumerable<KeyValuePair<string, string>> queries = new List<KeyValuePair<string, string>>()
            {

                new KeyValuePair<string, string>("GS_OC_CAB_OBS_COMPORTAMIENTO",cab),
                new KeyValuePair<string, string>("GS_OC_DET_OBS_COMPORTAMIENTO",det)

            };
            HttpContent q = new FormUrlEncodedContent(queries);

            using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage response = await client.PostAsync(url, q))
                {
                    using (HttpContent content = response.Content)
                    {
                        string mycontent = await content.ReadAsStringAsync();
                        HttpContentHeaders headers = content.Headers;
                      //  Console.WriteLine(mycontent);
                    }
                }
            }
        }

    


    }
}

