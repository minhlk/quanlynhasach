using MaterialSkin;
using MaterialSkin.Controls;
using QuanLyNhaSach.View.HoaDon;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyNhaSach.Model.AppData;
using QuanLyNhaSach.Presenter;
using QuanLyNhaSach.Validation;
using QuanLyNhaSach.Model;

namespace QuanLyNhaSach.View
{
    public partial class HoaDonForm : MaterialForm,IHoaDonForm
    {
        ModelState state;
        public HOADON hoadon = new HOADON();
        public HoaDonForm():this(new ModelState())
        {
            InitTheme();
            InitializeComponent();
        }
         HoaDonForm(ModelState _state)
        {
            state = _state;
            new HoaDonPresenter(this, new ModelStateWraper(state));

        }
        public object getListHoaDon
        {
            get
            {
                return dataGridView1.DataSource ;
            }

            set
            {
                dataGridView1.DataSource = value;
                dataGridView1.Columns[0].Visible = false;
                dataGridView1.Columns[4].Visible = false;
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
                int pos = dataGridView1.CurrentCell.RowIndex;
                return dataGridView1.Rows[pos].Cells[0].Value.ToString();
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
                if (date==null)
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
                if (int.TryParse(TextField2.Text, out a))
                {
                    return int.Parse(TextField2.Text);
                }

                else
                    return  0;
            }

            set
            {
                TextField2.Text = value.ToString();
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
                        errorProvider1.SetError(TextField2, err.Value);
                        break;


                }


            }
        }

        private void InitTheme()
        {
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Purple400, Primary.Purple700, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
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
            this.Close();
        }

        private void HoaDonForm_Load(object sender, EventArgs e)
        {
            Presenter.getListHoaDon();
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Presenter.showSelected();
        }
    }
}
