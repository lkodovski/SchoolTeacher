using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolTeacher
{

    public class Teacher
    {
        public string Name;
        public string Subject;
        public int YearsOfExperience;

        public void GradeStudent(string student, string assignment, int grade)
        {
            Console.WriteLine($"Teacher {Name} gave {student} a grade {grade} for {assignment}");
        }

        public void Introduce(string school, string classroom)
        {
            Console.WriteLine($"Hi, I am {Name}, I teach {Subject} for {YearsOfExperience} year(s) in classroom {classroom} at {school}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            var teacher = new Teacher();
            teacher.Name = "Marko";
            teacher.Subject = "Mathematics";
            teacher.YearsOfExperience = 10;

            teacher.GradeStudent("Stefan", "Homework 3", 5);
            teacher.Introduce("UZUS", "12");
        }
    }
}
