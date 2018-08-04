namespace Excalibur.Models.BabylonDb
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("babylon.rule")]
    public partial class rule
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public rule()
        {
            source_rule = new HashSet<source_rule>();
        }

        public int id { get; set; }

        [Required]
        [StringLength(50)]
        public string type { get; set; }

        public int operator_id { get; set; }

        [StringLength(255)]
        public string description { get; set; }

        [Column(TypeName = "text")]
        [StringLength(65535)]
        public string value { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<source_rule> source_rule { get; set; }

        public virtual rule_operator rule_operator { get; set; }
    }
}
