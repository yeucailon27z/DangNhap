using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class CuaHangRepositories
    {
        SOF205_finalContext repos;
        public CuaHangRepositories()
        {
            repos = new SOF205_finalContext();
        }
        public List<CuaHang> GetDSCH()
        {
            return repos.CuaHangs.ToList();
        }
        public List<CuaHang> GetCH(string loai)
        {
            return repos.CuaHangs.Where(p => p.LoaiHang == loai).ToList();
        }
        public bool AddCH(CuaHang ch) {
            try
            {
                repos.Add(ch);
                repos.SaveChanges();
                return true;
            }
            catch (Exception)
            {

               return false;
            }
        }
        public bool DeleteCH(string ma)
        {
            try
            {
                var deleteItems = repos.CuaHangs.Find(ma);
                repos.CuaHangs.Remove(deleteItems);
                repos.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
        public bool UpdateCH(CuaHang ch)
        {
            try
            {
                var updateItems = repos.CuaHangs.Find(ch.Ma);
                updateItems.LoaiHang = ch.LoaiHang;
                updateItems.Mota = ch.Mota;
                updateItems.NgayDangKy = ch.NgayDangKy;
                repos.Update(updateItems);
                repos.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
    }
}
