namespace ShopLyraAPP.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Color
    {
        public int ID { get; set; }

        [Column("Color")]
        [Required]
        [StringLength(50)]
        public string Color1 { get; set; }

        public bool? Active { get; set; }

        public int DisplayOrder { get; set; }
    }
}
