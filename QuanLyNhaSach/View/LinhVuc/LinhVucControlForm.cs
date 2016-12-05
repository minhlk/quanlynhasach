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

namespace QuanLyNhaSach.View.LinhVuc
{
    public partial class LinhVucControlForm : UserControl, ILinhVucForm

    {
        ModelState state;
        public LinhVucControlForm():this(new ModelState())
        {
           
            InitializeComponent();
        }
        LinhVucControlForm(ModelState _state)
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
                if (dataGridView1.DisplayedRowCount(true) != 0)
                {
                    dataGridView1.Columns[0].HeaderText = "Mã Lĩnh Vực";
                    dataGridView1.Columns[1].HeaderText = "Tên Lĩnh Vực";
                    dataGridView1.Columns[2].Visible = false;
                }
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
                if (dataGridView1.Rows.Count != 0)
                {

                    int pos = dataGridView1.CurrentCell.RowIndex;
                    return dataGridView1.Rows[pos].Cells[0].Value.ToString();
                }
                else return "";
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

        public DialogResult Log(string mes)
        {
          return  MessageBox.Show(mes, "Xác Nhận", MessageBoxButtons.YesNo);
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
        

        private void LinhVucForm_Load(object sender, EventArgs e)
        {
            if (!DesignMode)
            {
                Presenter.getListLinhVuc();
                Presenter.showSelected();
            }
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
            if (!DesignMode)
            {
                Presenter.getListLinhVuc();
                Presenter.showSelected();
            }
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Presenter.showSelected();
        }


    }
}
