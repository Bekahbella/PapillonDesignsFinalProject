namespace PapillonDesignsFinal.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Jewelry")]
    public partial class Jewelry
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Jewelry()
        {
            OrderDetails = new HashSet<OrderDetail>();
        }
        [DisplayName("Jewelry Id")]
        public int JewelryId { get; set; }

        [DisplayName("Name")]
        [Required]
        [StringLength(100)]
        public string Title { get; set; }

        [DisplayName("Cost")]
        public decimal Price { get; set; }

        [Required]
        [StringLength(800)]
        public string Description { get; set; }

        [StringLength(100)]
        public string Color { get; set; }


        [DisplayName("Image")]
        [StringLength(255)]
        public string ImageURL { get; set; }

        public int JewelryTypeId { get; set; }
        [DisplayName("")]
        public virtual JewelryType JewelryType { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
