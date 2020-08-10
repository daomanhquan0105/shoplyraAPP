namespace ShopLyraAPP.Models
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
            Assesses = new HashSet<Assess>();
            CartItems = new HashSet<CartItem>();
            OrderItems = new HashSet<OrderItem>();
            TagCategories = new HashSet<TagCategory>();
        }

        public long ID { get; set; }

        [StringLength(250)]
        public string Name { get; set; }

        [StringLength(250)]
        public string MetaTitle { get; set; }

        [StringLength(20)]
        public string Code { get; set; }

        [StringLength(500)]
        public string Description { get; set; }
         
        public string Images { get; set; }

        public string Location { get; set; }

        public decimal Price { get; set; }

        public int? Quantity { get; set; }

        public int SupplierID { get; set; }

        [Column(TypeName = "ntext")] 
        public string Detail { get; set; }

        public int? Warranty { get; set; }

        [Column(TypeName = "date")]
        public DateTime? CreateDate { get; set; }

        [StringLength(100)]
        public string CreateBy { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Modifiledate { get; set; }

        [StringLength(100)]
        public string ModifileBy { get; set; }

        [StringLength(1000)]
        public string ListSize { get; set; }

        [StringLength(1000)]
        public string LiseColor { get; set; }

        public int? DisplayOrder { get; set; }

        public bool? Status { get; set; }

        public bool? Active { get; set; }

        public bool? ShowOnHome { get; set; }

        public bool? HotProduct { get; set; }

        public bool? Remove { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Assess> Assesses { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CartItem> CartItems { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderItem> OrderItems { get; set; }

        public virtual Supplier Supplier { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TagCategory> TagCategories { get; set; }
    }
}
