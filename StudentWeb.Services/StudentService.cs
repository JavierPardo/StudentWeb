using Student.Repository.Interfaces;
using StudentWeb.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentWeb.Services
{
    public class StudentService : IStudentService
    {
        private readonly IStudentRepository _studentRepository;

        public StudentService(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }
        public ICollection<Student.Model.Student> GetAll()
        {
            return _studentRepository.GetAll();
        }
    }
}
