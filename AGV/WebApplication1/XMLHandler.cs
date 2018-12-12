using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace WebApplication1
{
    public class XMLHandler
    {
        public Staging_Alert MapXmlToStagingAlert(string xmlString)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Staging_Alert), new XmlRootAttribute("AGVAlert"));
            StringReader stringReader = new StringReader(xmlString);
            Staging_Alert alert = (Staging_Alert) serializer.Deserialize(stringReader);
            return alert;
        }

        public string getBetween(string strSource, string strStart, string strEnd)
        {
            int Start, End;
            if (strSource.Contains(strStart) && strSource.Contains(strEnd))
            {
                Start = strSource.IndexOf(strStart, 0) + strStart.Length;
                End = strSource.IndexOf(strEnd, Start);
                return strSource.Substring(Start, End - Start);
            }
            else
            {
                return "";
            }
        }
    }

}