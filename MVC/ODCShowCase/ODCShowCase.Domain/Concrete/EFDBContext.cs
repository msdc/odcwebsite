using System.Data.Entity;
using ODCShowCase.Domain.Entities;

namespace ODCShowCase.Domain.Concrete
{
    public class EFDBContext : DbContext
    {
        public DbSet<ShowCase> ShowCases { get; set; }
        public DbSet<Media> Medias { get; set; }
        public DbSet<Text> Texts { get; set; }
        public DbSet<News> Newses { get; set; }
    }
}
