using System.ComponentModel.DataAnnotations;

namespace Store.Models
{
    public class Product : MainModel
    {
        [Key]
        public int ProductId { get; set; }

        [Required]
        public string ProductName { get; set; }

        [Required]
        public string ProductDescription { get; set; }

        [Required]
        public string imageurl { get; set;}

        [Required]
        public string Qty { get; set;}

        [Required]
        public string Cost {  get; set; }

        [Required]
        public string Price { get; set;}

        [Required]
        public Guid CategoryID { get; set; }

        [Required]
        public Category Category { get; set; }

    }
}
