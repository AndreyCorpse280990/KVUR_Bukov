using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KVUR_Bukov
{
    internal class Program
    {
        // Solve - функция решения КВУР вида ax^2 + bx + c = 0;
        // вход: a, b, c - коэффициенты КВУР
        // выход: кол-во корней (через return) и сами корни (через ref)
        static int Solve(
            in double a, in double b, in double c,
            out double x1, out double x2
        )
        {
            if(Math.Abs(a) < double.Epsilon) // Если a равен нулю, то это не квадратное уравнение, срабатывает исключение
            {
                x1 = x2 = 0;
                throw new ArgumentException("Коэффициент 'a' не может быть равен нулю, квадратное уравнение не может быть решено");
            }

            double d = b * b - 4 * a * c;
            if (d < 0)
            {
                // корней нет
                x1 = x2 = 0;
                return 0;
            }
            else if (d == 0)
            {
                // один корень
                x1 = x2 = -b / (2 * a);
                return 1;
            }
            else
            {
                // два корня
                x1 = (-b - Math.Sqrt(d)) / (2 * a);
                x2 = (-b + Math.Sqrt(d)) / (2 * a);
                return 2;
            }
        }

        static void Main(string[] args)
        {
            // ЗАДАЧА: написать функцию решения КВУР вида ax^2 + bx + c = 0
            // на вход функция принимает коэффициенты a, b, c (double)
            // на выход возвращает результат решения


            double a = 0.0;
            double b = 3.0;
            double c = 0.77;

            double x1, x2;
            int rootsCount = Solve(in a, in b, in c, out x1, out x2);
            if (rootsCount == 0)
            {
                Console.WriteLine("no roots");
            }
            else if (rootsCount == 1)
            {
                Console.WriteLine($"x = {x1}");
            }
            else
            {
                Console.WriteLine($"x1 = {x1}; x2 = {x2}");
            }
        }
    }


}
