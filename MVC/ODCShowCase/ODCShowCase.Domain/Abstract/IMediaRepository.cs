using ODCShowCase.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ODCShowCase.Domain.Abstract
{
    public interface IMediaRepository
    {
        IQueryable<Media> Medias { get; }
    }
}
