namespace Excalibur.Models.BabylonDb
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("babylon.target")]
    public partial class target
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public target()
        {
            mappings = new HashSet<mapping>();
            target_value = new HashSet<target_value>();
        }

        public int id { get; set; }

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
        public virtual ICollection<target_value> target_value { get; set; }
    }
}
