using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestRepo222Batch
{
    class SwapNumbers
    {
        public static void SwapTwoNumbers(int x, int y)//10,20
        {
            int temp = 0;
            Console.WriteLine("Before swap\nx:{0} y:{1}", x, y);
            temp = x; //10
            x = y; //20
            y = temp;//10
            Console.WriteLine("After swap\nx:{0} y:{1}", x, y);
        }
    }
}