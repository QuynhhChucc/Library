using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Library.Models
{
    public class Book
    {
        [Key]
        public int Id { get; set; }
        public string? Image { get; set; }
        public string? Title { get; set; }
        public string? Author { get; set; }
        public int Quantity { get; set; }

        public decimal Price { get; set; }

        public string? Description { get; set; }

       

        [ForeignKey("Category")]
        public int CategoryId { get; set; }

        public virtual Category? category { get; set; }
    }
}
