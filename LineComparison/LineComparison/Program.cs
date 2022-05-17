using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparison
{
    class Program
    {
        static void Main(string[] args)
        {
            LineComparison lc = new LineComparison();
            Console.WriteLine("Enter x and y coordinates to find length of line");
            Console.Write("Enter x1 :  ");
            int x1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter x2 :  ");
            int x2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter y1 :  ");
            int y1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter y2 :  ");
            int y2 = Convert.ToInt32(Console.ReadLine());
            lc.Line1(x1, x2, y1, y2);
            Console.ReadLine();


        }
    }
}
