namespace ShopLyraAPP.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [MetadataTypeAttribute(typeof(SupplierMetaData))]
    public partial class Supplier
    {
        internal sealed class SupplierMetaData
        {
            public int ID { get; set; }

            [DisplayName("Tên nhà sản xuất")]
            [Required(ErrorMessage ="Hãy nhập tên nhà sản xuất"),UIHint("TextBox")]
            [StringLength(250)]
            public string Name { get; set; }

            [DisplayName("Bí danh")]
            [StringLength(100)]
            public string Alias { get; set; }

            [DisplayName("Số điện thoại"),UIHint("TextBox")]
            [Required(ErrorMessage ="Hãy nhập số điện thoại"),Phone(ErrorMessage ="Bạn hãy nhập đúng dạng số điện thoại")]
            [StringLength(12)]
            public string Phone { get; set; }

            [DisplayName("Email"), UIHint("TextBox")]
            [Required(ErrorMessage = "Hãy nhập số điện thoại"), EmailAddress(ErrorMessage = "Bạn hãy nhập đúng dạng của email")]
            [StringLength(250)]
            public string Email { get; set; }

            [DisplayName("Ảnh đại diện"), UIHint("UploadMultiFile")]
            [StringLength(250)]
            public string Image { get; set; }

            [DisplayName("Logo"), UIHint("UploadMultiFile")]
            [StringLength(250)]
            public string Logo { get; set; }
        }
        
    }
}
