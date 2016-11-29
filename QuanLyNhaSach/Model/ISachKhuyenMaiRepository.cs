using QuanLyNhaSach.Model.AppData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaSach.Model
{
    public interface ISachKhuyenMaiRepository
    {
        IEnumerable<SACHKHUYENMAI> getListSachKhuyenMai();
        SACHKHUYENMAI getSachKhuyenMai(string Masach);
        SACHKHUYENMAI saveSachKhuyenMai(SACHKHUYENMAI sachkhuyenmai);
        SACHKHUYENMAI editSachKhuyenMai(SACHKHUYENMAI sachkhuyenmai, string oldMasach);
        SACHKHUYENMAI deleteSachKhuyenMai(string MaSachKhuyenMai);
        IEnumerable<string> getListMaSach();
    }
}
