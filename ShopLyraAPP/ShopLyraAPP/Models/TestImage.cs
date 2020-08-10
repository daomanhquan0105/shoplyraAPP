using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ShopLyraAPP.Models
{
    public class TestImage
    {
        [Required(ErrorMessage ="Nhap ten")]
        public string Name { get; set; }
        [Required(ErrorMessage ="Chon anh")]
        public string Image { get; set; }
    }
}