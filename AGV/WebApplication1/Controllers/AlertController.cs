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
        AGVStagingContext agvStagingContext = new AGVStagingContext();

        public async Task<HttpResponseMessage> Post()
        {
            string alertXML = await Request.Content.ReadAsStringAsync();

            try
            {
                // xml validation to xsd

                // xml string to Model
                XMLHandler xmlHandler = new XMLHandler();

                Staging_Alert alert = xmlHandler.MapXmlToStagingAlert(alertXML);

                // alert model AddAlert()
                agvStagingContext.AddAlert(alert);

                return Request.CreateResponse(HttpStatusCode.OK);
            }
            catch (Exception e)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest,
                    "The given data did not match what was expected.");
            }
        }
    }
}
