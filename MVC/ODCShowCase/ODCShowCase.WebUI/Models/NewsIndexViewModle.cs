using ODCShowCase.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ODCShowCase.WebUI.Models
{
    public class NewsIndexViewModle
    {
        public IEnumerable<News> Newses { get; set; }
        public PagingInfo PagingInfo { get; set; }
    }
}