using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.GolubevDS.Sprint1.Task3.V18.Lib;
namespace Tyuiu.GolubevDS.Sprint1.Task3.V18
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #0 | Выполнил Голубев Д. С. | АСОиУБ 23-2";
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* Спринт #1                                                              *");
            Console.WriteLine("* Тема: Операторы составного присваивания                                *");
            Console.WriteLine("* Задание #3                                                             *");
            Console.WriteLine("* Вариант #18                                                            *");
            Console.WriteLine("* Выполнил: Голубев Дмитрий Сергеевич | АСОиУБ 23-2                      *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                               *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные *");
            Console.WriteLine("* выполняет указанные расчёты и печатает результат на экране             *");
            Console.WriteLine("*                                                                        *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* Исходные значения                                                      *");
            Console.WriteLine("**************************************************************************");

            double a = 12;
            double b = 17;
            double c = 22;

            Console.WriteLine("квадрат 1 = " + a);
            Console.WriteLine("квадрат 2 = " + b);
            Console.WriteLine("квадрат 3 = " + c);

            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* Результат                                                              *");
            Console.WriteLine("**************************************************************************");

            Console.WriteLine("Количество квадратов = " + ds.HowManySquares(a, b, c));

            Console.ReadKey();
        }
    }
}
