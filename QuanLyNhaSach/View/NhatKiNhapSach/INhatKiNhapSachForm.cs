using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhaSach.View.NhatKiNhapSach
{
    public interface INhatKiNhapSachForm
    {
        
        string MASACH { get; set; }
        Nullable<int> SOLUONG { get; set; }
        Nullable<System.DateTime> NGAYNHAP { get; set; }
        object getListNhatKiNhapSach { get; set; }
        object getListMasach { set; }
        Presenter.NhatKiNhapSachPresenter Presenter { set; }
        int selectedNhatKiNhapSach { get; }
        string selectedMaSach { get; }
        DialogResult Log(string mes);
        void showError();
    }
}
