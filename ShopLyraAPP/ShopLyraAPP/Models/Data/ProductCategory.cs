namespace ShopLyraAPP.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [MetadataTypeAttribute(typeof(ProductCategoryMetaData))]
    public partial class ProductCategory
    {
        internal sealed class ProductCategoryMetaData
        {
            public long ID { get; set; }

            [DisplayName("Tên loại sản phẩm"),UIHint("TextBox")]
            [Required(ErrorMessage ="Hãy nhập tên cho loại sản phẩm")]
            [StringLength(250)]
            public string Name { get; set; }

            [DisplayName("Cấu hình đường dẫn")]
            [StringLength(250)]
            public string MetaTitle { get; set; }

            [DisplayName("Thứ tự hiện thị"), RegularExpression(@"\d+", ErrorMessage = "Chỉ nhập số nguyên dương")]
            [Required(ErrorMessage ="Hãy chọn thứ tự hiển thị"),UIHint("NumberBox")]
            public int? DisplayOrder { get; set; }

            [StringLength(250)]
            public string SeoTitle { get; set; }

            [DisplayName("Ảnh đại diện"),UIHint("UploadMultiFile")]
            [StringLength(250)]
            public string Image { get; set; }

            [DisplayName("Logo"), UIHint("UploadMultiFile")]
            [StringLength(250)]
            public string Logo { get; set; }

            [DisplayName("Ngày tạo"), UIHint("DateTimePicker")]
            [Column(TypeName = "date")]
            public DateTime? CreateDate { get; set; }   

            [DisplayName("Người tạo"), UIHint("TextBox"),Required(ErrorMessage ="Nhập người tạo")]
            [StringLength(100)]
            public string CreateBy { get; set; }

            [DisplayName("Ngày sửa"), UIHint("DateTimePicker")]
            [Column(TypeName = "date")]
            public DateTime? Modifiledate { get; set; }

            [DisplayName("Người sủa"), UIHint("TextBox")]
            [StringLength(100)]
            public string ModifileBy { get; set; }

            [DisplayName("Hiển thị")]
            public bool? Active { get; set; }

            [DisplayName("Show trang chủ")]
            public bool? ShowOnHome { get; set; }
        }

    }
}
