namespace WebApplication1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Staging_AlertDescription
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string AlertDescription { get; set; }

        [Key]
        [Column(Order = 2)]
        public byte Environmental { get; set; }

        [Key]
        [Column(Order = 3)]
        public byte Blocking { get; set; }
    }
}
