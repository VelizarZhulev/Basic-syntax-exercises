using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal weight = decimal.Parse(Console.ReadLine());
            decimal height = decimal.Parse(Console.ReadLine());
            var area = weight * height;

            Console.WriteLine($"{area:f2}");
        }
    }
}
