using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaSach.Model
{
    public interface IThongKeRepository
    {
        IEnumerable<object> getListHoaDon();
       IEnumerable<object> getListHoaDon(string MaSach);
        IEnumerable<object> getListHoaDon(int MaHoaDon);
        IEnumerable<object> getListHoaDon(DateTime start,DateTime end);
        IEnumerable<object> getListSach();
        IEnumerable<object> getListSach(string MaSach);
        IEnumerable<object> getListSachName(string TenSach);
        IEnumerable<object> getListSach(DateTime start, DateTime end);
    }
}
