using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ODCShowCase.WebUI.Controllers
{
    public class SolutionCaseController : Controller
    {
        //
        // GET: /SolutionCase/
        [OutputCache(Duration = 300)]
        public ActionResult Index()
        {
            return View();
        }

    }
}
