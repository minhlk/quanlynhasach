using QuanLyNhaSach.Model.AppData;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaSach.Model
{
    public class TaiKhoanRepository : ITaiKhoanRepository
    {
        NhaSachEntities entity = new NhaSachEntities();
        public TAIKHOAN deleteTaiKhoan(string UserName)
        {
            TAIKHOAN tk = (from c in entity.TAIKHOANs where c.USERNAME == UserName select c).FirstOrDefault();
            entity.TAIKHOANs.Remove(tk);
            entity.SaveChanges();
            return tk;
        }

        public TAIKHOAN editTaiKhoan(TAIKHOAN tk, string oldUserName)
        {
            TAIKHOAN tk_re = (from c in entity.TAIKHOANs where c.USERNAME == oldUserName select c).FirstOrDefault();
            //linhvuc_re.MASACH = linhvuc.MASACH;
            saveTaiKhoan(tk);
            deleteTaiKhoan(tk_re.USERNAME);
            //linhvuc_re.SOLUONGCON = linhvuc.SOLUONGCON;
            //linhvuc_re.TONGSOLUONG = linhvuc.TONGSOLUONG;

            entity.SaveChanges();

            return tk_re; //linhvuc cu
        }

        public IEnumerable<TAIKHOAN> getListTaiKhoan()
        {
            return entity.TAIKHOANs.ToList();
        }

        public TAIKHOAN getTaiKhoan(string UserName)
        {
            return (from c in entity.TAIKHOANs where c.USERNAME == UserName select c).FirstOrDefault();
        }

        public TAIKHOAN saveTaiKhoan(TAIKHOAN tk)
        {
            try
            {
                entity.TAIKHOANs.Add(tk);
                entity.SaveChanges();
                return tk;
            }
            catch (DbUpdateException) // tranh loi update
            {
                return null;
            }
        }
    }
}
