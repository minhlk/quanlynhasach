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

namespace QuanLyNhaSach.View.ChiTietHoaDon
{
    public partial class ChiTietHoaDonControlForm : UserControl, IChiTietHoaDonForm
    {
        ModelState state;
        public ChiTietHoaDonControlForm():this(new ModelState())
        {
            InitializeComponent();
            
        }
        ChiTietHoaDonControlForm(ModelState _state)
        {
            state = _state;
            new ChiTietHoaDonPresenter(this, new ModelStateWraper(state));

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
                if (dataGridView1.Rows.Count != 0)
                {
                    dataGridView1.Columns[0].HeaderText = "Mã hóa đơn";
                    dataGridView1.Columns[1].HeaderText = "Mã sách";
                    dataGridView1.Columns[2].HeaderText = "Số lượng";
                    dataGridView1.Columns[3].HeaderText = "Mức giảm giá";
                    dataGridView1.Columns[4].Visible = false;
                    dataGridView1.Columns[5].Visible = false;
                }
            }
        }

        public object getListSach
        {
            get
            {
                return dataGridView3.DataSource;
            }

            set
            {
                dataGridView3.DataSource = value;
            }
        }
        public int MAHOADON
        {
            get
            {
                int i;
                if (!int.TryParse(materialLabel3.Text, out i))
                    return -1;
                //check null
                return Convert.ToInt32(materialLabel3.Text);
               
            }

            set
            {
                materialLabel3.Text = value.ToString();
            }
        }

        public string MASACH
        {
            get
            {
                return materialLabel4.Text;
                
            }

            set
            {
                materialLabel4.Text = value;
               
            }
        }

        public int? MUCGIAMGIA
        {
            get
            {
                return Convert.ToInt32(numericUpDown2.Value);
            }

            set
            {
                numericUpDown2.Value = Convert.ToInt32(value);
            }
        }

        public ChiTietHoaDonPresenter Presenter
        {
            get; set;
        }

        public int selectedHoaDon
        {
            get
            {
                if (dataGridView1.Rows.Count != 0)
                {
                    int pos = dataGridView1.CurrentCell.RowIndex;
                    return Convert.ToInt32(dataGridView1.Rows[pos].Cells[0].Value.ToString());
                }
                return -1;
            }
        }
        public int selectedMaHoaDon
        {
            get
            {
                if (dataGridView2.Rows.Count != 0)
                {
                    int pos = dataGridView2.CurrentCell.RowIndex;
                    return Convert.ToInt32(dataGridView2.Rows[pos].Cells[0].Value.ToString());
                }
                return -1;
            }
        }
        public string selectedMaSach
        {
            get
            {
                if (dataGridView3.Rows.Count != 0)
                {
                    int pos = dataGridView3.CurrentCell.RowIndex;
                    return dataGridView3.Rows[pos].Cells[0].Value.ToString();
                }
                return "";
            }
        }
        public int? SOLUONG
        {
            get
            {
                return Convert.ToInt32(numericUpDown1.Value);
            }

            set
            {
                numericUpDown1.Value = Convert.ToInt32(value);
            }
        }

        public object getListMaHoaDon
        {
            get
            {
                return dataGridView2.DataSource;
            }

            set
            {
                dataGridView2.DataSource = value;
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
                    case "mahoadon": errorProvider1.SetError(materialRaisedButton1, err.Value); break;
                    case "mahoadon2": errorProvider1.SetError(materialRaisedButton1, err.Value); break;
                    case "masach": errorProvider1.SetError(materialRaisedButton2, err.Value); break;
                        //case "sach": errorProvider1.SetError(comboBox1, err.Value); break;
                        //case "lonhon":
                        //    errorProvider1.SetError(numericUpDown1, err.Value);
                        //    errorProvider1.SetError(numericUpDown2, err.Value);
                        //    break;


                }


            }
        }
      

        private void ChiTietHoaDonForm_Load(object sender, EventArgs e)
        {
            if (!DesignMode)
            {
                Presenter.getListChiTietHoaDon();
                Presenter.showSelected();
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Presenter.saveChiTietHoaDon();
            showError();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Presenter.editChiTietHoaDon();
            showError();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Presenter.deleteChiTietHoaDon();
        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            if (!DesignMode) {
                Presenter.getListChiTietHoaDon();
                Presenter.showSelected();
            }
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Presenter.showSelected();
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            if (!dataGridView2.Visible)
            {
                dataGridView2.Visible = true;
                Presenter.getListMaHoaDon();

            }
            else dataGridView2.Visible = false;
        }

        private void materialRaisedButton2_Click(object sender, EventArgs e)
        {
            if (!dataGridView3.Visible)
            {
                dataGridView3.Visible = true;
                Presenter.getListMasach();

            }
            else dataGridView3.Visible = false;
        }

        private void dataGridView2_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
             Presenter.showSelectedMaHoaDon();
            dataGridView2.Visible = false;
        }

        private void dataGridView3_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
           
            Presenter.showSelectedMaSach();
            dataGridView3.Visible = false;
        }
    }
}
