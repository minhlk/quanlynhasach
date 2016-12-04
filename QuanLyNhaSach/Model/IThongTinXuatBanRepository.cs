using QuanLyNhaSach.Model.AppData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaSach.Model
{
    interface IThongTinXuatBanRepository
    {
         

        IEnumerable<THONGTINXUATBAN> getListThongTinXuatBan();
        THONGTINXUATBAN getThongTinXuatBan(string MaThongTinXuatBan);
        THONGTINXUATBAN saveThongTinXuatBan(THONGTINXUATBAN lv);
        THONGTINXUATBAN editThongTinXuatBan(THONGTINXUATBAN lv, string oldMaThongTinXuatBan);
        THONGTINXUATBAN deleteThongTinXuatBan(string MaThongTinXuatBan);
        IEnumerable<object> getListMaSach();
    }
}
