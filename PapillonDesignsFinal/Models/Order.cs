namespace PapillonDesignsFinal.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Order
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Order()
        {
            OrderDetails = new HashSet<OrderDetail>();
        }
        [DisplayName("Order Id")]
        public int OrderId { get; set; }

        [DisplayName("Order Date")]
        public DateTime? OrderDate { get; set; }

        public decimal? Total { get; set; }

        [DisplayName("Customer Id")]
        public int CustomerId { get; set; }

        public virtual Customer Customer { get; set; }



        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
