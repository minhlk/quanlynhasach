using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaSach.Validation
{
    public class ModelState :Dictionary<string,string>
    {

        void addError(string key,string mes) {
            this.Add(key, mes);

        }
        public bool isValid() {

            if (Count == 0) return true;
            return false;
        }
       

    }
}
