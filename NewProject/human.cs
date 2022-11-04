using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestRepo222Batch
{
    public class Human
    {
        public static string company;
        //state of object
        //instance variable syntax
        public string personName;
        public int phoneNumb;

        //method or behaviour
        public void Talk()
        {
            int numb = 20;
            Console.WriteLine("He/she can talk" + numb);
        }

        public void HumanDetails()
        {
            Console.WriteLine("Name:{0} Phone:{1}", personName, phoneNumb);
            // Console.WriteLine("Name:"+personName+" Phone:"+phoneNumb);
        }

    }
}