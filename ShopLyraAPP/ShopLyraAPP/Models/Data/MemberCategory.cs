namespace ShopLyraAPP.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [MetadataTypeAttribute(typeof(MemberCategoryMetaData))]
    public partial class MemberCategory
    {
        internal sealed class MemberCategoryMetaData
        {
            public int ID { get; set; }

            [DisplayName("Tên loại"),UIHint("TextBox")]
            [Required(ErrorMessage ="Hãy nhập tên loại thành viên")]
            [StringLength(250)]
            public string Name { get; set; }

            [DisplayName("Trạng thái")]
            public bool? Status { get; set; }

        }
    }
}
