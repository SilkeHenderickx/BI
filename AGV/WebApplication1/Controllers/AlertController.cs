using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace AGVWebAPI.Controller
{
    public class AlertController : ApiController
    {
        public async Task<string> Post()
        {
            string result = await Request.Content.ReadAsStringAsync();
            
            return result;
        }
    }
}
