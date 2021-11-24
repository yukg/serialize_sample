using System;
using System.Collections.Generic;
using System.Text;

namespace TestObject
{
    public class ClassB
    {
        public int cbVal { get; set; }
        public string cbStr { get; set; }

        public ClassB(int val, string str)
        {
            cbVal = val;
            cbStr = str;
        }

        public ClassB() : this(0, string.Empty) { }
    }
}
