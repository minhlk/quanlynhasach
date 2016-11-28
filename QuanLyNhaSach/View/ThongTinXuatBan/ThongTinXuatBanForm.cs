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

namespace QuanLyNhaSach.View.ThongTinXuatBan
{
    public partial class ThongTinXuatBanForm : MaterialForm,IThongTinXuatBanForm
    {
        ModelState state;
        public ThongTinXuatBanForm():this(new ModelState())
        {
            InitTheme();
            InitializeComponent();
        }
        ThongTinXuatBanForm(ModelState _state)
        {
            state = _state;
            new ThongTinXuatBanPresenter(this, new ModelStateWraper(state));

        }

        public object getListMasach
        {
            set
            {
                comboBox1.DataSource = value;
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
                dataGridView1.Columns[5].Visible = false;
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
                return comboBox1.Text;
            }

            set
            {
                Label4.Text=value;
                
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
                int pos = dataGridView1.CurrentCell.RowIndex;
                //Log(dataGridView1.Rows[pos].Cells[0].Value.ToString());
                return dataGridView1.Rows[pos].Cells[0].Value.ToString();
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
                    case "sach": errorProvider1.SetError(comboBox1, err.Value); break;
                    


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

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ThongTinXuatBanForm_Load(object sender, EventArgs e)
        {
            Presenter.getListThongTinXuatBan();
            
        }

       

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellMouseEventArgs e)
        {
                Presenter.showSelected();
        }
    }
}
