using System.Linq;
using ODCShowCase.Domain.Abstract;
using ODCShowCase.Domain.Entities;

namespace ODCShowCase.Domain.Concrete
{
    public class EFTextRepostory : ITextRepository
    {
        private EFDBContext context = new EFDBContext();

        public IQueryable<Text> Texts
        {
            get { return context.Texts; }
        }
    }
}