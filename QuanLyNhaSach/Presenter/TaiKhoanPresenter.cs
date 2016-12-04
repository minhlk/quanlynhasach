using QuanLyNhaSach.Model;
using QuanLyNhaSach.Model.AppData;
using QuanLyNhaSach.Validation;
using QuanLyNhaSach.View.TaiKhoan;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaSach.Presenter
{
    public class TaiKhoanPresenter

    {

        ITaiKhoanRepository repository;
        ITaiKhoanForm view;
        IModelStateWraper state;
        public TaiKhoanPresenter(ITaiKhoanForm _view, IModelStateWraper _state) : this(_view, new TaiKhoanRepository(), _state)
            {
            //state = _state;
            //view = _view;
            //repository = _repository;
            //_view.Presenter = this;
        }
        private TaiKhoanPresenter(ITaiKhoanForm _view, ITaiKhoanRepository _repository, IModelStateWraper _state)
        {
            state = _state;
            view = _view;
            repository = _repository;
            _view.Presenter = this;
        }

        public void getListTaiKhoan()
        {
            view.getListTaiKhoan = repository.getListTaiKhoan();

        }
        public void saveTaiKhoan()
        {
            //TAIKHOAN tk = repository.getTaiKhoan(view.selectedTaiKhoan);
            TAIKHOAN tk = ViewToModel();

            if (valid(tk) && checkExist(tk, false))
            {
                TAIKHOAN kq = repository.saveTaiKhoan(tk);

                //view.Log("Đã lưu thành công");
                getListTaiKhoan();
            }
        }
        public void editTaiKhoan()
        {

            TAIKHOAN tk_moi = ViewToModel();
            string matk_cu = view.selectedTaiKhoan;

            if (valid(tk_moi) && checkExist(tk_moi, tk_moi.USERNAME == matk_cu))
            {
                TAIKHOAN kq = repository.editTaiKhoan(tk_moi, matk_cu);


                getListTaiKhoan();
            }
        }
        public bool valid(TAIKHOAN tk)
        {
            //xet null
            state.Clear();
            if (tk.USERNAME == "")
                state.addError("username", "Tên tài khoản không được để trống");
            if (tk.PASSWORD == "")
                state.addError("password", "Mật khẩu không được để trống");
            if (tk.CHUCVU == "")
                state.addError("chucvu", "Chức vụ không được để trống");
            //if (tk.MATAIKHOAN.Length > 2)
            //    state.addError("malinhvuc2", "Mã lĩnh vực không dài quá 2 kí tự");
            //if (tk.NAMSINH >= tk.NAMMAT)
            //        state.addError("nam", "Năm sinh phải nhỏ hơn năm mất");

            return state.isValid();


        }
        private bool checkExist(TAIKHOAN tk, bool b)
        {
            if (b) { return true; }
            foreach (TAIKHOAN i in repository.getListTaiKhoan())
            {
                if (tk.USERNAME == i.USERNAME)
                {
                    state.addError("sameusername", "Tên tài khoản đã tồn tại");
                    return false;
                }

            }


            return true;
        }
        public void deleteTaiKhoan()
        {
            //TAIKHOAN tk = repository.getTaiKhoan(view.selectedTaiKhoan);
            string matk = view.selectedTaiKhoan;
            if (matk != "")
            {
                TAIKHOAN tk = repository.getTaiKhoan(matk);
                if (valid(tk))
                {
                    TAIKHOAN kq = repository.deleteTaiKhoan(matk);

                    //view.Log("Đã lưu thành công");
                    getListTaiKhoan();
                }
            }
        }

        public void showSelected()
        {
            if (view.selectedTaiKhoan != "")
            {
                TAIKHOAN tk = repository.getTaiKhoan(view.selectedTaiKhoan);
                ModelToView(tk);
                //view.TaiKhoan = tk;
            }
        }
        private void ModelToView(TAIKHOAN tk)
        {
            view.USERNAME = tk.USERNAME;
            view.TEN = tk.TEN;
            view.NGAYLAMVIEC = tk.NGAYLAMVIEC;
            view.PASSWORD= tk.PASSWORD;
            view.CHUCVU = tk.CHUCVU;


        }
        private TAIKHOAN ViewToModel()
        {
            TAIKHOAN tk = new TAIKHOAN();
            tk.USERNAME = view.USERNAME;
            tk.TEN = view.TEN;
            tk.NGAYLAMVIEC = view.NGAYLAMVIEC;
            tk.PASSWORD = view.PASSWORD;
            tk.CHUCVU = view.CHUCVU;
            return tk;

        }


    }
}
