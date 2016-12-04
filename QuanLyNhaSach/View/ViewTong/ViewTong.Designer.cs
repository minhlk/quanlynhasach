namespace QuanLyNhaSach.View.ViewTong
{
    partial class ViewTong
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.materialTabControl2 = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.sachControlForm1 = new QuanLyNhaSach.View.Sach.SachControlForm();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tacGiaControlForm1 = new QuanLyNhaSach.View.TacGia.TacGiaControlForm();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.thongTinXuatBanControlForm1 = new QuanLyNhaSach.View.ThongTinXuatBan.ThongTinXuatBanControlForm();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.linhVucControlForm1 = new QuanLyNhaSach.View.LinhVuc.LinhVucControlForm();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.loaiSachControlForm1 = new QuanLyNhaSach.View.LoaiSach.LoaiSachControlForm();
            this.tabPage8 = new System.Windows.Forms.TabPage();
            this.materialTabSelector2 = new MaterialSkin.Controls.MaterialTabSelector();
            this.taiKhoanControlForm1 = new QuanLyNhaSach.View.TaiKhoan.TaiKhoanControlForm();
            this.materialTabControl2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.tabPage7.SuspendLayout();
            this.tabPage8.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialTabControl2
            // 
            this.materialTabControl2.Controls.Add(this.tabPage3);
            this.materialTabControl2.Controls.Add(this.tabPage4);
            this.materialTabControl2.Controls.Add(this.tabPage5);
            this.materialTabControl2.Controls.Add(this.tabPage6);
            this.materialTabControl2.Controls.Add(this.tabPage7);
            this.materialTabControl2.Controls.Add(this.tabPage8);
            this.materialTabControl2.Depth = 0;
            this.materialTabControl2.Location = new System.Drawing.Point(41, 90);
            this.materialTabControl2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl2.Name = "materialTabControl2";
            this.materialTabControl2.SelectedIndex = 0;
            this.materialTabControl2.Size = new System.Drawing.Size(981, 419);
            this.materialTabControl2.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.Black;
            this.tabPage3.Controls.Add(this.sachControlForm1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(973, 393);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "Sách";
            // 
            // sachControlForm1
            // 
            this.sachControlForm1.BackColor = System.Drawing.Color.White;
            this.sachControlForm1.getListLinhVuc = null;
            this.sachControlForm1.getListLoaiSach = null;
            this.sachControlForm1.getListSach = null;
            this.sachControlForm1.getListTacGia = null;
            this.sachControlForm1.GIAMUA = 0;
            this.sachControlForm1.Location = new System.Drawing.Point(0, 0);
            this.sachControlForm1.MALINHVUC = "";
            this.sachControlForm1.MALOAISACH = "";
            this.sachControlForm1.MASACH = "";
            this.sachControlForm1.MATG = 0;
            this.sachControlForm1.Name = "sachControlForm1";
            this.sachControlForm1.selectedLinhVuc = "";
            this.sachControlForm1.selectedLoaiSach = "";
            this.sachControlForm1.selectedTacGia = 0;
            this.sachControlForm1.Size = new System.Drawing.Size(973, 390);
            this.sachControlForm1.TabIndex = 0;
            this.sachControlForm1.TENSACH = "";
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.White;
            this.tabPage4.Controls.Add(this.tacGiaControlForm1);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(192, 74);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "Tác Giả";
            // 
            // tacGiaControlForm1
            // 
            this.tacGiaControlForm1.getListTacGia = null;
            this.tacGiaControlForm1.Location = new System.Drawing.Point(6, 6);
            this.tacGiaControlForm1.Name = "tacGiaControlForm1";
            this.tacGiaControlForm1.NAMMAT = new System.DateTime(2016, 12, 4, 0, 0, 0, 0);
            this.tacGiaControlForm1.NAMSINH = new System.DateTime(2016, 12, 4, 0, 0, 0, 0);
            this.tacGiaControlForm1.QUEQUAN = "";
            this.tacGiaControlForm1.Size = new System.Drawing.Size(961, 387);
            this.tacGiaControlForm1.TabIndex = 0;
            this.tacGiaControlForm1.TENTG = "";
            // 
            // tabPage5
            // 
            this.tabPage5.BackColor = System.Drawing.Color.White;
            this.tabPage5.Controls.Add(this.thongTinXuatBanControlForm1);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(192, 74);
            this.tabPage5.TabIndex = 2;
            this.tabPage5.Text = "Thông tin xuất bản";
            // 
            // thongTinXuatBanControlForm1
            // 
            this.thongTinXuatBanControlForm1.getListThongTinXuatBan = null;
            this.thongTinXuatBanControlForm1.GIABIA = 0;
            this.thongTinXuatBanControlForm1.LANTAIBAN = 0;
            this.thongTinXuatBanControlForm1.Location = new System.Drawing.Point(6, 3);
            this.thongTinXuatBanControlForm1.MASACH = "";
            this.thongTinXuatBanControlForm1.Name = "thongTinXuatBanControlForm1";
            this.thongTinXuatBanControlForm1.NHAXUATBAN = "";
            this.thongTinXuatBanControlForm1.Size = new System.Drawing.Size(882, 338);
            this.thongTinXuatBanControlForm1.TabIndex = 0;
            // 
            // tabPage6
            // 
            this.tabPage6.BackColor = System.Drawing.Color.White;
            this.tabPage6.Controls.Add(this.linhVucControlForm1);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(192, 74);
            this.tabPage6.TabIndex = 3;
            this.tabPage6.Text = "Lĩnh vực";
            // 
            // linhVucControlForm1
            // 
            this.linhVucControlForm1.getListLinhVuc = null;
            this.linhVucControlForm1.Location = new System.Drawing.Point(6, 6);
            this.linhVucControlForm1.MALINHVUC = "";
            this.linhVucControlForm1.Name = "linhVucControlForm1";
            this.linhVucControlForm1.Size = new System.Drawing.Size(483, 327);
            this.linhVucControlForm1.TabIndex = 0;
            this.linhVucControlForm1.TENLINHVUC = "";
            // 
            // tabPage7
            // 
            this.tabPage7.BackColor = System.Drawing.Color.White;
            this.tabPage7.Controls.Add(this.loaiSachControlForm1);
            this.tabPage7.Location = new System.Drawing.Point(4, 22);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage7.Size = new System.Drawing.Size(192, 74);
            this.tabPage7.TabIndex = 4;
            this.tabPage7.Text = "Loại Sách";
            // 
            // loaiSachControlForm1
            // 
            this.loaiSachControlForm1.getListLoaiSach = null;
            this.loaiSachControlForm1.Location = new System.Drawing.Point(3, 3);
            this.loaiSachControlForm1.MALOAISACH = "";
            this.loaiSachControlForm1.Name = "loaiSachControlForm1";
            this.loaiSachControlForm1.Size = new System.Drawing.Size(519, 327);
            this.loaiSachControlForm1.TabIndex = 0;
            this.loaiSachControlForm1.TENLOAISACH = "";
            // 
            // tabPage8
            // 
            this.tabPage8.BackColor = System.Drawing.Color.White;
            this.tabPage8.Controls.Add(this.taiKhoanControlForm1);
            this.tabPage8.Location = new System.Drawing.Point(4, 22);
            this.tabPage8.Name = "tabPage8";
            this.tabPage8.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage8.Size = new System.Drawing.Size(973, 393);
            this.tabPage8.TabIndex = 5;
            this.tabPage8.Text = "Tài Khoản";
            // 
            // materialTabSelector2
            // 
            this.materialTabSelector2.BaseTabControl = this.materialTabControl2;
            this.materialTabSelector2.Depth = 0;
            this.materialTabSelector2.Location = new System.Drawing.Point(0, 26);
            this.materialTabSelector2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector2.Name = "materialTabSelector2";
            this.materialTabSelector2.Size = new System.Drawing.Size(1066, 45);
            this.materialTabSelector2.TabIndex = 1;
            this.materialTabSelector2.Text = "materialTabSelector2";
            // 
            // taiKhoanControlForm1
            // 
            this.taiKhoanControlForm1.CHUCVU = "";
            this.taiKhoanControlForm1.getListTaiKhoan = null;
            this.taiKhoanControlForm1.Location = new System.Drawing.Point(6, 6);
            this.taiKhoanControlForm1.Name = "taiKhoanControlForm1";
            this.taiKhoanControlForm1.NGAYLAMVIEC = new System.DateTime(2016, 12, 4, 0, 0, 0, 0);
            this.taiKhoanControlForm1.PASSWORD = "";
            this.taiKhoanControlForm1.Size = new System.Drawing.Size(681, 373);
            this.taiKhoanControlForm1.TabIndex = 0;
            this.taiKhoanControlForm1.TEN = "";
            this.taiKhoanControlForm1.USERNAME = "";
            // 
            // ViewTong
            // 
            this.ClientSize = new System.Drawing.Size(1062, 521);
            this.Controls.Add(this.materialTabSelector2);
            this.Controls.Add(this.materialTabControl2);
            this.Name = "ViewTong";
            this.materialTabControl2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.tabPage6.ResumeLayout(false);
            this.tabPage7.ResumeLayout(false);
            this.tabPage8.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        public MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private MaterialSkin.Controls.MaterialTabControl materialTabControl2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector2;
        private Sach.SachControlForm sachControlForm1;
        private TacGia.TacGiaControlForm tacGiaControlForm1;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.TabPage tabPage8;
        private ThongTinXuatBan.ThongTinXuatBanControlForm thongTinXuatBanControlForm1;
        private LinhVuc.LinhVucControlForm linhVucControlForm1;
        private LoaiSach.LoaiSachControlForm loaiSachControlForm1;
        private TaiKhoan.TaiKhoanControlForm taiKhoanControlForm1;
        //private Sach.SachControlForm sachControlForm1;
    }
}