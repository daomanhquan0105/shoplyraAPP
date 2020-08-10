namespace ShopLyraAPP.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [MetadataTypeAttribute(typeof(PostCategoryMetaData))]
    public partial class PostCategory
    {
        internal sealed class PostCategoryMetaData
        {
            public long ID { get; set; }

            [DisplayName("Tên loại"),UIHint("TextBox")]
            [Required(ErrorMessage ="Nhập tên loại")]
            [StringLength(250)]
            public string Name { get; set; }

            [DisplayName("Cấu hình url"),UIHint("TextBox")]
            [StringLength(250)]
            public string MetaTitle { get; set; }

            [DisplayName("Thứ tự hiện thị"),Required(ErrorMessage ="Nhập thứ tự"), RegularExpression(@"\d+", ErrorMessage = "Chỉ nhập số nguyên dương"),UIHint("NumberBox")]
            public int? DisplayOrder { get; set; }

            [DisplayName("Ngày tạo"),UIHint("DateTimePicker")]
            [Column(TypeName = "date")]
            public DateTime? CreateDate { get; set; }

            [DisplayName("Người tạo"),Required(ErrorMessage ="Nhập người tạo")]
            [StringLength(100)]
            public string CreateBy { get; set; }

            [DisplayName("Ngày sửa"),UIHint("DateTimePicker")]
            [Column(TypeName = "date")]
            public DateTime? Modifiledate { get; set; }

            [DisplayName("Người sửa")]
            [StringLength(100)]
            public string ModifileBy { get; set; }

            [DisplayName("Hiển thi?"),Required(ErrorMessage ="Hãy chọn hiển thị hoặc không")]
            public bool? Active { get; set; }

            [DisplayName("Show trang chủ?")]
            public bool? ShowOnHome { get; set; }
        }

    }
}
