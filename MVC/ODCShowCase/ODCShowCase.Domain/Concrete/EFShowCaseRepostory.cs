using System.Linq;
using ODCShowCase.Domain.Abstract;
using ODCShowCase.Domain.Entities;

namespace ODCShowCase.Domain.Concrete
{
    public class EFShowCaseRepostory:IShowCaseRepository
    {
        private EFDBContext context = new EFDBContext();

        public IQueryable<ShowCase> ShowCases
        {
            get { return context.ShowCases; }
        }
    }
}
