using QuanLyNhaSach.Model;
using QuanLyNhaSach.Model.AppData;
using QuanLyNhaSach.Validation;
using QuanLyNhaSach.View.LoaiSach;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaSach.Presenter
{
    public class LoaiSachPresenter
    {
       
            ILoaiSachRepository repository;
            ILoaiSachForm view;
            IModelStateWraper state;
            public LoaiSachPresenter(ILoaiSachForm _view, IModelStateWraper _state) : this(_view, new LoaiSachRepository(), _state)
            {
                state = _state;
                view = _view;
                //repository = _repository;
                _view.Presenter = this;
            }
            private LoaiSachPresenter(ILoaiSachForm _view, ILoaiSachRepository _repository, IModelStateWraper _state)
            {
                //state = _state;
                //view = _view;
                repository = _repository;
                //_view.Presenter = this;
            }

            public void getListLoaiSach()
            {
                view.getListLoaiSach = repository.getListLoaiSach();

            }
            public void saveLoaiSach()
            {
                //LOAISACH ls = repository.getLoaiSach(view.selectedLoaiSach);
                LOAISACH ls = ViewToModel();

                if (valid(ls)&& checkExist(ls,false))
                {
                    LOAISACH kq = repository.saveLoaiSach(ls);

                    //view.Log("Đã lưu thành công");
                    getListLoaiSach();
                }
            }
            public void editLoaiSach()
            {

                LOAISACH ls_moi = ViewToModel();
                string mals_cu = view.selectedLoaiSach;

                if (valid(ls_moi)&& checkExist(ls_moi,mals_cu==ls_moi.MALOAISACH))
                {
                    LOAISACH kq = repository.editLoaiSach(ls_moi, mals_cu);


                    getListLoaiSach();
                }
            }
            public bool valid(LOAISACH ls)
            {
                //xet null
                state.Clear();
                if (ls.MALOAISACH == ""  )
                    state.addError("maloaisach", "Mã loại sách không được để trống");
            if (ls.MALOAISACH.Length > 2)
                state.addError("maloaisach2", "Mã loại sách không dài quá 2 kí tự");
            //if (ls.NAMSINH >= ls.NAMMAT)
            //        state.addError("nam", "Năm sinh phải nhỏ hơn năm mất");

                return state.isValid();


            }
        private bool checkExist(LOAISACH ls, bool b)
        {
            if (b) { return true; }
            foreach (LOAISACH i in repository.getListLoaiSach())
            {
                if (ls.MALOAISACH== i.MALOAISACH)
                {
                    state.addError("maloaisach3", "Mã sách đã tồn tại");
                    return false;
                }

            }


            return true;
        }
        public void deleteLoaiSach()
            {
                //LOAISACH ls = repository.getLoaiSach(view.selectedLoaiSach);
                string mals = view.selectedLoaiSach;
                LOAISACH tacgia = repository.getLoaiSach(mals);
                if (valid(tacgia))
                {
                    LOAISACH kq = repository.deleteLoaiSach(mals);

                    //view.Log("Đã lưu thành công");
                    getListLoaiSach();
                }
            }

            public void showSelected()
            {
                LOAISACH ls = repository.getLoaiSach(view.selectedLoaiSach);
                ModelToView(ls);
                //view.LoaiSach = ls;

            }
            private void ModelToView(LOAISACH ls)
            {
                view.MALOAISACH = ls.MALOAISACH;
                view.TENLOAISACH = ls.TENLOAISACH;
                


            }
            private LOAISACH ViewToModel()
            {
                LOAISACH ls = new LOAISACH();
                ls.TENLOAISACH = view.TENLOAISACH;
                ls.MALOAISACH = view.MALOAISACH;
               
                return ls;

            }

        
    }
}
