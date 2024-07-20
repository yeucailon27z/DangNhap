using DTO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ProductDAL
    {
        QLYBanHangContext dbQLY = new QLYBanHangContext();
        public List<Product> GetALLProducts()
        {
            var products = dbQLY.Products.ToList();
            return products;
        }
        public List<Product> AddProducts(Product product)
        {
            var products = dbQLY.Products.ToList();
            dbQLY.Products.Add(product);
            dbQLY.SaveChanges();
            return products;
        }
        public Product TimID(int ID)
        {
            return dbQLY.Products.Find(ID);
        }
        public void DeleteProduct(int productId)
        {
            var orderItemsToDelete = dbQLY.OrderItems.Where(oi => oi.ProductId == productId).ToList();
            dbQLY.OrderItems.RemoveRange(orderItemsToDelete);
            var productToDelete = dbQLY.Products.Find(productId);
            if (productToDelete != null)
            {
                dbQLY.Products.Remove(productToDelete);
                dbQLY.SaveChanges();
            }

        }

        public List<Product> GetALLProductsDetail()
        {
            var productsWithOrders = (from product in dbQLY.Products
                                      join order in dbQLY.Orders on product.Id equals order.Id
                                      select new Product
                                      {
                                          Id = product.Id,
                                          ProductName = product.ProductName,
                                          Package = product.Package,
                                          SupplierId = product.SupplierId,
                                          OrderItems = product.OrderItems,
                                          IsDiscontinued = product.IsDiscontinued
                                      }).ToList();

            return productsWithOrders;
        }

    }
}
