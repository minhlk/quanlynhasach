using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyNhaSach.Model.AppData;
using System.Data.Entity.Infrastructure;

namespace QuanLyNhaSach.Model
{
    class ThongTinXuatBanRepository : IThongTinXuatBanRepository
    {
        NhaSachEntities entity = new NhaSachEntities();
        public THONGTINXUATBAN deleteThongTinXuatBan(string MaThongTinXuatBan)
        {
            THONGTINXUATBAN ttxb = (from c in entity.THONGTINXUATBANs where c.MASACH == MaThongTinXuatBan select c).FirstOrDefault();
            entity.THONGTINXUATBANs.Remove(ttxb);
            entity.SaveChanges();
            return ttxb;
        }

        public THONGTINXUATBAN editThongTinXuatBan(THONGTINXUATBAN ttxb, string oldMaThongTinXuatBan)
        {
            THONGTINXUATBAN thongtin_re = (from c in entity.THONGTINXUATBANs where c.MASACH == oldMaThongTinXuatBan select c).FirstOrDefault();
            //linhvuc_re.MASACH = linhvuc.MASACH;
            //saveThongTinXuatBan(ttxb);
            //deleteThongTinXuatBan(thongtin_re.MASACH);
            //saveThongTinXuatBan(ttxb);
            //linhvuc_re.SOLUONGCON = linhvuc.SOLUONGCON;
            //linhvuc_re.TONGSOLUONG = linhvuc.TONGSOLUONG;

            thongtin_re.NAMXUATBAN = ttxb.NAMXUATBAN;
            thongtin_re.NHAXUATBAN = ttxb.NHAXUATBAN;
            thongtin_re.GIABIA = ttxb.GIABIA;
            thongtin_re.LANTAIBAN= ttxb.LANTAIBAN;


            entity.SaveChanges();

            return thongtin_re; //linhvuc cu
        }

        public IEnumerable<string> getListMaSach()
        {
            return (from c in entity.SACHes
                    where !(from d in entity.THONGTINXUATBANs select d.MASACH).Contains(c.MASACH)
                    select c.MASACH).ToList();
        }

        public IEnumerable<THONGTINXUATBAN> getListThongTinXuatBan()
        {
            return entity.THONGTINXUATBANs.ToList();
        }

        public THONGTINXUATBAN getThongTinXuatBan(string MaThongTinXuatBan)
        {
            return (from c in entity.THONGTINXUATBANs where MaThongTinXuatBan == c.MASACH select c).FirstOrDefault();
        }

        public THONGTINXUATBAN saveThongTinXuatBan(THONGTINXUATBAN ttxb)
        {
            try
            {
                entity.THONGTINXUATBANs.Add(ttxb);
                entity.SaveChanges();
                return ttxb;
            }
            catch (DbUpdateException) // tranh loi update
            {
                return null;
            }
        }
    }
}
