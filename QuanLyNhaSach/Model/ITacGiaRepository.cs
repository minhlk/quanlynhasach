using QuanLyNhaSach.Model.AppData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaSach.Model
{
    public interface ITacGiaRepository
    {
        IEnumerable<TACGIA> getListTacGia();
        TACGIA getTacGia(int MaTacGia);
        TACGIA saveTacGia(TACGIA tg);
        TACGIA editTacGia(TACGIA tg, int oldMaTacGia);
        TACGIA deleteTacGia(int MaTacGia);
        void deleteSach(int MaTacGia);

    }
}
