using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ShopTruyenTranh.Models;
using System.Web.ModelBinding;

namespace ShopTruyenTranh
{
    public partial class ChiTietSach : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public IQueryable<TruyenTranh> GetDetails([QueryString("bookID")] int? bookId)
        {
            var _db = new ShopTruyenTranh.Models.DinhNghiaTruyen();
            IQueryable<TruyenTranh> query = _db.TruyenTranhs;
            if (bookId.HasValue && bookId > 0)
            {
                query = query.Where(p => p.MaTruyen == bookId);
            }
            else
            {
                query = null;
            }
            return query;
        }
    }
}