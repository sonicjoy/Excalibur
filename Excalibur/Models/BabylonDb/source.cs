namespace Excalibur.Models.BabylonDb
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("babylon.source")]
    public partial class source
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public source()
        {
            mappings = new HashSet<mapping>();
            source_rule = new HashSet<source_rule>();
            source_value = new HashSet<source_value>();
        }

        public int id { get; set; }

        public int system_id { get; set; }

        [Required]
        [StringLength(100)]
        public string entity_name { get; set; }

        [Required]
        [StringLength(100)]
        public string field_name { get; set; }

        [Required]
        [StringLength(20)]
        public string data_type { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<mapping> mappings { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<source_rule> source_rule { get; set; }

        public virtual system system { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<source_value> source_value { get; set; }
    }
}
