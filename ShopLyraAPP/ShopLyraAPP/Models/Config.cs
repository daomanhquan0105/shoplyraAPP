namespace ShopLyraAPP.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Config")]
    public partial class Config
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        [StringLength(12)]
        public string Phone { get; set; }

        [StringLength(1000)]
        public string ContentFooter { get; set; }

        public string Address { get; set; }

        [StringLength(500)]
        public string LinkFast { get; set; }

        [StringLength(500)]
        public string FacebookFanpage { get; set; }

        public string Contact { get; set; }

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
