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

namespace QuanLyNhaSach.View.TaiKhoan
{
    public partial class TaiKhoanForm : MaterialForm,ITaiKhoanForm
    {
        ModelState state;
        public TaiKhoanForm():this(new ModelState())
        {
            InitTheme();
            InitializeComponent();
        }
        TaiKhoanForm(ModelState _state)
        {
            state = _state;
            new TaiKhoanPresenter(this, new ModelStateWraper(state));

        }
        public string CHUCVU
        {
            get
            {
                return materialSingleLineTextField2.Text;
            }

            set
            {
                materialSingleLineTextField2.Text = value;
            }
        }

        public object getListTaiKhoan
        {
            get
            {
                return dataGridView1.DataSource;
            }

            set
            {
                dataGridView1.DataSource = value;
            }
        }

        //public string ID
        //{
        //    get
        //    {
        //        return TextField1.Text;
        //    }

        //    set
        //    {
        //        TextField1.Text = value;
        //    }
        //}

        public DateTime? NGAYLAMVIEC
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

        public string PASSWORD
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

        public TaiKhoanPresenter Presenter
        {
            get;set;
        }

        public string selectedTaiKhoan
        {
            get
            {
                int pos = dataGridView1.CurrentCell.RowIndex;
                return dataGridView1.Rows[pos].Cells[0].Value.ToString();
            }
        }

        public string TEN
        {
            get
            {
                return materialSingleLineTextField1.Text;
            }

            set
            {
                materialSingleLineTextField1.Text = value;
            }
        }

        public string USERNAME
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
                    case "sameusername": errorProvider1.SetError(TextField1, err.Value); break;
                    case "username": errorProvider1.SetError(TextField1, err.Value); break;
                    case "password": errorProvider1.SetError(TextField2, err.Value); break;
                    case "chucvu": errorProvider1.SetError(materialSingleLineTextField2, err.Value); break;

                }
            }
        }

        private void TaiKhoanForm_Load(object sender, EventArgs e)
        {
            Presenter.getListTaiKhoan();   
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
            Presenter.saveTaiKhoan();
            showError();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Presenter.editTaiKhoan();
            showError();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Presenter.deleteTaiKhoan();
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
