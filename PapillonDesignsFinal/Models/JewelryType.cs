namespace PapillonDesignsFinal.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    [DisplayName("Type of Jewelry")]
    [Table("JewelryType")]
    public partial class JewelryType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public JewelryType()
        {
            Jewelries = new HashSet<Jewelry>();
        }

        public int JewelryTypeId { get; set; }

        [Required]
        [StringLength(100)]
        public string JewelryTypeName { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Jewelry> Jewelries { get; set; }
    }
}
