using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaSach.Model.AppData
{
    public interface IKhoRepository
    {
        IEnumerable<KHO> getListKho();
        KHO getKho(string Masach);
        KHO saveKho(KHO kho);
        KHO editKho(KHO kho, string oldMasach);
        KHO deleteKho(string MaKho);
        IEnumerable<string> getListMaSach();
    }
}
