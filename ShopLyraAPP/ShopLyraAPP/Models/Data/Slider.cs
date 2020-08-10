namespace ShopLyraAPP.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [MetadataTypeAttribute(typeof(SliderMetaData))]
    public partial class Slider
    {
        internal sealed class SliderMetaData
        {
            public int ID { get; set; }

            [UIHint("UploadMultiFile"),DisplayName("Hình ảnh")]
            [StringLength(250)]
            public string Image { get; set; }

            [DisplayName("Đường dẫn")]
            public int? Location { get; set; }

            [DisplayName("Tiêu đề")]
            [StringLength(250), UIHint("TextBox"),Required(ErrorMessage ="Hãy nhập tiêu đề")]
            public string Title { get; set; }

            [StringLength(250)]
            [DisplayName("Url config")]
            public string MetaTitle { get; set; }

            [DisplayName("Nội dung ngắn")]
            [Required(ErrorMessage ="Hãy nhập nội dung"),UIHint("TextArea")]
            [StringLength(500)]
            public string ShortContent { get; set; }

            [DisplayName("Địa chỉ")]
            [Required(ErrorMessage = "Hãy nhập link"),UIHint("TextBox")]
            [StringLength(250)]
            public string Url { get; set; }

            [DisplayName("Nội dung")]
            [Column(TypeName = "ntext"), UIHint("EditorBox")]
            public string Content { get; set; }

            [DisplayName("Ngày tạo")]
            [Column(TypeName = "date"), UIHint("DateTimePicker")]
            public DateTime? CreateDate { get; set; }

            [DisplayName("Người tạo")]
            [StringLength(100)]
            public string CreateBy { get; set; }

            [DisplayName("Ngày sửa")]
            [Column(TypeName = "date"), UIHint("DateTimePicker")]
            public DateTime? Modifiledate { get; set; }

            [DisplayName("Người sửa")]
            [StringLength(100)]
            public string ModifileBy { get; set; }

            [DisplayName("Hiển thị?")]
            public bool? Active { get; set; }

            [DisplayName("Trình tư")]
            [UIHint("NumberBox"), RegularExpression(@"\d+", ErrorMessage = "Chỉ nhập số nguyên dương"),UIHint("NumberBox")]
            public int? DisplayOrder { get; set; }

            [DisplayName("Nổi bật")]
            public bool? Hot { get; set; }
        }
    }
}
