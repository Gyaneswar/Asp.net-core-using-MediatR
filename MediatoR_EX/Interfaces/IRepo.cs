using MediatoR_EX.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediatoR_EX.Interfaces
{
    public interface IRepo
    {
        public Boolean AddOrder(string item);
        public List<Order> GetAllOrders();
    }
}
