using NHD.EntityFramework.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NHD.Service.Interfaces
{
    public interface ISachService : IBaseService<Sach>
    {
        Sach AddSach(Sach sach);
        Sach UpdateSach(Sach sach);
        bool DeleteSach(int sachId);
    }
}
