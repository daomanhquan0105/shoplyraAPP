using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace ShopLyraAPP.Models
{
    [MetadataTypeAttribute(typeof(AssessMetaData))]
    public partial class Assess
    {
        internal sealed class AssessMetaData
        {
            [Key]
            [Column(Order = 0)]
            [DatabaseGenerated(DatabaseGeneratedOption.None)]
            public long IDProduct { get; set; }

            [Key]
            [Column(Order = 1)]
            [DatabaseGenerated(DatabaseGeneratedOption.None)]
            public long IDMember { get; set; }

            [DisplayName("Tiêu đề")]
            [Required(ErrorMessage ="Hãy nhập tiêu đề cho phần đánh giá")]
            [StringLength(250)]
            public string Title { get; set; }

            [DisplayName("Nội dung ngắn")]
            [Required(ErrorMessage ="Hãy nhập nội dung ngắn"),UIHint("TextArea")]
            [StringLength(1000)]
            public string ShortContent { get; set; }

            [DisplayName("Chất lượng")]
            [UIHint("NumberBox")]
            public int? NumberStar { get; set; }

            [DisplayName("Nội dung"),UIHint("EditorBox")]
            public string Content { get; set; }

        }
    }
}
