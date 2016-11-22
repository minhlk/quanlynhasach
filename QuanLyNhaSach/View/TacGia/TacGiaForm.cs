﻿using MaterialSkin;
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
using QuanLyNhaSach.Model.AppData;
using QuanLyNhaSach.Presenter;
using QuanLyNhaSach.Validation;
using QuanLyNhaSach.Model;

namespace QuanLyNhaSach.View
{
    public partial class TacGiaForm : MaterialForm,ITacGiaForm
    {
        ModelState state;
        public TACGIA tacgia=new TACGIA();
        public TacGiaForm():this(new ModelState())
        {
            InitTheme();
            InitializeComponent();
        }
        TacGiaForm(ModelState _state)
        {
            state = _state;
            new TacGiaPresenter(this, new TacGiaRepository(), new ModelStateWraper(state));

        }
        public IEnumerable<TACGIA> getListTacGia
        {
            get
            {
                return dataGridView1.DataSource as IEnumerable<TACGIA>;
            }

            set
            {
                dataGridView1.DataSource = value;
                dataGridView1.Columns[0].Visible = false;
                //dataGridView1.Columns[3].Visible = false;
                dataGridView1.Columns[5].Visible = false;
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
                int pos = dataGridView1.CurrentCell.RowIndex;
                return dataGridView1.Rows[pos].Cells[0].Value.ToString();
            }
        }

        public TACGIA TacGia
        {
            get
            {
                
                tacgia.TENTG = TextField1.Text;
                if (!CheckBox2.Checked) { tacgia.NAMMAT = DateTime.Parse(dateTimePicker2.Value.ToShortDateString()); }
                else tacgia.NAMMAT = null;
                if (!CheckBox1.Checked) { tacgia.NAMSINH = DateTime.Parse(dateTimePicker1.Value.ToShortDateString()); }
                else tacgia.NAMSINH = null;
                tacgia.QUEQUAN = TextField2.Text;
                return tacgia;
            }

            set
            {
                TACGIA tacgia = value;
                TextField1.Text = tacgia.TENTG;
                if (tacgia.NAMSINH == null)
                    CheckBox1.Checked = true;
                else
                {
                    
                    dateTimePicker1.Text = tacgia.NAMSINH.ToString();
                    CheckBox1.Checked = false;
                }
                if (tacgia.NAMMAT == null)
                {
                    CheckBox2.Checked = true;
                }
                else
                {
                    dateTimePicker2.Text = tacgia.NAMMAT.ToString();
                    CheckBox2.Checked = false;
                }
                TextField2.Text = tacgia.QUEQUAN;
                
            }
        }

       

        public void Log(string mes)
        {
            MessageBox.Show(mes);
        }

        private void InitTheme()
        {
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Purple400, Primary.Purple700, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }

        private void TacGiaForm_Load(object sender, EventArgs e)
        {
            Presenter.getListTacGia();
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
            foreach (var err in state) {
                switch (err.Key)
                {
                    case "tentg": errorProvider1.SetError(TextField1, err.Value); break;
                    case "nam": errorProvider1.SetError(dateTimePicker1, err.Value);
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

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
