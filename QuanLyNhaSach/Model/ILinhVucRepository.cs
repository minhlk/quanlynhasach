using QuanLyNhaSach.Model.AppData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaSach.Model
{
    public interface ILinhVucRepository
    {
        IEnumerable<LINHVUC> getListLinhVuc();
        LINHVUC getLinhVuc(string MaLinhVuc);
        LINHVUC saveLinhVuc(LINHVUC lv);
        LINHVUC editLinhVuc(LINHVUC lv, string oldMaLinhVuc);
        LINHVUC deleteLinhVuc(string MaLinhVuc);
        bool checkExistInSach(string MaLinhVuc);
        void deleteSach(string MaLinhVuc);
    }
}
