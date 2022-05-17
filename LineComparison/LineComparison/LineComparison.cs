using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparison
{
    class LineComparison
    {
        public void Line1(int x1, int x2, int y1, int y2)
        {
            int line1 = (int)Math.Sqrt((Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2)));
            Console.WriteLine($"The length of the line is {line1}");
        }
    }

}
