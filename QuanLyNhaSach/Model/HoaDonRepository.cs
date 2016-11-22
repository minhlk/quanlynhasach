using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyNhaSach.Model.AppData;
using System.Data.Entity.Infrastructure;

namespace QuanLyNhaSach.Model
{
    class HoaDonRepository : IHoaDonRepository
    {
        NhaSachEntities entity = new NhaSachEntities();
        public HOADON deleteHoaDon(int MaHoaDon)
        {
            HOADON hoadon = (from c in entity.HOADONs where c.MAHOADON == MaHoaDon select c).FirstOrDefault();
            entity.HOADONs.Remove(hoadon);
            entity.SaveChanges();
            return hoadon;
        }

        public HOADON editHoaDon(HOADON hd, int oldMaHoaDon)
        {
            HOADON hoadon = (from c in entity.HOADONs where c.MAHOADON == oldMaHoaDon select c).FirstOrDefault();
            hoadon.TENKHACHHANG = hd.TENKHACHHANG;
            hoadon.NGAYLAP = hd.NGAYLAP;
            hoadon.TONGTIEN = hd.TONGTIEN;
          
            entity.SaveChanges();

            return hoadon; //hoa don cu
        }

        public HOADON getHoaDon(int MaHoaDon)
        {
            return (from c in entity.HOADONs where c.MAHOADON == MaHoaDon select c).FirstOrDefault();
        }

        public IEnumerable<HOADON> getListHoaDon()
        {
            return entity.HOADONs.ToList();
        }

        public HOADON saveHoaDon(HOADON hd)
        {
            try
            {
                entity.HOADONs.Add(hd);
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
