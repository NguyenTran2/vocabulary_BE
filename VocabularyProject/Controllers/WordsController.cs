using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Service.Interfaces;

namespace VocabularyProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WordsController : ControllerBase
    {
        private readonly IWord _iWord;

        public WordsController(IWord iWord)
        {
            _iWord = iWord;
        }

        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            var categories = _iWord.GetAll();
            return Ok(categories);
        }

        [HttpGet("GetWordsByCourseID/{ID}")]
        public IActionResult GetWordsByCourseID(int ID)
        {
            var categories = _iWord.GetByCourseID(ID);
            return Ok(categories);
        }
    }
}