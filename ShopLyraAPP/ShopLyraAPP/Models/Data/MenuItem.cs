namespace ShopLyraAPP.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [MetadataTypeAttribute(typeof(MenuItemMetaData))]
    public partial class MenuItem
    {
        internal sealed class MenuItemMetaData
        {
            public int ID { get; set; }
            public int? IDMenu { get; set; }

            [DisplayName("Tên")]
            [Required(ErrorMessage ="Hãy nhập tên menu")]
            [StringLength(250)]
            public string Name { get; set; }

            [DisplayName("Đường dẫn")]
            [Required(ErrorMessage ="Hãy nhập đường dẫn")]
            [StringLength(250)]
            public string Url { get; set; }

            [DisplayName("Hiển thị?")]
            public bool? Active { get; set; }

            [DisplayName("Thứ tự hiện thị"), Required(ErrorMessage = "Hãy nhập số thứ tự"), RegularExpression(@"\d+", ErrorMessage = "Chỉ nhập số nguyên dương")]
            public int? DisplayOrder { get; set; }
        }
    }
}
