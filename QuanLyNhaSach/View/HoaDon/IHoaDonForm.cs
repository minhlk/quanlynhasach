using QuanLyNhaSach.Model.AppData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaSach.View.HoaDon
{
    public interface IHoaDonForm
    {
        
        HOADON HoaDon { get; set; }
        //IEnumerable<HOADON> getListHoaDon { get; set; }
        object getListHoaDon { get; set; }
        Presenter.HoaDonPresenter Presenter { set; }
        string selectedHoaDon { get; }
        void Log(string mes);
        void showError();
    }
}
