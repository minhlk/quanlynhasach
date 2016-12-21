using QuanLyNhaSach.Model;
using QuanLyNhaSach.Model.AppData;
using QuanLyNhaSach.Validation;
using QuanLyNhaSach.View.NhatKiNhapSach;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhaSach.Presenter
{
    public class NhatKiNhapSachPresenter

    {
        INhatKiNhapSachRepository repository;
        INhatKiNhapSachForm view;
        IModelStateWraper state;
        public NhatKiNhapSachPresenter(INhatKiNhapSachForm _view, IModelStateWraper _state) : this(_view, new NhatKiNhapSachRepository(), _state)
        {
            //state = _state;
            //view = _view;
            ////repository = _repository;
            //_view.Presenter = this;
        }
        private NhatKiNhapSachPresenter(INhatKiNhapSachForm _view, INhatKiNhapSachRepository _repository, IModelStateWraper _state)
        {
            state = _state;
            view = _view;
            repository = _repository;
            _view.Presenter = this;
        }
        public void getListNhatKiNhapSach()
        {
            if (repository.getListNhatKiNhapSach() != null)
            {
                view.getListNhatKiNhapSach = repository.getListNhatKiNhapSach();
                getListMasach();
            }
        }
        public void getListMasach()
        {
            if (repository.getListMaSach() != null)
                view.getListMasach = repository.getListMaSach();


        }
        public void showSelectedMaSach()
        {

            view.MASACH = view.selectedMaSach;

        }
        public void saveNhatKiNhapSach()
        {
            //NHATKINHAPSACH nhatkinhapsach = repository.getNhatKiNhapSach(view.selectedNhatKiNhapSach);
            NHATKINHAPSACH nhatkinhapsach = ViewToModel();


            if (valid(nhatkinhapsach) && repository.checkRepeat(nhatkinhapsach)==null)
            {
                NHATKINHAPSACH kq = repository.saveNhatKiNhapSach(nhatkinhapsach);

                //view.Log("Đã lưu thành công");
                getListNhatKiNhapSach();


            }
            else if ( repository.checkRepeat(nhatkinhapsach)!=null)
            {
                NHATKINHAPSACH temp = repository.checkRepeat(nhatkinhapsach);

                if (view.Log("Mã sách và thời gian trùng lặp,bạn có muốn cộng dồn vào số lượng cũ") == DialogResult.Yes)
                {
                    temp.SOLUONG = temp.SOLUONG + nhatkinhapsach.SOLUONG;
                    repository.editNhatKiNhapSach(temp, temp.STT);
                }
                getListNhatKiNhapSach();

            }
}
        public void editNhatKiNhapSach()
        {

            NHATKINHAPSACH nhatkinhapsach_moi = ViewToModel();
            if (view.selectedNhatKiNhapSach != -1)
            {
                int manhatkinhapsach_cu = Convert.ToInt32(view.selectedNhatKiNhapSach);
                nhatkinhapsach_moi.STT = manhatkinhapsach_cu;
                if (valid(nhatkinhapsach_moi) && repository.checkRepeat(nhatkinhapsach_moi) == null)
                {
                    nhatkinhapsach_moi.SOLUONG = nhatkinhapsach_moi.SOLUONG;
                    NHATKINHAPSACH kq = repository.editNhatKiNhapSach(nhatkinhapsach_moi, manhatkinhapsach_cu);


                    getListNhatKiNhapSach();
                }
                else
                if (valid(nhatkinhapsach_moi) && repository.checkRepeat(nhatkinhapsach_moi) != null)
                {
                    NHATKINHAPSACH temp = repository.checkRepeat(nhatkinhapsach_moi);

                    if (view.Log("Mã sách và thời gian trùng lặp,bạn có muốn cộng dồn vào số lượng cũ") == DialogResult.Yes)
                    {
                        temp.SOLUONG = temp.SOLUONG + nhatkinhapsach_moi.SOLUONG;
                        repository.editNhatKiNhapSach(temp, temp.STT);
                        repository.deleteNhatKiNhapSach(manhatkinhapsach_cu);


                    }
                    getListNhatKiNhapSach();

                }
            }
        }
        public bool valid(NHATKINHAPSACH nhatkinhapsach)
        {
            //xet null
            state.Clear();
            //if (nhatkinhapsach.SOLUONGCON <0)
            //    state.addError("soluongcon", "Số lượng còn không được nhỏ hơn 0");
            //if (nhatkinhapsach.TONGSOLUONG < 0)
            //    state.addError("tongsoluong", "Tổng số lượng không được nhỏ hơn 0");
            //if (nhatkinhapsach.SOLUONGCON > nhatkinhapsach.TONGSOLUONG)
            //    state.addError("lonhon", "Số lượng còn không được lớn hơn tổng số lượng");
            //if (nhatkinhapsach.MASACH == "")
            //    state.addError("sach", "Không còn sách để thêm thông tin");
            if (nhatkinhapsach.MASACH == "a")
                state.addError("sach", "Chọn sách để thêm thông tin");
            return state.isValid();


        }

        public void deleteNhatKiNhapSach()
        {
            //NHATKINHAPSACH nhatkinhapsach = repository.getNhatKiNhapSach(view.selectedNhatKiNhapSach);
            if (view.selectedNhatKiNhapSach != -1)
            {
                int manhatkinhapsach = Convert.ToInt32(view.selectedNhatKiNhapSach);
                NHATKINHAPSACH nhatkinhapsach = repository.getNhatKiNhapSach(manhatkinhapsach);
                if (valid(nhatkinhapsach))
                {
                    NHATKINHAPSACH kq = repository.deleteNhatKiNhapSach(manhatkinhapsach);

                    //view.Log("Đã lưu thành công");
                    getListNhatKiNhapSach();
                }
            }
        }

        public void showSelected()
        {
            if (view.selectedNhatKiNhapSach != -1)
            {
                NHATKINHAPSACH nhatkinhapsach = repository.getNhatKiNhapSach(view.selectedNhatKiNhapSach);
                ModelToView(nhatkinhapsach);
                //view.NhatKiNhapSach = nhatkinhapsach;
            }
        }
        private void ModelToView(NHATKINHAPSACH nhatkinhapsach)
        {
            //view.STT=nhatkinhapsach.STT;
            view.MASACH = nhatkinhapsach.MASACH;
            view.NGAYNHAP = nhatkinhapsach.NGAYNHAP;
            view.SOLUONG = nhatkinhapsach.SOLUONG;
            


        }
        private NHATKINHAPSACH ViewToModel()
        {
            NHATKINHAPSACH nhatkinhapsach = new NHATKINHAPSACH();
            nhatkinhapsach.MASACH = view.MASACH;
            nhatkinhapsach.NGAYNHAP = view.NGAYNHAP;
            nhatkinhapsach.SOLUONG = view.SOLUONG;
            return nhatkinhapsach;

        }

    }
}
