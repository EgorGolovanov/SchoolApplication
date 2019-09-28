using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SchoolApplication.DataBase
{
    public interface ISubject
    {
        Guid Id { get; set; }
        List<Student> Students { get; set; }
        Teacher Teacher { get; set; }
        List<Contest> Contests { get; set; }
        List<Quiz> Quizs { get; set; }
        List<Homework> Homeworks { get; set; }
        List<ClassWorkContent> ClassWorkContent { get; set; }
    }
}
