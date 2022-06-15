namespace Trade.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Product")]
    public partial class Product
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Product()
        {
            OrderProduct = new HashSet<OrderProduct>();
        }

        [Key]
        [StringLength(50)]
        public string ProductArticleNumber { get; set; }

        [StringLength(50)]
        public string ProductName { get; set; }

        [StringLength(50)]
        public string ProductDescription { get; set; }

        [StringLength(50)]
        public string ProductCategory { get; set; }

        [StringLength(50)]
        public string ProductPhoto { get; set; }

        [StringLength(50)]
        public string ProductManufacture { get; set; }

        [StringLength(50)]
        public string ProductCost { get; set; }

        [StringLength(50)]
        public string ProductDiscountAmount { get; set; }

        [StringLength(50)]
        public string ProductQuantityStock { get; set; }

        [StringLength(50)]
        public string ProductStatus { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderProduct> OrderProduct { get; set; }
    }
}
