using QuanLyNhaSach.Model.AppData;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaSach.Model
{
    class KhoRepository : IKhoRepository
    {
        NhaSachEntities entity = new NhaSachEntities();
        public KHO deleteKho(string MaKho)
        {
            KHO kho = (from c in entity.KHOes where c.MASACH == MaKho select c).FirstOrDefault();
            entity.KHOes.Remove(kho);
            entity.SaveChanges();
            return kho;
        }

        public KHO editKho(KHO kho, string oldMasach)
        {
            KHO kho_re = (from c in entity.KHOes where c.MASACH == oldMasach select c).FirstOrDefault();
            //kho_re.MASACH = kho.MASACH;
            saveKho(kho);
            deleteKho(kho_re.MASACH);
            //kho_re.SOLUONGCON = kho.SOLUONGCON;
            //kho_re.TONGSOLUONG = kho.TONGSOLUONG;
           
            entity.SaveChanges();

            return kho_re; //kho cu
        }

        public KHO getKho(string Masach)
        {
            return (from c in entity.KHOes where c.MASACH == Masach select c).FirstOrDefault();
        }

        public IEnumerable<KHO> getListKho()
        {
            return entity.KHOes.ToList();
        }

        public IEnumerable<string> getListMaSach()
        {
            return (from c in entity.SACHes
                    where !(from d in entity.KHOes select d.MASACH).Contains(c.MASACH)
                    select c.MASACH).ToList();
        }

        public KHO saveKho(KHO kho)
        {
            try
            {
                entity.KHOes.Add(kho);
                entity.SaveChanges();
                return kho;
            }
            catch (DbUpdateException) // tranh loi update
            {
                return null;
            }
        }
    }
}
