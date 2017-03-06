using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingAttributes
{
    [AttributeUsage(AttributeTargets.Class, Inherited = false)]
    public class MyAttr : Attribute
    {
        public MyAttr()
        {

        }
        public MyAttr(string message)
        {
            Message = message;
        }
        public string Message { get; set; }
        public string returnMessage() { return this.Message; }
    }
}
