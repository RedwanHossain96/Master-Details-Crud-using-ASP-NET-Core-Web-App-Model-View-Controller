using System.ComponentModel.DataAnnotations;

namespace MyPractise1.Models
{
    public class OrderDetail
    {
        [Key]
        public int OrderDetailId { get; set; }

        [Required(ErrorMessage = "Quantity is required")]
        [Range(1, int.MaxValue, ErrorMessage = "Quantity must be a positive number")]
        public int Quantity { get; set; }

        [Required(ErrorMessage = "Price is required")]
        [Range(0.01, double.MaxValue, ErrorMessage = "Price must be a positive number")]
        public decimal Price { get; set; }

        public int ProductId { get; set; }
        public virtual Product Product { get; set; }

        public int OrderId { get; set; }
        public OrderMaster OrderMaster { get; set; }
    }
}
