using MediatoR_EX.Interfaces;
using MediatoR_EX.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediatoR_EX.Repo
{
    public class OrdersRepo : IRepo
    {
        List<Order> order = new List<Order>();
        public OrdersRepo()
        {
            Order newOrder1 = new Order();
            newOrder1.OrderId = Guid.NewGuid();
            newOrder1.Item = "books";
            order.Add(newOrder1);

            Order newOrder2 = new Order();
            newOrder2.OrderId =Guid.NewGuid();
            newOrder2.Item = "Laptops";
            order.Add(newOrder2);
        }
        public bool AddOrder(string item)
        {
            Order newOrder = new Order();
            newOrder.OrderId = Guid.NewGuid();
            if (string.IsNullOrEmpty(item))
                return false;
            newOrder.Item = item;
            order.Add(newOrder);
            return true;
        }

        public List<Order> GetAllOrders()
        {
            return order;
        }
    }
}
