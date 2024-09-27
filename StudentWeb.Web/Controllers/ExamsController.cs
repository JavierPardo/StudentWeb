using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudentWeb.Services.Interfaces;

namespace StudentWeb.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExamsController : ControllerBase
    {
        private readonly IExamService _examService;

        public ExamsController(IExamService examService)
        {
            _examService = examService;
        }

        [HttpGet("{StudentId}/Exam")]
        public void GetStudentExams([FromRoute] int StudentId)
        {

        }
    }
}
