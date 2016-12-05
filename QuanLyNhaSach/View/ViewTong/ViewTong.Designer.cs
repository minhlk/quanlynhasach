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
            this.taiKhoanControlForm1 = new QuanLyNhaSach.View.TaiKhoan.TaiKhoanControlForm();
            this.tabPage9 = new System.Windows.Forms.TabPage();
            this.sachKhuyenMaiControlForm1 = new QuanLyNhaSach.View.SachKhuyenMai.SachKhuyenMaiControlForm();
            this.tabPage10 = new System.Windows.Forms.TabPage();
            this.materialTabControl3 = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage11 = new System.Windows.Forms.TabPage();
            this.khoControlForm1 = new QuanLyNhaSach.View.Kho.KhoControlForm();
            this.tabPage12 = new System.Windows.Forms.TabPage();
            this.materialTabSelector2 = new MaterialSkin.Controls.MaterialTabSelector();
            this.materialTabSelector3 = new MaterialSkin.Controls.MaterialTabSelector();
            this.nhatKiNhapSachControlForm1 = new QuanLyNhaSach.View.NhatKiNhapSach.NhatKiNhapSachControlForm();
            this.materialTabControl2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.tabPage7.SuspendLayout();
            this.tabPage8.SuspendLayout();
            this.tabPage9.SuspendLayout();
            this.tabPage10.SuspendLayout();
            this.materialTabControl3.SuspendLayout();
            this.tabPage11.SuspendLayout();
            this.tabPage12.SuspendLayout();
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
            this.materialTabControl2.Controls.Add(this.tabPage9);
            this.materialTabControl2.Controls.Add(this.tabPage10);
            this.materialTabControl2.Depth = 0;
            this.materialTabControl2.Location = new System.Drawing.Point(28, 111);
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
            this.thongTinXuatBanControlForm1.Size = new System.Drawing.Size(882, 387);
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
            this.tabPage8.Size = new System.Drawing.Size(192, 74);
            this.tabPage8.TabIndex = 5;
            this.tabPage8.Text = "Tài Khoản";
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
            // tabPage9
            // 
            this.tabPage9.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage9.Controls.Add(this.sachKhuyenMaiControlForm1);
            this.tabPage9.Location = new System.Drawing.Point(4, 22);
            this.tabPage9.Name = "tabPage9";
            this.tabPage9.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage9.Size = new System.Drawing.Size(192, 74);
            this.tabPage9.TabIndex = 6;
            this.tabPage9.Text = "Sách Khuyến Mãi";
            // 
            // sachKhuyenMaiControlForm1
            // 
            this.sachKhuyenMaiControlForm1.getListSachKhuyenMai = null;
            this.sachKhuyenMaiControlForm1.Location = new System.Drawing.Point(6, 6);
            this.sachKhuyenMaiControlForm1.MASACH = "Mã Sách";
            this.sachKhuyenMaiControlForm1.MUCGIAMGIA = 0;
            this.sachKhuyenMaiControlForm1.Name = "sachKhuyenMaiControlForm1";
            this.sachKhuyenMaiControlForm1.Size = new System.Drawing.Size(876, 346);
            this.sachKhuyenMaiControlForm1.TabIndex = 0;
            // 
            // tabPage10
            // 
            this.tabPage10.BackColor = System.Drawing.Color.White;
            this.tabPage10.Controls.Add(this.materialTabControl3);
            this.tabPage10.Location = new System.Drawing.Point(4, 22);
            this.tabPage10.Name = "tabPage10";
            this.tabPage10.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage10.Size = new System.Drawing.Size(973, 393);
            this.tabPage10.TabIndex = 7;
            this.tabPage10.Text = "Kho";
            // 
            // materialTabControl3
            // 
            this.materialTabControl3.Controls.Add(this.tabPage11);
            this.materialTabControl3.Controls.Add(this.tabPage12);
            this.materialTabControl3.Depth = 0;
            this.materialTabControl3.Location = new System.Drawing.Point(6, 6);
            this.materialTabControl3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl3.Name = "materialTabControl3";
            this.materialTabControl3.SelectedIndex = 0;
            this.materialTabControl3.Size = new System.Drawing.Size(961, 381);
            this.materialTabControl3.TabIndex = 0;
            // 
            // tabPage11
            // 
            this.tabPage11.BackColor = System.Drawing.Color.White;
            this.tabPage11.Controls.Add(this.khoControlForm1);
            this.tabPage11.Location = new System.Drawing.Point(4, 22);
            this.tabPage11.Name = "tabPage11";
            this.tabPage11.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage11.Size = new System.Drawing.Size(953, 355);
            this.tabPage11.TabIndex = 0;
            this.tabPage11.Text = "Kho";
            // 
            // khoControlForm1
            // 
            this.khoControlForm1.getListKho = null;
            this.khoControlForm1.Location = new System.Drawing.Point(7, 4);
            this.khoControlForm1.MASACH = "a";
            this.khoControlForm1.Name = "khoControlForm1";
            this.khoControlForm1.Size = new System.Drawing.Size(885, 326);
            this.khoControlForm1.SOLUONGCON = 0;
            this.khoControlForm1.TabIndex = 0;
            this.khoControlForm1.TONGSOLUONG = 0;
            // 
            // tabPage12
            // 
            this.tabPage12.BackColor = System.Drawing.Color.White;
            this.tabPage12.Controls.Add(this.nhatKiNhapSachControlForm1);
            this.tabPage12.Location = new System.Drawing.Point(4, 22);
            this.tabPage12.Name = "tabPage12";
            this.tabPage12.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage12.Size = new System.Drawing.Size(953, 355);
            this.tabPage12.TabIndex = 1;
            this.tabPage12.Text = "Nhật kí nhập";
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
            // materialTabSelector3
            // 
            this.materialTabSelector3.BaseTabControl = this.materialTabControl3;
            this.materialTabSelector3.Depth = 0;
            this.materialTabSelector3.Location = new System.Drawing.Point(28, 77);
            this.materialTabSelector3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector3.Name = "materialTabSelector3";
            this.materialTabSelector3.Size = new System.Drawing.Size(977, 24);
            this.materialTabSelector3.TabIndex = 2;
            this.materialTabSelector3.Text = "materialTabSelector3";
            // 
            // nhatKiNhapSachControlForm1
            // 
            this.nhatKiNhapSachControlForm1.getListNhatKiNhapSach = null;
            this.nhatKiNhapSachControlForm1.Location = new System.Drawing.Point(7, 7);
            this.nhatKiNhapSachControlForm1.MASACH = "a";
            this.nhatKiNhapSachControlForm1.Name = "nhatKiNhapSachControlForm1";
            this.nhatKiNhapSachControlForm1.NGAYNHAP = new System.DateTime(2016, 12, 5, 0, 0, 0, 0);
            this.nhatKiNhapSachControlForm1.Size = new System.Drawing.Size(853, 321);
            this.nhatKiNhapSachControlForm1.SOLUONG = 0;
            this.nhatKiNhapSachControlForm1.TabIndex = 0;
            // 
            // ViewTong
            // 
            this.ClientSize = new System.Drawing.Size(1062, 542);
            this.Controls.Add(this.materialTabSelector3);
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
            this.tabPage9.ResumeLayout(false);
            this.tabPage10.ResumeLayout(false);
            this.materialTabControl3.ResumeLayout(false);
            this.tabPage11.ResumeLayout(false);
            this.tabPage12.ResumeLayout(false);
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
        private TacGia.TacGiaControlForm tacGiaControlForm1;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.TabPage tabPage8;
        private ThongTinXuatBan.ThongTinXuatBanControlForm thongTinXuatBanControlForm1;
        private LinhVuc.LinhVucControlForm linhVucControlForm1;
        private LoaiSach.LoaiSachControlForm loaiSachControlForm1;
        private TaiKhoan.TaiKhoanControlForm taiKhoanControlForm1;
        private System.Windows.Forms.TabPage tabPage9;
        private SachKhuyenMai.SachKhuyenMaiControlForm sachKhuyenMaiControlForm1;
        private System.Windows.Forms.TabPage tabPage10;
        private MaterialSkin.Controls.MaterialTabControl materialTabControl3;
        private System.Windows.Forms.TabPage tabPage11;
        private System.Windows.Forms.TabPage tabPage12;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector3;
        private Kho.KhoControlForm khoControlForm1;
        private Sach.SachControlForm sachControlForm1;
        private NhatKiNhapSach.NhatKiNhapSachControlForm nhatKiNhapSachControlForm1;
        //private Sach.SachControlForm sachControlForm1;
    }
}