﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student.Repository.Interfaces
{
    public interface IStudentRepository
    {
        ICollection<Model.Student> GetAll();
        Model.Student GetById(int studentId);
    }
}
