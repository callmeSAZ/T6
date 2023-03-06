using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //دریافت ورودی و جمع یکان و دهگان

            int x = int.Parse(Console.ReadLine());
            int y, d;

            y = x % 10;
            d = x / 10;

            Console.WriteLine("Sum={0}", y+d);

            Console.ReadKey();
        }
    }
}
