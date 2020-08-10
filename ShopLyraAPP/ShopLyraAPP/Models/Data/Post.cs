namespace ShopLyraAPP.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Runtime.CompilerServices;

    [MetadataTypeAttribute(typeof(PostMetaData))]
    public partial class Post
    {
        internal sealed class PostMetaData
        {
            public long ID { get; set; }

            [DisplayName("Tên bài đăng")]
            [Required(ErrorMessage ="Hãy nhập tên bài đăng")]
            [StringLength(250),UIHint("TextBox")]
            public string Name { get; set; }

            [DisplayName("Cấu hình url"),UIHint("TextBox")]
            [StringLength(250)]
            public string MetaTitle { get; set; }

            [DisplayName("Miêu tả ngắn"),UIHint("TextArea")]
            [Required(ErrorMessage ="Nhập miêu tả ngắn")]
            [StringLength(500)]
            public string Description { get; set; }

            [DisplayName("Ảnh đại diện"),UIHint("UploadMultiFile")]
            public string Images { get; set; }

            [DisplayName("Thứ tự hiện thị"), RegularExpression(@"\d+", ErrorMessage = "Chỉ nhập số nguyên dương"),UIHint("NumberBox")]
            public int? DisplayOrder { get; set; }

            [DisplayName("Nội dung")]
            [Column(TypeName = "ntext"),UIHint("EditorBox")]
            [Required(ErrorMessage ="Nhập nội dung")]
            public string Content { get; set; }

            [DisplayName("Ngày viết"),UIHint("DateTimePicker")]
            [Required(ErrorMessage ="Ngày viết")]
            [Column(TypeName = "date")]
            public DateTime? CreateDate { get; set; }

            [DisplayName("Người viết")]
            [StringLength(100)]
            public string CreateBy { get; set; }

            [DisplayName("Ngày sửa"), UIHint("DateTimePicker")]
            [Column(TypeName = "date")]
            public DateTime? Modifiledate { get; set; }

            [DisplayName("Người sửa")]
            [StringLength(100)]
            public string ModifileBy { get; set; }

            [DisplayName("Hiển thị")]
            public bool? Active { get; set; }

            [DisplayName("Show trang chủ")]
            public bool? ShowOnHome { get; set; }

            [DisplayName("Tin nổi bật?")]
            public bool? HotPost { get; set; }

            [DisplayName("Xóa?")]
            public bool? Remove { get; set; }
        }

    }
}
