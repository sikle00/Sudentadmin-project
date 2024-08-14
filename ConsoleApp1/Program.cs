namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Student overview");
            Console.WriteLine("To view information about every student, press 1");
            Console.WriteLine("To view information about every subject we have, press 2");
            Console.WriteLine("To view information about the grades for a specific student, press 3");
            Console.WriteLine("To exit the program, press any other key");
            var input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    WriteInfoStudent();
                    break;
                case "2":
                    WriteInfoSubject();
                    break;
                case "3":
                    WriteGrades();
                    break;
            }
            void WriteInfoStudent()
            {
                //CreateStudent();
            }
            void WriteInfoSubject()
            {
                //Cyber security year 1
                var subject1 = new Subject("CS1AS1", "Academic skills 1", "10");
                var subject2 = new Subject("CS1ITF", "IT Fundamentals", "10");
                var subject3 = new Subject("CS1BA", "Business Analytics", "10");
            }
            void WriteGrades()
            {

            }
        }
        
    }
}
