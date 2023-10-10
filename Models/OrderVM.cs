using Microsoft.AspNetCore.Http;

namespace MyPractise1.Models
{
    public class OrderVM
    {
        public OrderMaster OrderMaster { get; set; }

        public IFormFile imagefile { get; set; }
    }
}
