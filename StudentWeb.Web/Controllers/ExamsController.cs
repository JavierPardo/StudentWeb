using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Student.Model;
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

        [HttpGet("student/{studentId}")]
        public ActionResult<ICollection<Exam>> GetStudentExams([FromRoute] int studentId)
        {
            var exams = _examService.GetExamsByStudentId(studentId);

            return Ok(exams);
        }

        [HttpGet("{examId}")]
        public ActionResult<ICollection<Exam>> GetExam([FromRoute] int examId)
        {
            var exams = _examService.GetExamByExamId(examId);

            return Ok(exams);
        }
        [HttpPut("{examId}")]
        public ActionResult GetExam([FromRoute] int examId, [FromBody] Exam exam)
        {
             _examService.UpdateExam(examId, exam);

            return Ok();
        }
    }
}
