namespace ShopLyraAPP.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [MetadataTypeAttribute(typeof(FeedBackMetaData))]
    public partial class FeedBack
    {
        internal sealed class FeedBackMetaData
        {
            public long ID { get; set; }

            [DisplayName("Tên khách hàng"),UIHint("TextBox")]
            [Required(ErrorMessage ="Hãy Nhập tên khách hàng phản hồi")]
            [StringLength(250)]
            public string Name { get; set; }

            [DisplayName("Đường dẫn"),UIHint("TextBox")]
            [StringLength(250)]
            public string MetaTitle { get; set; }

            [DisplayName("Tiêu đề"),UIHint("TextBox")]
            [Required(ErrorMessage ="Hãy nhập tiêu đề")]
            [StringLength(50)]
            public string TitleContent { get; set; }

            [DisplayName("Nội dung ngắn")]
            [Required(ErrorMessage ="Hãy nhập nội dung ngắn"),UIHint("TextArea")]
            [StringLength(1000)]
            public string ShortNote { get; set; }

            [DisplayName("Nội dung"),UIHint("EditorBox")]
            [Column(TypeName = "ntext")]
            [Required(ErrorMessage ="Hãy nhập nội dung")]
            public string Content { get; set; }

            [DisplayName("Hiện thị?")]
            public bool? Active { get; set; }
            [DisplayName("Nổi bật?")]
            public bool? Hot { get; set; }
            [DisplayName("Thứ tự hiển thị"),UIHint("NumberBox"), RegularExpression(@"\d+", ErrorMessage = "Chỉ nhập số nguyên")]
            public int? DisplayOrder { get; set; }
        }
    }
}
