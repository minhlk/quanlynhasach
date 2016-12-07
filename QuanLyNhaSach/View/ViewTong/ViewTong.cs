using MaterialSkin;
using MaterialSkin.Controls;
using QuanLyNhaSach.View.Sach;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhaSach.View.ViewTong
{
    public partial class ViewTong : MaterialForm
    {
        public ViewTong()
        {
            InitializeComponent();
            InitTheme();
            //SachForm sach = new SachForm();
            //sach.TopLevel = false;

            //this.Controls.Add(sach);
            ////this.AllowDrop = false;
            //sach.Dock = DockStyle.Fill;
            //sach.FormBorderStyle = FormBorderStyle.None;
            ////sach.ControlBox = false;
            //sach.TopMost = true;
            //sach.Show();
        }
        private void InitTheme()
        {
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Purple400, Primary.Purple700, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }

        private void ViewTong_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
