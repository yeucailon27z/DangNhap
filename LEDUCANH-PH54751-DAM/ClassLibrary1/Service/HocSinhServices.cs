using DAL.Models;
using DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Service
{
    public class HocSinhServices
    {
        NhanvienRepositories repos;
        public HocSinhServices()
        {
            repos = new NhanvienRepositories();
        }
        public List<HocSinh> GetALLHS()
        {
            return repos.GetALLHS();
        }
        public List<HocSinh> GetHS(string ten)
        {
            return repos.GetHocSinhs(ten);
        }
        public string AddHS(string ma, string ten, string nganh, int tuoi)
        {
            HocSinh hs = new HocSinh()
            {
                Ma = ma,
                Ten = ten,
                Nganh = nganh,
                Tuoi = tuoi
            };
            if (repos.AddHS(hs))
            {
                return "Them thanh cong";
            }
            else return "Them that bai";
        }
        public string UpdateHS(string ma, string ten, string nganh, int tuoi)
        {
            HocSinh hs = new HocSinh()
            {
                Ma = ma,
                Ten = ten,
                Nganh = nganh,
                Tuoi = tuoi
            };
            if (repos.UpdateHS(hs))
            {
                return "Sua thanh cong";
            }
            else return "Sua that bai";
        }
        public string DeleteHS(string ma)
        {
        
            if (repos.DeleteHS(ma))
            {
                return "Xoa thanh cong";
            }
            else return "Xoa that bai";
        }
        public bool CheckTuoi(int tuoi)
        {
            if (tuoi < 18)
            {
                return false;
            }
            else return true;
        }
    }
}
