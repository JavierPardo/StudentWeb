using Student.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentWeb.Services.Interfaces
{
    public interface IExamService
    {
        Exam GetExamByExamId(int examId);
        ICollection<Exam> GetExamsByStudentId(int studentId);
        void UpdateExam(int examId, Exam exam);
    }
}
