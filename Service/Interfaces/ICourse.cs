using Service.Models;
using Service.ModelsVM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Interfaces
{
    public interface ICourse
    {
        List<Courses> GetByUserID(int? ID);

        List<Courses> GetByFolderID(int ID);

        List<Courses> GetAll();

        List<Courses> GetSixNewest(int ID);

        bool CreateCourseWord(string name, string description, int userID, List<CreateWord> words);

        bool EditCourseWord(int courseID, string name, string description, int userID, List<CreateWord> words);

        bool ShareCourse(string userNameShared, int setID);

        bool AddCourseToFolder(int courseID, int folderID);

        bool RemoveCourseToFolder(int courseID, int folderID);
    }
}