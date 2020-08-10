using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace ShopLyraAPP.Models
{
    [MetadataTypeAttribute(typeof(AboutMetaData))]
    public partial class About
    {
        internal sealed class AboutMetaData
        {
            public int ID { get; set; }

            [DisplayName("Tên công ty")]
            [Required(ErrorMessage = "Hãy nhập tên công ty")]
            [StringLength(250)]
            [UIHint("TextBox")]
            public string Name { get; set; }

            [DisplayName("Đường dẫn")]
            [StringLength(250)]
            [UIHint("TextBox")]
            public string MetaTitle { get; set; }

            [DisplayName("Miêu tả ngắn")]
            [Required(ErrorMessage ="Hãy nhập vài dòng miêu tả  ngắn")]
            [StringLength(500)]
            [UIHint("TextArea")]
            public string Desciption { get; set; }

            [DisplayName("Miêu tả công ty")]
            [Column(TypeName = "ntext")]
            [Required(ErrorMessage ="Hãy miêu tả chi tiết về công ty bạn")]
            [UIHint("EditorBox")]
            public string Detail { get; set; }

            [DisplayName("Ngày viết")]
            [Required(ErrorMessage ="Ngày viết")]
            [Column(TypeName = "date"),UIHint("DateTimePicker")]
            public DateTime? CreateDate { get; set; }

            [DisplayName("Người tạo")]
            [StringLength(250)]
            [UIHint("TextBox")]
            public string CreateBy { get; set; }

            [DisplayName("Ngày sửa")]
            [Column(TypeName = "date"), UIHint("DateTimePicker")]
            public DateTime? ModifileDate { get; set; }

            [DisplayName("Người sửa")]
            [StringLength(250)]
            [UIHint("TextBox")]
            public string ModifileBy { get; set; }

            [DisplayName("Hiển thị")]
            public bool? Active { get; set; }
        }
    }
}
