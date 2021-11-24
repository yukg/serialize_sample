using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using TestObject;

namespace dotNET5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var obj = new ClassA(new ClassB(123, "strClassB"), 456, "strClassA", new List<int>() { 7, 8, 9 }, new List<string>() { "a", "b", "c" });

            var serializer = new XmlSerializer(typeof(ClassA));
            using (var stringWriter = new StringWriter())
            {
                serializer.Serialize(stringWriter, obj);
                File.WriteAllText("dotNET6xml.xml", stringWriter.ToString());
            }
        }
    }
}
