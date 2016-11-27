using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyNhaSach.Model.AppData;
using System.Data.Entity.Infrastructure;

namespace QuanLyNhaSach.Model
{
    class LinhVucRepository : ILinhVucRepository
    {
        NhaSachEntities entity = new NhaSachEntities();
        public LINHVUC deleteLinhVuc(string MaLinhVuc)
        {
            LINHVUC linhvuc = (from c in entity.LINHVUCs where c.MALINHVUC == MaLinhVuc select c).FirstOrDefault();
            entity.LINHVUCs.Remove(linhvuc);
            entity.SaveChanges();
            return linhvuc;
        }

        public LINHVUC editLinhVuc(LINHVUC lv, string oldMaLinhVuc)
        {

            LINHVUC linhvuc_re = (from c in entity.LINHVUCs where c.MALINHVUC == oldMaLinhVuc select c).FirstOrDefault();
            //linhvuc_re.MASACH = linhvuc.MASACH;
            saveLinhVuc(lv);
            deleteLinhVuc(linhvuc_re.MALINHVUC);
            //linhvuc_re.SOLUONGCON = linhvuc.SOLUONGCON;
            //linhvuc_re.TONGSOLUONG = linhvuc.TONGSOLUONG;

            entity.SaveChanges();

            return linhvuc_re; //linhvuc cu
        }

        public IEnumerable<LINHVUC> getListLinhVuc()
        {
            return entity.LINHVUCs.ToList();
        }

        public LINHVUC getLinhVuc(string MaLinhVuc)
        {
            return (from c in entity.LINHVUCs where c.MALINHVUC == MaLinhVuc select c).FirstOrDefault();
        }

        public LINHVUC saveLinhVuc(LINHVUC lv)
        {
            try
            {
                entity.LINHVUCs.Add(lv);
                entity.SaveChanges();
                return lv;
            }
            catch (DbUpdateException) // tranh loi update
            {
                return null;
            }
        }
    }
}
