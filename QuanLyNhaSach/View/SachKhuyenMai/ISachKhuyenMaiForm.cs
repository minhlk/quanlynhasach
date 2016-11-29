using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaSach.View.SachKhuyenMai
{
    public interface ISachKhuyenMaiForm
    {
        string MASACH { get; set; }
        Nullable<int> MUCGIAMGIA { get; set; }
        object getListSachKhuyenMai { get; set; }
        object getListMasach { set; }
        Presenter.SachKhuyenMaiPresenter Presenter { set; }
        string selectedSackKhuyenMai { get; }
        void Log(string mes);
        void showError();
    }
}
