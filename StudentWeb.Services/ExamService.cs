using Student.Model;
using Student.Repository;
using Student.Repository.Interfaces;
using StudentWeb.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentWeb.Services
{
    public class ExamService : IExamService
    {
        private readonly IExamRepository _examRepository;

        public ExamService(IExamRepository examRepository)
        {
            _examRepository = examRepository;
        }

        public Exam GetExamByExamId(int examId)
        {
            return _examRepository.GetByExamId(examId);
        }

        public ICollection<Exam> GetExamsByStudentId(int studentId)
        {
            return _examRepository.GetAllByStudentId(studentId);
        }

        public void UpdateExam(int examId, Exam exam)
        {
            var examPrevious = _examRepository.GetByExamId(examId);
            examPrevious.ExamName = exam.ExamName;
            examPrevious.DateTaken = exam.DateTaken;
            examPrevious.Score = exam.Score;
            examPrevious.IsPassed= exam.IsPassed;
        }
    }
}
