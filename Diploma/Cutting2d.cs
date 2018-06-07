using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diploma
{
    public class Cutting2d
    {
        //Число раскройных карт?
        public int M;
        //Длина болванки
        public double L;
        //Ширина болванки
        public double W;
        //Барьер обтора деталей
        public double barier;
        //Итоговый коэффициент раскроя
        public double cutting_coef;
        public int bottom_border, N;
        //Список деталей (класс)
        public Detail_list detailList;
        public List<Cutting_Pattern> cuttintgPatternList;
    }
}
