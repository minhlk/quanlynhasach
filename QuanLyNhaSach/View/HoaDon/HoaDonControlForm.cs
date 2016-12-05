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

namespace QuanLyNhaSach.View.HoaDon
{
    public partial class HoaDonControlForm : UserControl, IHoaDonForm
    {
        ModelState state;
        
        public HoaDonControlForm():this(new ModelState())
        {
           
            InitializeComponent();
        }
        HoaDonControlForm(ModelState _state)
        {
            state = _state;
            new HoaDonPresenter(this, new ModelStateWraper(state));

        }
        public object getListHoaDon
        {
            get
            {
                return dataGridView1.DataSource;
            }

            set
            {
                dataGridView1.DataSource = value;
                if (dataGridView1.DisplayedRowCount(true) != 0)
                {
                    dataGridView1.Columns[0].HeaderText = "Mã Hóa Đơn";
                    dataGridView1.Columns[1].HeaderText = "Tên Khách hàng";
                    dataGridView1.Columns[2].HeaderText = "Ngày lập";
                    dataGridView1.Columns[3].HeaderText = "Tổng tiền";
                    dataGridView1.Columns[4].Visible = false;

                }
            }
        }

        //public HOADON HoaDon
        //{
        //    get
        //    {

        //        hoadon.TENKHACHHANG = TextField1.Text;

        //        if (!CheckBox1.Checked) { hoadon.NGAYLAP = DateTime.Parse(dateTimePicker1.Value.ToShortDateString()); }
        //        else hoadon.NGAYLAP = null;
        //        int a;
        //        if (int.TryParse(TextField2.Text, out a))
        //        {
        //            hoadon.TONGTIEN = int.Parse(TextField2.Text);
        //        }

        //        else
        //            hoadon.TONGTIEN = 0;
        //        return hoadon;
        //    }

        //    set
        //    {
        //        HOADON hoadon = value;
        //        TextField1.Text = hoadon.TENKHACHHANG;
        //        if (hoadon.NGAYLAP == null)
        //            CheckBox1.Checked = true;
        //        else
        //        {

        //            dateTimePicker1.Text = hoadon.NGAYLAP.ToString();
        //            CheckBox1.Checked = false;
        //        }

        //        TextField2.Text = hoadon.TONGTIEN.ToString() ;

        //    }
        //}

        public HoaDonPresenter Presenter
        {
            set; get;
        }

        public string selectedHoaDon
        {
            get
            {
                if (dataGridView1.DisplayedRowCount(true) != 0)
                {
                    int pos = dataGridView1.CurrentCell.RowIndex;
                    return dataGridView1.Rows[pos].Cells[0].Value.ToString();
                }
                return "";
            }
        }

        public string TENKHACHHANG
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

        public DateTime? NGAYLAP
        {
            get
            {
                if (!CheckBox1.Checked) { return DateTime.Parse(dateTimePicker1.Value.ToShortDateString()); }
                else return null;
            }

            set
            {
                DateTime? date = value;
                if (date == null)
                    CheckBox1.Checked = true;
                else
                {

                    dateTimePicker1.Text = date.ToString();
                    CheckBox1.Checked = false;
                }
            }
        }

        public decimal? TONGTIEN
        {
            get
            {
                int a;
                if (int.TryParse(numericUpDown1.Text, out a))
                {
                    return int.Parse(numericUpDown1.Text);
                }

                else
                    return 0;
            }

            set
            {
                numericUpDown1.Text = value.ToString();
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
                    case "tenkhach": errorProvider1.SetError(TextField1, err.Value); break;
                    case "tongtien":
                        errorProvider1.SetError(numericUpDown1, err.Value);
                        break;


                }


            }
        }

     

        private void Button1_Click(object sender, EventArgs e)
        {
            Presenter.saveHoaDon();
            showError();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Presenter.editHoaDon();

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Presenter.deleteHoaDon();
            showError();
        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            if (!DesignMode) {
                Presenter.getListHoaDon();
                Presenter.showSelected();
            }
        }

        private void HoaDonForm_Load(object sender, EventArgs e)
        {
            if (!DesignMode)
            {
                Presenter.getListHoaDon();
                Presenter.showSelected();
            }
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Presenter.showSelected();
        }
    }
}
