using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NHD.EntityFramework.Entities
{
    public class LoaiSach
    {
        public int LoaiSachId { get; set; }
        public string TenLoai { get; set; }
        public string MoTa { get; set; }

        public virtual List<Sach_LoaiSach> ListSach_LoaiSach { get; set; }
    }
}
