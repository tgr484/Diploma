using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diploma
{
    public class Detail
    {
        //Порядковый номер детали
        public int i;
        //Всего деталей
        public int b;
        //Сколько осталось раскроить
        public int cb;
        //Длина детали
        public double l;
        //Ширина детали
        public double w;
        public double y; 
        public double _y;
        public Detail(double _l, int _b, int _i, double _w = 0)
        {
            l = _l;
            b = _b;
            cb = b; //сколько осталось деталей
            i = _i;
            w = _w;
        }
    }
}
