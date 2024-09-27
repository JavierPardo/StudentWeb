using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudentWeb.Services.Interfaces;

namespace StudentWeb.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private readonly IStudentService _studentService;

        public StudentsController(IStudentService studentService)
        {
            _studentService = studentService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var students = _studentService.GetAll();

            return Ok(students);
        }

        [HttpGet("{studentId}")]
        public IActionResult GetByStudentId([FromRoute] int studentId)
        {
            var student = _studentService.GetByStudentId(studentId);

            return Ok(student);
        }
    }
}
