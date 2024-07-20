using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class NhanvienRepositories
    {
        SOF205_finalContext dbcontex;
        public NhanvienRepositories()
        {
            dbcontex = new SOF205_finalContext();
        }
        public List<HocSinh> GetALLHS()
        {
            return dbcontex.HocSinhs.ToList();
        }
        public List<HocSinh> GetHocSinhs(string ten)
        {
            return dbcontex.HocSinhs.Where(p => p.Ten == ten).ToList();
        }
        public bool AddHS(HocSinh hs)
        {
            try
            {
                dbcontex.HocSinhs.Add(hs);
                dbcontex.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool UpdateHS(HocSinh hs)
        {
            try
            {
                var updateItems = dbcontex.HocSinhs.Find(hs.Ma);
                updateItems.Ten = hs.Ten;
                updateItems.Nganh = hs.Nganh;
                updateItems.Tuoi = hs.Tuoi;
                dbcontex.HocSinhs.Update(updateItems);
                dbcontex.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool DeleteHS(string ma)
        {
            try
            {
                var deleteItems = dbcontex.HocSinhs.Find(ma);
                dbcontex.HocSinhs.Remove(deleteItems);
                dbcontex.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
