using System.ComponentModel.DataAnnotations;

namespace ODCShowCase.Domain.Entities
{
    public class ShowCase
    {   
        [Key]
        public int CaseId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public string ImageURL { get; set; }
    }
}
