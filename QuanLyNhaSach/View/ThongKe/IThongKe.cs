using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaSach.View.ThongKe
{
    public interface IThongKe
    {

        bool MaSach { get; }
        bool TenSach { get; }
        bool MaSach2 { get; }
        bool MaHoaDon { get; }
        string GiaTriTimKiem{ get; }
        DateTime NgayBatDau{ get; }
        DateTime NgayKetThuc{ get; }
        int TongChi{ set; }
        int TongThu{ set; }
        object getListSach { set; }
        object getListHoaDon{ set; }
        Presenter.ThongKePresenter Presenter { set; }

    }
}
