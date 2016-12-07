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
    public partial class ThongKeControlForm : UserControl,IThongKe
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
                if (dataGridView1.Rows.Count != 0) {

                    dataGridView1.Columns[0].HeaderText = "Mã hóa đơn";
                    dataGridView1.Columns[1].HeaderText = "Tên khách";
                    dataGridView1.Columns[2].HeaderText = "Ngày lập";
                    dataGridView1.Columns[3].HeaderText = "Tổng tiền";
                    dataGridView1.Columns[4].HeaderText = "Mã sách";
                    dataGridView1.Columns[5].HeaderText = "Tên sách";
                    dataGridView1.Columns[6].HeaderText = "Số lượng";
                    dataGridView1.Columns[7].HeaderText = "Giá mua";
                    dataGridView1.Columns[8].HeaderText = "Mức giảm giá";
                }
            }
        }

        public object getListSach
        {
            set
            {
                //c.MASACH, c.TENSACH, c.GIAMUA, d.TONGSOLUONG, d.SOLUONGCON, e.NGAYNHAP, e.SOLUONG ,f.GIABIA}
                  
                dataGridView1.DataSource = value;
                if (dataGridView1.Rows.Count != 0)
                {

                    dataGridView1.Columns[0].HeaderText = "Mã sách";
                    dataGridView1.Columns[1].HeaderText = "Tên sách";
                    dataGridView1.Columns[2].HeaderText = "Giá mua";
                    dataGridView1.Columns[3].HeaderText = "Tổng số lượng";
                    dataGridView1.Columns[4].HeaderText = "Số lượng còn";
                    dataGridView1.Columns[5].HeaderText = "Ngày nhập";
                    dataGridView1.Columns[6].HeaderText = "Số lượng";
                    dataGridView1.Columns[7].HeaderText = "Giá bìa";
                   
                }
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
            if (!DesignMode)
            {
                Presenter.getListSach();
                Presenter.getTongChi();
                Presenter.getTongThu();
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (materialTabControl1.SelectedTab == tabPage1)
                Presenter.getListSach();
            else
                Presenter.getListHoaDon();
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            if (materialTabControl1.SelectedTab == tabPage1)
                Presenter.getListSachTime();
            else
                Presenter.getListHoaDonTime();
            
        }

        private void materialTabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (materialTabControl1.SelectedTab == tabPage1)
                Presenter.getListSach();
            else
                Presenter.getListHoaDon();
        }
    }
}
