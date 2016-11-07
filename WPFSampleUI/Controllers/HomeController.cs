using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WPFSampleBL;
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
                    clsListadosBL oClsListadoBL = new clsListadosBL();
                    

                    return View("Index");
                }
                catch (Exception){
                    return View("paginaError");
                }
            }

        }
    }
}