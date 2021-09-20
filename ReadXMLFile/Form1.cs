using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace ReadXMLFile
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            load();
        }
        private void load()
        {
            string path = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location) + "\\Resource\\student.xml";
            String xmltext = System.IO.File.ReadAllText(path);
            xmltext = xmltext.Replace("\r\n", string.Empty);
            xmltext = xmltext.Replace(@"\", string.Empty);
            //using (TextReader sr = new StringReader(aciResponseData))
            //{
            //    var serializer = new System.Xml.Serialization.XmlSerializer(typeof(MyClass));
            //    MyClass response = (MyClass)serializer.Deserialize(sr);
            //    Console.WriteLine(response.people.bar);
            //}
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(xmltext);
            string jsonresult = JsonConvert.SerializeXmlNode(doc);
            var obj = JsonConvert.DeserializeObject<MyClass>(jsonresult);
        }
    }


    
    public class MyClass
    {
        public Tag Tag { get; set; }
    }
   // [System.Xml.Serialization.XmlRoot("tag")]
    public class Tag
    {
        public People People { get; set; }
    }

   // [System.Xml.Serialization.XmlRoot("people")]
    public class People
    {
        private int _number;
        public dynamic Number { get { return _number; }
            set {
                try
                {
                    var str = value as string;
                    var integer = Int32.Parse(str);
                    _number = integer;
                }
                catch(Exception e)
                {
                    _number = 0;
                }
                 }
        }

        private bool _isSmart;
        public dynamic IsSmart
        {
            get { return _isSmart; }
            set
            {
                try
                {
                    var str = value as string;
                    var boolean = bool.Parse(str);
                    _isSmart = boolean;
                }
                catch(Exception e)
                {
                    _isSmart = false;
                }
                
            }
        }
        
    }
}
