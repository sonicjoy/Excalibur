namespace Excalibur.Models.BabylonDb
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("babylon.rule_operator")]
    public partial class rule_operator
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public rule_operator()
        {
            rules = new HashSet<rule>();
        }

        public int id { get; set; }

        [Column("operator")]
        [Required]
        [StringLength(20)]
        public string _operator { get; set; }

        [Required]
        [StringLength(20)]
        public string type { get; set; }

        [StringLength(100)]
        public string description { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<rule> rules { get; set; }
    }
}
