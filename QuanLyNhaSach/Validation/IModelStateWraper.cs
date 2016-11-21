using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaSach.Validation
{
    public interface IModelStateWraper
    {


        void addError(String key,String mes);
        bool isValid();
        void Clear();
    }
}
