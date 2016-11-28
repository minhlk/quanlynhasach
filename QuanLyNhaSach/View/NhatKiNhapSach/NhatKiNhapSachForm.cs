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

namespace QuanLyNhaSach.View.NhatKiNhapSach
{
    public partial class NhatKiNhapSachForm : MaterialForm,INhatKiNhapSachForm
    {
        ModelState state;
        public NhatKiNhapSachForm():this(new ModelState())
        {
            InitializeComponent();
            InitTheme();
        }
        NhatKiNhapSachForm(ModelState _state)
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
                dataGridView1.Columns[0].Visible = false;
                dataGridView1.Columns[4].Visible = false;
            }
        }

        public object getListMasach
        {
            set
            {
                comboBox1.DataSource = value;
            }
        }

        public string MASACH
        {
            get
            {
                return comboBox1.Text;
            }

            set
            {
                comboBox1.Text = value;
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
            get;set;
        }

        public int selectedNhatKiNhapSach
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

        public DialogResult Log(string mes)
        {
            return MessageBox.Show(mes,"Giá trị trùng lặp", MessageBoxButtons.YesNo);
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
                    //case "sach": errorProvider1.SetError(comboBox1, err.Value); break;
                    //case "lonhon":
                    //    errorProvider1.SetError(numericUpDown1, err.Value);
                    //    errorProvider1.SetError(numericUpDown2, err.Value);
                    //    break;


                }


            }
        }

        private void NhatKiNhapSachForm_Load(object sender, EventArgs e)
        {
            Presenter.getListNhatKiNhapSach();
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
            this.Close();
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Presenter.showSelected();
        }
    }
}
