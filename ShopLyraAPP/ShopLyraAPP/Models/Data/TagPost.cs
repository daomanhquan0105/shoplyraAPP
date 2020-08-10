namespace ShopLyraAPP.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [MetadataTypeAttribute(typeof(TagPostMetaData))]
    public partial class TagPost
    {
        internal sealed class TagPostMetaData
        {
            [Key]
            [Column(Order = 0)]
            [DatabaseGenerated(DatabaseGeneratedOption.None)]
            public long CategoryID { get; set; }

            [Key]
            [Column(Order = 1)]
            [DatabaseGenerated(DatabaseGeneratedOption.None)]
            public long PostID { get; set; }

            public bool? Active { get; set; }

            [StringLength(50)]
            public string TagName { get; set; }
        }
    }
}
