using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student.Repository.Interfaces
{
    public interface IDBContext
    {
        public ICollection<Model.Student> Students { get; set; }
        public ICollection<Model.Exam> Exams { get; set; }
    }
}
