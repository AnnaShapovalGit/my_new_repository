using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int vik = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Мене звати {0},мені {1} років", name, vik);

            int a = 3;
            int v = Convert.ToInt32(Console.ReadLine());
            double res = 0;
            res = (Math.Pow(a - v, 2) - (Math.Pow(a, 2) - (2 * a * v))) / Math.Pow(v, 2);
            Console.WriteLine(res);

            int ch = Convert.ToInt32(Console.ReadLine());
            double sot = ch / 100;
            double des = (ch % 100) / 10;
            double od = (ch % 100) % 10;

            Console.WriteLine("{0}{1}{2}", od, des, sot);
            Console.ReadKey();
 








        }
    }
}
