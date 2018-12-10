using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class StagingAlert
    {
        [Key]
        public int AGV { get; set; }
        public string AlertType { get; set; }
        public TimestampAttribute TimeStamp { get; set; }
        public bool Blocked { get; set; }
        public int AGVJobKey { get; set; }
        public int XLocation { get; set; }
        public int YLocation { get; set; }
        public int Direction { get; set; }
        public int Speed { get; set; }
        public bool Loaded { get; set; }

    }
}