using NHD.EntityFramework.Entities;
using NHD.Repository;
using NHD.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace NHD.Services
{
    public class SachService : ISachService
    {
        private IQLSachRepository<Sach> sachRepository;
        public SachService()
        {
            sachRepository = new QLSachRepository<Sach>();
        }

        public Sach AddSach(Sach sach)
        {
            return sachRepository.Add(sach);
        }

        public bool DeleteSach(int sachId)
        {
            try
            {
                sachRepository.Delete(sachId);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public IEnumerable<Sach> GetAll()
        {
            return sachRepository.GetByWhere(s => true);
        }

        public Sach GetById(object id)
        {
            return sachRepository.GetByID(id);
            //return sachRepository.GetByCondition(s => s.SachId == (int)id);
        }

        public Sach UpdateSach(Sach sach)
        {
            var existing = sachRepository.GetByID(sach.SachId);
            if (existing != null)
            {
                existing.TenSach = sach.TenSach;
                existing.MoTa = sach.MoTa;
                existing.NhaXuatBanId = sach.NhaXuatBanId;
                sachRepository.Update(existing);
            }
            return null;
        }
    }
}
