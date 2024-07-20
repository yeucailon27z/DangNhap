using DAL.Models;
using DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Services
{
    public class CuaHangServices
    {
        CuaHangRepositories service;
        public CuaHangServices()
        {
            service = new CuaHangRepositories();
        }
        public List<CuaHang> CNShow()
        {
            return service.GetDSCH();
        }
        public List<CuaHang> GetCH(string loai)
        {
            return service.GetCH(loai);
        }
        public string CNThem(string ma, string mota, string loai, string ngay)
        {
            CuaHang ch = new CuaHang()
            {
                Ma = ma,
                Mota = mota,
                LoaiHang = loai,
                NgayDangKy = ngay
            };
            if (service.AddCH(ch))
            {
                return "Thêm thành công";
            }
            else return "Thêm thất bại";
        }
        public string CNSua(string ma, string mota, string loai, string ngay)
        {
            CuaHang ch = new CuaHang()
            {
                Ma = ma,
                Mota = mota,
                LoaiHang = loai,
                NgayDangKy = ngay
            };
            if (service.UpdateCH(ch))
            {
                return "Sửa thành công";
            }
            else return "Sửa thất bại";
        }

        public string CNXoa(string ma)
        {
            if (service.DeleteCH(ma))
            {
                return "Xoa thành công";
            }
            else return "Xoa thất bại";
        }
    }
}
