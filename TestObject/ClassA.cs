using System;
using System.Collections.Generic;
using System.Linq;

namespace TestObject
{
    public class ClassA
    {
        public ClassB ClassB { get; set; }
        public int Val { get; set; }
        public string Str { get; set; }
        public List<int> ValList { get; set; }
        public List<string> StrList { get; set; }

        public ClassA(ClassB classB, int val, string str, IEnumerable<int> vallist, IEnumerable<string> strlist)
        {
            ClassB = classB;
            Val = val;
            Str = str;
            StrList = strlist.ToList();
            ValList = vallist.ToList();
        }

        public ClassA() : this(new ClassB(), 0, string.Empty, new int[] { }, new string[] { }) { }
    }
}
