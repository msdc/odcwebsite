using System.ComponentModel.DataAnnotations;

namespace ODCShowCase.Domain.Entities
{
    public class Text
    {
        [Key]
        public int TextId { get; set; }
        public int TextOrder { get; set; }
        public string TextContent { get; set; }
        public int CaseId { get; set; }
        public string TextType { get; set; }
    }
}
