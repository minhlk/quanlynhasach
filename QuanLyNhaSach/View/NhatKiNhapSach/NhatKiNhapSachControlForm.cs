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

namespace QuanLyNhaSach.View.NhatKiNhapSach
{
    public partial class NhatKiNhapSachControlForm : UserControl, INhatKiNhapSachForm
    {
        ModelState state;
        public NhatKiNhapSachControlForm():this(new ModelState())
        {
            InitializeComponent();
          
        }
        NhatKiNhapSachControlForm(ModelState _state)
        {
            state = _state;
            new NhatKiNhapSachPresenter(this, new ModelStateWraper(state));

        }
        public object getListNhatKiNhapSach
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
                    dataGridView1.Columns[0].Visible = false;
                    //dataGridView1.Columns[0].HeaderText = "Số thứ tự";
                    dataGridView1.Columns[1].HeaderText = "Mã Sách";
                    dataGridView1.Columns[2].HeaderText = "Số lượng";
                    dataGridView1.Columns[3].HeaderText = "Ngày nhập";
                    dataGridView1.Columns[4].Visible = false;
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
                return Label2.Text;
            }

            set
            {
                Label2.Text = value;
            }
        }

        public DateTime? NGAYNHAP
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

        public NhatKiNhapSachPresenter Presenter
        {
            get; set;
        }

        public int selectedNhatKiNhapSach
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

        public DialogResult Log(string mes)
        {
            return MessageBox.Show(mes, "Giá trị trùng lặp", MessageBoxButtons.YesNo);
        }

        public void showError()
        {
            errorProvider1.Clear();
            foreach (var err in state)
            {
                switch (err.Key)
                {
                    //case "soluongcon": errorProvider1.SetError(numericUpDown1, err.Value); break;
                    //case "tongsoluong": errorProvider1.SetError(numericUpDown2, err.Value); break;
                    case "sach": errorProvider1.SetError(materialRaisedButton1, err.Value); break;
                        //case "lonhon":
                        //    errorProvider1.SetError(numericUpDown1, err.Value);
                        //    errorProvider1.SetError(numericUpDown2, err.Value);
                        //    break;


                }


            }
        }

        private void NhatKiNhapSachForm_Load(object sender, EventArgs e)
        {
            if (!DesignMode)
            {

                Presenter.getListNhatKiNhapSach();
                Presenter.getListMasach();
                //Presenter.showSelected();
            }
        }
      

        private void Button1_Click(object sender, EventArgs e)
        {
            Presenter.saveNhatKiNhapSach();
            showError();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Presenter.editNhatKiNhapSach();
            showError();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Presenter.deleteNhatKiNhapSach();
        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            if (!DesignMode)
            {

                Presenter.getListNhatKiNhapSach();
                Presenter.getListMasach();
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
