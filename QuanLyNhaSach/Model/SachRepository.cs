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
        NhaSachEntities entity= new NhaSachEntities();
     
        public SACH deleteSach(string MaSach)
        {
            try
               {
             SACH sach = (from c in entity.SACHes where c.MASACH == MaSach select c).FirstOrDefault();
            entity.SACHes.Remove(sach);
            entity.SaveChanges();
            return sach;
            }
            catch (Exception)
            {
                return null;
            }
           
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

        public IEnumerable<object> getListLinhVuc()
        {
            return entity.LINHVUCs.Select(c => new { c.MALINHVUC, c.TENLINHVUC }).ToList();
        }

        public IEnumerable<object> getListLoaiSach()
        {
            return entity.LOAISACHes.Select(c => new { c.MALOAISACH, c.TENLOAISACH }).ToList();
        }

        public IEnumerable<object> getListSach()
        {

            return entity.SACHes.Select(c => new { c.MASACH, c.TENSACH, c.MATG, c.MALOAISACH, c.MALINHVUC,c.GIAMUA }).ToList();
        }

        public IEnumerable<object> getListTacGia()
        {


            return entity.TACGIAs.Select(c =>new { c.MATG,c.TENTG }).ToList();
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
            catch (Exception ) // tranh loi update
            {
                return null;
            }
        }
    }
}
