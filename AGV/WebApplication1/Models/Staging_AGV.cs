namespace WebApplication1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Staging_AGV
    {
        [Key]
        public int AGVID { get; set; }

        public int CustKey { get; set; }

        [Required]
        [StringLength(10)]
        public string Identification { get; set; }

        [Column(TypeName = "date")]
        public DateTime InProductionDate { get; set; }

        [Column(TypeName = "date")]
        public DateTime? OutProductionDate { get; set; }

        public virtual Staging_Customer Staging_Customer { get; set; }
    }
}
