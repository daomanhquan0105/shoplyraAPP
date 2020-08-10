namespace ShopLyraAPP.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("FeedBack")]
    public partial class FeedBack
    {
        public long ID { get; set; }

        [StringLength(250)]
        public string Name { get; set; }

        [StringLength(250)]
        public string Image { get; set; }

        [StringLength(250)]
        public string Location { get; set; }

        [StringLength(250)]
        public string MetaTitle { get; set; }

        [StringLength(50)]
        public string TitleContent { get; set; }

        [StringLength(1000)]
        public string ShortNote { get; set; }

        [Column(TypeName = "ntext")] 
        public string Content { get; set; }

        public bool? Active { get; set; }

        public bool? Hot { get; set; }

        public int? DisplayOrder { get; set; }
    }
}
