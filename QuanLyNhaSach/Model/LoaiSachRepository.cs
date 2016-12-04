using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyNhaSach.Model.AppData;
using System.Data.Entity.Infrastructure;

namespace QuanLyNhaSach.Model
{
    class LoaiSachRepository : ILoaiSachRepository
    {
        NhaSachEntities entity = new NhaSachEntities();
        public LOAISACH deleteLoaiSach(string MaLoaiSach)
        {
            LOAISACH loaisach = (from c in entity.LOAISACHes where c.MALOAISACH == MaLoaiSach select c).FirstOrDefault();
            entity.LOAISACHes.Remove(loaisach);
            entity.SaveChanges();
            return loaisach;
        }

        public LOAISACH editLoaiSach(LOAISACH ls, string oldMaLoaiSach)
        {

            LOAISACH loaisach_re = (from c in entity.LOAISACHes where c.MALOAISACH == oldMaLoaiSach select c).FirstOrDefault();
            //loaisach_re.MASACH = loaisach.MASACH;
            saveLoaiSach(ls);
            deleteLoaiSach(loaisach_re.MALOAISACH);
            //loaisach_re.SOLUONGCON = loaisach.SOLUONGCON;
            //loaisach_re.TONGSOLUONG = loaisach.TONGSOLUONG;

            entity.SaveChanges();

            return loaisach_re; //loaisach cu
        }

        public IEnumerable<LOAISACH> getListLoaiSach()
        {
            return entity.LOAISACHes.ToList();
        }

        public LOAISACH getLoaiSach(string MaLoaiSach)
        {
            return (from c in entity.LOAISACHes where c.MALOAISACH == MaLoaiSach select c).FirstOrDefault();
        }

        public LOAISACH saveLoaiSach(LOAISACH ls)
        {
            try
            {
                entity.LOAISACHes.Add(ls);
                entity.SaveChanges();
                return ls;
            }
            catch (DbUpdateException) // tranh loi update
            {
                return null;
            }
        }
        public void deleteSach(string MaLoaiSach)
        {
            entity.SACHes.RemoveRange((entity.SACHes.Where(x => x.MALOAISACH == MaLoaiSach).ToList()));

        }
    }
}
