using Service.ModelsVM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Interfaces
{
    public interface IUser
    {
        Users Login(string userName, string password);

        bool CreateUser(string userName, string password, string name);

        bool ChangePassword(string userName, string oldPassword, string newPassword);

        bool ChangeAvatar(int userID, string linkAvatar);
    }
}