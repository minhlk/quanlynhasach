using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyNhaSach.Model.AppData;
using System.Data.Entity.Infrastructure;

namespace QuanLyNhaSach.Model
{
    class TacGiaRepository : ITacGiaRepository
    {
        NhaSachEntities entity=new NhaSachEntities();

        public void deleteSach(int MaTacGia)
        {
            entity.SACHes.RemoveRange((entity.SACHes.Where(x => x.MATG == MaTacGia).ToList()));
        }

        public TACGIA deleteTacGia(int MaTacGia)
        {
            TACGIA tg = (from c in entity.TACGIAs where c.MATG == MaTacGia select c).FirstOrDefault();
            entity.TACGIAs.Remove(tg);
            entity.SaveChanges();
            return tg;
        }

        public TACGIA editTacGia(TACGIA tg, int oldMaTacGia)
        {
            TACGIA tacgia = (from c in entity.TACGIAs where c.MATG == oldMaTacGia select c).FirstOrDefault();
            tacgia.TENTG = tg.TENTG;
            tacgia.NAMSINH = tg.NAMSINH;
            tacgia.NAMMAT = tg.NAMMAT;
            tacgia.QUEQUAN = tg.QUEQUAN;
            entity.SaveChanges();

            return tacgia; //tac gia cu
        }

        public IEnumerable<TACGIA> getListTacGia()
        {
            return entity.TACGIAs.ToList();
        }

        public TACGIA getTacGia(int MaTacGia)
        {
            return (from c in entity.TACGIAs where c.MATG == MaTacGia select c).FirstOrDefault();
        }

        public TACGIA saveTacGia(TACGIA tg)
        {
            try
            {
                entity.TACGIAs.Add(tg);
                entity.SaveChanges();
                return tg;
            }
            catch(DbUpdateException) // tranh loi update
            {
                return null;
            }
        }
    }
}
