using Service.Interfaces;
using Service.Models;
using Service.ModelsVM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VocabularyProject.Models;

namespace Service.Services
{
    public class CourseService : ICourse
    {
        private readonly VocabularyDbContext _context;

        public CourseService(VocabularyDbContext context)
        {
            _context = context;
        }

        public bool AddCourseToFolder(int courseID, int folderID)
        {
            var set = _context.Sets.FirstOrDefault(x => x.ID == courseID);
            if (set.FoldersIDs == "")
            {
                set.FoldersIDs = "," + folderID + ",";
                set.FoldersID = folderID;
            }
            else
            {
                set.FoldersIDs += folderID + ",";
            }

            return Convert.ToBoolean(_context.SaveChanges());
        }

        public bool RemoveCourseToFolder(int courseID, int folderID)
        {
            var set = _context.Sets.FirstOrDefault(x => x.ID == courseID);
            var str = "," + folderID + ",";

            if (set.FoldersIDs.Contains(str))
            {
                var a = set.FoldersIDs.Replace(str, ",");
                set.FoldersIDs = a;
            }
            if (set.FoldersID == folderID)
            {
                set.FoldersID = null;
            }

            return Convert.ToBoolean(_context.SaveChanges());
        }

        public bool CreateCourseWord(string name, string description, int userID, List<CreateWord> words)
        {
            var newCourseWord = new Set()
            {
                Name = name,
                Description = description,
                UserID = userID,
                FoldersID = null,
                UserSharedIDs = "",
                NewestDateLearn = DateTime.Now,
                Words = words.Select(x => new Word()
                {
                    English = x.English,
                    TiengViet = x.TiengViet,
                    Status = 0
                }).ToList()
            };
            _context.Sets.Add(newCourseWord);
            return Convert.ToBoolean(_context.SaveChanges());
        }

        public bool EditCourseWord(int courseID, string name, string description, int userID, List<CreateWord> words)
        {
            var set = _context.Sets.FirstOrDefault(x => x.ID == courseID);
            if (set.UserID != userID)
                return false;
            set.Name = name;
            set.Description = description;

            _context.Words.RemoveRange(_context.Words.Where(x => x.SetID == courseID));

            words.ForEach(x =>
            {
                _context.Words.Add(new Word()
                {
                    English = x.English,
                    SetID = courseID,
                    TiengViet = x.TiengViet,
                });
            });

            return Convert.ToBoolean(_context.SaveChanges());
        }

        public List<Courses> GetAll()
        {
            return _context.Sets.Select(x => new Courses()
            {
                ID = x.ID,
                UserID = x.UserID,
                Name = x.Name,
                Description = x.Description
            }).ToList();
        }

        public List<Courses> GetByUserID(int? userID)
        {
            return _context.Sets.Where(x => x.UserID == userID || x.UserSharedIDs.Contains($",{userID},")).Select(x => new Courses()
            {
                ID = x.ID,
                Name = x.Name,
                Description = x.Description,
                NumberOfWord = _context.Words.Where(z => z.SetID == x.ID).ToList().Count,
                User = new Users()
                {
                    ID = _context.Users.FirstOrDefault(y => y.ID == x.UserID).ID,
                    Account = _context.Users.FirstOrDefault(y => y.ID == x.UserID).Account,
                    Name = _context.Users.FirstOrDefault(y => y.ID == x.UserID).Name,
                    LinkAvatar = _context.Users.FirstOrDefault(y => y.ID == x.UserID).LinkAvatar
                }
            }).ToList();
        }

        public List<Courses> GetSixNewest(int userID)
        {
            return _context.Sets.Where(x => x.UserID == userID || x.UserSharedIDs.Contains("," + userID + ",")).OrderByDescending(x => x.NewestDateLearn).Take(6).Select(x => new Courses()
            {
                ID = x.ID,
                Name = x.Name,
                Description = x.Description,
                NumberOfWord = _context.Words.Where(z => z.SetID == x.ID).ToList().Count,
                User = new Users()
                {
                    ID = _context.Users.FirstOrDefault(y => y.ID == x.UserID).ID,
                    Account = _context.Users.FirstOrDefault(y => y.ID == x.UserID).Account,
                    Name = _context.Users.FirstOrDefault(y => y.ID == x.UserID).Name,
                    LinkAvatar = _context.Users.FirstOrDefault(y => y.ID == x.UserID).LinkAvatar
                }
            }).ToList();
        }

        public bool ShareCourse(string userNameShared, int setID)
        {
            var userShared = _context.Users.FirstOrDefault(x => x.Account == userNameShared);
            if (userShared == null)
                return false;
            var set = _context.Sets.FirstOrDefault(x => x.ID == setID);

            if (set.UserSharedIDs == "")
            {
                set.UserSharedIDs = "," + userShared.ID + ",";
            }
            else
            {
                if (set.UserSharedIDs.Contains("," + userShared.ID + ","))
                    return false;
                set.UserSharedIDs += userShared.ID + ",";
            }
            return Convert.ToBoolean(_context.SaveChanges());
        }

        public List<Courses> GetByFolderID(int ID)
        {
            return _context.Sets.Where(x => x.FoldersIDs.Contains($",{ID},")).Select(x => new Courses()
            {
                ID = x.ID,
                Name = x.Name,
                Description = x.Description,
                NumberOfWord = _context.Words.Where(z => z.SetID == x.ID).ToList().Count,
                User = new Users()
                {
                    ID = _context.Users.FirstOrDefault(y => y.ID == x.UserID).ID,
                    Account = _context.Users.FirstOrDefault(y => y.ID == x.UserID).Account,
                    Name = _context.Users.FirstOrDefault(y => y.ID == x.UserID).Name,
                    LinkAvatar = _context.Users.FirstOrDefault(y => y.ID == x.UserID).LinkAvatar
                }
            }).ToList();
        }
    }
}