using DTO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ProductDTO
    {
        QLthucungContext qLthucungContext = new QLthucungContext();
        public List<Dsthucung> GetAllDSThuCung()
        {
            var dsThuCung = qLthucungContext.Dsthucungs.ToList();
            return dsThuCung;
        }
        public List<Dsthucung> AddThuCung(Dsthucung dsthucung )
        {
            var dsthucungs = qLthucungContext.Dsthucungs.ToList();
            qLthucungContext.Dsthucungs.Add(dsthucung);
            qLthucungContext.SaveChanges();
            return dsthucungs;

        }
        public void UpdateThuCung(Dsthucung dsthucung)
        {
            var existingThuCung = qLthucungContext.Dsthucungs.Find(dsthucung.Stt);
            if (existingThuCung != null)
            {
                existingThuCung.Ten = dsthucung.Ten;
                existingThuCung.Loai = dsthucung.Loai;
                existingThuCung.Maulong = dsthucung.Maulong;
                existingThuCung.Tuoi = dsthucung.Tuoi;
                qLthucungContext.SaveChanges();
            }
        }
        public Dsthucung TimSTT(int STT)
        {
            return qLthucungContext.Dsthucungs.Find(STT);
        }
        public void DeleteThuCung(int STT)
        {
            var thucungToDelete = qLthucungContext.Dsthucungs.Find(STT);
            if (thucungToDelete != null)
            {
                qLthucungContext.Dsthucungs.Remove(thucungToDelete);
                qLthucungContext.SaveChanges();
            }

        }
    }
}
