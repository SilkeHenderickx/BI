namespace WebApplication1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Staging_Alert
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int AGV { get; set; }

        [Required]
        [StringLength(50)]
        public string AlertType { get; set; }

        [Key]
        [Column(Order = 1, TypeName = "timestamp")]
        [MaxLength(8)]
        [Timestamp]
        public byte[] TimeStamp { get; set; }

        public byte Blocked { get; set; }

        public int AGVJobKey { get; set; }

        public int XLocation { get; set; }

        public int YLocation { get; set; }

        public int Direction { get; set; }

        public int Speed { get; set; }

        public byte Loaded { get; set; }
    }
}
