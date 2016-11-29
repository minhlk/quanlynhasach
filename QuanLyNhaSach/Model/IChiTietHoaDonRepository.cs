using QuanLyNhaSach.Model.AppData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaSach.Model
{
    public interface IChiTietHoaDonRepository
    {
        IEnumerable<CHITIETHOADON> getListHoaDon();
        IEnumerable<int> getListMaHoaDon();
        IEnumerable<string> getListSach();
        CHITIETHOADON getHoaDon(int MaHoaDon);
        CHITIETHOADON saveHoaDon(CHITIETHOADON hd);
        CHITIETHOADON editHoaDon(CHITIETHOADON hd, int oldMaHoaDon);
        CHITIETHOADON deleteHoaDon(int MaHoaDon);
    }
}
