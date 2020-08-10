using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ShopLyraAPP.Models;

namespace ShopLyraAPP.ViewModel
{
    public class ListProductViewModel
    {
        public List<Product> listProduct { get; set; } = new List<Product>();
        public List<Supplier> listSupplier { get; set; } = new List<Supplier>();
        public List<ProductCategory> listCategory { get; set; } = new List<ProductCategory>();
        public List<TagCategory> listTag { get; set; } = new List<TagCategory>();
    }

    public class CRUDProduct
    {
        public Product product { get; set; }
        public List<ProductCategory> listCategory { get; set; } = new List<ProductCategory>();
    }
}