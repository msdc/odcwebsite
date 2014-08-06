using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace ODCShowCase.WebUI
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            config.Routes.MapHttpRoute(
                name: "CaseMaterialsApi",
                routeTemplate: "materialsapi/{controller}/{caseId}",
                defaults: new { caseId = RouteParameter.Optional }
            );

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{category}",
                defaults: new { category = RouteParameter.Optional }
            );

            //
            var appXMLType = config.Formatters.XmlFormatter.SupportedMediaTypes.FirstOrDefault(t => t.MediaType == "application/xml");
            config.Formatters.XmlFormatter.SupportedMediaTypes.Remove(appXMLType);
        }
    }
}
