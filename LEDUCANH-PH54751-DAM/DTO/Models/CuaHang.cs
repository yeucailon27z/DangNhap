using System;
using System.Collections.Generic;

namespace DTO.Models
{
    public partial class CuaHang
    {
        public string Ma { get; set; } = null!;
        public string? Mota { get; set; }
        public string? LoaiHang { get; set; }
        public int? DoanhThu { get; set; }
    }
}
