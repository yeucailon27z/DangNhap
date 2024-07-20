using DTO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class OrderDAL
    {
        QLYBanHangContext dbQLY = new QLYBanHangContext();
        public List<Order> GetALLOrder()
        {
            var orders = dbQLY.Orders.ToList();
            return orders;
        }
        public List<Order> AddOrders(Order order)
        {
            var orders = dbQLY.Orders.ToList();
            dbQLY.Orders.Add(order);
            dbQLY.SaveChanges();
            return orders;
        }
        public Order TimID(int ID)
        {
            return dbQLY.Orders.Find(ID);
        }
        public void DeleteOrder(int orderId)
        {
            var orderToDelete = dbQLY.Orders.Find(orderId);
            if (orderToDelete != null)
            {
                dbQLY.Orders.Remove(orderToDelete);
                dbQLY.SaveChanges();
            }
        }
    }
}
