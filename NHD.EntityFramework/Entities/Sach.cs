using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NHD.EntityFramework.Entities
{
    public class Sach
    {
        public int SachId { get; set; }
        public string TenSach { get; set; }
        public string MoTa { get; set; }
        public int NhaXuatBanId { get; set; }
        public virtual NhaXuatBan NhaXuatBan { get; set; }
        public virtual List<Sach_LoaiSach> ListSach_LoaiSach { get; set; }

    }
}
