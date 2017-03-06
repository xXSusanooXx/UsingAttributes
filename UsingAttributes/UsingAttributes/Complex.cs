using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingAttributes
{
    [MyAttr(Message = "I am not a Real")]
    public class Complex
    {
        public int R { get; set; }
        public int I { get; set; }
    }
}
