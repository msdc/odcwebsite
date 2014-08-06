using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ODCShowCase.Domain.Concrete;
using ODCShowCase.Domain.Entities;
using ODCShowCase.WebUI.Models;

namespace ODCShowCase.WebUI.Controllers
{
    public class CaseMaterialsAPIController : ApiController
    {
        public EFMediaRepostory mediaRepository = new EFMediaRepostory();
        public EFTextRepostory textRepository = new EFTextRepostory();

        public List<CaseMaterial> GetCaseMaterial(int caseId)
        {
            List<CaseMaterial> caseMaterials = new List<CaseMaterial>();

            CaseMaterial caseMaterial = null;

            var matchTexts = textRepository.Texts.Where(t => t.CaseId == caseId).OrderBy(t => t.TextOrder);

            IEnumerable<Text> textMaterials = matchTexts.Count() > 0 ? (IEnumerable<Text>)matchTexts : null;

            if (textMaterials == null) return null;


            IEnumerable<Media> mediaMaterials = null;

            foreach (Text textMaterial in textMaterials)
            {
                caseMaterial = new CaseMaterial();
                caseMaterial.TextContent = textMaterial;

                var matchMedia = mediaRepository.Medias.Where(m => m.RelevantTextId == textMaterial.TextId).OrderBy(m => m.Order);
                mediaMaterials = matchMedia.Count() > 0 ? (IEnumerable<Media>)matchMedia : null;
               
                caseMaterial.Medias = mediaMaterials;

                caseMaterials.Add(caseMaterial);
            }

            return caseMaterials;
        }
    }
}
