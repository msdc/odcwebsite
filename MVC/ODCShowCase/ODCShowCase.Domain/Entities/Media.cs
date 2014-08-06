using System.ComponentModel.DataAnnotations;

namespace ODCShowCase.Domain.Entities
{
    public class Media
    {
        [Key]
        public int MediaId { get; set; }
        public int Order { get; set; }
        public string Location { get; set; }
        public int RelevantTextId { get; set; }
        public string Type { get; set; }
        public string DisplayLocation { get; set; }
    }
}
