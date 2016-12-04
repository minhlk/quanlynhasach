using QuanLyNhaSach.Model;
using QuanLyNhaSach.Model.AppData;
using QuanLyNhaSach.Validation;
using QuanLyNhaSach.View.LinhVuc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaSach.Presenter
{
    public class LinhVucPresenter
    {
       
            ILinhVucRepository repository;
            ILinhVucForm view;
            IModelStateWraper state;
            public LinhVucPresenter(ILinhVucForm _view, IModelStateWraper _state) : this(_view, new LinhVucRepository(), _state)
            {
                //state = _state;
                //view = _view;
                //repository = _repository;
                //_view.Presenter = this;
            }
            private LinhVucPresenter(ILinhVucForm _view, ILinhVucRepository _repository, IModelStateWraper _state)
            {
            state = _state;
            view = _view;
            repository = _repository;
            _view.Presenter = this;
        }

            public void getListLinhVuc()
            {
                view.getListLinhVuc = repository.getListLinhVuc();

            }
            public void saveLinhVuc()
            {
                //LINHVUC lv = repository.getLinhVuc(view.selectedLinhVuc);
                LINHVUC lv = ViewToModel();

                if (valid(lv) && checkExist(lv,false))
                {
                    LINHVUC kq = repository.saveLinhVuc(lv);

                    //view.Log("Đã lưu thành công");
                    getListLinhVuc();
                }
            }
            public void editLinhVuc()
            {

                LINHVUC lv_moi = ViewToModel();
                string malv_cu = view.selectedLinhVuc;

                if (valid(lv_moi) && checkExist(lv_moi, lv_moi.MALINHVUC == malv_cu))
                {
                    LINHVUC kq = repository.editLinhVuc(lv_moi, malv_cu);


                    getListLinhVuc();
                }
            }
            public bool valid(LINHVUC lv)
            {
                //xet null
                state.Clear();
                if (lv.MALINHVUC == ""  )
                    state.addError("malinhvuc", "Mã lĩnh vực không được để trống");
            if (lv.MALINHVUC.Length > 2)
                state.addError("malinhvuc2", "Mã lĩnh vực không dài quá 2 kí tự");
            //if (lv.NAMSINH >= lv.NAMMAT)
            //        state.addError("nam", "Năm sinh phải nhỏ hơn năm mất");

                return state.isValid();


            }
        private bool checkExist(LINHVUC lv,bool b) {
            if (b) { return true; }
            foreach (LINHVUC i in repository.getListLinhVuc()) {
                if (lv.MALINHVUC == i.MALINHVUC)
                {
                    state.addError("malinhvuc3", "Mã lĩnh vực đã tồn tại");
                    return false;
                }

            }


            return true;
        }

            public void deleteLinhVuc()
            {
                //LINHVUC lv = repository.getLinhVuc(view.selectedLinhVuc);
                string malv = view.selectedLinhVuc;
            if (malv != "")
            {
                LINHVUC lv = repository.getLinhVuc(malv);

                if (valid(lv))
                {
                    if (checkExistInSach(lv.MALINHVUC))
                    {

                        //hien thong bao da ton tai xem co can xoa khong
                        if (view.Log("Xóa Lĩnh Vực này và xóa các sách liên quan đến lĩnh vực này") == System.Windows.Forms.DialogResult.Yes)
                        {
                            repository.deleteSach(lv.MALINHVUC);
                            LINHVUC kq = repository.deleteLinhVuc(malv);
                            getListLinhVuc();
                        }


                    }
                    else
                    {
                        LINHVUC kq = repository.deleteLinhVuc(malv);
                        getListLinhVuc();
                    }

                }
            }
            }
        public bool checkExistInSach(string MaLinhVuc) {
            return repository.checkExistInSach(MaLinhVuc);



        }
            public void showSelected()
            {
            if (view.selectedLinhVuc != "")
            {
                LINHVUC lv = repository.getLinhVuc(view.selectedLinhVuc);
                ModelToView(lv);
                //view.LinhVuc = lv;
            }
            }
            private void ModelToView(LINHVUC lv)
            {
                view.MALINHVUC = lv.MALINHVUC;
                view.TENLINHVUC = lv.TENLINHVUC;
                


            }
            private LINHVUC ViewToModel()
            {
                LINHVUC lv = new LINHVUC();
                lv.TENLINHVUC = view.TENLINHVUC;
                lv.MALINHVUC = view.MALINHVUC;
               
                return lv;

            }

        
    }
}
