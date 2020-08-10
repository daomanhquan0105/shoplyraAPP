using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace ShopLyraAPP.Models
{
    [MetadataTypeAttribute(typeof(CartItemMetaData))]
    public partial class CartItem
    {
        internal sealed class CartItemMetaData
        {
            [Key]
            [Column(Order = 0)]
            [DatabaseGenerated(DatabaseGeneratedOption.None)]
            public long IDCart { get; set; }

            [Key]
            [Column(Order = 1)]
            [DatabaseGenerated(DatabaseGeneratedOption.None)]
            public long IDProduct { get; set; }
            [DisplayName("Số lượng"), RegularExpression(@"\d+", ErrorMessage = "Chỉ nhập số nguyên")]
            public int? Quantity { get; set; }
            [DisplayName("Đơn giá")]
            public decimal? Price { get; set; }
            [DisplayName("Ngày thêm")]
            [Column(TypeName = "date")]
            public DateTime? InsertDate { get; set; }
        }
    }
}
