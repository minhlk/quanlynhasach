using QuanLyNhaSach.Model;
using QuanLyNhaSach.View.DangNhap;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaSach.Presenter
{
    public class DangNhapPresenter
    {
        IDangNhapRepository repository;
        IDangNhapForm view;
        public DangNhapPresenter(IDangNhapForm _view) : this(_view, new DangNhapRepository())
        {
         
        }
        private DangNhapPresenter(IDangNhapForm _view, IDangNhapRepository _repository)
        {
           
            view = _view;
            repository = _repository;
            _view.Presenter = this;
        }
        public void checkExist() {
            if (repository.checkExist(view.userName, view.passWord)) view.openForm();
            else view.showError();
        }



    }
}
