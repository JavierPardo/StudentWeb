using Student.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student.Repository.Interfaces
{
    public interface IExamRepository
    {
        ICollection<Exam> GetAllByStudentId(int studentId);
        Exam GetByExamId(int examId);
    }
}
