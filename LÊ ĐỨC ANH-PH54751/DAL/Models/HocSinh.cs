using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class HocSinh
    {
        public string Ma { get; set; } = null!;
        public string? Ten { get; set; }
        public string? Nganh { get; set; }
        public int? Tuoi { get; set; }
    }
}
