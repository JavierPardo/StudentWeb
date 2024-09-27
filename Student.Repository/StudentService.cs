using Student.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student.Repository
{
    public class StudentRepository : IStudentRepository
    {
        private readonly IDBContext _dBContext;

        public StudentRepository(IDBContext dBContext)
        {
            _dBContext = dBContext;
        }
        public ICollection<Model.Student> GetAll()
        {
            return _dBContext.Students;
        }

        public Model.Student GetById(int studentId)
        {
            return _dBContext.Students.FirstOrDefault(x => x.StudentId == studentId);
        }
    }
}
