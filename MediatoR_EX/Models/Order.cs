using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediatoR_EX.Models
{
    public class Order
    {
        public Guid OrderId { get; set; }

        public string Item { get; set; }
    }
}
