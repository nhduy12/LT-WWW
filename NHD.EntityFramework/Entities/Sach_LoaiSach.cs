using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NHD.EntityFramework.Entities
{
    public class Sach_LoaiSach
    {
        public int Id { get; set; }
        public int SachId { get; set; }
        public int LoaiSachId { get; set; }

        public virtual Sach Sach { get; set; }
        public virtual LoaiSach LoaiSach { get; set; }
    }
}
