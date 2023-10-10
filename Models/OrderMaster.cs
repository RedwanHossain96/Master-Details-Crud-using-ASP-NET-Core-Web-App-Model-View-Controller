using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System;

namespace MyPractise1.Models
{
    public class OrderMaster
    {
        [Key]
        public int OrderId { get; set; }

        [StringLength(100)]
        public string CustomerName { get; set; }

        [Display(Name = "Order Date")]
        [DataType(DataType.Date)]
        [Range(typeof(DateTime), "2023-01-01", "2023-12-31", ErrorMessage = "Date Must be 2023 - 01 - 01 to 2023 - 12 - 31")]
        public DateTime? OrderDate { get; set; }

        [Display(Name = "Image")]
        public string Image { get; set; }

        [Display(Name = "Terms")]
        public bool Terms { get; set; }

        public virtual List<OrderDetail> OrderDetails { get; set; } = new List<OrderDetail>();
    }
}
