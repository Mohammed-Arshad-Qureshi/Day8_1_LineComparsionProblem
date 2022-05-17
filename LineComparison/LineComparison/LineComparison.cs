using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparison
{
    class LineComparison
    {
        
        public int Line1(int x1, int x2, int y1, int y2)
        {
            int line1 = (int)Math.Sqrt((Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2)));
            Console.WriteLine($"The length of the line is {line1}");
            return line1;
        }

        public void check(int line1,int line2)
        {
            if(line1.CompareTo(line2) == 0)
            {
                Console.WriteLine($"The two line {line1}  and  {line2} are Equal");
            }
        }
       
    }

}
