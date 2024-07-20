using DAL;
using DTO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLLProduct
    {
        ProductDAL productDAL = new ProductDAL();
        public List<Product> GetALLProducts()
        {
            var products = productDAL.GetALLProducts();
            return products;
        }

        public List<Product> AddProducts(Product product)
        {
            var products = productDAL.AddProducts(product);
            products.Add(product);
            return products;
        }
        public Product TimID(int ID)
        {
            return productDAL.TimID(ID);
        }
        public void DeleteProduct(int productId)
        {
            productDAL.DeleteProduct(productId);
        }
        public List<Product> GetALLProductsDetail()
        {
            var products = productDAL.GetALLProductsDetail();
            return products;
        }

    }
}
