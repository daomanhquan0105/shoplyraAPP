namespace ShopLyraAPP.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [MetadataTypeAttribute(typeof(OrderMetaData))]
    public partial class Order
    {
        internal sealed class OrderMetaData
        {

            public long ID { get; set; }
            public long IdMember { get; set; }

            [DisplayName("Ngày đặt")]
            [Column(TypeName = "date")]
            public DateTime? CreateDate { get; set; }

            [DisplayName("Người đặt")]
            [Required(ErrorMessage ="Nhập tên người nhập" )]
            [StringLength(250)]
            public string CreateBy { get; set; }

            [DisplayName("Thành tiền")]
            [Required(ErrorMessage ="Nhập giá tiền của hóa đơn")]
            public decimal? Price { get; set; }

            [DisplayName("Dạng thanh toán")]
            [Required(ErrorMessage ="Chọn loại thanh toán")]
            public int? Payment { get; set; }

            [DisplayName("Ngày giao")]
            [Required(ErrorMessage ="Nhập ngày giao hàng")]
            [Column(TypeName = "date"), UIHint("DateTimePicker")]
            public DateTime? ShipDate { get; set; }

            [DisplayName("Người giao")]
            [Required(ErrorMessage ="Nhập tên người giao")]
            [StringLength(250)]
            public string ShipBy { get; set; }

            [DisplayName("Tình trang?")]
            public bool? Status { get; set; }

            public bool? Remove { get; set; }
        }
    }
}
