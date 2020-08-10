namespace ShopLyraAPP.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [MetadataTypeAttribute(typeof(OrderItemMetaData))]
    public partial class OrderItem
    {
        internal sealed class OrderItemMetaData
        {
            [Key]
            [Column(Order = 0)]
            [DatabaseGenerated(DatabaseGeneratedOption.None)]
            public long IDOrder { get; set; }

            [Key]
            [Column(Order = 1)]
            [DatabaseGenerated(DatabaseGeneratedOption.None)]
            public long IDProduct { get; set; }

            [DisplayName("Số lượng mua")]
            public int QuantityPurchased { get; set; }

            [DisplayName("Giá tiền")]
            public decimal? Price { get; set; }
        }
    }
}
