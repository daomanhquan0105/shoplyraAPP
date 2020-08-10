namespace ShopLyraAPP.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CartItem")]
    public partial class CartItem
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long IDCart { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long IDProduct { get; set; }

        public int? Quantity { get; set; }

        public decimal? Price { get; set; }

        [Column(TypeName = "date")]
        public DateTime? InsertDate { get; set; }

        public virtual Product Product { get; set; }

        public virtual ProductCart ProductCart { get; set; }
    }
}
