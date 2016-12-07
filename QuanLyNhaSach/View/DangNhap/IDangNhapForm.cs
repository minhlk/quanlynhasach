namespace QuanLyNhaSach.View.DangNhap
{
    public interface IDangNhapForm
    {

        string userName { get; }
        string passWord { get;  }
        Presenter.DangNhapPresenter Presenter { set; }
        void openForm();
        void showError();
    }
}