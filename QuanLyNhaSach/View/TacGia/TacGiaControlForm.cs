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

namespace QuanLyNhaSach.View.TacGia
{
    public partial class TacGiaControlForm : UserControl, ITacGiaForm
    {
        ModelState state;

        public TacGiaControlForm() : this(new ModelState())
        {
            
            InitializeComponent();
        }
        TacGiaControlForm(ModelState _state)
        {
            state = _state;
            new TacGiaPresenter(this, new ModelStateWraper(state));

        }
        //public IEnumerable<TACGIA> getListTacGia
        public object getListTacGia
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
                    dataGridView1.Columns[0].HeaderText = " Mã Tác Giả";
                    dataGridView1.Columns[1].HeaderText = "Tên Tác Giả";
                    dataGridView1.Columns[2].HeaderText = "Năm Sinh";
                    dataGridView1.Columns[3].HeaderText =  "Năm Mất";
                    dataGridView1.Columns[4].HeaderText ="Quê Quán";
                    dataGridView1.Columns[5].Visible = false;

                }
                //dataGridView1.Columns[0].Visible = false;
                //dataGridView1.Columns[3].Visible = false;
                //dataGridView1.Columns[5].Visible = false;
            }
        }

        public TacGiaPresenter Presenter
        {
            set; get;
        }

        public string selectedTacGia
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

        //public TACGIA TacGia
        //{


        //    set
        //    {
        //        TACGIA tacgia = value;
        //        TextField1.Text = tacgia.TENTG;
        //        if (tacgia.NAMSINH == null)
        //            CheckBox1.Checked = true;
        //        else
        //        {

        //            dateTimePicker1.Text = tacgia.NAMSINH.ToString();
        //            CheckBox1.Checked = false;
        //        }
        //        if (tacgia.NAMMAT == null)
        //        {
        //            CheckBox2.Checked = true;
        //        }
        //        else
        //        {
        //            dateTimePicker2.Text = tacgia.NAMMAT.ToString();
        //            CheckBox2.Checked = false;
        //        }
        //        TextField2.Text = tacgia.QUEQUAN;

        //    }
        //}



        public string TENTG
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

        public DateTime? NAMSINH
        {
            get
            {
                if (!CheckBox1.Checked) { return DateTime.Parse(dateTimePicker1.Value.ToShortDateString()); }
                else return null;

            }

            set
            {
                DateTime? time = value;
                if (time == null)
                    CheckBox1.Checked = true;
                else
                {

                    dateTimePicker1.Text = time.ToString();
                    CheckBox1.Checked = false;
                }
            }
        }

        public DateTime? NAMMAT
        {
            get
            {
                if (!CheckBox2.Checked) { return DateTime.Parse(dateTimePicker2.Value.ToShortDateString()); }
                return null;
            }

            set
            {
                DateTime? time = value;
                if (time == null)
                    CheckBox2.Checked = true;
                else
                {

                    dateTimePicker2.Text = time.ToString();
                    CheckBox2.Checked = false;
                }
            }
        }

        public string QUEQUAN
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

        //public int MATG
        //{
        //    get
        //    {
        //        return Convert.ToInt32(materialSingleLineTextField1.Text);
        //    }

        //    set
        //    {
        //        materialSingleLineTextField1.Text = value.ToString();
        //    }
        //}

        public DialogResult Log(string mes)
        {
           return  MessageBox.Show(mes,"Xác Nhận",MessageBoxButtons.YesNo);
        }

      

        private void TacGiaForm_Load(object sender, EventArgs e)
        {
            if (!DesignMode)
            {
                Presenter.getListTacGia();
                Presenter.showSelected();
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Presenter.saveTacGia();
            showError();
            //MessageBox.Show(dateTimePicker2.Value.ToShortDateString());


        }

        public void showError()
        {
            errorProvider1.Clear();
            foreach (var err in state)
            {
                switch (err.Key)
                {
                    case "tentg": errorProvider1.SetError(TextField1, err.Value); break;
                    case "nam":
                        errorProvider1.SetError(dateTimePicker1, err.Value);
                        errorProvider1.SetError(dateTimePicker2, err.Value);
                        break;


                }


            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Presenter.deleteTacGia();



        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Presenter.editTacGia();

            showError();
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Presenter.showSelected();

        }

       
    }
}
