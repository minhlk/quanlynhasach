using QuanLyNhaSach.Model;
using QuanLyNhaSach.Model.AppData;
using QuanLyNhaSach.Validation;
using QuanLyNhaSach.View.Kho;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaSach.Presenter
{
    public class KhoPresenter
    {
        IKhoRepository repository;
        IKhoForm view;
        IModelStateWraper state;
        public KhoPresenter(IKhoForm _view, IModelStateWraper _state):this(_view,new KhoRepository(),_state)
        {
            //state = _state;
            //view = _view;
            ////repository = _repository;
            //_view.Presenter = this;
        }
        private KhoPresenter(IKhoForm _view, IKhoRepository _repository, IModelStateWraper _state)
        {
            state = _state;
            view = _view;
            repository = _repository;
            _view.Presenter = this;
        }
        public void getListKho()
        {
            view.getListKho = repository.getListKho();
            getListMasach();
        }
        public void getListMasach()
        {
            view.getListMasach = repository.getListMaSach();
            

        }
        public void saveKho()
        {
            //KHO kho = repository.getKho(view.selectedKho);
            KHO kho = ViewToModel();

            if (valid(kho))
            {
                KHO kq = repository.saveKho(kho);

                //view.Log("Đã lưu thành công");
                getListKho();
  

            }
}
        public void editKho()
        {

            KHO kho_moi = ViewToModel();
            string makho_cu = view.selectedKho;
            kho_moi.MASACH = makho_cu;
            if (valid(kho_moi))
            {
                KHO kq = repository.editKho(kho_moi, makho_cu);


                getListKho();
            }
        }
        public bool valid(KHO kho)
        {
            //xet null
            state.Clear();
            if (kho.SOLUONGCON <0)
                state.addError("soluongcon", "Số lượng còn không được nhỏ hơn 0");
            if (kho.TONGSOLUONG < 0)
                state.addError("tongsoluong", "Tổng số lượng không được nhỏ hơn 0");
            if (kho.SOLUONGCON > kho.TONGSOLUONG)
                state.addError("lonhon", "Số lượng còn không được lớn hơn tổng số lượng");
            if (kho.MASACH == "")
                state.addError("sach", "Không còn sách để thêm thông tin");
            return state.isValid();


        }

        public void deleteKho()
        {
            //KHO kho = repository.getKho(view.selectedKho);
            string makho = view.selectedKho;
            KHO kho = repository.getKho(makho);
            if (valid(kho))
            {
                KHO kq = repository.deleteKho(makho);

                //view.Log("Đã lưu thành công");
                getListKho();
            }
        }

        public void showSelected()
        {
            KHO kho = repository.getKho(view.selectedKho);
            ModelToView(kho);
            //view.Kho = kho;

        }
        private void ModelToView(KHO kho)
        {
            view.MASACH = kho.MASACH;
            view.SOLUONGCON = kho.SOLUONGCON;
            view.TONGSOLUONG = kho.TONGSOLUONG;
            


        }
        private KHO ViewToModel()
        {
            KHO kho = new KHO();
            kho.MASACH = view.MASACH;
            kho.SOLUONGCON = view.SOLUONGCON;
            kho.TONGSOLUONG = view.TONGSOLUONG;
            return kho;

        }

    }
}
