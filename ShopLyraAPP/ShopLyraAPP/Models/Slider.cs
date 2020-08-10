namespace ShopLyraAPP.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Slider
    {
        public int ID { get; set; }

        [StringLength(250)]
        public string Image { get; set; }

        public int? Location { get; set; }

        [StringLength(250)]
        public string Title { get; set; }

        [StringLength(250)]
        public string MetaTitle { get; set; }

        [StringLength(500)]
        public string ShortContent { get; set; }

        [Required(ErrorMessage ="Hãy nhập link")]
        [StringLength(250)]
        public string Url { get; set; }

        [Column(TypeName = "ntext")]
        public string Content { get; set; }

        [Column(TypeName = "date"), UIHint("DateTimePicker")]
        public DateTime? CreateDate { get; set; }

        [StringLength(100)]
        public string CreateBy { get; set; }

        [Column(TypeName = "date"), UIHint("DateTimePicker")]
        public DateTime? Modifiledate { get; set; }

        [StringLength(100)]
        public string ModifileBy { get; set; }

        public bool? Active { get; set; }
        [UIHint("NumberBox"), RegularExpression(@"\d+", ErrorMessage = "Chỉ nhập số nguyên dương")]
        public int? DisplayOrder { get; set; }

        public bool? Hot { get; set; }
    }
}
