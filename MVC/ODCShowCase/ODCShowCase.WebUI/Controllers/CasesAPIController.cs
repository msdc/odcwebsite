using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ODCShowCase.Domain.Concrete;
using ODCShowCase.Domain.Entities;

namespace ODCShowCase.WebUI.Controllers
{
    public class CasesAPIController : ApiController
    {
        public EFShowCaseRepostory showCaseRepository = new EFShowCaseRepostory();


        public IEnumerable<ShowCase> GetAllCases()
        {
            return showCaseRepository.ShowCases;
        }

        public IEnumerable<ShowCase> GetCasesByCatigory(string category)
        {
            var matches = showCaseRepository.ShowCases.Where(s => s.Category.ToLower() == category.ToLower());

            return matches.Count() > 0 ? matches : null;
        }
    }
}
