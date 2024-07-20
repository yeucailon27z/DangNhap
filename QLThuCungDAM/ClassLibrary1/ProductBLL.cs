using DAL;
using DTO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ProductBLL
    {
        ProductDTO productDTO = new ProductDTO();
        public List<Dsthucung> GetAllDSThuCung()
        {
            var dsThuCung = productDTO.GetAllDSThuCung();
            return dsThuCung;
        }
        public void UpdateThuCung(Dsthucung dsthucung)
        {
            productDTO.UpdateThuCung(dsthucung);
        }
        public Dsthucung TimSTT(int STT)
        {
            return productDTO.TimSTT(STT);
        }
        public List<Dsthucung> AddThuCung(Dsthucung dsthucung)
        {
            var dsthucungs = productDTO.AddThuCung(dsthucung);
            dsthucungs.Add(dsthucung);
            return dsthucungs;

        }
        public void DeleteThuCung(int STT)
        {
            productDTO.DeleteThuCung(STT);

        }
    }
}
