using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class Dongvat
    {
        public string Ma { get; set; } = null!;
        public string? Mota { get; set; }
        public string? ThucAn { get; set; }
        public int? Sochan { get; set; }
    }
}
