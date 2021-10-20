using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass myClass = new MyClass();
            myClass.X = "3";
            string x = myClass.X;
            myClass[0] = "4";
            x = myClass[0];
        }
    }
}
