using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MyPractise1.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }

        [Display(Name = "Product Name")]
        public string ProductName { get; set; }

        public ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
