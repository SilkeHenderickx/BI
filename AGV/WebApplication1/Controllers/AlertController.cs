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

            // timestamp handler
            XMLHandler xmlHandler = new XMLHandler();

            //string timestamp = xmlHandler.getBetween(alertXML, "<TimeStamp>", "</TimeStamp>");
            //string newTimestamp = timestamp.
            // xml string to Model

            alertXML = alertXML.Replace("-", "=");
            Staging_Alert alert = xmlHandler.MapXmlToStagingAlert(alertXML);

            // alert model AddAlert()

        }
    }
}
