using DTO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class CustomerDAL
    {
        QLYBanHangContext dbQLY = new QLYBanHangContext();
        public List<Customer> GetALLCustomer()
        {
            var customers = dbQLY.Customers.ToList();

            return customers;
        }
        public List<Customer> AddCustomers(Customer customer)
        {
            var cutomers = dbQLY.Customers.ToList();
            dbQLY.Customers.Add(customer);
            dbQLY.SaveChanges();
            return cutomers;
        }
        public Customer TimID(int ID)
        {
            return dbQLY.Customers.Find(ID);
        }
        public void DeleteCustomer(int customerId)
        {
            var customerToDelete = dbQLY.Customers.Find(customerId);
            if (customerToDelete != null)
            {
                dbQLY.Customers.Remove(customerToDelete);
                dbQLY.SaveChanges();
            }

        }
    }
}
