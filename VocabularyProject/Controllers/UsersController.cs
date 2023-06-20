using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Service.Interfaces;

namespace VocabularyProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUser _iUser;

        public UsersController(IUser iUser)
        {
            _iUser = iUser;
        }

        [HttpPost("Login")]
        public IActionResult Login(string userName, string password)
        {
            var user = _iUser.Login(userName, password);
            if (user.Name == "")
                return BadRequest();
            return Ok(user);
        }

        [HttpPost("Register")]
        public IActionResult Register(string userName, string password, string name)
        {
            var user = _iUser.CreateUser(userName, password, name);
            if (user)
                return Ok();
            return BadRequest();
        }

        [HttpPut("ChangePassword")]
        public IActionResult ChangePassword(string userName, string oldPassword, string newPassword)
        {
            var user = _iUser.ChangePassword(userName, oldPassword, newPassword);
            if (user)
                return Ok();
            return BadRequest();
        }

        [HttpPut("ChangeAvatar")]
        public IActionResult ChangeAvatar(int userID, string linkAvatar)
        {
            var user = _iUser.ChangeAvatar(userID, linkAvatar);
            if (user)
                return Ok();
            return BadRequest();
        }
    }
}