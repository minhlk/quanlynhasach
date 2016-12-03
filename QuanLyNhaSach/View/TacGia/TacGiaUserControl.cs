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
    public partial class TacGiaUserControl : UserControl,ITacGiaForm       
    {
        ModelState state;

        public TacGiaUserControl():this(new ModelState())
        {
            
            InitializeComponent();
        }
        TacGiaUserControl(ModelState _state)
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

        public string TENTG
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public DateTime? NAMSINH
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public DateTime? NAMMAT
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public string QUEQUAN
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        private void TacGiaForm_Load(object sender, EventArgs e)
        {
            Presenter.getListTacGia();
        }

      
     
      

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Presenter.showSelected();

        }

        public void Log(string mes)
        {
            throw new NotImplementedException();
        }

        public void showError()
        {
            throw new NotImplementedException();
        }
    }
}
