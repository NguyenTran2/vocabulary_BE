using Service.Interfaces;
using Service.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VocabularyProject.Models;

namespace Service.Services
{
    public class WordService : IWord
    {
        private readonly VocabularyDbContext _context;

        public WordService(VocabularyDbContext context)
        {
            _context = context;
        }

        public List<Words> GetAll()
        {
            return _context.Words.Select(x => new Words()
            {
                ID = x.ID,
                English = x.English,
                SetID = x.SetID,
                TiengViet = x.TiengViet
            }).ToList();
        }

        public DetailWords GetByCourseID(int ID)
        {
            var set = _context.Sets.FirstOrDefault(x => x.ID == ID);
            var user = _context.Users.FirstOrDefault(x => x.ID == set.UserID);

            return new DetailWords()
            {
                Words = _context.Words.Where(x => x.SetID == ID).Select(x => new Words()
                {
                    ID = x.ID,
                    English = x.English,
                    SetID = x.SetID,
                    TiengViet = x.TiengViet,
                }).ToList(),
                user = new ModelsVM.Users()
                {
                    ID = user.ID,
                    Account = user.Account,
                    LinkAvatar = user.LinkAvatar,
                    Name = user.Name
                },
                course = new ModelsVM.Courses()
                {
                    ID = set.ID,
                    Name = set.Name,
                    Description = set.Description
                }
            };
        }
    }
}