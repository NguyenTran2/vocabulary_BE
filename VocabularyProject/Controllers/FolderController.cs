using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Service.Interfaces;

namespace VocabularyProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FolderController : ControllerBase
    {
        private readonly IFolder _iFolder;

        public FolderController(IFolder iFolder)
        {
            _iFolder = iFolder;
        }

        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            return Ok(_iFolder.GetAll());
        }

        [HttpPost("CreateFolder")]
        public IActionResult CreateFolder(string name, string description, int userID)
        {
            var folder = _iFolder.CreateFolder(name, description, userID);
            if (folder)
                return Ok();
            return BadRequest();
        }

        [HttpGet("getfolderbyuserid")]
        public IActionResult getfolderbyuserid(int userid)
        {
            return Ok(_iFolder.GetFolderByUserID(userid));
        }

        [HttpGet("GetFolderByUserIDAndSetID")]
        public IActionResult GetFolderByUserIDAndSetID(int userID, int setID)
        {
            return Ok(_iFolder.GetFolderByUserIDAndSetID(userID, setID));
        }
    }
}