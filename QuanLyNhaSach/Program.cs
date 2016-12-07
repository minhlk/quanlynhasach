using QuanLyNhaSach.Model;
using QuanLyNhaSach.Presenter;
using QuanLyNhaSach.Validation;
using QuanLyNhaSach.View;
using QuanLyNhaSach.View.ChiTietHoaDon;
using QuanLyNhaSach.View.DangNhap;
using QuanLyNhaSach.View.Kho;
using QuanLyNhaSach.View.LinhVuc;
using QuanLyNhaSach.View.LoaiSach;
using QuanLyNhaSach.View.NhatKiNhapSach;
using QuanLyNhaSach.View.Sach;
using QuanLyNhaSach.View.SachKhuyenMai;
using QuanLyNhaSach.View.TaiKhoan;
using QuanLyNhaSach.View.ThongKe;
using QuanLyNhaSach.View.ThongTinXuatBan;
using QuanLyNhaSach.View.ViewTong;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhaSach
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //TacGiaForm TacGiaForm = new TacGiaForm();
            //HoaDonForm HoaDonForm = new HoaDonForm();
            //KhoForm KhoForm = new KhoForm();
            //LoaiSachForm LoaiSachForm = new LoaiSachForm();
            //LinhVucForm LinhVucForm = new LinhVucForm();
            //ThongTinXuatBanForm ThongTinXuatBanForm = new ThongTinXuatBanForm();
            //NhatKiNhapSachForm NhatKiNhapSachForm = new NhatKiNhapSachForm();
            //ChiTietHoaDonForm ChiTietHoaDonForm = new ChiTietHoaDonForm();
            //SachKhuyenMaiForm SachKhuyenMaiForm = new SachKhuyenMaiForm();
            //TaiKhoanForm TaiKhoanForm = new TaiKhoanForm();
            //SachForm SachForm = new SachForm();

            //Application.Run(TacGiaForm);
            //Application.Run(HoaDonForm);
            //Application.Run(KhoForm);
            //Application.Run(LoaiSachForm);
            //Application.Run(LinhVucForm);
            //Application.Run(ThongTinXuatBanForm);
            //Application.Run(NhatKiNhapSachForm);
            //Application.Run(ChiTietHoaDonForm);
            //Application.Run(SachKhuyenMaiForm);
            //Application.Run(TaiKhoanForm);
            //Application.Run(SachForm);
            //Application.Run(new ViewTong());
            //Application.Run(new ThongKeControlForm());
            DangNhapForm DangNhap =new DangNhapForm();
            DangNhap.Show();
            Application.Run();
        }
    }
}
