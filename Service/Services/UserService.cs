using Service.Interfaces;
using Service.ModelsVM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VocabularyProject.Models;

namespace Service.Services
{
    public class UserService : IUser
    {
        private readonly VocabularyDbContext _context;

        public UserService(VocabularyDbContext context)
        {
            _context = context;
        }

        public bool ChangeAvatar(int userID, string linkAvatar)
        {
            _context.Users.FirstOrDefault(x => x.ID == userID).LinkAvatar = linkAvatar;
            return Convert.ToBoolean(_context.SaveChanges());
        }

        public bool ChangePassword(string userName, string oldPassword, string newPassword)
        {
            try
            {
                var user = _context.Users.FirstOrDefault(x => x.Account == userName && x.Password == oldPassword);

                if (user == null)
                    return false;

                user.Password = newPassword;
                return Convert.ToBoolean(_context.SaveChanges());
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool CreateUser(string userName, string password, string name)
        {
            try
            {
                var user = _context.Users.FirstOrDefault(x => x.Account == userName);
                if (user != null)
                    return false;

                var newUser = new User()
                {
                    Account = userName,
                    Name = name,
                    Password = password,
                    LinkAvatar = "https://assets.quizlet.com/a/j/dist/app/i/animals/116.cda755979f5721a.jpg"
                };

                _context.Users.Add(newUser);
                return Convert.ToBoolean(_context.SaveChanges());
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Users Login(string userName, string password)
        {
            try
            {
                var account = _context.Users.FirstOrDefault(x => x.Account == userName && x.Password == password);
                if (account == null)
                {
                    return new Users();
                }
                var result = new Users
                {
                    ID = account.ID,
                    Account = account.Account,
                    Name = account.Name,
                    LinkAvatar = account.LinkAvatar
                };
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}