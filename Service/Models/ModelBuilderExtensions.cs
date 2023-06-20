using Microsoft.EntityFrameworkCore;

namespace VocabularyProject.Models
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(
                new User() { ID = 1, Name = "LHN", Password = "LHN" },
                new User() { ID = 2, Name = "VTAT", Password = "VTAT" }
                );

            modelBuilder.Entity<Set>().HasData(
                new Set() { ID = 1, Name = "Contracts", UserID = 1 },
                new Set() { ID = 2, Name = "Marketing", UserID = 2 },
                new Set() { ID = 3, Name = "Warrranties", UserID = 2 },
                new Set() { ID = 4, Name = "Business Planning", UserID = 2 },
                new Set() { ID = 5, Name = "Conferences", UserID = 2 },
                new Set() { ID = 6, Name = "Computers and the Internet", UserID = 2 }
                );

            modelBuilder.Entity<Word>().HasData(
                new Word() { ID = 1, TiengViet = "tuân theo", English = "abide by", SetID = 1 },
                new Word() { ID = 2, TiengViet = "Thoả thuận", English = "agreement", SetID = 1 },
                new Word() { ID = 3, TiengViet = "đảm bảo", English = "assurance", SetID = 1 },
                new Word() { ID = 4, TiengViet = "giải quyết vấn đề", English = "determine", SetID = 1 },
                new Word() { ID = 5, TiengViet = "thuê, mướn", English = "engage", SetID = 1 },
                new Word() { ID = 6, TiengViet = "thành lập", English = "establish", SetID = 1 },
                new Word() { ID = 7, TiengViet = "bắt buộc, ép buộc", English = "obligate", SetID = 1 },
                new Word() { ID = 8, TiengViet = "nhóm làm việc chung", English = "party", SetID = 1 },
                new Word() { ID = 9, TiengViet = "sự cung cấp", English = "provision", SetID = 1 },
                new Word() { ID = 10, TiengViet = "Giải quyết", English = "Resolve", SetID = 1 },
                new Word() { ID = 11, TiengViet = "chỉ rõ, định rõ", English = "specify", SetID = 1 },

                new Word() { ID = 12, TiengViet = "hấp dẫn, lôi cuốn, thu hút", English = "attract", SetID = 2 },
                new Word() { ID = 13, TiengViet = "so sánh, đối chiếu", English = "compare", SetID = 2 },
                new Word() { ID = 14, TiengViet = "cạnh tranh, tranh giành, thi đấu", English = "competition", SetID = 2 },
                new Word() { ID = 15, TiengViet = "tiêu thụ, tiêu dùng", English = "consume", SetID = 2 },
                new Word() { ID = 16, TiengViet = "Thuyết phục", English = "convince", SetID = 2 },
                new Word() { ID = 17, TiengViet = "hiện thời, hiện nay, lúc này", English = "currently", SetID = 2 },
                new Word() { ID = 18, TiengViet = "mốt nhất thời, sự thích thú tạm thời; dở hơi, gàn dở", English = "fad", SetID = 2 },
                new Word() { ID = 19, TiengViet = "‹sự/người/vật› truyền cảm hứng, gây cảm hứng", English = "inspiration", SetID = 2 },
                new Word() { ID = 20, TiengViet = "thị trường, chợ, nơi mua bán sản phẩm", English = "market", SetID = 2 },
                new Word() { ID = 21, TiengViet = "thuyết phục, làm cho tin", English = "persuasion", SetID = 2 },
                new Word() { ID = 22, TiengViet = "sản xuất, sinh sản; sinh lợi nhiều, có hiệu quả", English = "productive", SetID = 2 },
                new Word() { ID = 23, TiengViet = "sự làm thỏa mãn, sự hài lòng", English = "satisfaction", SetID = 2 }

                );
        }
    }
}