using QuanLyNhaSach.Model;
using QuanLyNhaSach.Model.AppData;
using QuanLyNhaSach.Validation;
using QuanLyNhaSach.View.SachKhuyenMai;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaSach.Presenter
{
    public class SachKhuyenMaiPresenter

    {
        ISachKhuyenMaiRepository repository;
        ISachKhuyenMaiForm view;
        IModelStateWraper state;
        public SachKhuyenMaiPresenter(ISachKhuyenMaiForm _view, IModelStateWraper _state):this(_view,new SachKhuyenMaiRepository(),_state)
        {
            //state = _state;
            //view = _view;
            ////repository = _repository;
            //_view.Presenter = this;
        }
        private SachKhuyenMaiPresenter(ISachKhuyenMaiForm _view, ISachKhuyenMaiRepository _repository, IModelStateWraper _state)
        {
            state = _state;
            view = _view;
            repository = _repository;
            _view.Presenter = this;
        }
        public void getListSachKhuyenMai()
        {
            view.getListSachKhuyenMai = repository.getListSachKhuyenMai();
            getListMasach();
        }
        public void getListMasach()
        {
            view.getListMasach = repository.getListMaSach();


        }
        public void saveSachKhuyenMai()
        {
            //SACHKHUYENMAI kho = repository.getSachKhuyenMai(view.selectedSachKhuyenMai);
            SACHKHUYENMAI kho = ViewToModel();

            if (valid(kho))
            {
                SACHKHUYENMAI kq = repository.saveSachKhuyenMai(kho);

                //view.Log("Đã lưu thành công");
                getListSachKhuyenMai();


            }
        }
        public void editSachKhuyenMai()
        {

            SACHKHUYENMAI kho_moi = ViewToModel();
            string makho_cu = view.selectedSackKhuyenMai;
            kho_moi.MASACH = makho_cu;
            if (valid(kho_moi))
            {
                SACHKHUYENMAI kq = repository.editSachKhuyenMai(kho_moi, makho_cu);


                getListSachKhuyenMai();
            }
        }
        public bool valid(SACHKHUYENMAI skm)
        {
            //xet null
            state.Clear();
            if (skm.MASACH == "")
                state.addError("masach", "Không có sách được chọn");
            //if (kho.TONGSOLUONG < 0)
            //    state.addError("tongsoluong", "Tổng số lượng không được nhỏ hơn 0");
            //if (kho.SOLUONGCON > kho.TONGSOLUONG)
            //    state.addError("lonhon", "Số lượng còn không được lớn hơn tổng số lượng");
            //if (kho.MASACH == "")
            //    state.addError("sach", "Không còn sách để thêm thông tin");
            return state.isValid();


        }

        public void deleteSachKhuyenMai()
        {
            //SACHKHUYENMAI kho = repository.getSachKhuyenMai(view.selectedSachKhuyenMai);
            string makho = view.selectedSackKhuyenMai;
            SACHKHUYENMAI kho = repository.getSachKhuyenMai(makho);
            if (valid(kho))
            {
                SACHKHUYENMAI kq = repository.deleteSachKhuyenMai(makho);

                //view.Log("Đã lưu thành công");
                getListSachKhuyenMai();
            }
        }

        public void showSelected()
        {
            SACHKHUYENMAI kho = repository.getSachKhuyenMai(view.selectedSackKhuyenMai);
            ModelToView(kho);
            //view.SachKhuyenMai = kho;

        }
        private void ModelToView(SACHKHUYENMAI skm)
        {
            view.MASACH = skm.MASACH;
            view.MUCGIAMGIA = skm.MUCGIAMGIA;
            



        }
        private SACHKHUYENMAI ViewToModel()
        {
            SACHKHUYENMAI skm = new SACHKHUYENMAI();
            skm.MASACH = view.MASACH;
            skm.MUCGIAMGIA = view.MUCGIAMGIA;
           
            return skm;

        }

    }
}
