using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ODCShowCase.WebUI.Models;

namespace ODCShowCase.WebUI.Controllers
{
    public class NavController : Controller
    {
        [OutputCache(Duration = 300)]
        public PartialViewResult Menu(string currentController)
        {
            ViewBag.SelectedNavNodeName = currentController;

            NavNode[] navNodes = { //new NavNode("Home", "Index","首页"),
                                   new NavNode("ShowCase", "Index","成功案例"), 
                                   new NavNode("SolutionCase", "Index","行业解决方案"),                                    
                                   new NavNode("AboutCOE", "Index","关于我们"),
                                   new NavNode("News", "Index","新闻动态"),
                                   new NavNode("ContactUs", "Index","联系我们")};

            return PartialView(navNodes);
        }

    }
}
