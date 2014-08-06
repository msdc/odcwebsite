using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ODCShowCase.WebUI.Models
{
    public class NavNode
    {
        public NavNode(string ctrName, string actName,string disName)
        {
            ControlerName = ctrName;
            ActionName = actName;
            DisplayName = disName;
        }

        public string ControlerName { get; set; }
        public string ActionName { get; set; }
        public string DisplayName { get; set; }
    }
}