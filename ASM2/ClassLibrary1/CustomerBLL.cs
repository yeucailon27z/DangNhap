using DAL;
using DTO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class CustomerBLL
    {
        CustomerDAL customerDAL = new CustomerDAL();
        public List<Customer> GetALLCustomer()
        {
            var customers = customerDAL.GetALLCustomer();
            return customers;
        }
        public List<Customer> AddCustomers(Customer customer)
        {
            var customers = customerDAL.AddCustomers(customer);
            customers.Add(customer);
            return customers;
        }
        public Customer TimID(int ID)
        {
            return customerDAL.TimID(ID);
        }
        public void DeleteCustomer(int customerId)
        {
            customerDAL.DeleteCustomer(customerId);
        }
    }
}
