using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ShopTruyenTranh.Models
{
    public class TruyenTranh
    {
        [ScaffoldColumn(false)]
        [Key]
        public int MaTruyen { get; set; }
        [Required, StringLength(100), Display(Name = "Tên")]
        public string TenTruyen { get; set; }
        [Required, StringLength(1000), Display(Name = "Mô tả truyện"),
        DataType(DataType.MultilineText)]
        public string MoTa { get; set; }
        public string HinhAnh { get; set; }
        [Display(Name = "Price")]
        public float? GiaTruyen { get; set; }
        public int? MaTL { get; set; }
        public virtual TheLoaiTruyen TheLoaiTruyen { get; set; }
    }
}