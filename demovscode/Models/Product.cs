using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ef
{
    [Table("Product")]
    public class Product
    {
        [Key]
        [Required]
        public int ProductId { get; set; }

        public string Name { get; set; }
        public decimal Price { set; get; }
    }
}