using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AGVWebAPI.Controller
{
    public class AlertController : ApiController
    {
        public void PostAlert([FromBody] string value)
        {
            Console.WriteLine(value);
        }
    }
}
