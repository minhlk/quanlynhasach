using QuanLyNhaSach.Model.AppData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaSach.Model
{
    public interface ILoaiSachRepository
    {
        IEnumerable<LOAISACH> getListLoaiSach();
        LOAISACH getLoaiSach(string MaLoaiSach);
        LOAISACH saveLoaiSach(LOAISACH ls);
        LOAISACH editLoaiSach(LOAISACH ls, string oldMaLoaiSach);
        LOAISACH deleteLoaiSach(string MaLoaiSach);
    }
}
