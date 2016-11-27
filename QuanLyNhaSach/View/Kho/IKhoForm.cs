using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaSach.View.Kho
{
   public interface IKhoForm
    {
        string MASACH { get; set; }

        Nullable<int> TONGSOLUONG { get; set; }
        Nullable<int> SOLUONGCON { get; set; }

        object getListKho { get; set; }
        object getListMasach {  set; }
        Presenter.KhoPresenter Presenter { set; }
        string selectedKho { get; }
        void Log(string mes);
        void showError();
    }
}
