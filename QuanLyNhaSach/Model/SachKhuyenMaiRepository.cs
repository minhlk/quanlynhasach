using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyNhaSach.Model.AppData;
using System.Data.Entity.Infrastructure;

namespace QuanLyNhaSach.Model
{
    public class SachKhuyenMaiRepository : ISachKhuyenMaiRepository
    {
        NhaSachEntities entity = new NhaSachEntities();
        public SACHKHUYENMAI deleteSachKhuyenMai(string MaSachKhuyenMai)
        {
            SACHKHUYENMAI skm = (from c in entity.SACHKHUYENMAIs where c.MASACH == MaSachKhuyenMai select c).FirstOrDefault();
            entity.SACHKHUYENMAIs.Remove(skm);
            entity.SaveChanges();
            return skm;
        }

        public SACHKHUYENMAI editSachKhuyenMai(SACHKHUYENMAI sachkhuyenmai, string oldMasach)
        {
            SACHKHUYENMAI skm = (from c in entity.SACHKHUYENMAIs where c.MASACH == oldMasach select c).FirstOrDefault();
            //kho_re.MASACH = kho.MASACH;
            saveSachKhuyenMai(sachkhuyenmai);
            deleteSachKhuyenMai(skm.MASACH);
            //kho_re.SOLUONGCON = kho.SOLUONGCON;
            //kho_re.TONGSOLUONG = kho.TONGSOLUONG;

            entity.SaveChanges();

            return skm; //kho cu
        }

        public IEnumerable<string> getListMaSach()
        {
            return (from c in entity.SACHes
                    where !(from d in entity.SACHKHUYENMAIs select d.MASACH).Contains(c.MASACH)
                    select c.MASACH).ToList();
        }

        public IEnumerable<SACHKHUYENMAI> getListSachKhuyenMai()
        {
            return (from c in entity.SACHKHUYENMAIs select c).ToList();
        }

        public SACHKHUYENMAI getSachKhuyenMai(string Masach)
        {
            return (from c in entity.SACHKHUYENMAIs where c.MASACH == Masach select c).FirstOrDefault();
        }

        public SACHKHUYENMAI saveSachKhuyenMai(SACHKHUYENMAI sachkhuyenmai)
        {
            try
            {
                entity.SACHKHUYENMAIs.Add(sachkhuyenmai);
                entity.SaveChanges();
                return sachkhuyenmai;
            }
            catch (DbUpdateException) // tranh loi update
            {
                return null;
            }
        }
    }
}
