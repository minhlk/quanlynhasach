﻿using QuanLyNhaSach.Model;
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
        public HoaDonPresenter(IHoaDonForm _view, IModelStateWraper _state) : this(_view, new HoaDonRepository(), _state)
        {
            //view = _view;
            //state = _state;
            //_view.Presenter = this;
        }
        private HoaDonPresenter(IHoaDonForm _view, IHoaDonRepository _repository, IModelStateWraper _state)
        {
            state = _state;
            view = _view;
            repository = _repository;
            _view.Presenter = this;
        }

        public void getListHoaDon()
        {
            if(repository.getListHoaDon()!=null)
            view.getListHoaDon = repository.getListHoaDon();

        }
        public void saveHoaDon()
        {
            //HOADON hd = repository.getHoaDon(view.selectedHoaDon);
            //HOADON hd = view.HoaDon;
            HOADON hd = viewtoModel();

            if (valid(hd))
            {
                HOADON kq = repository.saveHoaDon(hd);

                //view.Log("Đã lưu thành công");
                getListHoaDon();
            }
        }
        public void editHoaDon()
        {

            //HOADON hd_moi = view.HoaDon;
            HOADON hd_moi = viewtoModel();
            if (view.selectedHoaDon != "")
            {
                int mahd_cu = int.Parse(view.selectedHoaDon);

                if (valid(hd_moi))
                {
                    HOADON kq = repository.editHoaDon(hd_moi, mahd_cu);


                    getListHoaDon();
                }
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
            if (view.selectedHoaDon != "")
            {
                int mahd = int.Parse(view.selectedHoaDon);
                HOADON hoadon = repository.getHoaDon(mahd);
                if (valid(hoadon))
                {
                    HOADON kq = repository.deleteHoaDon(mahd);

                    //view.Log("Đã lưu thành công");
                    getListHoaDon();
                }
            }
        }

        public void showSelected()
        {
            if (view.selectedHoaDon != "")
            {
                HOADON hd = repository.getHoaDon(int.Parse(view.selectedHoaDon));

                //view.HoaDon = hd;
                modeltoView(hd);
            }
        }
        private HOADON viewtoModel()
        {
            HOADON temp = new HOADON();
            temp.NGAYLAP = view.NGAYLAP;
            temp.TENKHACHHANG = view.TENKHACHHANG;
            temp.TONGTIEN = view.TONGTIEN;
            

            return temp;

        }
        private void modeltoView(HOADON hd)
        {
            view.NGAYLAP = hd.NGAYLAP;
            view.TENKHACHHANG = hd.TENKHACHHANG;
            view.TONGTIEN = hd.TONGTIEN;
        }

    }
}

