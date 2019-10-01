using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ShopTruyenTranh.Models;

namespace ShopTruyenTranh
{
    public partial class SiteMaster : MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public IQueryable<TheLoaiTruyen> GetCategories()
        {
            var _db = new ShopTruyenTranh.Models.DinhNghiaTruyen();
            IQueryable<TheLoaiTruyen> query = _db.TheLoais;
            return query;
        }        protected void Page_PreRender(object sender, EventArgs e)
        {
            using (Logic.ShoppingCartActions usersShoppingCart = new Logic.ShoppingCartActions())
            {
                string cartStr = string.Format("Giỏ ({0})",
                usersShoppingCart.GetCount());
                cartCount.InnerText = cartStr;
            }
        }
    }
}