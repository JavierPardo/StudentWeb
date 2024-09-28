using Student.Model;
using Student.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student.Repository
{
    public class ExamRepository : IExamRepository
    {
        private readonly IDBContext _dBContext;

        public ExamRepository(IDBContext dBContext)
        {
            _dBContext = dBContext;
        }

        public ICollection<Exam> GetAllByStudentId(int studentId)
        {
            return _dBContext.Exams.Where(x=>x.StudentId == studentId).OrderBy(x=>x.ExamId).ToList();
        }

        public Exam GetByExamId(int examId)
        {
            return _dBContext.Exams.FirstOrDefault(x => x.ExamId == examId);
        }

    }
}
