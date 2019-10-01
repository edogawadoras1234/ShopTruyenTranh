using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace ShopTruyenTranh.Models
{
    public class DinhNghiaTruyen : DbContext
    {
        public DinhNghiaTruyen() : base("ShopTruyenTranh")
        { }
        public DbSet<TheLoaiTruyen> TheLoais { get; set; }
        public DbSet<TruyenTranh> TruyenTranhs { get; set; }
        public DbSet<CartItem> ShoppingCartItems { get; set; }
    }
}