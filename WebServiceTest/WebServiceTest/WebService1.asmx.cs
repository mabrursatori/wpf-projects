﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Services;
using Newtonsoft.Json;

namespace WebServiceTest
{
    /// <summary>
    /// Summary description for WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {
        DataTable dtCountries = new DataTable();
          
        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

        [WebMethod]
        public int Sum(int a, int b)
        {
            return a+b; 
        }
        
        [WebMethod]
        public string Countries()
        {
            dtCountries.Columns.Add("Country Names");
            dtCountries.Columns.Add("Continent");

            dtCountries.Rows.Add("Hokkaido", "Japan");
            dtCountries.Rows.Add("Osaka", "Japan");
            dtCountries.Rows.Add("Tokyo", "Japan");
            dtCountries.Rows.Add("Nagasaki", "Japan");
            dtCountries.Rows.Add("Hiroshima", "Japan");
            dtCountries.Rows.Add("Yokohama", "Japan");

            return JsonConvert.SerializeObject(dtCountries);
        }
    }
}
