using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class MyClass
    {
        string x;
        public string X
        {
            get { return x; }
            set { x = value; }
        }

        public string this[string index]
        {
            get { return (index == "0") ? x : null; }
            set { if (index == "0") x = value; }
        }

        public string this[int index]
        {
            get { return new string[] { x }[index]; }
            set { x = value; }
        }
    }
}
