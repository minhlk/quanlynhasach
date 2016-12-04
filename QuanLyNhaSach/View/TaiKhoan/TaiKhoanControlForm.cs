using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyNhaSach.Validation;
using QuanLyNhaSach.Presenter;

namespace QuanLyNhaSach.View.TaiKhoan
{
    public partial class TaiKhoanControlForm : UserControl, ITaiKhoanForm
    {
        ModelState state;
        public TaiKhoanControlForm():this(new ModelState())
        {
           
            InitializeComponent();
        }
        TaiKhoanControlForm(ModelState _state)
        {
            state = _state;
            new TaiKhoanPresenter(this, new ModelStateWraper(state));

        }
        public string CHUCVU
        {
            get
            {
                return materialSingleLineTextField2.Text;
            }

            set
            {
                materialSingleLineTextField2.Text = value;
            }
        }

        public object getListTaiKhoan
        {
            get
            {
                return dataGridView1.DataSource;
            }

            set
            {
                dataGridView1.DataSource = value;
                if (dataGridView1.Rows.Count != 0)
                {

                    dataGridView1.Columns[0].HeaderText = "Tên đăng nhập";
                    dataGridView1.Columns[1].HeaderText = "Mật khẩu";
                    dataGridView1.Columns[2].HeaderText = "Tên ";
                    dataGridView1.Columns[3].HeaderText = "Ngày làm việc";
                    dataGridView1.Columns[4].HeaderText = "Chức vụ";
                }
            }
        }

        //public string ID
        //{
        //    get
        //    {
        //        return TextField1.Text;
        //    }

        //    set
        //    {
        //        TextField1.Text = value;
        //    }
        //}

        public DateTime? NGAYLAMVIEC
        {
            get
            {
                return Convert.ToDateTime(dateTimePicker1.Value.ToShortDateString());
            }

            set
            {
                dateTimePicker1.Value = Convert.ToDateTime(value);
            }
        }

        public string PASSWORD
        {
            get
            {
                return TextField2.Text;
            }

            set
            {
                TextField2.Text = value;
            }
        }

        public TaiKhoanPresenter Presenter
        {
            get; set;
        }

        public string selectedTaiKhoan
        {
            get
            {
                if (dataGridView1.Rows.Count != 0)
                {

                    int pos = dataGridView1.CurrentCell.RowIndex;
                    return dataGridView1.Rows[pos].Cells[0].Value.ToString();
                }
                else return "";
            }
        }

        public string TEN
        {
            get
            {
                return materialSingleLineTextField1.Text;
            }

            set
            {
                materialSingleLineTextField1.Text = value;
            }
        }

        public string USERNAME
        {
            get
            {
                return TextField1.Text;
            }

            set
            {
                TextField1.Text = value;
            }
        }

        public void Log(string mes)
        {
            MessageBox.Show(mes);
        }

        public void showError()
        {
            errorProvider1.Clear();
            foreach (var err in state)
            {
                switch (err.Key)
                {
                    case "sameusername": errorProvider1.SetError(TextField1, err.Value); break;
                    case "username": errorProvider1.SetError(TextField1, err.Value); break;
                    case "password": errorProvider1.SetError(TextField2, err.Value); break;
                    case "chucvu": errorProvider1.SetError(materialSingleLineTextField2, err.Value); break;

                }
            }
        }

        private void TaiKhoanForm_Load(object sender, EventArgs e)
        {
            if (!DesignMode)
            {

                Presenter.getListTaiKhoan();
                Presenter.showSelected();
            }
        }
       

        private void Button1_Click(object sender, EventArgs e)
        {
            Presenter.saveTaiKhoan();
            showError();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Presenter.editTaiKhoan();
            showError();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Presenter.deleteTaiKhoan();
        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            if (!DesignMode) {

                Presenter.getListTaiKhoan();
                Presenter.showSelected();
            }
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Presenter.showSelected();
        }
    }
}
