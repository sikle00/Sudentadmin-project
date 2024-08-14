using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Grade
    {
        public string Student { get; private set; }
        public string Subject { get; private set; }
        public int Value { get; private set; }
        public Grade(string student, string subject, int value)
        {
            Student = student;
            Subject = subject;
            Value = value;
        }
    }
}
