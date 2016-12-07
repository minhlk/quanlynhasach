using QuanLyNhaSach.Model;
using QuanLyNhaSach.View.ThongKe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaSach.Presenter
{
    public class ThongKePresenter
    {

        IThongKe view;
        IThongKeRepository repository;
        public ThongKePresenter(IThongKe _view):this(_view,new ThongKeRepository()) {
           
        }
        public ThongKePresenter(IThongKe _view, IThongKeRepository _repository) {
            this.view = _view;
            repository = _repository;
            _view.Presenter = this;
        }
        public void getListHoaDon() {

            if (view.MaHoaDon && view.GiaTriTimKiem != "")
            {
                if (repository.getListHoaDon(Convert.ToInt32(view.GiaTriTimKiem)) != null)
                    view.getListHoaDon = repository.getListHoaDon(Convert.ToInt32(view.GiaTriTimKiem));
            }
            else if (view.MaSach2 && view.GiaTriTimKiem != "") {
                if (repository.getListHoaDon(view.GiaTriTimKiem) != null)
                    view.getListHoaDon = repository.getListHoaDon(view.GiaTriTimKiem);
            }
            else if (!view.MaHoaDon && !view.MaSach2 || view.GiaTriTimKiem == "")
            {
                if(repository.getListHoaDon()!=null)
                view.getListHoaDon = repository.getListHoaDon();
            }
        }
        public void getListHoaDonTime() {
            if (repository.getListHoaDon(view.NgayBatDau, view.NgayKetThuc) != null)
                view.getListHoaDon = repository.getListHoaDon(view.NgayBatDau, view.NgayKetThuc);

        }
        public void getListSach() {
            if (view.MaSach&& view.GiaTriTimKiem != "") {
                if (repository.getListSach(view.GiaTriTimKiem) != null)
                view.getListSach = repository.getListSach(view.GiaTriTimKiem);
            }

            else if (view.TenSach&&view.GiaTriTimKiem!="") {
                if(repository.getListSachName(view.GiaTriTimKiem)!=null)
                view.getListSach= repository.getListSachName(view.GiaTriTimKiem);

            }


            else if (!view.MaSach && !view.TenSach||view.GiaTriTimKiem=="") {
                if (repository.getListSach() != null)

                    view.getListSach = repository.getListSach();
            }


           
        }
        public void getListSachTime() {
            if(repository.getListSach(view.NgayBatDau, view.NgayKetThuc)!=null)
            view.getListSach = repository.getListSach(view.NgayBatDau,view.NgayKetThuc);


        }
        public void getTongChi()
        {
           
           view.TongChi= repository.getTongChi();

        }
        public void getTongThu()
        {

            view.TongThu= repository.getTongThu();
        }
    }
}
