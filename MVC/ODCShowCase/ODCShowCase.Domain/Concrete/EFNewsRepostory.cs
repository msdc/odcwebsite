using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ODCShowCase.Domain.Abstract;
using ODCShowCase.Domain.Entities;

namespace ODCShowCase.Domain.Concrete
{
    public class EFNewsRepostory : INewsRepository
    {
        private EFDBContext context = new EFDBContext();

        public IQueryable<News> Newses
        {
            get { return context.Newses; }
        }
    }
}
