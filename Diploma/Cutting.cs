using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diploma
{
    public class Cutting
    {
        //Количество укладываемых прутков?
        public int M;
        //Длина болванки
        public double L;
        //Барьер обтора деталей
        public double barier;
        //Итоговый коэффициент раскроя
        public double cutting_coef;
        public int bottom_border,  N;
        //Список деталей (класс)
        public Detail_list detailList;
        public List<Cutting_Pattern> cuttintgPatternList;


        /// <summary>
        /// Главный конструктор
        /// </summary>
        /// <param name="_L">Длина заготовки</param>
        /// <param name="_dl">Список деталей</param>
        public Cutting(double _L, Detail_list _dl)
        {
            M = _dl.list.Count;
            L = _L;
            detailList = _dl;
            detailList.update_work_list();
            detailList.sort_by_l();
            cuttintgPatternList = new List<Cutting_Pattern>();
        }


        /// <summary>
        /// Создание карты первый подходящий (первоначальное размещение), затем ее оптимизируем
        /// </summary>
        public void create_ffd_cutting_map()
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
            for (int i = 0; i < detailList.work_list.Count-1; ++i)
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
            /*for (int i = 0; i < M; ++i)
            {
                _f += dl.list[i]._y;
            }*/
            barier = (L + _f )/2;
        }
        public void calc_botton_border()
        {
            double sum = 0;
            for (int i = 0; i < M; ++i)
            {
                sum += detailList.list[i].b * detailList.list[i].l;
            }
            bottom_border = Convert.ToInt32( Math.Ceiling(sum / L));
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
            detailList.reset_cb();
            detailList.update_work_list();
            calc_y_first();
            cuttintgPatternList.Clear();
            

            while (!detailList.check_empty_wl())
            {
                detailList.sort_by__y();
                calc_barier();
                Cutting_Pattern cp = new Cutting_Pattern(M, L);
                double _f;                
                double fi;
                double old_barier = 0; 
                int place_count = 1;
                int prev = 0;
                detailList.current_detail = 0;
                bool was_step_back = false;
                while (cp.h >= detailList.calc_min() && !detailList.check_empty_wl())
                {
                    if (cp.h < detailList.work_list[detailList.current_detail].l && !was_step_back)
                    {
                        detailList.next();
                        continue;
                    }
                    _f = detailList.work_list[detailList.current_detail]._y * cp.h;
                    if (_f >= barier) // step forward //запатчтил остаток
                    {
                     
                        if (detailList.work_list[detailList.current_detail].cb >= place_count)
                        {
                            for (int i = 0; i < place_count; ++i)
                            {
                                cp.add_detail(detailList.work_list[detailList.current_detail]);
                            }
                            detailList.work_list[detailList.current_detail].cb -= place_count;
                        }
                        else
                        {
                            for (int i = 0; i < detailList.work_list[detailList.current_detail].cb; ++i)
                            {
                                cp.add_detail(detailList.work_list[detailList.current_detail]);
                            }
                            detailList.work_list[detailList.current_detail].cb = 0;
                        }                       
                        fi = detailList.work_list[detailList.current_detail].y * cp.map[detailList.work_list[detailList.current_detail].i]; 
                        old_barier = barier;
                        prev = detailList.current_detail;
                        barier -= fi;
                        detailList.next();
                        was_step_back = false;
                        place_count = 1;
                        
                        
                    }
                    else // step back
                    {
                        if (was_step_back)
                        {
                            barier *= 0.8;
                            continue;
                        }
                        detailList.current_detail = prev;
                        try 
                        {
                            cp.remove_detail(detailList.work_list[detailList.current_detail]);
                        }
                        catch
                        {
                            detailList.current_detail--;
                            cp.remove_detail(detailList.work_list[detailList.current_detail]);
                        }                       
                        detailList.work_list[detailList.current_detail].cb += place_count; 
                        barier = old_barier;
                        place_count++;
                        was_step_back = true;
                    }
                }
                cuttintgPatternList.Add(cp);

                if (!detailList.check_empty_wl())
                    calc_y();
                //else
            }
        }
    }
}
