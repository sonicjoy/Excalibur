namespace Excalibur.Models.BabylonDb
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("babylon.mapping")]
    public partial class mapping
    {
        public int id { get; set; }

        [Required]
        [StringLength(100)]
        public string name { get; set; }

        [StringLength(255)]
        public string description { get; set; }

        public int source_id { get; set; }

        public int target_id { get; set; }

        public virtual source source { get; set; }

        public virtual target target { get; set; }
    }
}
