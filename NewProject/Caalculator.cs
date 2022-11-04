using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestRepo222Batch
{
    public class Calculator
    {
        //access-modifier return-type methodName
        public static void AddTwoNumbers(int firstNumb, int sendNumb)
        {
            int result = firstNumb + sendNumb;
            Console.WriteLine("Sum of two numbers:" + result);
        }
    }
}