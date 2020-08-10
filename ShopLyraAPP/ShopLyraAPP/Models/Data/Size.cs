namespace ShopLyraAPP.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [MetadataTypeAttribute(typeof(SizeMetaData))]
    public partial class Size
    {
        internal sealed class SizeMetaData
        {
            public int ID { get; set; }

            [DisplayName("Size")]
            [Column("Size")]
            [Required(ErrorMessage ="Hãy nhập size")]
            [StringLength(10)]
            public string Size1 { get; set; }
            [DisplayName("Hiển thị")]
            public bool? Active { get; set; }
            [DisplayName("Thứ tự hiện thị"), RegularExpression(@"\d+", ErrorMessage = "Chỉ nhập số nguyên dương"),UIHint("NumberBox")]
            public int DisplayOrder { get; set; }

        }
    }
}
