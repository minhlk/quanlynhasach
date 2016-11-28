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

namespace QuanLyNhaSach.View.Kho
{
    public partial class KhoForm : MaterialForm,IKhoForm
    {
        ModelState state;
        public KhoForm():this(new ModelState())
        {
            InitializeComponent();
            InitTheme();
        }
        KhoForm(ModelState _state)
        {
            state = _state;
            new KhoPresenter(this, new ModelStateWraper(state));

        }
        public object getListKho
        {
            get
            {
                return dataGridView1.DataSource; 
            }

            set
            {
                dataGridView1.DataSource = value;
                //dataGridView1.Columns[0].Visible = false;
                dataGridView1.Columns[3].Visible = false;
                dataGridView1.Columns[4].Visible = false;
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
                Label2.Text = value;
            }
        }

        public KhoPresenter Presenter
        {
            get; set;
        }

        public string selectedKho
        {
            get
            {
                int pos = dataGridView1.CurrentCell.RowIndex;
                return dataGridView1.Rows[pos].Cells[0].Value.ToString();
            }
        }

        public int? SOLUONGCON
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

        public int? TONGSOLUONG
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

        public object getListMasach
        {
           

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
                    case "soluongcon": errorProvider1.SetError(numericUpDown1, err.Value); break;
                    case "tongsoluong": errorProvider1.SetError(numericUpDown2, err.Value); break;
                    case "sach": errorProvider1.SetError(comboBox1, err.Value); break;
                    case "lonhon":
                        errorProvider1.SetError(numericUpDown1, err.Value);
                        errorProvider1.SetError(numericUpDown2, err.Value);
                        break;


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
            Presenter.saveKho();
            showError();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Presenter.editKho();
            showError();

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Presenter.deleteKho();
            showError();
        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void KhoForm_Load(object sender, EventArgs e)
        {
            Presenter.getListKho();
            Presenter.showSelected();
            //Presenter.getListMasach();
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Presenter.showSelected();
        }
    }
}
