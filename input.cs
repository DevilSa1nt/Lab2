using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public class input
    {
        List<Tuple<string, string>> det_and_color;

        List<string> det;
        List<string> colors;

        public input()
        {
            det_and_color = new();

            init();
        }

        void init()
        {
            det = new();
            det.Add("Капот".ToLower());
            det.Add("Передняя дверь".ToLower());
            det.Add("Задняя дверь".ToLower());
            det.Add("Передний бампер".ToLower());
            det.Add("Задний бампер".ToLower());
            det.Add("Крыша".ToLower());

            colors = new();
            colors.Add("Белый".ToLower());
            colors.Add("Синий".ToLower());
            colors.Add("Желтый".ToLower());
            colors.Add("Красный".ToLower());
            colors.Add("Перламутровый".ToLower());
            colors.Add("Серый металлик".ToLower());
        }

        public List<Tuple<string, string>> input_d()
        {
            while (true)
            {
                string s = Console.ReadLine();

                if (s == "")
                {
                    break;
                }
                else
                {
                    string[] ss = s.Split(", ");

                    if (det.Contains(ss[0].ToLower()))
                    {
                        if (colors.Contains(ss[1].ToLower()))
                        {
                            Tuple<string, string> t = new(ss[0], ss[1]);

                            det_and_color.Add(t);
                        }
                        else
                        {
                            Console.WriteLine("Цвет введён некорректно");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Название детали введено некорректно");
                    }
                }
            }

            return det_and_color;
        }
    }
}
