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

namespace QuanLyNhaSach.View.ThongTinXuatBan
{
    public partial class ThongTinXuatBanControlForm : UserControl, IThongTinXuatBanForm
    {
        ModelState state;
        public ThongTinXuatBanControlForm():this(new ModelState())
        {
           
            InitializeComponent();
        }
        ThongTinXuatBanControlForm(ModelState _state)
        {
            state = _state;
            new ThongTinXuatBanPresenter(this, new ModelStateWraper(state));

        }

        public object getListMasach
        {
            set
            {
                dataGridView2.DataSource = value;
            }
        }

        public object getListThongTinXuatBan
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
                    dataGridView1.Columns[0].HeaderText = "Mã Sách";
                    dataGridView1.Columns[1].HeaderText = "Lần tái bản";
                    dataGridView1.Columns[2].HeaderText = "Năm xuất bản";
                    dataGridView1.Columns[3].HeaderText = "Nhà xuất bản ";
                    dataGridView1.Columns[4].HeaderText = "Giá bìa";
                    dataGridView1.Columns[5].Visible = false;
                }
            }
        }

        public int? GIABIA
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

        public int? LANTAIBAN
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

        public string MASACH
        {
            get
            {
                return Label4.Text;
            }

            set
            {
                Label4.Text = value;

            }
        }



        public string NHAXUATBAN
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

        public ThongTinXuatBanPresenter Presenter
        {
            get; set;
        }

        public string selectedThongTinXuatBan
        {
            get
            {
                if (dataGridView1.Rows.Count != 0)
                {
                    int pos = dataGridView1.CurrentCell.RowIndex;
                    //Log(dataGridView1.Rows[pos].Cells[0].Value.ToString());
                    return dataGridView1.Rows[pos].Cells[0].Value.ToString();
                }
                return "";
            }
        }

        DateTime? IThongTinXuatBanForm.NAMXUATBAN
        {
            get
            {
                if (!CheckBox1.Checked)
                    return Convert.ToDateTime(dateTimePicker1.Value.ToShortDateString());
                else return null;
            }

            set
            {
                if (value != null)
                {
                    dateTimePicker1.Value = Convert.ToDateTime(value);
                    CheckBox1.Checked = false;
                }
                else CheckBox1.Checked = true;
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
                    case "sach": errorProvider1.SetError(materialRaisedButton1, err.Value); break;



                }


            }
        }
       

        private void Button1_Click(object sender, EventArgs e)
        {
            Presenter.saveThongTinXuatBan();
            showError();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Presenter.editThongTinXuatBan();
            showError();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Presenter.deleteThongTinXuatBan();
            showError();
        }

       
        private void ThongTinXuatBanForm_Load(object sender, EventArgs e)
        {
            if (!DesignMode)
            {
                Presenter.getListThongTinXuatBan();
                Presenter.showSelected();
            }

        }



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Presenter.showSelected();
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
        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            if (!DesignMode)
            {
                Presenter.getListThongTinXuatBan();
                Presenter.showSelected();
            }
        }

        private void dataGridView2_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Presenter.showSelectedMaSach();
            dataGridView2.Visible = false;
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
    }
}
