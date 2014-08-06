using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ODCShowCase.Domain.Entities;

namespace ODCShowCase.Domain.Abstract
{
    public interface INewsRepository
    {
        IQueryable<News> Newses { get; }
    }
}
