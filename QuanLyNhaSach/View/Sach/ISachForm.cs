using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaSach.View.Sach
{
    public interface ISachForm
    {

        string MASACH { get; set; }
        string TENSACH { get; set; }
        Nullable<int> MATG { get; set; }
        string MALOAISACH { get; set; }
        string MALINHVUC { get; set; }
        Nullable<int> GIAMUA { get; set; }
        object getListLoaiSach { get; set; }
        object getListTacGia { get; set; }
        object getListLinhVuc { get; set; }
        object getListSach { get; set; }
        Presenter.SachPresenter Presenter { set; }
        string selectedSach { get; }
        int selectedTacGia { get; set; }
        string selectedLoaiSach { get; set; }
        string selectedLinhVuc { get; set; }
        void Log(string mes);
        void showError();


    }
}
