namespace ShopLyraAPP.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [MetadataTypeAttribute(typeof(TagCategoryMetaData))]
    public partial class TagCategory
    {
        internal sealed class TagCategoryMetaData
        {

            [Key]
            [Column(Order = 0)]
            [DatabaseGenerated(DatabaseGeneratedOption.None)]
            public long CategoryID { get; set; }

            [Key]
            [Column(Order = 1)]
            [DatabaseGenerated(DatabaseGeneratedOption.None)]
            public long ProductID { get; set; }

            [DisplayName("Tag name")]
            [StringLength(50)]
            public string Name { get; set; }
        }
    }
}
