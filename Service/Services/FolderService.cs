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
    public class FolderService : IFolder
    {
        private readonly VocabularyDbContext _context;

        public FolderService(VocabularyDbContext context)
        {
            _context = context;
        }

        public List<ModelsVM.Folders> GetAll()
        {
            return _context.Folders.Select(x => new ModelsVM.Folders()
            {
                ID = x.ID,
                Description = x.Description,
                Name = x.Name,
                UserID = x.UserID
            }).ToList();
        }

        public bool CreateFolder(string name, string description, int userID)
        {
            try
            {
                var newFolder = new Folders()
                {
                    Name = name,
                    Description = description,
                    UserID = userID
                };
                _context.Folders.Add(newFolder);
                return Convert.ToBoolean(_context.SaveChanges());
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<ModelsVM.Folders> GetFolderByUserID(int userID)
        {
            return _context.Folders.Where(x => x.UserID == userID).Select(y => new ModelsVM.Folders()
            {
                ID = y.ID,
                UserID = y.UserID,
                Description = y.Description,
                Name = y.Name,
                countSet = _context.Sets.Where(a => a.FoldersID == y.ID || a.FoldersIDs.Contains("," + y.ID + ",")).Count(),
            }).ToList();
        }

        public List<ModelsVM.Folders> GetFolderByUserIDAndSetID(int userID, int setID)
        {
            return _context.Folders.Where(x => x.UserID == userID).Select(y => new ModelsVM.Folders()
            {
                ID = y.ID,
                UserID = y.UserID,
                Description = y.Description,
                Name = y.Name,
                countSet = _context.Sets.Where(a => a.FoldersID == y.ID).Count(),
                Added = _context.Sets.FirstOrDefault(x => x.ID == setID).FoldersIDs.Contains("," + y.ID + ",")
            }).ToList();
        }
    }
}