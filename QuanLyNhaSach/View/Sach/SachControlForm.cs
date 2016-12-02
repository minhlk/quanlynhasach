﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;
using QuanLyNhaSach.Presenter;
using QuanLyNhaSach.Validation;
using MaterialSkin;

namespace QuanLyNhaSach.View.Sach
{
    public partial class SachControlForm : UserControl, ISachForm
    {

        ModelState state;
        public SachControlForm():this(new ModelState())
        {
            InitializeComponent();
            //InitTheme();
        }
        SachControlForm(ModelState _state)
        {
            state = _state;
            new SachPresenter(this, new ModelStateWraper(state));

        }
        public object getListLinhVuc
        {
            get
            {
                return comboBox4.DataSource;
            }

            set
            {
                comboBox4.DataSource = value;
            }
        }

        public object getListLoaiSach
        {
            get
            {
                return comboBox3.DataSource;
            }

            set
            {
                comboBox3.DataSource = value;
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
                if (dataGridView1.DisplayedRowCount(true) != 0)
                {
                    dataGridView1.Columns[0].HeaderText = "Mã Sách";
                    dataGridView1.Columns[1].HeaderText = "Tên Sách";
                    dataGridView1.Columns[2].HeaderText = "Mã Tác Giả";
                    dataGridView1.Columns[3].HeaderText = "Mã Loại Sách";
                    dataGridView1.Columns[4].HeaderText = "Mã Lĩnh Vực";
                    dataGridView1.Columns[5].HeaderText = "Giá Mua";
                    dataGridView1.Columns[6].Visible = false;
                    dataGridView1.Columns[7].Visible = false;
                    dataGridView1.Columns[8].Visible = false;
                    dataGridView1.Columns[9].Visible = false;
                    dataGridView1.Columns[10].Visible = false;
                    dataGridView1.Columns[11].Visible = false;
                    dataGridView1.Columns[12].Visible = false;
                }

            }
        }

        public object getListTacGia
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
                return comboBox4.Text;
            }

            set
            {
                comboBox4.Text = value;
            }
        }

        public string MALOAISACH
        {
            get
            {
                return comboBox3.Text;

            }

            set
            {
                comboBox3.Text = value;
            }
        }

        public string MASACH
        {
            get
            {
                return TextField1.Text;
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
                return Convert.ToInt32(comboBox2.Text);
            }

            set
            {
                comboBox2.Text = value.ToString();
            }
        }

        public SachPresenter Presenter
        {
            get; set;
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
                    case "tensach": errorProvider1.SetError(TextField2, err.Value); break;
                        //case "tongsoluong": errorProvider1.SetError(numericUpDown2, err.Value); break;
                        //case "sach": errorProvider1.SetError(comboBox1, err.Value); break;
                        //case "lonhon":
                        //    errorProvider1.SetError(numericUpDown1, err.Value);
                        //    errorProvider1.SetError(numericUpDown2, err.Value);
                        //    break;


                }


            }
        }
        //private void InitTheme()
        //{
        //    var materialSkinManager = MaterialSkinManager.Instance;
        //    materialSkinManager.AddFormToManage(this);
        //    materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
        //    materialSkinManager.ColorScheme = new ColorScheme(Primary.Purple400, Primary.Purple700, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        //}

        private void SachForm_Load(object sender, EventArgs e)
        {
            Presenter.getListSach();
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
            //this.Close();
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Presenter.showSelected();
        }
    }
}
