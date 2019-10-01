using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.ModelBinding;
using ShopTruyenTranh.Models;

namespace ShopTruyenTranh
{
    public partial class DanhSach : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public IQueryable<TruyenTranh> GetBooks([QueryString("id")] int? categoryId)
        {
            var _db = new ShopTruyenTranh.Models.DinhNghiaTruyen();
            IQueryable<TruyenTranh> query = _db.TruyenTranhs;
            if (categoryId.HasValue && categoryId > 0)
            {
                query = query.Where(p => p.MaTL == categoryId);
            }
            return query;
        }
    }
}