using System.ComponentModel.DataAnnotations;

namespace Store.Models
{
    public class Category : MainModel
    {
        public Category()
        {
            this.Product = new HashSet<Product>();
        }

        [Required]
        public string Name { get; set; }

        public ICollection<Product> Product { get; set; }   
    }
}
