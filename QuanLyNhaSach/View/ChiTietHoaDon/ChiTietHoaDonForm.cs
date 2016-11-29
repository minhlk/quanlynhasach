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

namespace QuanLyNhaSach.View.ChiTietHoaDon
{
    public partial class ChiTietHoaDonForm : MaterialForm,IChiTietHoaDonForm
    {
        ModelState state;
        public ChiTietHoaDonForm():this(new ModelState())
        {
            InitializeComponent();
            InitTheme();
        }
        ChiTietHoaDonForm(ModelState _state)
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
                dataGridView1.Columns[4].Visible = false;
                dataGridView1.Columns[5].Visible = false;
            }
        }

        public object getListSach
        {
            get
            {
                return comboBox2.DataSource;
            }

            set
            {
                comboBox2.DataSource = value;
            }
        }
        public int MAHOADON
        {
            get
            {
                int i;
                if (!int.TryParse(comboBox1.Text, out i))
                    return -1;
                         //check null
                return Convert.ToInt32(comboBox1.Text);
            }

            set
            {
                comboBox1.Text = value.ToString();
            }
        }

        public string MASACH
        {
            get
            {
                return comboBox2.Text; //check null
            }

            set
            {
                comboBox2.Text = value;
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
                int pos = dataGridView1.CurrentCell.RowIndex;
                return Convert.ToInt32(dataGridView1.Rows[pos].Cells[0].Value.ToString());
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
                return comboBox1.DataSource;
            }

            set
            {
                comboBox1.DataSource = value;
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
                    case "mahoadon": errorProvider1.SetError(comboBox1, err.Value); break;
                    case "masach": errorProvider1.SetError(comboBox2, err.Value); break;
                        //case "sach": errorProvider1.SetError(comboBox1, err.Value); break;
                        //case "lonhon":
                        //    errorProvider1.SetError(numericUpDown1, err.Value);
                        //    errorProvider1.SetError(numericUpDown2, err.Value);
                        //    break;


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

        private void ChiTietHoaDonForm_Load(object sender, EventArgs e)
        {
            Presenter.getListChiTietHoaDon();
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
            this.Close();
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Presenter.showSelected();
        }
    }
}
