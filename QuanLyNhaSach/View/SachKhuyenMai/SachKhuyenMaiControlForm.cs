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

namespace QuanLyNhaSach.View.SachKhuyenMai
{
    public partial class SachKhuyenMaiControlForm : UserControl, ISachKhuyenMaiForm
    {
        ModelState state;
        public SachKhuyenMaiControlForm():this(new ModelState())
        {
            InitializeComponent();
          
        }
        SachKhuyenMaiControlForm(ModelState _state)
        {
            state = _state;
            new SachKhuyenMaiPresenter(this, new ModelStateWraper(state));

        }
        public object getListSachKhuyenMai
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
                    dataGridView1.Columns[0].HeaderText = "Mã Sách";
                   dataGridView1.Columns[1].HeaderText = "Mức giảm giá";
                   dataGridView1.Columns[2].Visible = false;
                    //dataGridView1.Columns[3].Visible = false;
                    //dataGridView1.Columns[4].Visible = false;
                }
            }
        }

        public object getListMasach
        {
            set
            {
                dataGridView2.DataSource = value;
            }
        }

        public string MASACH
        {
            get
            {
                return materialLabel1.Text;
            }

            set
            {
                materialLabel1.Text = value;
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

        public SachKhuyenMaiPresenter Presenter
        {
            get; set;
        }

        public string selectedSackKhuyenMai
        {
            get
            {
                if (dataGridView1.Rows.Count != 0)
                {
                    int pos = dataGridView1.CurrentCell.RowIndex;
                    return dataGridView1.Rows[pos].Cells[0].Value.ToString();
                }
                return "";
            }
        }
        public string selectedMaSach
        {
            get
            {
                if (dataGridView2.Rows.Count != 0)
                {
                    int pos = dataGridView2.CurrentCell.RowIndex;
                    return dataGridView2.Rows[pos].Cells[0].Value.ToString();
                }
                return "";
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
                    case "masach": errorProvider1.SetError(materialRaisedButton1, err.Value); break;
                        //case "tongsoluong": errorProvider1.SetError(numericUpDown2, err.Value); break;
                        //case "sach": errorProvider1.SetError(comboBox1, err.Value); break;
                        //case "lonhon":
                        //    errorProvider1.SetError(numericUpDown1, err.Value);
                        //    errorProvider1.SetError(numericUpDown2, err.Value);
                        //    break;


                }


            }
        }
      

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            if (!DesignMode) {

                Presenter.getListSachKhuyenMai();
                Presenter.showSelected();
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Presenter.deleteSachKhuyenMai();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Presenter.editSachKhuyenMai();
            showError();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Presenter.saveSachKhuyenMai();
            showError();
        }

        private void SachKhuyenMaiForm_Load(object sender, EventArgs e)
        {
            if (!DesignMode)
            {

                Presenter.getListSachKhuyenMai();
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
                Presenter.getListMasach();

            }
            else dataGridView2.Visible = false;
        }

        private void dataGridView2_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Presenter.showSelectedMaSach();
            dataGridView2.Visible = false;
        }
    }
}
