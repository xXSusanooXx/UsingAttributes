using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsingAttributes;

namespace UsingAttributes.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Complex c = new Complex();
            Type t = c.GetType();
            MyAttr attr = (MyAttr)t.GetCustomAttributes(false).FirstOrDefault();

            System.Console.WriteLine("-> {0}\n", attr.returnMessage());

            System.Console.Read();
        }
    }
}
