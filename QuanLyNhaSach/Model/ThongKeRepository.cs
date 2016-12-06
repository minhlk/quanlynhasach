using QuanLyNhaSach.Model.AppData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaSach.Model
{
    public class ThongKeRepository : IThongKeRepository
    {
        NhaSachEntities entity = new NhaSachEntities();

        public IEnumerable<object> getListHoaDon()
        {
            throw new NotImplementedException();

        }

        public IEnumerable<object> getListHoaDon(int MaHoaDon)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<object> getListHoaDon(string MaSach)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<object> getListHoaDon(DateTime start, DateTime end)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<object> getListSach()
        {
            return (from c in entity.SACHes
                    join d in entity.KHOes
                    on c.MASACH equals d.MASACH
                    join e in entity.NHATKINHAPSACHes
                    on d.MASACH equals e.MASACH
                    select new { c.MASACH, c.TENSACH, c.GIAMUA, d.TONGSOLUONG, d.SOLUONGCON, e.NGAYNHAP, e.SOLUONG }
                  ).ToList();
            
        }

        public IEnumerable<object> getListSach(string MaSach)
        {
            return (from c in entity.SACHes
                    join d in entity.KHOes
                    on c.MASACH equals d.MASACH
                    join e in entity.NHATKINHAPSACHes
                    on d.MASACH equals e.MASACH
                    where c.MASACH.Contains(MaSach)
                    select new { c.MASACH, c.TENSACH, c.GIAMUA, d.TONGSOLUONG, d.SOLUONGCON, e.NGAYNHAP, e.SOLUONG }
                  ).ToList();
        }

        public IEnumerable<object> getListSach(DateTime start, DateTime end)
        {
            return (from c in entity.SACHes
                    join d in entity.KHOes
                    on c.MASACH equals d.MASACH
                    join e in entity.NHATKINHAPSACHes
                    on d.MASACH equals e.MASACH
                    where e.NGAYNHAP >= start && e.NGAYNHAP<=end
                    select new { c.MASACH, c.TENSACH, c.GIAMUA, d.TONGSOLUONG, d.SOLUONGCON, e.NGAYNHAP, e.SOLUONG }
                  ).ToList();
        }

        public IEnumerable<object> getListSachName(string TenSach)
        {
            return (from c in entity.SACHes
                    join d in entity.KHOes
                    on c.MASACH equals d.MASACH
                    join e in entity.NHATKINHAPSACHes
                    on d.MASACH equals e.MASACH
                    where c.TENSACH.Contains(TenSach)
                    select new { c.MASACH, c.TENSACH, c.GIAMUA, d.TONGSOLUONG, d.SOLUONGCON, e.NGAYNHAP, e.SOLUONG }
                   ).ToList();
        }
    }
}
