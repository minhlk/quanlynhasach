using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhaSach.View.LoaiSach
{
    public interface ILoaiSachForm
    {
        string MALOAISACH { get; set; }
        string TENLOAISACH { get; set; }


        //IEnumerable<TACGIA> getListTacGia { get; set; }
        object getListLoaiSach{ get; set; }
        Presenter.LoaiSachPresenter Presenter { set; }
        string selectedLoaiSach { get; }
        DialogResult Log(string mes);
        void showError();
    }
}
