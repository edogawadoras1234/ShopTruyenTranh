using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace ShopTruyenTranh.Models
{
    public class DuLieuTruyen : DropCreateDatabaseAlways<DinhNghiaTruyen>
    {
        protected override void Seed(DinhNghiaTruyen context)
        {
            GetCategories().ForEach(c => context.TheLoais.Add(c));
            GetBooks().ForEach(p => context.TruyenTranhs.Add(p));
        }
        private static List<TheLoaiTruyen> GetCategories()
        {
            var categories = new List<TheLoaiTruyen> {
                new TheLoaiTruyen
               {
                 MaTL = 1,
                 TenTL = "Trinh Thám"
                 },
                 new TheLoaiTruyen
                 {
                 MaTL = 2,
                 TenTL = "Hành Động"
                 },
                 new TheLoaiTruyen{
                 MaTL= 3,
                 TenTL = "Võ Thuật"
                 },
                 new TheLoaiTruyen{
                 MaTL= 4,
                 TenTL = "Tình Cảm"
                 },
                 new TheLoaiTruyen{
                 MaTL= 5,
                 TenTL = "Siêu Nhân"
                 },
                 new TheLoaiTruyen{
                 MaTL= 6,
                 TenTL = "Thiếu Nhi"
                 },
                 };
            return categories;
        }
        private static List<TruyenTranh> GetBooks()
        {
            var books = new List<TruyenTranh> {
                 //book 1
                 new TruyenTranh
                 {
                 MaTruyen = 1,
                 TenTruyen = "Thám tử Conan",
                 MoTa = "Kudo Shinichi bị một tổ chức áo đen cho uống thuốc độc và teo nhỏ trở thành Edogawa Conan." +
                 " Mặc dù cơ thể bị teo nhỏ nhưng với trí tuệ của một thám tử lừng danh anh vẫn phá được nhiều vụ án mà người lớn phải đau đầu suy nghĩ",
                 HinhAnh="Pic1.JPG",
                 GiaTruyen = 10000,
                 MaTL = 1
                 },
                 //book 2
                 new TruyenTranh
                 {
                 MaTruyen = 2,
                 TenTruyen = "7 viên ngọc rồng",
                 MoTa = "Songoku cùng các chiến binh Z phải chiến đấu với nhiều quái vật và mọi người cùng nhau tăng cấp lên các sức mạnh mới",
                 HinhAnh="Pic2.JPG",
                 GiaTruyen = 12000,
                 MaTL = 2
                 },
                 //book 3
                 new TruyenTranh
                 {
                 MaTruyen = 3,
                 TenTruyen = "One Punch Man",
                 MoTa = "Saitama cùng đồng bọn đánh với các quái vât. Riêng anh chỉ với 1 đấm có thể giết hết quái vật",
                 HinhAnh="Pic3.JPG",
                 GiaTruyen = 10000,
                 MaTL = 3
                 },
                 new TruyenTranh
                 {
                 MaTruyen = 4,
                 TenTruyen = " Ore no Yome ni Nare Yo",
                 MoTa = "Bộ truyện lãng mạn học đường cùng với Yome và Ore",
                 HinhAnh="Pic4.jpg",
                 GiaTruyen = 10000,
                 MaTL = 4
                 },
                 new TruyenTranh
                 {
                 MaTruyen= 5,
                 TenTruyen = "Kamen Rider Zi-o",
                 MoTa = "Mùa thu năm 2018, một cô gái cùng cỗ máy thời gian xuất hiện trước mặt nhân vật chính của chúng ta, " +
                 "Tokiwa Sougo sinh vào năm 2000 mà cô gái được báo mộng sẽ trở thành Vua." +
                 " Cô gái bí ẩn xuất hiện từ cỗ máy thời gian nói với main rằng: Tôi đến từ năm 2068." +
                 " Trong tương lai, thế giới sẽ do Ma Vương thống trị, khiến loài người lầm than, tạo nên một thế giới vô vọng." +
                 " Cô gái tới năm 2018 với hi vọng thay đổi thế giới tương lai đầy tuyệt vọng mà cô nói. " +
                 "Trong tương lai, cậu sẽ trở thành Zi-O, vị vua thời gian, và cũng là ma vương hủy diệt thế giới.",
                 HinhAnh="Pic5.jpg",
                 GiaTruyen = 10000,
                 MaTL = 5
                 },
                 new TruyenTranh
                 {
                 MaTruyen = 6,
                 TenTruyen = "Sherlocks Homles",
                 MoTa = "Sherlocks Holmes là một thám tử tư ở Luân Đôn nổi tiếng nhờ trí thông minh, " +
                 "khả năng suy diễn logic và quan sát tinh tường trong khi phá những vụ án mà cảnh sát phải bó tay. " +
                 "Nhiều người cho rằng Sherlock Holmes là nhân vật thám tử hư cấu nổi tiếng nhất trong lịch sử văn học và " +
                 "là một trong những nhân vật văn học được biết đến nhiều nhất trên toàn thế giới.",
                 HinhAnh="Pic6.jpg",
                 GiaTruyen = 10000,
                 MaTL = 1
                 },
                  new TruyenTranh
                 {
                 MaTruyen = 7,
                 TenTruyen = "Doraemon",
                 MoTa = "Bộ truyện kể về một chú mèo máy tên là Doraemon đến từ thế kỉ 22 để giúp một cậu bé lớp 5-3 hậu đậu tên là Nobi Nobita. " +
                 "Các câu chuyện của Doraemon thường ngắn gọn, dễ hiểu, dí dỏm và mang cái nhìn lạc quan về cuộc sống tương lai " +
                 "cũng như sự phát triển của khoa học - kĩ thuật.",
                 HinhAnh="Pic7.jpg",
                 GiaTruyen = 10000,
                 MaTL = 6
                 },
                   new TruyenTranh
                 {
                 MaTruyen = 8,
                 TenTruyen = "One Piece",
                 MoTa = "One Piece nói về cuộc hành trình của Monkey D. Luffy - thuyền trưởng của băng hải tặc Mũ Rơm và các đồng đội của cậu. " +
                 "Luffy tìm kiếm vùng biển bí ẩn nơi cất giữ kho báu lớn nhất thế giới One Piece, với mục đích trở thành Tân Vua Hải Tặc.",
                 HinhAnh="Pic8.jpg",
                 GiaTruyen = 12000,
                 MaTL = 2
                 },
                    new TruyenTranh
                 {
                 MaTruyen = 9,
                 TenTruyen = "Inu Yasha",
                 MoTa = "Câu chuyện kể về hành trình tìm ngọc Tứ Hồn của nữ học sinh Kagome Higurashi," +
                 " người có thể trở về thời Chiến Quốc nhờ chiếc giếng cổ thần bí trong nhà cô, và InuYasha, một hanyō (tiếng Nhật nghĩa là 'bán yêu')",
                 HinhAnh="Pic9.jpg",
                 GiaTruyen = 10000,
                 MaTL = 2
                 },
                 };
            return books;
        }
    }
}