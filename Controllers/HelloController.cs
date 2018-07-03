using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SitecoreDev.Website.Controllers
{
    public class HelloController : Controller
    {
        // GET: Hello
        public ActionResult Index()
        {
            try
            {
            }
            catch (Exception ex)
            {

            }
            return View("~/Hello/Hello");
        }
    }
}