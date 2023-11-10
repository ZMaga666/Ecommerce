using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Entities.Concrete
{
    public class Order
    {public int Id { get; set; }
        public User Users { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public decimal ProductPrice { get; set; }  
        public int ProductQuantity { get; set; }
        public string Message { get; set; }

    }
}
