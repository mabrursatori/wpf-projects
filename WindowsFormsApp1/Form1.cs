using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
       

public class Sample
        {
            public static void Main()
            {

                //Create the XML fragment to be parsed.
                string xmlFrag = "<book> " +
                                "<title>Pride And Prejudice</title>" +
                                "<bk:genre>novel</bk:genre>" +
                                "</book>";

                //Create the XmlNamespaceManager.
                NameTable nt = new NameTable();
                XmlNamespaceManager nsmgr = new XmlNamespaceManager(nt);
                nsmgr.AddNamespace("bk", "urn:sample");

                //Create the XmlParserContext.
                XmlParserContext context = new XmlParserContext(null, nsmgr, null, XmlSpace.None);

                //Create the reader.
                XmlReadMode reader = new Xml(xmlFrag, XmlNodeType.Element, context);

                //Parse the XML.  If they exist, display the prefix and
                //namespace URI of each element.
                while (reader.Read())
                {
                    if (reader.IsStartElement())
                    {
                        if (reader.Prefix == String.Empty)
                        {
                            Console.WriteLine("<{0}>", reader.LocalName);
                        }
                        else
                        {
                            Console.Write("<{0}:{1}>", reader.Prefix, reader.LocalName);
                            Console.WriteLine(" The namespace URI is " + reader.NamespaceURI);
                        }
                    }
                }

                //Close the reader.
                reader.Close();
            }
        } // End class
    }
    }
}
