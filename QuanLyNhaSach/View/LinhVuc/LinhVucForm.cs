using MaterialSkin;
using MaterialSkin.Controls;
using QuanLyNhaSach.Presenter;
using QuanLyNhaSach.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhaSach.View.LinhVuc
{
    public partial class LinhVucForm : MaterialForm,ILinhVucForm
   
    {
        ModelState state;
        public LinhVucForm():this(new ModelState())
        {
            InitTheme();
            InitializeComponent();
        }
        LinhVucForm(ModelState _state)
        {
            state = _state;
            new LinhVucPresenter(this, new ModelStateWraper(state));

        }
        public object getListLinhVuc
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

        public string MALINHVUC
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

        public LinhVucPresenter Presenter
        {
            get; set;
        }

        public string selectedLinhVuc
        {
            get
            {
                int pos = dataGridView1.CurrentCell.RowIndex;
                return dataGridView1.Rows[pos].Cells[0].Value.ToString();
            }
        }

        public string TENLINHVUC
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
                    case "malinhvuc": errorProvider1.SetError(TextField1, err.Value); break;
                    case "malinhvuc2": errorProvider1.SetError(TextField1, err.Value); break;
                    case "malinhvuc3": errorProvider1.SetError(TextField1, err.Value); break;


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

        private void LinhVucForm_Load(object sender, EventArgs e)
        {
            Presenter.getListLinhVuc();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Presenter.saveLinhVuc();
            showError();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Presenter.editLinhVuc();
            showError();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Presenter.deleteLinhVuc();
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

