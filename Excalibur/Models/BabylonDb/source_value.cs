namespace Excalibur.Models.BabylonDb
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("babylon.source_value")]
    public partial class source_value
    {
        public int id { get; set; }

        [Column(TypeName = "text")]
        [StringLength(65535)]
        public string value { get; set; }

        [StringLength(255)]
        public string description { get; set; }

        [StringLength(255)]
        public string reference { get; set; }

        public int source_id { get; set; }

        public virtual source source { get; set; }
    }
}
