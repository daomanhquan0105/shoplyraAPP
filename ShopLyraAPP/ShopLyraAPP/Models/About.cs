namespace ShopLyraAPP.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("About")]
    public partial class About
    {
        public int ID { get; set; }

        [StringLength(250)]
        public string Name { get; set; }

        [StringLength(250)]
        public string MetaTitle { get; set; }

        [StringLength(500)]
        public string Desciption { get; set; }

        [Column(TypeName = "ntext")]
        public string Detail { get; set; }

        [Column(TypeName = "date")]
        public DateTime? CreateDate { get; set; }

        [StringLength(250)]
        public string CreateBy { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ModifileDate { get; set; }

        [StringLength(250)]
        public string ModifileBy { get; set; }

        public bool? Active { get; set; }
    }
}
