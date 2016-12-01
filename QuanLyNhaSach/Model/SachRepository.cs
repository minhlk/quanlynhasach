using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyNhaSach.Model.AppData;
using System.Data.Entity.Infrastructure;

namespace QuanLyNhaSach.Model
{
    public class SachRepository : ISachRepository
    {
        NhaSachEntities entity = new NhaSachEntities();
        public SACH deleteSach(string MaSach)
        {
            SACH sach = (from c in entity.SACHes where c.MASACH == MaSach select c).FirstOrDefault();
            entity.SACHes.Remove(sach);
            entity.SaveChanges();
            return sach;
        }

        public SACH editSach(SACH sach, string oldMaSach)
        {

            SACH sach_re = (from c in entity.SACHes where c.MASACH == oldMaSach select c).FirstOrDefault();
            sach_re.MALINHVUC = sach.MALINHVUC;
            sach_re.MATG = sach.MATG;
            sach_re.MALOAISACH = sach.MALOAISACH;
            sach_re.TENSACH = sach.TENSACH;
            sach_re.GIAMUA = sach.GIAMUA;
            entity.SaveChanges();

            return sach_re; //sach cu
        }

        public IEnumerable<string> getListLinhVuc()
        {
            return (from c in entity.LINHVUCs select c.MALINHVUC).ToList();
        }

        public IEnumerable<string> getListLoaiSach()
        {
            return (from c in entity.LOAISACHes select c.MALOAISACH).ToList();
        }

        public IEnumerable<SACH> getListSach()
        {
            return (from c in entity.SACHes select c).ToList();
        }

        public IEnumerable<int> getListTacGia()
        {
            return (from c in entity.TACGIAs select c.MATG).ToList();
        }
        
        public SACH getSach(string MaSach)
        {
            return (from c in entity.SACHes where MaSach==c.MASACH select c).SingleOrDefault();
        }

        public SACH saveSach(SACH sach)
        {
            try
            {
                entity.SACHes.Add(sach);
                entity.SaveChanges();
                return sach;
            }
            catch (DbUpdateException) // tranh loi update
            {
                return null;
            }
        }
    }
}
