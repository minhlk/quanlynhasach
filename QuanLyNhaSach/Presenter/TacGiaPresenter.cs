using QuanLyNhaSach.Model;
using QuanLyNhaSach.Model.AppData;
using QuanLyNhaSach.Validation;
using QuanLyNhaSach.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaSach.Presenter
{
    public class TacGiaPresenter
    {
        ITacGiaRepository repository;
        ITacGiaForm view;
        IModelStateWraper state;
        public TacGiaPresenter(ITacGiaForm _view,ITacGiaRepository _repository,IModelStateWraper _state)
        {
            state = _state;
            view = _view;
            repository = _repository;
            _view.Presenter = this;
        }

        public void getListTacGia() {
            view.getListTacGia = repository.getListTacGia();

        }
        public void saveTacGia() {
            //TACGIA tg = repository.getTacGia(view.selectedTacGia);
            TACGIA tg = view.TacGia;

            if (valid(tg)) { 
                TACGIA kq = repository.saveTacGia(tg);
     
                 //view.Log("Đã lưu thành công");
                getListTacGia();
            }
        }
        public void editTacGia()
        {
           
            TACGIA tg_moi = view.TacGia;
            int tg_cu = int.Parse(view.selectedTacGia);

            if (valid(tg_moi))
            {
                TACGIA kq = repository.editTacGia(tg_moi,tg_cu);

               
                getListTacGia();
            }
        }
        public bool valid(TACGIA tg) {
            //xet null
            state.Clear();
            if (tg.TENTG == "")
                state.addError("tentg", "Tên tác giả không được để trống");
            if (tg.NAMSINH >= tg.NAMMAT)
                state.addError("nam", "Năm sinh phải nhỏ hơn năm mất");
            return state.isValid();


        }

        public void deleteTacGia()
        {
            //TACGIA tg = repository.getTacGia(view.selectedTacGia);
            int matg = int.Parse(view.selectedTacGia);
            TACGIA tacgia = repository.getTacGia(matg);
            if (valid(tacgia))
            {
                TACGIA kq = repository.deleteTacGia(matg);

                //view.Log("Đã lưu thành công");
                getListTacGia();
            }
        }

        public void showSelected() {
            TACGIA tg = repository.getTacGia(int.Parse(view.selectedTacGia));
            
            view.TacGia = tg;
        }


    }
}
