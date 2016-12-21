using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyNhaSach.Presenter;

namespace QuanLyNhaSach.View.DangNhap
{
    public partial class DangNhapForm : MaterialForm,IDangNhapForm
    {
        public DangNhapForm()
        {
            InitializeComponent();
            new DangNhapPresenter(this);
        }

        public string passWord
        {
            get
            {
                return materialSingleLineTextField2.Text;
            }

           
        }

        public DangNhapPresenter Presenter
        {
            get; set;
        }

        public string userName
        {
            get
            {
               return materialSingleLineTextField1.Text;
            }

           
        }
        public void openForm()
        {
            this.Hide();
            ViewTong.ViewTong form = new ViewTong.ViewTong();
            form.Show();
            //this.Close();
        }
        public void showError()
        {
            MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu");
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            Presenter.checkExist();
        }

        private void DangNhapForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }

      
    }
}
