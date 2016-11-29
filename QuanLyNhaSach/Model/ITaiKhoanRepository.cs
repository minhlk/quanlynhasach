using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaSach.Model.AppData
{
    public interface ITaiKhoanRepository
    {
        IEnumerable<TAIKHOAN> getListTaiKhoan();
        TAIKHOAN getTaiKhoan(string MaTaiKhoan);
        TAIKHOAN saveTaiKhoan(TAIKHOAN tk);
        TAIKHOAN editTaiKhoan(TAIKHOAN tk, string oldMaTaiKhoan);
        TAIKHOAN deleteTaiKhoan(string MaTaiKhoan);
    }
}
