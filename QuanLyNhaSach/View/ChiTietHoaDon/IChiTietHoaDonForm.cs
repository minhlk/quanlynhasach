using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaSach.View.ChiTietHoaDon
{
    public interface IChiTietHoaDonForm
    {
        int MAHOADON { get; set; }
        string MASACH { get; set; }
        Nullable<int> SOLUONG { get; set; }
        Nullable<int> MUCGIAMGIA { get; set; }
        object getListHoaDon { get; set; }
        object getListSach { get; set; }
        object getListMaHoaDon { get; set; }
        string selectedMaSach { get; }
        int selectedMaHoaDon { get; }
        Presenter.ChiTietHoaDonPresenter Presenter { set; }
        int selectedHoaDon { get; }
        void Log(string mes);
        void showError();
    }
}
