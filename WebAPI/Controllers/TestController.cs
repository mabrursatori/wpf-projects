using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebAPI.Controllers
{
    public class TestController : ApiController
    {
        public string Get()
        {
            return "Welcome to Web API";
        }
        public List<string> Get(int ID) 
        {
            return new List<string>
            {
                "Data 1",
                "data 2"
            };
        
        }


    }
}
