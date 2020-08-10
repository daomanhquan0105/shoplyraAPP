using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace ShopLyraAPP.Models
{
    [MetadataTypeAttribute(typeof(ConfigMetaData))]
    public partial class Config
    {
        internal sealed class ConfigMetaData
        {
            public int ID { get; set; }

            [DisplayName("Số điệnt thoại")]
            [StringLength(12),Phone(ErrorMessage ="Phải là các chữ số"),MaxLength(12),Required(ErrorMessage ="Hãy nhập số điện thoại"),UIHint("TextBox")]
            public string Phone { get; set; }


            [DisplayName("Nội dung bên dưới"),UIHint("TextArea")]
            [Required(ErrorMessage ="Hãy nhập nội dung cho phần bên dưới")]
            [StringLength(1000)]
            public string ContentFooter { get; set; }

            [DisplayName("Địa chỉ"),UIHint("EditorBox")]
            [Required(ErrorMessage ="Hãy nhập địa chỉ")]
            public string Address { get; set; }

            [DisplayName("Các liên kê muốn hiện"),Required(ErrorMessage ="Hãy nhập liên kết chỉ"), UIHint("EditorBox")]
            [StringLength(500)]
            public string LinkFast { get; set; }

            [DisplayName("Link trang FaceBook"), UIHint("TextArea")]
            [Required(ErrorMessage ="hãy nhập link trang facebook")]
            [StringLength(500)]
            public string FacebookFanpage { get; set; }

            [DisplayName("Liên hệ"), UIHint("EditorBox")]
            public string Contact { get; set; }

            [DisplayName("Ngày tạo")]
            [Column(TypeName = "date"), UIHint("DateTimePicker")]
            public DateTime? CreateDate { get; set; }

            [DisplayName("Người tạo")]
            [StringLength(250)]
            public string CreateBy { get; set; }

            [DisplayName("Ngày sửa")]
            [Column(TypeName = "date"), UIHint("DateTimePicker")]
            public DateTime? ModifileDate { get; set; }

            [DisplayName("Người sửa")]
            [StringLength(250)]
            public string ModifileBy { get; set; }
            [DisplayName("Hiện thị")]
            public bool? Active { get; set; }
        }
        
    }
}
