using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaSach.View.LinhVuc
{
    public interface ILinhVucForm
    {
        string MALINHVUC { get; set; }
        string TENLINHVUC { get; set; }


        //IEnumerable<TACGIA> getListTacGia { get; set; }
        object getListLinhVuc { get; set; }
        Presenter.LinhVucPresenter Presenter { set; }
        string selectedLinhVuc { get; }
        void Log(string mes);
        void showError();
    }
}
