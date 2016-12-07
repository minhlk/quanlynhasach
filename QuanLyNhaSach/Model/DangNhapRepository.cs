using QuanLyNhaSach.Model.AppData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaSach.Model
{
    public class DangNhapRepository : IDangNhapRepository
    {
        NhaSachEntities entity = new NhaSachEntities();
        public bool checkExist(string userName,string passWord)
        {
            return (from c in entity.TAIKHOANs where c.USERNAME == userName && c.PASSWORD == passWord select c).FirstOrDefault()
                 != null ? true : false
                ;
        }
    }
}
