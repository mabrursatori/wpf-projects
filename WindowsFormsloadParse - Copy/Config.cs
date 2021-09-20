using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.IO;
namespace WindowsFormsloadParse
{
    class Config
    {

        public string Detail { get; private set; }
        public string Core1 { get; private set; }

        public Config ( string detail,string core1)
        {
            Detail = detail;
            Core1 = core1;

        }

        public override string ToString()
        {
            return Detail;
            
        }

    }
}
