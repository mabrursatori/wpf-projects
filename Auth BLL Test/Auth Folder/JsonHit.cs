using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Auth_BLL_Test.Auth_Folder
{
    public partial class JsonHit
    {
        #region Method 
        public bool ApiInputIdPassword(string sTestPostData, string URL, out string sAuth)
        {
            bool TPDSuccess = false;
            string responseFromServer = "";
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(URL);
            request.Method = "POST";
            request.Credentials = CredentialCache.DefaultCredentials;
            ((HttpWebRequest)request).UserAgent = "Mozilla/5.0 (compatible; MSIE 9.0; Windows NT 7.1; Trident/5.0)";
            request.Accept = "/";
            request.UseDefaultCredentials = true;
            request.Proxy.Credentials = System.Net.CredentialCache.DefaultCredentials;
            byte[] bytearray = Encoding.UTF8.GetBytes(sTestPostData);
            request.ContentType = "application/json";
            request.ContentLength = bytearray.Length;
            Stream datastream = request.GetRequestStream();
            datastream.Write(bytearray, 0, bytearray.Length);
            datastream.Close();

            WebResponse response = request.GetResponse();
            datastream = response.GetResponseStream();
            StreamReader reader = new StreamReader(datastream);
            responseFromServer = reader.ReadToEnd();
            reader.Close();
            datastream.Close();
            response.Close();

            dynamic json = JsonConvert.DeserializeObject(responseFromServer);
            sAuth = json.auth;

            return TPDSuccess;

        }




        #endregion
    }
}
