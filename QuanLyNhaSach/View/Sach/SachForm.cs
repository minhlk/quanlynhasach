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

namespace QuanLyNhaSach.View.Sach
{
    public partial class SachForm : MaterialForm,ISachForm
    {
        ModelState state;
        public SachForm():this(new ModelState())
        {
            InitializeComponent();
            InitTheme();
        }
        SachForm(ModelState _state)
        {
            state = _state;
            new SachPresenter(this, new ModelStateWraper(state));

        }
        public object getListLinhVuc
        {
            get
            {
                return dataGridView4.DataSource;
            }

            set
            {
                dataGridView4.DataSource = value;
            }
        }

        public object getListLoaiSach
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

        public object getListSach
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

        public object getListTacGia
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

        public int? GIAMUA
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

        public string MALINHVUC
        {
            get
            {
                return Label8.Text;
            }

            set
            {
                Label8.Text = value;
            }
        }

        public string MALOAISACH
        {
            get
            {
                return Label7.Text;

            }

            set
            {
                Label7.Text = value;
            }
        }

        public string MASACH
        {
            get
            {
                return  TextField1.Text;
            }

            set
            {
                TextField1.Text = value.Trim();
            }
        }

        public int? MATG
        {
            get
            {
                return Convert.ToInt32(Label6.Text);
                //return 0;
            }

            set
            {
                Label6.Text = value.ToString();
            }
        }

        public SachPresenter Presenter
        {
            get;set;
        }

        public string selectedSach
        {
            get
            {
                int pos = dataGridView1.CurrentCell.RowIndex;
                return dataGridView1.Rows[pos].Cells[0].Value.ToString();
            }
        }

        public string TENSACH
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

        public int selectedTacGia
        {
            get
            {
                int pos = dataGridView2.CurrentCell.RowIndex;
                return Convert.ToInt32(dataGridView2.Rows[pos].Cells[0].Value.ToString());
            }
            set {
                Label6.Text = value.ToString();
            }
        }

        public string selectedLoaiSach
        {
            get
            {
                int pos = dataGridView3.CurrentCell.RowIndex;
                return dataGridView3.Rows[pos].Cells[0].Value.ToString();
            }
            set
            {
                Label7.Text = value;
            }
        }

        public string selectedLinhVuc
        {
            get
            {
                int pos = dataGridView4.CurrentCell.RowIndex;
                return dataGridView4.Rows[pos].Cells[0].Value.ToString();
            }
            set
            {
                Label8.Text = value;
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
                    case "masach": errorProvider1.SetError(TextField1, err.Value); break;
                            case "tensach": errorProvider1.SetError(TextField1, err.Value); break;
                        //case "tongsoluong": errorProvider1.SetError(numericUpDown2, err.Value); break;
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

        private void SachForm_Load(object sender, EventArgs e)
        {
            Presenter.getListSach();
            Presenter.showSelected();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Presenter.saveSach();
            showError();

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Presenter.editSach();
            showError();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Presenter.deleteSach();
        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Presenter.showSelected();
        }
        
    
            private void Button5_Click(object sender, EventArgs e)
            {
            if (dataGridView2.Visible)
            {
                dataGridView2.Visible = false;

            }
            else
            {
                dataGridView2.Visible = true;

                Presenter.getListTacGia();





            }

        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            if (dataGridView3.Visible)
            {
                dataGridView3.Visible = false;

            }
            else
            {
                dataGridView3.Visible = true;

                Presenter.getListLoaiSach();





            }
        }

        private void materialRaisedButton2_Click(object sender, EventArgs e)
        {
            if (dataGridView4.Visible)
            {
                dataGridView4.Visible = false;

            }
            else
            {
                dataGridView4.Visible = true;

                Presenter.getListLinhVuc();





            }
        }

        private void dataGridView2_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Presenter.showSelectedMaTacGia();
            ((DataGridView)sender).Visible = false;
        }

        private void dataGridView3_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Presenter.showSelectedMaLoaiSach();
            ((DataGridView)sender).Visible = false;
        }

        private void dataGridView4_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Presenter.showSelectedMaLinhVuc();
            ((DataGridView)sender).Visible = false;
        }

        private void materialLabel5_Click(object sender, EventArgs e)
        {

        }
    }
}
