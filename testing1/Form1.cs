using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testing1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var k = System.Windows.Forms.SystemInformation.TerminalServerSession;
           
            //string userName = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
            WindowsPrincipal wp = new WindowsPrincipal(WindowsIdentity.GetCurrent());
            MessageBox.Show(wp.Identity.Name); // Username
            MessageBox.Show(GetTerminalServerClientNameWTSAPI()); // Remote Host PC Name
            MessageBox.Show(k.ToString());

        }

        private static string GetTerminalServerClientNameWTSAPI()
        {

            const int WTS_CURRENT_SERVER_HANDLE = -1;

            IntPtr buffer = IntPtr.Zero;
            uint bytesReturned;

            string strReturnValue = "";
            try
            {
                WTSQuerySessionInformation(IntPtr.Zero, WTS_CURRENT_SERVER_HANDLE, WTS_INFO_CLASS.WTSClientUserName, out buffer, out bytesReturned);
                strReturnValue = System.Runtime.InteropServices.Marshal.PtrToStringAnsi(buffer);
            }

            finally
            {
                buffer = IntPtr.Zero;
            }

            return strReturnValue;
        }

        enum WTS_INFO_CLASS
        {
            WTSInitialProgram,
            WTSApplicationName,
            WTSWorkingDirectory,
            WTSOEMId,
            WTSSessionId,
            WTSUserName,
            WTSWinStationName,
            WTSDomainName,
            WTSConnectState,
            WTSClientBuildNumber,
            WTSClientName,
            WTSClientUserName,
            WTSClientDirectory,
            WTSClientProductId,
            WTSClientHardwareId,
            WTSClientAddress,
            WTSClientDisplay,
            WTSClientProtocolType

        }

        [System.Runtime.InteropServices.DllImport("Wtsapi32.dll")]
        private static extern bool WTSQuerySessionInformation(System.IntPtr hServer, int sessionId, WTS_INFO_CLASS wtsInfoClass, out System.IntPtr ppBuffer, out uint pBytesReturned);


        private const uint WDA_NONE = 0x0;
        private const uint WDA_MONITOR = 0x1;

    }
}
