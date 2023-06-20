using Service.ModelsVM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Interfaces
{
    public interface IFolder
    {
        bool CreateFolder(string name, string description, int userID);

        List<Folders> GetAll();

        List<Folders> GetFolderByUserID(int userID);

        List<Folders> GetFolderByUserIDAndSetID(int userID, int setID);
    }
}