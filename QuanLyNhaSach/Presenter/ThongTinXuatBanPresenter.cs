using QuanLyNhaSach.Model;
using QuanLyNhaSach.Model.AppData;
using QuanLyNhaSach.Validation;
using QuanLyNhaSach.View.ThongTinXuatBan;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaSach.Presenter
{
    public class ThongTinXuatBanPresenter
    {
        IThongTinXuatBanRepository repository;
        IThongTinXuatBanForm view;
        IModelStateWraper state;
        public ThongTinXuatBanPresenter(IThongTinXuatBanForm _view, IModelStateWraper _state):this(_view,new ThongTinXuatBanRepository(),_state)
        {
            //state = _state;
            //view = _view;
            ////repository = _repository;
            //_view.Presenter = this;
        }
        private ThongTinXuatBanPresenter(IThongTinXuatBanForm _view, IThongTinXuatBanRepository _repository, IModelStateWraper _state)
        {
            state = _state;
            view = _view;
            repository = _repository;
            _view.Presenter = this;
        }

        public void getListThongTinXuatBan()
        {
            if (repository.getListThongTinXuatBan() != null)
            {
                view.getListThongTinXuatBan = repository.getListThongTinXuatBan();
                getListMasach();
            }
        }
        public void getListMasach()
        {
            view.getListMasach = repository.getListMaSach();
            showSelected();

        }
        public void saveThongTinXuatBan()
        {
            
            //THONGTINXUATBAN ttxb = repository.getThongTinXuatBan(view.selectedThongTinXuatBan);
            THONGTINXUATBAN ttxb = ViewToModel();

            if (valid(ttxb))
            {
                THONGTINXUATBAN kq = repository.saveThongTinXuatBan(ttxb);

                //view.Log("Đã lưu thành công");
                getListThongTinXuatBan();
            }
        }
        public void editThongTinXuatBan()
        {
            
            THONGTINXUATBAN ttxb_moi = ViewToModel();
            string mattxb_cu = view.selectedThongTinXuatBan;

            //if (valid(ttxb_moi))
            //{
            
                THONGTINXUATBAN kq = repository.editThongTinXuatBan(ttxb_moi, mattxb_cu);


                getListThongTinXuatBan();
            //}
        }
        public bool valid(THONGTINXUATBAN ttxb)
        {
            //xet null
            
            state.Clear();
            if (ttxb.MASACH == "")
                state.addError("sach", "Không còn sách để thêm thông tin");

            //if (ttxb.NAMSINH >= ttxb.NAMMAT)
            //    state.addError("nam", "Năm sinh phải nhỏ hơn năm mất");

            return state.isValid();


        }

        public void deleteThongTinXuatBan()
        {
            
            //THONGTINXUATBAN ttxb = repository.getThongTinXuatBan(view.selectedThongTinXuatBan);
            string mattxb = view.selectedThongTinXuatBan;
            if (mattxb != "")
            {
                THONGTINXUATBAN tacgia = repository.getThongTinXuatBan(mattxb);
                if (valid(tacgia))
                {
                    THONGTINXUATBAN kq = repository.deleteThongTinXuatBan(mattxb);

                    //view.Log("Đã lưu thành công");
                    getListThongTinXuatBan();
                }
            }
        }

        public void showSelected()
        {
            if (view.selectedThongTinXuatBan != "")
            {
                THONGTINXUATBAN ttxb = repository.getThongTinXuatBan(view.selectedThongTinXuatBan);

                ModelToView(ttxb);
            }
            //view.ThongTinXuatBan = ttxb;

        }
        private void ModelToView(THONGTINXUATBAN ttxb)
        {
            view.MASACH = ttxb.MASACH;
            view.LANTAIBAN = ttxb.LANTAIBAN;
            view.NHAXUATBAN = ttxb.NHAXUATBAN;
            view.NAMXUATBAN = ttxb.NAMXUATBAN;
            view.GIABIA = ttxb.GIABIA;

        }
        private THONGTINXUATBAN ViewToModel()
        {
            THONGTINXUATBAN ttxb = new THONGTINXUATBAN();
            ttxb.MASACH = view.MASACH;
            ttxb.LANTAIBAN = view.LANTAIBAN;
            ttxb.NHAXUATBAN = view.NHAXUATBAN;
            ttxb.NAMXUATBAN = view.NAMXUATBAN;
            ttxb.GIABIA = view.GIABIA;
            return ttxb;

        }

    }
}
