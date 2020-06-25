using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NHD.EntityFramework.Entities
{
    public class NhaXuatBan
    {
        public int NhaXuatBanId { get; set; }
        public string TenNhaXuatBan { get; set; }
        public List<Sach> ListSach { get; set; }
    }
}
