using QuanLyNhaSach.Model;
using QuanLyNhaSach.Model.AppData;
using QuanLyNhaSach.Validation;
using QuanLyNhaSach.View.ChiTietHoaDon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaSach.Presenter
{
    public class ChiTietHoaDonPresenter


    {
        IChiTietHoaDonRepository repository;
        IChiTietHoaDonForm view;
        IModelStateWraper state;
        public ChiTietHoaDonPresenter(IChiTietHoaDonForm _view, IModelStateWraper _state) : this(_view, new ChiTietHoaDonRepository(), _state)
        {
            //state = _state;
            //view = _view;
            ////repository = _repository;
            //_view.Presenter = this;
        }
        private ChiTietHoaDonPresenter(IChiTietHoaDonForm _view, IChiTietHoaDonRepository _repository, IModelStateWraper _state)
        {
            state = _state;
            view = _view;
            repository = _repository;
            _view.Presenter = this;
        }
        public void getListChiTietHoaDon()
        {
            if (repository.getListHoaDon() != null)
            {
                view.getListHoaDon = repository.getListHoaDon();
                //view.Log("in");
            }
            //view.Log("out");
            getListMasach();
            getListMaHoaDon();
        }
        public void getListMasach()
        {
            if (repository.getListSach() != null)
                view.getListSach = repository.getListSach();


        }
        public void showSelectedMaSach()
        {
            view.MASACH = view.selectedMaSach;


        }
        public void showSelectedMaHoaDon()
        {
            view.MAHOADON = view.selectedMaHoaDon;


        }
        public void getListMaHoaDon()
        {
            if (repository.getListMaHoaDon() != null)
            {
                //view.Log("in");
                view.getListMaHoaDon = repository.getListMaHoaDon();
            }

        }
        public void saveChiTietHoaDon()
        {
            //CHITIETHOADON chitiethoadon = repository.getChiTietHoaDon(view.selectedChiTietHoaDon);
            CHITIETHOADON chitiethoadon = ViewToModel();


            if (valid(chitiethoadon)&&checkExists(chitiethoadon.MAHOADON))
            {
                CHITIETHOADON kq = repository.saveHoaDon(chitiethoadon);

                //view.Log("Đã lưu thành công");
                getListChiTietHoaDon();


            }
           
        }
        public void editChiTietHoaDon()
        {

            CHITIETHOADON chitiethoadon_moi = ViewToModel();
            int machitiethoadon_cu = Convert.ToInt32(view.selectedHoaDon);
            chitiethoadon_moi.MAHOADON = machitiethoadon_cu;
            if (valid(chitiethoadon_moi))
            {
                CHITIETHOADON kq = repository.editHoaDon(chitiethoadon_moi, machitiethoadon_cu);


                getListChiTietHoaDon();
            }
            

            
        }
        public bool checkExists(int mahd) {

            if (repository.getHoaDon(mahd) != null)
            {
                state.addError("mahoadon2", "Mã hóa đơn đã tồn tại,chọn mã khác");
                return false;
            }
            return true;
        }
        public bool valid(CHITIETHOADON chitiethoadon)
        {
            //xet null
            state.Clear();
            if (chitiethoadon.MAHOADON == -1)
                state.addError("mahoadon", "Cần thêm hóa đơn mới");
            if (chitiethoadon.MASACH =="a")
                state.addError("masach", "Vui lòng thêm sách để thực hiện");
           
            //if (chitiethoadon.SOLUONGCON > chitiethoadon.TONGSOLUONG)
            //    state.addError("lonhon", "Số lượng còn không được lớn hơn tổng số lượng");
            //if (chitiethoadon.MASACH == "")
            //    state.addError("sach", "Không còn sách để thêm thông tin");
            return state.isValid();


        }

        public void deleteChiTietHoaDon()
        {
            //CHITIETHOADON chitiethoadon = repository.getChiTietHoaDon(view.selectedChiTietHoaDon);
            if (view.selectedHoaDon != -1)
            {
                int machitiethoadon = Convert.ToInt32(view.selectedHoaDon);
                CHITIETHOADON chitiethoadon = repository.getHoaDon(machitiethoadon);
                if (valid(chitiethoadon))
                {
                    CHITIETHOADON kq = repository.deleteHoaDon(machitiethoadon);

                    //view.Log("Đã lưu thành công");
                    getListChiTietHoaDon();
                }
            }
        }

        public void showSelected()
        {
            if (view.selectedHoaDon != -1)
            {
                //view.Log("showselected");
                CHITIETHOADON chitiethoadon = repository.getHoaDon(view.selectedHoaDon);
                ModelToView(chitiethoadon);
                //view.ChiTietHoaDon = chitiethoadon;
            }
        }
        private void ModelToView(CHITIETHOADON chitiethoadon)
        {
            view.MASACH = chitiethoadon.MASACH;
            view.MAHOADON = chitiethoadon.MAHOADON;
            view.SOLUONG = chitiethoadon.SOLUONG;
            view.MUCGIAMGIA = chitiethoadon.MUCGIAMGIA;


        }
        private CHITIETHOADON ViewToModel()
        {
            CHITIETHOADON chitiethoadon = new CHITIETHOADON();
            chitiethoadon.MASACH = view.MASACH;
            chitiethoadon.MAHOADON = view.MAHOADON;
            chitiethoadon.SOLUONG = view.SOLUONG;
            chitiethoadon.MUCGIAMGIA = view.MUCGIAMGIA;
            return chitiethoadon;

        }

    }
}
