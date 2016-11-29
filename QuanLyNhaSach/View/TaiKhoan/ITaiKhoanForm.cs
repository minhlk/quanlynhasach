using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaSach.View.TaiKhoan
{
    public interface ITaiKhoanForm
    {
        string USERNAME { get; set; }
        string PASSWORD { get; set; }
        string TEN { get; set; }
        //string ID { get; set; }
        Nullable<System.DateTime> NGAYLAMVIEC { get; set; }
        string CHUCVU { get; set; }
        object getListTaiKhoan { get; set; }
        Presenter.TaiKhoanPresenter Presenter { set; }
        string selectedTaiKhoan { get; }
        void Log(string mes);
        void showError();

    }
}
