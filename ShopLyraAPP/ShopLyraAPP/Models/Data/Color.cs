using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace ShopLyraAPP.Models
{   
    [MetadataTypeAttribute(typeof(ColorMetaData))]
    public partial class Color
    {
        internal sealed class ColorMetaData
        {
            public int ID { get; set; }
            [DisplayName("Màu")]
            [Column("Color"),UIHint("TextBox")]
            [Required(ErrorMessage ="Hãy nhập màu")]
            [StringLength(50)]
            public string Color1 { get; set; }
            [DisplayName("Hiển thị")]
            public bool? Active { get; set; }
            [DisplayName("Thứ tự hiệnt thị"),UIHint("NumberBox"), RegularExpression(@"\d+", ErrorMessage = "Chỉ nhập số nguyên")]
            public int DisplayOrder { get; set; }
        } 
    }
}
