using DAL.Models;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ProductBLL
    {
        public ProductDTO productDTO=new ProductDTO();  
        public List<Product> GetAllProduct1()
        {
            return productDTO.GetAllProduct();
        }
    }
}
