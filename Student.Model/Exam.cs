using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student.Model
{
    public class Exam
    {
        [Range(1, 999, ErrorMessage = "The Exam Id {0} must be greater than {1}.")]
        public int ExamId { get; set; }

        public int StudentId { get; set; }

        public string ExamName { get; set; }
        
        public DateTime DateTaken { get; set; }

        [Range(0, 100, ErrorMessage = "The score {0} must be greater than {1}.")]
        public int Score { get; set; }

        public bool? IsPassed { get; set; }
    }
}
