using QuanLyNhaSach.Model.AppData;
using QuanLyNhaSach.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaSach.View
{
    public interface ITacGiaForm
    {



        //int MATG { get; set; }
        string TENTG { get; set; }
         Nullable<System.DateTime> NAMSINH { get; set; }
         Nullable<System.DateTime> NAMMAT { get; set; }
         string QUEQUAN { get; set; }


        //IEnumerable<TACGIA> getListTacGia { get; set; }
        object getListTacGia { get; set; }
        Presenter.TacGiaPresenter Presenter { set; }
        string selectedTacGia { get; }
        void Log(string mes);
        void showError();

    }
}
