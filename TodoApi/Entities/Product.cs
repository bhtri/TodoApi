using System;
using System.Collections.Generic;

namespace TodoApi.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public decimal Price { get; set; }
        public decimal OriginalPrice { get; set; }
        public int Stock { get; set; }
        public int ViewCount { get; set; }
        public DateTime DateCreated { get; set; }
        public string SeoAlias { get; set; }

        public List<ProductInCategory> ProductInCategories { get; set; }

        public List<OrderDetail> OrderDetails { get; set; }

        public List<Cart> Carts { get; set; }

        public List<ProductTranslation> ProductTranslations { get; set; }
    }
}

///
/// Cau hinh thuoc tinh kieu du lieu ntn trong DB (Configure entity):
/// +> Attribute configuration (dung cac thuoc tinh de chi ra [Table], [Required], ...)
/// +> Fluent API configuration (* common) (khong dung gi toi class -> config o ngoai)
///