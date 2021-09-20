using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Reflection;

namespace SetConfig.shared
{
    class StringLib
    {
        public static string path
        {
            get { return Path.GetDirectoryName(Assembly.GetEntryAssembly().Location) + "\\Resources\\config.json"; }
        }
    }
}
