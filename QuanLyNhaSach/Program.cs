using QuanLyNhaSach.Model;
using QuanLyNhaSach.Presenter;
using QuanLyNhaSach.Validation;
using QuanLyNhaSach.View;
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
            
            Application.Run(TacGiaForm);
        }
    }
}
