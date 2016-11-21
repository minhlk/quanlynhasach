using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaSach.Validation
{
    class ModelStateWraper : IModelStateWraper
    {
        ModelState state;
        public ModelStateWraper(ModelState _state) {
            state = _state;
        }
        public void addError(string key, string mes)
        {
            state.Add(key, mes);
        }

        public bool isValid()
        {
            return state.isValid();
        }
        public void Clear() {
            state.Clear();
        }
    }
}
