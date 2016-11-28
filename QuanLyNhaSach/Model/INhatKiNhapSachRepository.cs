using QuanLyNhaSach.Model.AppData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaSach.Model
{
    public interface INhatKiNhapSachRepository
    {
        IEnumerable<NHATKINHAPSACH> getListNhatKiNhapSach();
        NHATKINHAPSACH getNhatKiNhapSach(int MaNhatKiNhapSach);
        NHATKINHAPSACH saveNhatKiNhapSach(NHATKINHAPSACH nkns);
        IEnumerable<string> getListMaSach();
        NHATKINHAPSACH editNhatKiNhapSach(NHATKINHAPSACH nkns, int oldMaNhatKiNhapSach);
        NHATKINHAPSACH deleteNhatKiNhapSach(int MaNhatKiNhapSach);
        NHATKINHAPSACH checkRepeat(NHATKINHAPSACH nkns);
    }
}
