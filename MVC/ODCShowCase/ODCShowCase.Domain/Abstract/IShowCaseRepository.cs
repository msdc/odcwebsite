using System.Linq;
using ODCShowCase.Domain.Entities;

namespace ODCShowCase.Domain.Abstract
{
    public interface IShowCaseRepository
    {
        IQueryable<ShowCase> ShowCases { get; }
    }
}
