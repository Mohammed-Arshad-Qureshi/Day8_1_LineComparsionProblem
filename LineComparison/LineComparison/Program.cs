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
            //Line one
            Console.WriteLine("Enter x and y coordinates to find length of line1");
            Console.Write("Enter x1 :  ");
            int x1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter x2 :  ");
            int x2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter y1 :  ");
            int y1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter y2 :  ");
            int y2 = Convert.ToInt32(Console.ReadLine());
            int Line1 = lc.Line1(x1, x2, y1, y2);

            //Line two
            Console.WriteLine("Enter x and y coordinates to find length of line2");
            Console.Write("Enter a1 :  ");
            int a1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter a2 :  ");
            int a2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter b1 :  ");
            int b1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter b2 :  ");
            int b2 = Convert.ToInt32(Console.ReadLine());
            int Line2 = lc.Line1(a1, a2, b1, b2);


            //condition check
            lc.check(Line1, Line2);
            Console.ReadLine();
            Console.ReadLine();


        }
    }
}
