using System.Linq;
using ODCShowCase.Domain.Abstract;
using ODCShowCase.Domain.Entities;

namespace ODCShowCase.Domain.Concrete
{
    public class EFMediaRepostory : IMediaRepository
    {
        private EFDBContext context = new EFDBContext();

        public IQueryable<Media> Medias
        {
            get { return context.Medias; }
        }
    }
}
