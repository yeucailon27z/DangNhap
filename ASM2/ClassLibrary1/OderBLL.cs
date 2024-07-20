using DAL;
using DTO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class OderBLL
    {
        OrderDAL orderDAL = new OrderDAL();
        public List<Order> GetALLOder()
        {
            var orders = orderDAL.GetALLOrder();
            return orders;
        }
        public List<Order> AddOrders(Order order)
        {
            var ordes = orderDAL.AddOrders(order);
            ordes.Add(order);
            return ordes;
        }
        public Order TimID(int ID)
        {
            return orderDAL.TimID(ID);
        }
        public void DeleteOrder(int orderId)
        {
            orderDAL.DeleteOrder(orderId);
        }
    }
}
