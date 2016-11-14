using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WPFSampleBL;
using WPFSampleBL.Manejadora;
using WPFSampleEntities;

namespace WPFSampleUI.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            clsListadosBL lista = new clsListadosBL();

            try
            {
                return View(lista.getListadoPersonasBL());
            }
            catch (Exception)
            {
                return View("paginaError");
            }
            
        }
        public ActionResult Create()
        {
            return View();
        }
        //CREAR UNA NUEVA PERSONA
        [HttpPost]
        public ActionResult Create(clsPersona persona)
        {

            int i;
            if (!ModelState.IsValid)
            {
                return View(persona);
            }
            else
            {
                try
                {

                    clsManejadoraPersonaBL oManejadoraPersonaBL = new clsManejadoraPersonaBL();
                    i = oManejadoraPersonaBL.insertarPersonaBL(persona);

                    clsListadosBL listadoPersona = new clsListadosBL();  
                    return View("Index",listadoPersona.getListadoPersonasBL());
                }
                catch (Exception){
                    return View("paginaError");
                }
            }
        }
       
        public ActionResult Edit()
        {
            return View();
        }

        //EDITAR LA PERSONM
        [HttpPost]
        public ActionResult Edit(clsPersona persona)
        {

            int i;
            clsListadosBL lista = new clsListadosBL();
            if (!ModelState.IsValid)
            {
                return View(persona);
            }
            else
            {
                try
                {

                    clsManejadoraPersonaBL oManejadoraPersonaBL = new clsManejadoraPersonaBL();
                    i = oManejadoraPersonaBL.editarPersonaBL(persona);

                    clsListadosBL listadoPersona = new clsListadosBL();
                    return View("Index", listadoPersona.getListadoPersonasBL());
                }
                catch (Exception)
                {
                    return View("paginaError");
                }
            }
        }
        //MOSTRAR PAGINA DE ERROR
        
        public ActionResult PaginaError()
        {
            return View();
        }

    }
}