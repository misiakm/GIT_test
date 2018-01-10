using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace testowy.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            /*
                Wybacz Damian ale skasowałem twoje zmiany ;( Wrzucę co to ty napisałeś do komentarza poniżej:
                    return View();
            */
            ViewBag.abc = "coś sprawdzam";
            return View("abc");

        }
    }
}