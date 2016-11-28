using QuanLyNhaSach.Model;
using QuanLyNhaSach.Presenter;
using QuanLyNhaSach.Validation;
using QuanLyNhaSach.View;
using QuanLyNhaSach.View.Kho;
using QuanLyNhaSach.View.LinhVuc;
using QuanLyNhaSach.View.LoaiSach;
using QuanLyNhaSach.View.NhatKiNhapSach;
using QuanLyNhaSach.View.ThongTinXuatBan;
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
            TacGiaForm TacGiaForm = new TacGiaForm();
            HoaDonForm HoaDonForm = new HoaDonForm();
            KhoForm KhoForm = new KhoForm();
            LoaiSachForm LoaiSachForm = new LoaiSachForm();
            LinhVucForm LinhVucForm = new LinhVucForm();
            ThongTinXuatBanForm ThongTinXuatBanForm = new ThongTinXuatBanForm();
            NhatKiNhapSachForm NhatKiNhapSachForm = new NhatKiNhapSachForm();
            //Application.Run(TacGiaForm);
            //Application.Run(HoaDonForm);
            //Application.Run(KhoForm);
            //Application.Run(LoaiSachForm);
            //Application.Run(LinhVucForm);
            //Application.Run(ThongTinXuatBanForm);
            Application.Run(NhatKiNhapSachForm);
        }
    }
}
