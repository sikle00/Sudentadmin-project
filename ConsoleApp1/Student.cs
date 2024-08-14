using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Student
    {
        
        public string Name { get; set; }
        public string Age { get; set; }
        public string Program { get; set; }
        public string StudentID { get; set; }
        public Student(string name, string age, string program, string studentid)
        {
            Name = name;
            Age = age;
            Program = program;
            StudentID = studentid;
        }
        public void CreateStudent()
        {
            var student1 = new Student("Jack", "22", "Cyber security 1", "200 001");
            var student2 = new Student("Peter", "21", "Personal trainer 1", "200 002");
            Console.WriteLine($"{student1.Name}, {student1.Age}, studies {student1.Program}, and has student ID {student1.StudentID}");
            Console.WriteLine($"{student2.Name}, {student2.Age}, studies {student2.Program}, and has student ID {student2.StudentID}");
        }
    }
}
