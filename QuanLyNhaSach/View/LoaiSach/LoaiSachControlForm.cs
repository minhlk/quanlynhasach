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

namespace QuanLyNhaSach.View.LoaiSach
{
    public partial class LoaiSachControlForm : UserControl, ILoaiSachForm
    {
        ModelState state;
        public LoaiSachControlForm():this(new ModelState())
        {
            
            InitializeComponent();
        }
        LoaiSachControlForm(ModelState _state)
        {
            state = _state;
            new LoaiSachPresenter(this, new ModelStateWraper(state));

        }
        public object getListLoaiSach
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
                    dataGridView1.Columns[0].HeaderText = "Mã Loại Sách";
                    dataGridView1.Columns[1].HeaderText = "Tên Loại Sách";
                    dataGridView1.Columns[2].Visible = false;
                }
            }
        }

        public string MALOAISACH
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

        public LoaiSachPresenter Presenter
        {
            get; set;
        }

        public string selectedLoaiSach
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

        public string TENLOAISACH
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

        public DialogResult Log(string mes)
        {
            return MessageBox.Show(mes, "Xác Nhận", MessageBoxButtons.YesNo);
        }

        public void showError()
        {
            errorProvider1.Clear();
            foreach (var err in state)
            {
                switch (err.Key)
                {
                    case "maloaisach": errorProvider1.SetError(TextField1, err.Value); break;
                    case "maloaisach2": errorProvider1.SetError(TextField1, err.Value); break;
                    case "maloaisach3": errorProvider1.SetError(TextField1, err.Value); break;

                }
            }
        }
    

        private void LoaiSachForm_Load(object sender, EventArgs e)
        {
            if (!DesignMode)
            {

                Presenter.getListLoaiSach();
                Presenter.showSelected();
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Presenter.saveLoaiSach();
            showError();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Presenter.editLoaiSach();
            showError();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Presenter.deleteLoaiSach();
            //showError();
        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            if (!DesignMode) {

                Presenter.getListLoaiSach();
                Presenter.showSelected();
            }
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Presenter.showSelected();
        }
    }
}
