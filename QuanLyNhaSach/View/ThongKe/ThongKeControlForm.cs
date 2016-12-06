using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyNhaSach.Presenter;

namespace QuanLyNhaSach.View.ThongKe
{
    public partial class ThongKeControlForm : Form,IThongKe
    {
        public ThongKeControlForm()
        {
            InitializeComponent();
            new ThongKePresenter(this);
        }

        public object getListHoaDon
        {
            set
            {
                dataGridView1.DataSource = value;
            }
        }

        public object getListSach
        {
            set
            {
                dataGridView1.DataSource = value;
            }
        }

        public string GiaTriTimKiem
        {
            get
            {
                return TextField1.Text;
            }
        }

        public bool MaHoaDon
        {
            get
            {
                return checkBox3.Checked;
            }
        }

        public bool MaSach
        {
            get
            {
                return checkBox1.Checked;

            }
        }

        public bool MaSach2
        {
            get
            {
                
                return checkBox4.Checked;
            }
        }

        public DateTime NgayBatDau
        {
            get
            {
                return Convert.ToDateTime(dateTimePicker1.Value.ToShortDateString());
            }
        }

        public DateTime NgayKetThuc
        {
            get
            {
                return Convert.ToDateTime(dateTimePicker2.Value.ToShortDateString());
            }
        }

        public ThongKePresenter Presenter
        {
            set; get;
        }

        public bool TenSach
        {
            get
            {
                return checkBox2.Checked;
            }
        }

        public int TongChi
        {
            set
            {
                materialLabel5.Text = value.ToString();
            }
        }

        public int TongThu
        {
            set
            {
                materialLabel6.Text = value.ToString();
            }
        }

        private void ThongKeControlForm_Load(object sender, EventArgs e)
        {
            Presenter.getListSach();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Presenter.getListSach();
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            Presenter.getListSachTime();
        }
    }
}
