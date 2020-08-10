namespace ShopLyraAPP.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [MetadataTypeAttribute(typeof(ProductCartMetaData))]
    public partial class ProductCart
    {
        internal sealed class ProductCartMetaData
        {
            public long ID { get; set; }
            [DisplayName("Người tạo")]
            public long CreateBy { get; set; }
            [DisplayName("Giá bán")]
            public decimal? Price { get; set; }

        }
    }
}
