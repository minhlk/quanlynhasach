using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaSach.Model
{
    public interface IDangNhapRepository
    {

        bool checkExist(string userName, string passWord);


    }
}
