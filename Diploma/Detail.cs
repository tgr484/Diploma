using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diploma
{
    public class Detail
    {
        public int  i, b, cb;
        public double l,y, _y;
        public Detail(double _l, int _b, int _i)
        {
            l = _l;
            b = _b;
            cb = b; //сколько осталось деталей
            i = _i;
        }
    }
}
