using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
namespace Diploma
{
    public partial class MainForm : Form
    {

        Detail_list dl;
        public MainForm()
        {
            InitializeComponent();
        }


       
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar)) && !((e.KeyChar == ',') && (((TextBox)sender).Text.IndexOf(".") == -1) && (((TextBox)sender).Text.Length != 0)))
            {
                if (e.KeyChar != (char)Keys.Back)
                {
                    e.Handled = true;
                }
            }

        }

        
        public Detail str_to_det(String s, int _i)
        {
            String l = "";
            String b = "";
            s = s.Replace(".", ",");
            int i = 0;
            try
            {
                while (s[i] != '\t')
                {
                    l += s[i];
                    i++;
                }
                i++;
                for (int j = i; j < s.Length; ++j)
                {
                    b += s[j];
                }
                return new Detail(Convert.ToDouble(l), Convert.ToInt32(b), _i);
            }
            catch
            {
                
                return new Detail(-1,-1,-1); 
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = "C:\\Users\\Пушок\\Desktop\\Тесты\\";
            openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                String input = File.ReadAllText(openFileDialog1.FileName);
                input = input.Replace("\r","");
                input = input.Replace(".", ",");
                String[] substrings = input.Split('\n');
                dl = new Detail_list(substrings.Length);
                for (int i = 0; i < substrings.Length; ++i)
                {
                    if (substrings[i] == "")
                        continue;
                    Detail det = str_to_det(substrings[i], i);
                    if (det.l == -1 || det.b == -1 || det.i == -1)
                    {
                        MessageBox.Show("Неверный входной файл", "Ошибка");
                        return;
                    }
                    else
                        dl.add_detail(det);
                }
                dg_input.Rows.Clear();

                foreach (Detail d in dl.list)
                {
                    dg_input.Rows.Add(d.l.ToString(), d.b.ToString());
                }
            }
           

            
        }

        public void output(Cutting c)
        {            
            int rows = c.cuttintgPatternList.Count;
            int cols = c.detailList.list.Count + 1;
            dg_output.Columns.Add("num", "Номер карты");
            for (int i = 0; i < cols - 1; ++i )
            {
                dg_output.Columns.Add("c" + i.ToString(), c.detailList.list[i].l.ToString());
            }
            dg_output.Columns.Add("c" + cols.ToString(), "Остаток");           
            for (int i = 0; i < rows; i++)
            {
                dg_output.Rows.Add();
            }


            for (int i = 0; i < rows; i++ )
            {
                dg_output.Rows[i].Cells[0].Value = (i + 1).ToString();
                for (int j = 1; j < cols; ++j)
                {
                    dg_output.Rows[i].Cells[j].Value = c.cuttintgPatternList[i].map[j-1].ToString();
                }
                dg_output.Rows[i].Cells[cols].Value = c.cuttintgPatternList[i].h;
            }
            labelCoef.Text = Math.Round(c.calc_coef(), 2).ToString();
        }

        /// <summary>
        /// Преобразовывает инпут в список деталей в памяти 1 мерный
        /// </summary>
        public void dg_to_dl()
        {
            for (int i = 0; i < dg_input.Rows.Count-1; ++i)
            {
                dl.add_detail(str_to_det((dg_input.Rows[i].Cells[0].Value + "\t" + dg_input.Rows[i].Cells[1].Value.ToString()), i));
            }
        }

        /// <summary>
        /// Преобразовывает инпут в список деталей в памяти 2 мерный
        /// </summary>
        public void dg_to_dl2()
        {
            for (int i = 0; i < dg_input.Rows.Count - 1; ++i)
            {
                //dl.add_detail(str_to_det((dg_input.Rows[i].Cells[0].Value + "\t" + dg_input.Rows[i].Cells[1].Value.ToString()), i));
                try
                {
                    dl.add_detail(new Detail(Convert.ToDouble(dg_input.Rows[i].Cells[0].Value), Convert.ToInt32(dg_input.Rows[i].Cells[1].Value), i, Convert.ToInt32(dg_input.Rows[i].Cells[2].Value)));
                }
                catch
                {
                    dl.add_detail(new Detail(-1, -1, -1));
                }
            }

        }

        private void button_create_cutting_Click(object sender, EventArgs e)
        {

            if (dg_input.Rows.Count < 2)
            {
                MessageBox.Show("Деталей для раскроя должно быть, как минимум две", "Ошибка");
                return;
            }
            dg_output.Rows.Clear();
            dg_output.Columns.Clear();
            dl = new Detail_list(dg_input.RowCount - 1);
            dl.list.Clear();
            dg_to_dl();
            if (Convert.ToDouble(tb_length.Text) < dl.calc_max())
            {
                MessageBox.Show("Одна из деталей длиннее стержня", "Ошибка");
                return;
            }
            label_best.Text = "0";
            Cutting cutting = new Cutting(Convert.ToDouble(tb_length.Text), dl);
            //Создали карту раскроя первый подходящий
            cutting.create_ffd_cutting_map();            
            //Расчитали нижнюю границу
            cutting.calc_botton_border();
            if (cutting.cuttintgPatternList.Count > cutting.bottom_border)
            {
                int i = 0;
                while (true)
                {
                    cutting.S_task();
                    ++i;
                    if (cutting.cuttintgPatternList.Count == cutting.bottom_border || i > 100)
                        break;
                }
                   
               
            }
            output(cutting);
            label_best.Text = tb_length.Text;
        }
       

        private void button_create_cutting_best_Click(object sender, EventArgs e)
        {
            if(Convert.ToDouble(tb_length_A.Text) >= Convert.ToDouble(tb_length_B.Text))
            {
                MessageBox.Show("Интервал неверный", "Ошибка");
                return;
            }
            if (dg_input.Rows.Count < 2)
            {
                MessageBox.Show("Деталей для раскроя должно быть, как минимум две", "Ошибка");
                return;
            }
            if (Convert.ToDouble(tb_length_A.Text) < dl.calc_max())
            {
                MessageBox.Show("Одна из деталей длиннее наименьшего стержня", "Ошибка");
                return;
            }
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            dg_output.Rows.Clear();
            dg_output.Columns.Clear();
            List<Cutting> cuttings = new List<Cutting>();
            dl = new Detail_list(dg_input.RowCount - 1);
            dl.list.Clear();
            dg_to_dl();
            for (int i = Convert.ToInt32(tb_length_A.Text); i <= Convert.ToInt32(tb_length_B.Text); ++i)
            {
                cuttings.Add(new Cutting(i, dl));
            }
            int best_i = 0;
            double best_coef = 0;
            int map_count = 0;
            for (int i = 0; i < cuttings.Count; ++i)
            {
                dl.reset_cb();
                cuttings[i].create_ffd_cutting_map();
                cuttings[i].calc_botton_border();
                if (cuttings[i].cuttintgPatternList.Count > cuttings[i].bottom_border)
                {
                    int j = 0;
                    while (true)
                    {
                        cuttings[i].S_task();
                        ++j;
                        if (cuttings[i].cuttintgPatternList.Count == cuttings[i].bottom_border || j > 100)
                            break;
                    }
                }
                cuttings[i].calc_coef();
                if(i == 0)
                {
                    best_i = 0;
                    best_coef = cuttings[i].cutting_coef;
                    map_count = cuttings[i].cuttintgPatternList.Count;
                }
                else
                {
                    if (cuttings[i].cutting_coef > best_coef || map_count > cuttings[i].cuttintgPatternList.Count)
                    {
                        best_i = i;
                        best_coef = cuttings[i].cutting_coef;
                        map_count = cuttings[i].cuttintgPatternList.Count;
                    }
                }
               
            }
            output(cuttings[best_i]);
            label_best.Text = cuttings[best_i].L.ToString();
            stopWatch.Stop();
        
           
        }
      

        private void tb_length_A_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar)) && !((e.KeyChar == ',') && (((TextBox)sender).Text.IndexOf(".") == -1) && (((TextBox)sender).Text.Length != 0)))
            {
                if (e.KeyChar != (char)Keys.Back)
                {
                    e.Handled = true;
                }
            }
        }

        private void tb_length_B_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar)) && !((e.KeyChar == ',') && (((TextBox)sender).Text.IndexOf(".") == -1) && (((TextBox)sender).Text.Length != 0)))
            {
                if (e.KeyChar != (char)Keys.Back)
                {
                    e.Handled = true;
                }
            }
        }

        private void tabPage5_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Двумерный раскрой
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            //Очистка результата
            dg_output2.Rows.Clear();
            dg_output2.Columns.Clear();
            dl = new Detail_list(dg_input2.RowCount - 1);
            dl.list.Clear();
            dg_to_dl2();
            Cutting2d cutting = new Cutting2d(Convert.ToDouble(tb_l2.Text), Convert.ToDouble(tb_w2.Text), dl);

        }

        private void button_create_cutting_single_Click(object sender, EventArgs e)
        {

        }
    }
}