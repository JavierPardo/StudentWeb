using Student.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace StudentWeb.Services.Interfaces
{
    public interface IStudentService
    {
        ICollection<Student.Model.Student> GetAll();
        Student.Model.Student GetByStudentId(int studentId);
    }
}
