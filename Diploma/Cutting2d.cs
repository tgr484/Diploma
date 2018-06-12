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

        public Cutting2d(double v1, double v2, Detail_list dl)
        {
            this.M = dl.list.Count;
            this.L = v1;
            this.W = v2;
            this.detailList = dl;
        }
        public void create_first_cutting_map()
        {
            detailList.update_work_list();
            //Пока не обработаны все делати
            while (!detailList.check_empty_wl())
            {
                Cutting_Pattern cp = new Cutting_Pattern(M, L);
                int currentDetail = 0;
                //Флаг перехода к следующей детали
                bool next = false;
                while (!next)
                {
                    if (cp.add_detail(detailList.work_list[currentDetail])) //Если можно добавить текущую деталь
                    {
                        detailList.work_list[currentDetail].cb--;
                        continue;
                    }
                    else
                    {
                        if (cp.h == 0 || cp.h < detailList.work_list[detailList.work_list.Count - 1].l)
                            next = true;
                        else
                        {
                            if (currentDetail < detailList.work_list.Count - 1)
                                currentDetail++;
                            else next = true;
                        }
                    }
                }
                cuttintgPatternList.Add(cp);
            }
        }


        /// <summary>
        /// Расчет первоначальных оценок
        /// </summary>
        public void calc_y_first()
        {
            for (int i = 0; i < detailList.list.Count; ++i)
            {
                detailList.list[i].y = 0;
                for (int j = 0; j < cuttintgPatternList.Count; ++j)
                {
                    detailList.list[i].y += ((detailList.list[i].l * cuttintgPatternList[j].h) / (L - cuttintgPatternList[j].h) + detailList.list[i].l) * cuttintgPatternList[j].map[detailList.list[i].i];
                }
                detailList.list[i].y /= detailList.list[i].b;
            }
            calc__y_dl();
            detailList.update_work_list();
        }

        public void calc_y()
        {
            for (int i = 0; i < detailList.work_list.Count - 1; ++i)
            {
                double old_y = detailList.work_list[i].y;
                detailList.work_list[i].y = 0;
                for (int j = 0; j < cuttintgPatternList.Count; ++j)
                {
                    detailList.work_list[i].y += ((detailList.work_list[i].l * cuttintgPatternList[j].h) / (L - cuttintgPatternList[j].h) + detailList.work_list[i].l) * cuttintgPatternList[j].map[detailList.work_list[i].i]; //+old_y * dl.list[i].b;
                }
                detailList.work_list[i].y += old_y * detailList.work_list[i].cb;
                detailList.work_list[i].y /= detailList.work_list[i].b;
            }
            foreach (Detail d in detailList.work_list)
            {
                if (d.y == 0)
                    d.y = d.l;
            }
            calc__y_wl();
        }

        public void calc__y_wl()
        {
            for (int i = 0; i < detailList.work_list.Count; ++i)
            {
                detailList.work_list[i]._y = detailList.work_list[i].y / detailList.work_list[i].l;
            }
        }

        public void calc__y_dl()
        {
            for (int i = 0; i < M; ++i)
            {
                detailList.list[i]._y = detailList.list[i].y / detailList.list[i].l;
            }
        }

        public void calc_barier()
        {
            double _f = detailList.work_list[0]._y * L;
          
            barier = (L + _f) / 2;
        }
        public void calc_botton_border()
        {
            double sum = 0;
            for (int i = 0; i < M; ++i)
            {
                sum += detailList.list[i].b * detailList.list[i].l;
            }
            bottom_border = Convert.ToInt32(Math.Ceiling(sum / L));
        }

        public double calc_coef()
        {
            double H = 0;
            foreach (Cutting_Pattern cp in cuttintgPatternList)
            {
                H += cp.h;
            }
            double sum = 0;
            for (int i = 0; i < M; ++i)
            {
                sum += detailList.list[i].b * detailList.list[i].l;
            }
            cutting_coef = (sum - H) / sum * 100;
            if (cutting_coef < 0)
                return 0;
            else
                return cutting_coef;
        }

        public bool check_solution()
        {
            if (cuttintgPatternList.Count == bottom_border)
                return true;
            else return false; //Здесь корректировку?
        }

        public void S_task()
        {
            
        }
    }
}
