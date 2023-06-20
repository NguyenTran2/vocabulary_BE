using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Service.Interfaces;
using Service.Models;

namespace VocabularyProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CoursesController : ControllerBase
    {
        private readonly ICourse _iCourse;

        public CoursesController(ICourse iCourse)
        {
            _iCourse = iCourse;
        }

        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            return Ok(_iCourse.GetAll());
        }

        [HttpGet("GetAll/{ID}")]
        public IActionResult GetByID(int ID)
        {
            return Ok(_iCourse.GetByUserID(ID));
        }

        [HttpGet("GetByFolderID/{folderID}")]
        public IActionResult GetByFolderID(int folderID)
        {
            return Ok(_iCourse.GetByFolderID(folderID));
        }

        [HttpGet("GetSixNewest")]
        public IActionResult GetSixNewest(int userID)
        {
            return Ok(_iCourse.GetSixNewest(userID));
        }

        [HttpPost("CreateCourseWord")]
        public IActionResult CreateCourseWord(string name, string description, int userID, List<CreateWord> words)
        {
            var course = _iCourse.CreateCourseWord(name, description, userID, words);
            if (course)
                return Ok();
            return BadRequest();
        }

        [HttpPut("EditCourseWord")]
        public IActionResult EditCourseWord(int courseID, string name, string description, int userID, List<CreateWord> words)
        {
            var course = _iCourse.EditCourseWord(courseID, name, description, userID, words);
            if (course)
                return Ok();
            return BadRequest();
        }

        [HttpPut("ShareCourse")]
        public IActionResult ShareCourse(string userNameShared, int setID)
        {
            var result = _iCourse.ShareCourse(userNameShared, setID);
            if (result)
                return Ok();
            return BadRequest();
        }

        [HttpPut("AddCourseToFolder")]
        public IActionResult AddCourseToFolder(int courseID, int folderID)
        {
            var result = _iCourse.AddCourseToFolder(courseID, folderID);
            if (result)
                return Ok();
            return BadRequest();
        }

        [HttpPut("RemoveCourseToFolder")]
        public IActionResult RemoveCourseToFolder(int courseID, int folderID)
        {
            var result = _iCourse.RemoveCourseToFolder(courseID, folderID);
            if (result)
                return Ok();
            return BadRequest();
        }
    }
}