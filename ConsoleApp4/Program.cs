using System;
using System.IO;
using System.Xml;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("newbooks.xml");

            XmlNamespaceManager nsm = new XmlNamespaceManager(doc.NameTable);
            nsm.AddNamespace("bk", "urn:newbooks-schema");

            XmlNode book;
            XmlElement root = doc.DocumentElement;
            book = root.SelectSingleNode("descendant::bk:book[bk: author / bk:last - name = 'Atwood']", nsm);

            Console.WriteLine(book.OuterXml);
        }
    }
}
