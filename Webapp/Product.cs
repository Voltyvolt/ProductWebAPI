using System.ComponentModel.DataAnnotations;

namespace Webapp
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string ProductName { get; set; }
        public string productDetail { get; set; }
        public double Price { get; set; }
        public string Images { get; set; }
        public string Timestamp { get; set; }

    }
}
