using System.Data.Linq.Mapping;
namespace MvcAjaxApplication.Models
{
    [Table(Name = "Products")]
    public class Products
    {
        [Column(IsPrimaryKey =true)]
        public int productId { get; set; }
        [Column]
        public string productName { get; set; }
        [Column]
        public string productDescription { get; set; }
        [Column]
        public decimal Price { get; set; }
        [Column]
        public int UnitsInStock { get; set; }

    }
}