using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Subject
    {
        public string SubjectCode;
        public string SubjectName;
        public string Studypoints;
        public Subject(string subjectCode, string subjectName, string studypoints)
        {
            SubjectCode = subjectCode;
            SubjectName = subjectName;
            Studypoints = studypoints;
        }
    }
}
