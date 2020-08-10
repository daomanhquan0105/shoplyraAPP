namespace ShopLyraAPP.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PostCategory
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PostCategory()
        {
            TagPosts = new HashSet<TagPost>();
            Active = true;
            ShowOnHome = false;
        }

        public long ID { get; set; }

        public string Name { get; set; }

        public string MetaTitle { get; set; }

        public int? DisplayOrder { get; set; }

        [Column(TypeName = "date")]
        public DateTime? CreateDate { get; set; }

        [StringLength(100)]
        public string CreateBy { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Modifiledate { get; set; }

        [StringLength(100)]
        public string ModifileBy { get; set; }

        public bool? Active { get; set; }

        public bool? ShowOnHome { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TagPost> TagPosts { get; set; }
    }
}
