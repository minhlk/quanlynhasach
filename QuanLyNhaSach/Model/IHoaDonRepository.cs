using QuanLyNhaSach.Model.AppData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaSach.Model
{
    public interface IHoaDonRepository { 


         IEnumerable<HOADON> getListHoaDon();
    HOADON getHoaDon(int MaHoaDon);
    HOADON saveHoaDon(HOADON hd);
    HOADON editHoaDon(HOADON hd, int oldMaHoaDon);
    HOADON deleteHoaDon(int MaHoaDon);


        }
}
