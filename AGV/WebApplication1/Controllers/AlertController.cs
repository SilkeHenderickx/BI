using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Xml;
using WebApplication1;

namespace AGVWebAPI.Controller
{
    public class AlertController : ApiController
    {
        public async void Post()
        {
            string alertXML = await Request.Content.ReadAsStringAsync();

            // xml validation to xsd

            // xml string to Model
            XMLHandler xmlHandler = new XMLHandler();

            Staging_Alert alert = xmlHandler.MapXmlToStagingAlert(alertXML);

            // alert model AddAlert()

        }
    }
}
