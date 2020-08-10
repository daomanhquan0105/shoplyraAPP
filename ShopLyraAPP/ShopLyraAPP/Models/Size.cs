namespace ShopLyraAPP.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Size
    {
        public int ID { get; set; }

        [Column("Size"), UIHint("TextBox")]
        [Required(ErrorMessage ="Nhập size")]
        [StringLength(10)]
        public string Size1 { get; set; }

        public bool? Active { get; set; }

        public int DisplayOrder { get; set; }
    }
}
