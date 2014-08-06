using System;
using System.ComponentModel.DataAnnotations;

namespace ODCShowCase.Domain.Entities
{
    public class News
    {
        [Key]
        public int NewsId { get; set; }
        public string Summery { get; set; }
        public DateTime NewsDate { get; set; }
        public string DetailPageURL { get; set; }
        public string NewsTitle { get; set; }
        public string NewsIconURL { get; set; }
    }
}
