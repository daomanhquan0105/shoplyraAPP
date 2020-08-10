namespace ShopLyraAPP.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [MetadataTypeAttribute(typeof(MenuMetaData))]
    public partial class Menu
    {
        internal sealed class MenuMetaData
        {
            public int ID { get; set; }

            [DisplayName("Tên")]
            [Required(ErrorMessage ="Nhập tên menu")]
            [StringLength(250)]
            public string Name { get; set; }

            [DisplayName("Đường dẫn")]
            [Required(ErrorMessage ="Nhập đường dẫn đến menu")]
            [StringLength(250)]
            public string Url { get; set; }

            [DisplayName("Hiển thị?")]
            public bool? Active { get; set; }

            [DisplayName("Show trang chủ?")]
            public bool? ShowOnHome { get; set; }
            [DisplayName("Thứ tự hiện thị"),UIHint("NumberBox"), Required(ErrorMessage ="Hãy nhập số thứ tự"), RegularExpression(@"\d+", ErrorMessage = "Chỉ nhập số nguyên dương")]
            public int? DisplayOrder { get; set; }
        }
    }
}
