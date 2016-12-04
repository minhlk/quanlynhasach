using QuanLyNhaSach.Model;
using QuanLyNhaSach.Model.AppData;
using QuanLyNhaSach.Validation;
using QuanLyNhaSach.View.Sach;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaSach.Presenter
{
    public class SachPresenter

    {
        ISachRepository repository;
        ISachForm view;
        IModelStateWraper state;
        public SachPresenter(ISachForm _view, IModelStateWraper _state):this(_view,new SachRepository(),_state)
        {
            //state = _state;
            //view = _view;
            ////repository = _repository;
            //_view.Presenter = this;
        }
        private SachPresenter(ISachForm _view, ISachRepository _repository, IModelStateWraper _state)
        {
            state = _state;
            view = _view;
            repository = _repository;
            _view.Presenter = this;
        }
        public void getListSach()
        {
            view.getListSach= repository.getListSach();
            //getListTacGia();
            getListLinhVuc();
            getListLoaiSach();
        }
        public void getListTacGia()
        {
            view.getListTacGia = repository.getListTacGia();


        }
        public void getListLinhVuc()
        {
            view.getListLinhVuc = repository.getListLinhVuc();


        }
        public void getListLoaiSach()
        {
            view.getListLoaiSach = repository.getListLoaiSach();


        }

        public void saveSach()
        {
            //SACH sach = repository.getSach(view.selectedSach);
            SACH sach = ViewToModel();

            if (valid(sach)&&checkExist(sach.MASACH))
            {
                SACH kq = repository.saveSach(sach);

                //view.Log("Đã lưu thành công");
                getListSach();


            }
        }
        public void editSach()
        {

            SACH sach_moi = ViewToModel();
            string masach_cu = view.selectedSach;
            sach_moi.MASACH = masach_cu;
            if (valid(sach_moi))
            {
                SACH kq = repository.editSach(sach_moi, masach_cu);


                getListSach();
            }
        }
        public bool valid(SACH sach)
        {
            //xet null
            state.Clear();
            if (sach.MASACH =="")
                state.addError("masach", "Mã sách không được để trống");
            if (sach.TENSACH =="" )
                state.addError("tensach", "Tên sách không được để trống");
            
            // can them ham xoa tat ca cac bang khac
            return state.isValid();


        }
        public bool checkExist(string masach)
        {
            SACH sach = repository.getSach(masach);
            if (sach != null)
            {
                state.addError("masach2", "Mã sách đã tồn tại");
                //view.Log("sai r");
                return false;
            }
            return true;
        }
        public void deleteSach()
        {
            //SACH sach = repository.getSach(view.selectedSach);
            string masach = view.selectedSach;
            SACH sach = repository.getSach(masach);
            //view.Log(sach.MASACH);
            if (valid(sach))
            {
                SACH kq = repository.deleteSach(masach);

                //view.Log("Đã lưu thành công");
                getListSach();
            }
        }

        public void showSelected()
        {
            SACH sach = repository.getSach(view.selectedSach);
            ModelToView(sach);
            //view.Sach = sach;

        }

        public void showSelectedMaLoaiSach()
        {
            view.selectedLoaiSach = view.selectedLoaiSach;
            

        }
        public void showSelectedMaTacGia()
        {
            view.selectedTacGia = view.selectedTacGia;

        }
        public void showSelectedMaLinhVuc()
        {
            view.selectedLinhVuc = view.selectedLinhVuc;

        }
        private void ModelToView(SACH sach)
        {
            view.MASACH = sach.MASACH;
            view.MALINHVUC = sach.MALINHVUC;
            view.MALOAISACH = sach.MALOAISACH;
            view.MATG = sach.MATG;
            view.GIAMUA = sach.GIAMUA;
            view.TENSACH = sach.TENSACH;


        }
        private SACH ViewToModel()
        {
            SACH sach = new SACH();
            sach.MASACH = view.MASACH;
            sach.MALINHVUC = view.MALINHVUC;
            sach.MALOAISACH = view.MALOAISACH;
            sach.MATG = view.MATG;
            sach.GIAMUA = view.GIAMUA;
            sach.TENSACH = view.TENSACH;
            return sach;

        }

    }
}
