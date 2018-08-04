namespace Excalibur.Models.BabylonDb
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("babylon.source_rule")]
    public partial class source_rule
    {
        public int id { get; set; }

        [Required]
        [StringLength(100)]
        public string name { get; set; }

        [StringLength(255)]
        public string description { get; set; }

        public int rule_id { get; set; }

        public int source_id { get; set; }

        public virtual rule rule { get; set; }

        public virtual source source { get; set; }
    }
}
