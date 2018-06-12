using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diploma
{
    /// <summary>
    /// План раскроя
    /// </summary>
    public class Cutting_Pattern2
    {
        //Остаток
        public double h;
        //Длина детали
        public double L;
        //Ширина детали
        public double W;
        //Карта раскроя (Индекс - деталь, значение - количество в карте раскроя)
        public int[] map;
        public Cutting_Pattern2(int M,double _L, double _W)
        {
            map = new int[M];
            L = _L;
            h = L;
            W = _W;
        }
        /// <summary>
        /// Добавление детали
        /// </summary>
        /// <param name="d">Деталь</param>
        /// <returns>Истина, если деталь добавлена, иначе - ложь</returns>
        public bool add_detail(Detail d)
        {
            if (h >= d.l && d.cb > 0)
            {
                h -= d.l;
                map[d.i] += 1;
                return true;
            }
            return false;
        }

        /// <summary>
        /// Удаление детали
        /// </summary>
        /// <param name="d"></param>
        public void remove_detail(Detail d)
        {            
            h += d.l;
            map[d.i] -= 1;            
        }
    }
}
