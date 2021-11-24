// See https://aka.ms/new-console-template for more information

using System.Xml.Serialization;
using TestObject;

var obj = new ClassA(new ClassB(123, "strClassB"), 456, "strClassA", new List<int>() { 7, 8, 9 }, new List<string>() { "a", "b", "c" });

var serializer = new XmlSerializer(typeof(ClassA));
using (var stringWriter = new StringWriter())
{
    serializer.Serialize(stringWriter, obj);
    File.WriteAllText("dotNET6xml.xml", stringWriter.ToString());
}

