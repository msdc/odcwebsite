using ODCShowCase.Domain.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ODCShowCase.WebUI.Models;

namespace ODCShowCase.WebUI.Controllers
{
    public class NewsController : Controller
    {
        private INewsRepository repository;
        public int PageSize = 6;

        public NewsController(INewsRepository newsRepository)
        {
            this.repository = newsRepository;
        }

        [OutputCache(Duration = 300)]
        public ActionResult Index(int page=1)
        {
            NewsIndexViewModle viewModel = new NewsIndexViewModle
            {
                Newses = repository.Newses
                .OrderBy(n => n.NewsDate)
                .Skip((page - 1) * PageSize)
                .Take(PageSize),

                PagingInfo = new PagingInfo
                {
                    CurrentPage=page,
                    ItemsPerPage=PageSize,
                    TotalItems=repository.Newses.Count()                    
                }
            };

            return View(viewModel);
        }

    }
}
