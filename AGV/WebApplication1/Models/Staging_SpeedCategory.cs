namespace WebApplication1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Staging_SpeedCategory
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string SpeedCategory { get; set; }

        public int MinimumSpeed { get; set; }

        public int MaximumSpeed { get; set; }
    }
}
