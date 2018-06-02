using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diploma
{
    public class Detail
    {
        //Положение детали???
        public int i;
        //Всего деталей
        public int b;
        //Сколько осталось раскроить
        public int cb;
        //Длина детали
        public double l;
        public double y; 
        public double _y;
        public Detail(double _l, int _b, int _i)
        {
            l = _l;
            b = _b;
            cb = b; //сколько осталось деталей
            i = _i;
        }
    }
}
