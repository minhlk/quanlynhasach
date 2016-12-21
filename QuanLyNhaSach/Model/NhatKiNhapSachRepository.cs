using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyNhaSach.Model.AppData;
using System.Data.Entity.Infrastructure;

namespace QuanLyNhaSach.Model
{
    public class NhatKiNhapSachRepository : INhatKiNhapSachRepository
    {
        NhaSachEntities entity = new NhaSachEntities();
        public NHATKINHAPSACH deleteNhatKiNhapSach(int MaNhatKiNhapSach)
        {
            NHATKINHAPSACH nhatkinhapsach = (from c in entity.NHATKINHAPSACHes where c.STT == MaNhatKiNhapSach select c).FirstOrDefault();

            //entity.SaveChanges();
            KHO kho = (from c in entity.KHOes
                       where c.MASACH == nhatkinhapsach.MASACH
                       select c).FirstOrDefault();
            kho.TONGSOLUONG = kho.TONGSOLUONG - nhatkinhapsach.SOLUONG;
            if (kho.SOLUONGCON > kho.TONGSOLUONG)
                kho.SOLUONGCON = kho.TONGSOLUONG;
            entity.NHATKINHAPSACHes.Remove(nhatkinhapsach);
            entity.SaveChanges();



            return nhatkinhapsach;
        }

        public NHATKINHAPSACH editNhatKiNhapSach(NHATKINHAPSACH nkns, int oldMaNhatKiNhapSach)
        {
            NHATKINHAPSACH nhatkinhapsach_re = (from c in entity.NHATKINHAPSACHes where c.STT == oldMaNhatKiNhapSach select c).FirstOrDefault();
            int change;
            if (nhatkinhapsach_re.SOLUONG > nkns.SOLUONG)
            {
                change = (int) (nhatkinhapsach_re.SOLUONG - nkns.SOLUONG);
                KHO kho = (from c in entity.KHOes
                           where c.MASACH == nhatkinhapsach_re.MASACH
                           select c).FirstOrDefault();
                kho.TONGSOLUONG = kho.TONGSOLUONG - change;
               
            }
            else
            {
                change = (int) (nkns.SOLUONG - nhatkinhapsach_re.SOLUONG);
                KHO kho = (from c in entity.KHOes
                           where c.MASACH == nhatkinhapsach_re.MASACH
                           select c).FirstOrDefault();
                kho.TONGSOLUONG = kho.TONGSOLUONG + change;
            }


            nhatkinhapsach_re.MASACH = nkns.MASACH;
            //saveNhatKiNhapSach(nkns);
            //deleteNhatKiNhapSach(nhatkinhapsach_re.STT);
            nhatkinhapsach_re.NGAYNHAP = nkns.NGAYNHAP;
            nhatkinhapsach_re.SOLUONG= nkns.SOLUONG;

            entity.SaveChanges();

            return nhatkinhapsach_re; //nhatkinhapsach cu
        }

        public IEnumerable<NHATKINHAPSACH> getListNhatKiNhapSach()
        {
            return entity.NHATKINHAPSACHes.ToList();
        }

        public NHATKINHAPSACH getNhatKiNhapSach(int MaNhatKiNhapSach)
        {
            return (from c in entity.NHATKINHAPSACHes where c.STT == MaNhatKiNhapSach select c).FirstOrDefault();
        }
        public IEnumerable<object> getListMaSach()
        {
            return (from d in entity.SACHes join  c in entity.KHOes 
                    on d.MASACH equals c.MASACH
                    select d).ToList().Select(c => new { c.MASACH, c.TENSACH }).ToList();
        }
        public NHATKINHAPSACH saveNhatKiNhapSach(NHATKINHAPSACH nkns)
        {
            try
            {
                
                    entity.NHATKINHAPSACHes.Add(nkns); entity.SaveChanges();
                    KHO kho= (from c in entity.KHOes
                    where c.MASACH == nkns.MASACH
                    select c).FirstOrDefault();
                    kho.TONGSOLUONG = kho.TONGSOLUONG + nkns.SOLUONG;
                    entity.SaveChanges();
                    return nkns;
                
               
            }
            catch (DbUpdateException) // tranh loi update
            {
                return null;
            }
        }
        public NHATKINHAPSACH checkRepeat(NHATKINHAPSACH nkns)
        {
            NHATKINHAPSACH repeat_item = (from c in entity.NHATKINHAPSACHes
                                          where nkns.MASACH == c.MASACH
                                                && nkns.NGAYNHAP == c.NGAYNHAP
                                                && nkns.STT!=c.STT
                                          select c).FirstOrDefault();
            if(repeat_item==null)
            return null;
            else return repeat_item;
        }
    }
}
