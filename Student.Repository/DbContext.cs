using Student.Model;
using Student.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student.Repository
{
    public class DbContext : IDBContext
    {
        public DbContext()
        {
            Students = new List<Model.Student>
            {
                new Model.Student{ FirstName="Javier", LastName="Pardo", StudentId=10001 },
                new Model.Student{ FirstName="Jhon", LastName="Doe", StudentId=10002 },
                new Model.Student{ FirstName="Jane", LastName="Doe", StudentId=10003 },
                new Model.Student{ FirstName="Foo", LastName="Bar", StudentId=10004 },
                new Model.Student{ FirstName="Jhon", LastName="Rambo", StudentId=10005 },
                new Model.Student{ FirstName="Nicola", LastName="Tesla", StudentId=10006 },
                new Model.Student{ FirstName="Jhon", LastName="Ford", StudentId=10007 },
                new Model.Student{ FirstName="James", LastName="Bond", StudentId=10008 },
                new Model.Student{ FirstName="Daniel", LastName="Ramos", StudentId=10009 },
                new Model.Student{ FirstName="Cristiano", LastName="Ronaldo", StudentId=10010 }
            };

            Exams = new List<Exam> {
            new Exam{DateTaken=DateTime.Now.AddDays(-100),ExamName="Driving", IsPassed=null,Score=55, StudentId=10002, ExamId=201},
            new Exam{DateTaken=DateTime.Now.AddDays(-102),ExamName="Programming", IsPassed=false,Score=25, StudentId=10002, ExamId=202},
            new Exam{DateTaken=DateTime.Now.AddDays(-101),ExamName="Circuit", IsPassed=true,Score=35, StudentId=10003, ExamId=203},
            new Exam{DateTaken=DateTime.Now.AddDays(-105),ExamName="Calculus", IsPassed=false,Score=26, StudentId=10003, ExamId=204},
            new Exam{DateTaken=DateTime.Now.AddDays(-102),ExamName="Biology", IsPassed=false,Score=24, StudentId=10004, ExamId=205},
            new Exam{DateTaken=DateTime.Now.AddDays(-102),ExamName="Office", IsPassed=null,Score=34, StudentId=10004, ExamId=206},
            new Exam{DateTaken=DateTime.Now.AddDays(-101),ExamName="POV", IsPassed=true,Score=55, StudentId=10005, ExamId=207},
            new Exam{DateTaken=DateTime.Now.AddDays(-102),ExamName="Cooking", IsPassed=false,Score=12, StudentId=10005, ExamId=208},
            new Exam{DateTaken=DateTime.Now.AddDays(-104),ExamName="Reading", IsPassed=true,Score=53, StudentId=10006, ExamId=209},
            new Exam{DateTaken=DateTime.Now.AddDays(-106),ExamName="English", IsPassed=true,Score=13, StudentId=10006, ExamId=220},
            new Exam{DateTaken=DateTime.Now.AddDays(-103),ExamName="German", IsPassed=true,Score=12, StudentId=10007, ExamId=211},
            new Exam{DateTaken=DateTime.Now.AddDays(-102),ExamName="Math", IsPassed=null,Score=54, StudentId=10007, ExamId=212},
            new Exam{DateTaken=DateTime.Now.AddDays(-102),ExamName="Chemistry", IsPassed=false,Score=66, StudentId=10008, ExamId=213},
            new Exam{DateTaken=DateTime.Now.AddDays(-101),ExamName="History", IsPassed=false,Score=45, StudentId=10008, ExamId=214},
            new Exam{DateTaken=DateTime.Now.AddDays(-102),ExamName="Politics", IsPassed=null,Score=76, StudentId=10009, ExamId=215},
            new Exam{DateTaken=DateTime.Now.AddDays(-104),ExamName="Gaming", IsPassed=false,Score=34, StudentId=10009, ExamId=216},
            new Exam{DateTaken=DateTime.Now.AddDays(-106),ExamName="Economics", IsPassed=true,Score=76, StudentId=10010, ExamId=217},
            new Exam{DateTaken=DateTime.Now.AddDays(-104),ExamName="Physics", IsPassed=true,Score=42, StudentId=10010, ExamId=218},
            new Exam{DateTaken=DateTime.Now.AddDays(-107),ExamName="Weather", IsPassed=null,Score=78, StudentId=10001, ExamId=219},
            new Exam{DateTaken=DateTime.Now.AddDays(-108),ExamName="Social Media", IsPassed=true,Score=22, StudentId=10001, ExamId=220},
            };
        }
        public ICollection<Model.Student> Students { get; set; } = new List<Model.Student>();
        public ICollection<Exam> Exams { get; set; } = new List<Exam>();
    }
}
