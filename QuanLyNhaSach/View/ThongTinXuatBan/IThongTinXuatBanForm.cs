using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaSach.View.ThongTinXuatBan
{
    public interface IThongTinXuatBanForm
    {
        string MASACH { get; set; }
        Nullable<int> LANTAIBAN { get; set; }
        Nullable<System.DateTime> NAMXUATBAN { get; set; }
        string NHAXUATBAN { get; set; }
        Nullable<int> GIABIA { get; set; }
        object getListMasach { set; }
        object getListThongTinXuatBan { get; set; }
        Presenter.ThongTinXuatBanPresenter Presenter { set; }
        string selectedThongTinXuatBan { get; }
        void Log(string mes);
        void showError();
    }
}
