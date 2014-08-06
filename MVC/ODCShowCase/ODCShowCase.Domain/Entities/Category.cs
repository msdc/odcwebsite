using System.ComponentModel.DataAnnotations;

namespace ODCShowCase.Domain.Entities
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
