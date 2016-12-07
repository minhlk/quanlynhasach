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
            return (from a in entity.HOADONs
                    join b in entity.CHITIETHOADONs
                    on a.MAHOADON equals b.MAHOADON
                    join c in entity.SACHes
                    on b.MASACH equals c.MASACH
                    select new {a.MAHOADON,a.TENKHACHHANG,a.NGAYLAP,a.TONGTIEN,
                                b.MASACH,c.TENSACH,b.SOLUONG,c.GIAMUA,b.MUCGIAMGIA
                    }
                    ).ToList();

        }

        public IEnumerable<object> getListHoaDon(int MaHoaDon)
        {
            return (from a in entity.HOADONs
                    join b in entity.CHITIETHOADONs
                    on a.MAHOADON equals b.MAHOADON
                    join c in entity.SACHes
                    on b.MASACH equals c.MASACH
                    where a.MAHOADON.ToString().Contains(MaHoaDon.ToString())
                    select new
                    {
                        a.MAHOADON,
                        a.TENKHACHHANG,
                        a.NGAYLAP,
                        a.TONGTIEN,
                        b.MASACH,
                        c.TENSACH,
                        b.SOLUONG,
                        c.GIAMUA,
                        b.MUCGIAMGIA
                    }
                    ).ToList();
        }

        public IEnumerable<object> getListHoaDon(string MaSach)
        {
            return (from a in entity.HOADONs
                    join b in entity.CHITIETHOADONs
                    on a.MAHOADON equals b.MAHOADON
                    join c in entity.SACHes
                    on b.MASACH equals c.MASACH
                    where c.MASACH.Contains(MaSach)
                    select new
                    {
                        a.MAHOADON,
                        a.TENKHACHHANG,
                        a.NGAYLAP,
                        a.TONGTIEN,
                        b.MASACH,
                        c.TENSACH,
                        b.SOLUONG,
                        c.GIAMUA,
                        b.MUCGIAMGIA
                    }
                      ).ToList();
        }

        public IEnumerable<object> getListHoaDon(DateTime start, DateTime end)
        {
            return (from a in entity.HOADONs
                    join b in entity.CHITIETHOADONs
                    on a.MAHOADON equals b.MAHOADON
                    join c in entity.SACHes
                    on b.MASACH equals c.MASACH
                    where a.NGAYLAP>=start && a.NGAYLAP<=end
                    select new
                    {
                        a.MAHOADON,
                        a.TENKHACHHANG,
                        a.NGAYLAP,
                        a.TONGTIEN,
                        b.MASACH,
                        c.TENSACH,
                        b.SOLUONG,
                        c.GIAMUA,
                        b.MUCGIAMGIA
                    }
                        ).ToList();
        }

        public IEnumerable<object> getListSach()
        {
            return (from c in entity.SACHes
                    join d in entity.KHOes
                    on c.MASACH equals d.MASACH
                    join e in entity.NHATKINHAPSACHes
                    on d.MASACH equals e.MASACH
                    join f in entity.THONGTINXUATBANs
                    on c.MASACH equals f.MASACH
                    select new { c.MASACH, c.TENSACH, c.GIAMUA, d.TONGSOLUONG, d.SOLUONGCON, e.NGAYNHAP, e.SOLUONG ,f.GIABIA}
                  ).ToList();
            
        }

        public IEnumerable<object> getListSach(string MaSach)
        {
            return (from c in entity.SACHes
                    join d in entity.KHOes
                    on c.MASACH equals d.MASACH
                    join e in entity.NHATKINHAPSACHes
                    on d.MASACH equals e.MASACH
                    join f in entity.THONGTINXUATBANs
                   on c.MASACH equals f.MASACH
                    where c.MASACH.Contains(MaSach)
                    select new { c.MASACH, c.TENSACH, c.GIAMUA, d.TONGSOLUONG, d.SOLUONGCON, e.NGAYNHAP, e.SOLUONG, f.GIABIA }
                  ).ToList();
        }

        public IEnumerable<object> getListSach(DateTime start, DateTime end)
        {
            return (from c in entity.SACHes
                    join d in entity.KHOes
                    on c.MASACH equals d.MASACH
                    join e in entity.NHATKINHAPSACHes
                    on d.MASACH equals e.MASACH
                    join f in entity.THONGTINXUATBANs
                   on c.MASACH equals f.MASACH
                    where e.NGAYNHAP >= start && e.NGAYNHAP<=end
                    select new { c.MASACH, c.TENSACH, c.GIAMUA, d.TONGSOLUONG, d.SOLUONGCON, e.NGAYNHAP, e.SOLUONG, f.GIABIA }
                  ).ToList();
        }

        public IEnumerable<object> getListSachName(string TenSach)
        {
            return (from c in entity.SACHes
                    join d in entity.KHOes
                    on c.MASACH equals d.MASACH
                    join e in entity.NHATKINHAPSACHes
                    on d.MASACH equals e.MASACH
                    join f in entity.THONGTINXUATBANs
                   on c.MASACH equals f.MASACH
                    where c.TENSACH.Contains(TenSach)
                    select new { c.MASACH, c.TENSACH, c.GIAMUA, d.TONGSOLUONG, d.SOLUONGCON, e.NGAYNHAP, e.SOLUONG, f.GIABIA }
                   ).ToList();
        }
        public int getTongChi() {


            var a= (from c in entity.SACHes
                    join d in entity.KHOes
                    on c.MASACH equals d.MASACH
                    select new { c.GIAMUA, d.TONGSOLUONG }
             ).ToList().Sum(c => c.GIAMUA * c.TONGSOLUONG).ToString();
            int i;
            return int.TryParse(a,out i) ? Convert.ToInt32(a):0;


         

        }
        public int getTongThu() {
            var a=((from c in entity.SACHes
                                    join d in entity.CHITIETHOADONs
                                    on c.MASACH equals d.MASACH
                                    join e in entity.THONGTINXUATBANs
                                    on c.MASACH equals e.MASACH
                                    select new { d.SOLUONG, d.MUCGIAMGIA,e.GIABIA}
            ).ToList().Sum(c =>c.SOLUONG*c.GIABIA- c.SOLUONG*c.MUCGIAMGIA*c.GIABIA/100).ToString());
            ;
            int i;
            return int.TryParse(a, out i) ? Convert.ToInt32(a) : 0;

        }
    }
}
