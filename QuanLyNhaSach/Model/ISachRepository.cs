using QuanLyNhaSach.Model.AppData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaSach.Model
{
    public interface ISachRepository
    {
        IEnumerable<string> getListLoaiSach();
        IEnumerable<int> getListTacGia();
        IEnumerable<string> getListLinhVuc();
        IEnumerable<SACH> getListSach();
        SACH getSach(string MaSach);
        SACH saveSach(SACH sach);
        SACH editSach(SACH sach, string oldMaSach);
        SACH deleteSach(string MaSach);
    }
}
