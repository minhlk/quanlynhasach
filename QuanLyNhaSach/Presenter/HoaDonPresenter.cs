using QuanLyNhaSach.Model;
using QuanLyNhaSach.Model.AppData;
using QuanLyNhaSach.Validation;
using QuanLyNhaSach.View.HoaDon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaSach.Presenter
{
    public class HoaDonPresenter
    {
        IHoaDonRepository repository;
        IHoaDonForm view;
        IModelStateWraper state;
        public HoaDonPresenter(IHoaDonForm _view, IHoaDonRepository _repository, IModelStateWraper _state)
        {
            state = _state;
            view = _view;
            repository = _repository;
            _view.Presenter = this;
        }

        public void getListHoaDon()
        {
            view.getListHoaDon = repository.getListHoaDon();

        }
        public void saveHoaDon()
        {
            //HOADON hd = repository.getHoaDon(view.selectedHoaDon);
            HOADON hd = view.HoaDon;

            if (valid(hd))
            {
                HOADON kq = repository.saveHoaDon(hd);

                //view.Log("Đã lưu thành công");
                getListHoaDon();
            }
        }
        public void editHoaDon()
        {

            HOADON hd_moi = view.HoaDon;
            int mahd_cu = int.Parse(view.selectedHoaDon);

            if (valid(hd_moi))
            {
                HOADON kq = repository.editHoaDon(hd_moi, mahd_cu);


                getListHoaDon();
            }
        }
        public bool valid(HOADON hd)
        {
            //xet null
            state.Clear();
            if (hd.TENKHACHHANG == "")
                state.addError("tenkhach", "Tên khách hàng không được để trống");

            if (hd.TONGTIEN==0)
                state.addError("tongtien", "Nhập số tiền trong hóa đơn");

            return state.isValid();


        }

        public void deleteHoaDon()
        {
            //HOADON hd = repository.getHoaDon(view.selectedHoaDon);
            int mahd = int.Parse(view.selectedHoaDon);
            HOADON hoadon = repository.getHoaDon(mahd);
            if (valid(hoadon))
            {
                HOADON kq = repository.deleteHoaDon(mahd);

                //view.Log("Đã lưu thành công");
                getListHoaDon();
            }
        }

        public void showSelected()
        {
            HOADON hd = repository.getHoaDon(int.Parse(view.selectedHoaDon));

            view.HoaDon = hd;
        }


    }
}

