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

        public ActionResult PaginaError()
        {
            return View();
        }

    }
}