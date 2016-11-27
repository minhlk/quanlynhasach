using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyNhaSach.Presenter;
using QuanLyNhaSach.Validation;
using MaterialSkin;

namespace QuanLyNhaSach.View.LoaiSach
{
    public partial class LoaiSachForm : MaterialForm,ILoaiSachForm
    {
        ModelState state;
        public LoaiSachForm():this(new ModelState())
        {
            InitTheme();
            InitializeComponent();
        }
        LoaiSachForm(ModelState _state)
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
                dataGridView1.Columns[2].Visible = false;
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
                int pos = dataGridView1.CurrentCell.RowIndex;
                return dataGridView1.Rows[pos].Cells[0].Value.ToString();
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
                    case "maloaisach": errorProvider1.SetError(TextField1, err.Value); break;
                    case "maloaisach2": errorProvider1.SetError(TextField1, err.Value); break;
                    

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

        private void LoaiSachForm_Load(object sender, EventArgs e)
        {
            Presenter.getListLoaiSach();
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
            this.Close();
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Presenter.showSelected();
        }
    }
}
