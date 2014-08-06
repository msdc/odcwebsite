using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ODCShowCase.Domain.Entities;

namespace ODCShowCase.WebUI.Models
{
    public class CaseMaterial
    {
        public Text TextContent { get; set; }
        public IEnumerable<Media> Medias { get; set; }
    }
}