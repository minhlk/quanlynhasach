using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyNhaSach.Model.AppData;
using System.Data.Entity.Infrastructure;

namespace QuanLyNhaSach.Model
{
    public class ChiTietHoaDonRepository : IChiTietHoaDonRepository
    {
        NhaSachEntities entity = new NhaSachEntities();
        public CHITIETHOADON deleteHoaDon(int MaHoaDon)
        {
            CHITIETHOADON hoadon = (from c in entity.CHITIETHOADONs where c.MAHOADON == MaHoaDon select c).FirstOrDefault();
            entity.CHITIETHOADONs.Remove(hoadon);
            entity.SaveChanges();
            return hoadon;
        }

        public CHITIETHOADON editHoaDon(CHITIETHOADON hd, int oldMaHoaDon)
        {
            CHITIETHOADON hoadon = (from c in entity.CHITIETHOADONs where c.MAHOADON == oldMaHoaDon select c).FirstOrDefault();
            hoadon.MAHOADON = hd.MAHOADON;
            hoadon.MASACH = hd.MASACH;
            hoadon.MUCGIAMGIA = hd.MUCGIAMGIA;
            hoadon.SOLUONG = hd.SOLUONG;
            entity.SaveChanges();

            return hoadon; //hoa don cu
        }

        public CHITIETHOADON getHoaDon(int MaHoaDon)
        {
            return (from c in entity.CHITIETHOADONs where c.MAHOADON == MaHoaDon select c).FirstOrDefault();
        }

        public IEnumerable<CHITIETHOADON> getListHoaDon()
        {
            return entity.CHITIETHOADONs.ToList();
        }

        public IEnumerable<object> getListMaHoaDon()
        {
            return (from c in entity.HOADONs
                    where !(from d in entity.CHITIETHOADONs select d.MAHOADON).Contains(c.MAHOADON)
                    select c
                    ).ToList().Select(c=>new { c.MAHOADON,c.TENKHACHHANG,c.NGAYLAP}).ToList();
        }

        public IEnumerable<object> getListSach()
        {
            return entity.SACHes.Select(c => new { c.MASACH, c.TENSACH }).ToList();
            //return (from c in entity.SACHes select c).ToList();
        }

        public CHITIETHOADON saveHoaDon(CHITIETHOADON hd)
        {
            try
            {
                entity.CHITIETHOADONs.Add(hd);
                entity.SaveChanges();
                return hd;
            }
            catch (DbUpdateException) // tranh loi update
            {
                return null;
            }
        }
    }
}
