using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Service.Interfaces;

namespace VocabularyProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LearnedDatesController : ControllerBase
    {
        private readonly ILearnedDate _iLearnedDate;

        public LearnedDatesController(ILearnedDate iLearnedDate)
        {
            _iLearnedDate = iLearnedDate;
        }

        [HttpGet("GetDateInLastestWeek")]
        public IActionResult GetDateInLastestWeek()
        {
            return Ok(_iLearnedDate.GetDateInLastestWeek());
        }
    }
}