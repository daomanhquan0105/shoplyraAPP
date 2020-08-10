using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace ShopLyraAPP.Models
{
    
    [MetadataTypeAttribute(typeof(ProductMetaData))]
    public partial class Product
    {
        internal sealed class ProductMetaData
        {
            public long ID { get; set; }

            [DisplayName("Tên sản phẩm"),UIHint("TextBox")]
            [Required(ErrorMessage ="Hãy nhập tên cho sản phẩm")]
            [StringLength(250)]
            public string Name { get; set; }

            [DisplayName("Cấu hình đường dẫn"),UIHint("TextBox")]
            [StringLength(250)]
            public string MetaTitle { get; set; }

            [DisplayName("Mã sản phẩm"),UIHint("TextBox")]
            [Required(ErrorMessage ="Hãy nhập mã cho sản phẩm")]
            [StringLength(20)]
            public string Code { get; set; }

            [DisplayName("Miêu tả ngắn"),UIHint("TextArea")]
            [Required(ErrorMessage ="Hãy miêu tả ngắn về sản phẩm")]
            [StringLength(500)]
            public string Description { get; set; }

            [DisplayName("Hình ảnh"),UIHint("UploadMultiFile")]
            public string Images { get; set; }

            [DisplayName("Đơn giá"),UIHint("NumberBox"), RegularExpression(@"\d+", ErrorMessage = "Chỉ nhập số nguyên dương")]
            [Required(ErrorMessage ="Hãy nhập giá cho sản phẩm")]
            public decimal Price { get; set; }

            [DisplayName("Số lượng tồn"),UIHint("NumberBox")]
            [Required(ErrorMessage ="Nhập số lượng cho sản phẩm")]
            public int? Quantity { get; set; }

            [DisplayName("Nhà sản xuất")]
            [Required(ErrorMessage ="Chọn hãng sản xuất của sản phẩm")]
            public int SupplierID { get; set; }

            [DisplayName("Miêu tả chi tiết"),UIHint("EditorBox")]
            [Column(TypeName = "ntext")]
            [Required(ErrorMessage ="Hãy miêu tả chi tiết cho sản phẩm")]
            public string Detail { get; set; }

            [DisplayName("Thời gian đổi trả"),UIHint("NumberBox"), RegularExpression(@"\d+", ErrorMessage = "Chỉ nhập số nguyên dương")]
            public int? Warranty { get; set; }

            [DisplayName("Ngày tạo"),UIHint("DateTimePicker"),Required(ErrorMessage ="Hãy chọn ngày thêm")]
            [Column(TypeName = "date")]
            public DateTime? CreateDate { get; set; }

            [DisplayName("Người tạo"),UIHint("TextBox"),Required(ErrorMessage ="Hãy nhập người tạo")]
            [StringLength(100)]
            public string CreateBy { get; set; }

            [DisplayName("Ngày sửa"), UIHint("DateTimePicker")]
            [Column(TypeName = "date")]
            public DateTime? Modifiledate { get; set; }

            [DisplayName("Người sửa"), UIHint("TextBox")]
            [StringLength(100)]
            public string ModifileBy { get; set; }

            [DisplayName("Danh sách size")]
            [Required(ErrorMessage ="Hãy nhập size cho sản phẩm")]
            [StringLength(1000)]
            public string ListSize { get; set; }

            [DisplayName("Danh sách màu")]
            [Required(ErrorMessage ="Hãy nhập màu cho sản phẩm")]
            [StringLength(1000)]
            public string LiseColor { get; set; }

            [DisplayName("Thứ tự hiển thị"),UIHint("NumberBox"), RegularExpression(@"\d+", ErrorMessage = "Chỉ nhập số nguyên dương")]
            [Required(ErrorMessage = "Hãy nhập thứ tự hiện thị cho sản phẩm")]
            public int? DisplayOrder { get; set; }

            [DisplayName("Tình trạng")]
            public bool? Status { get; set; }

            [DisplayName("Hiển thị?")]
            public bool? Active { get; set; }

            [DisplayName("Show trang chủ")]
            public bool? ShowOnHome { get; set; }
            [DisplayName("Sản phẩm nổi bật")]
            public bool? HotProduct { get; set; }
            [DisplayName("Xóa?")]
            public bool? Remove { get; set; }
        }
    }
}
