using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Beginner
{
    /// <summary>
    /// https://www.codechef.com/problems/ATTND
    /// </summary>
    public class ATTND
    {
        public static void CheckDuplicateFirstName(List<StudentName> students)
        {
            foreach (var student in students)
            {
                student.isFirstNameDuplicate = students.Any(x => x.FirstName == student.FirstName && x.LastName != student.LastName);
            }
        }

        public static void Main(string[] args)
        {
            int testCases = Convert.ToInt32(Console.ReadLine());
            List<StudentName> students = new List<StudentName>();

            for (int i = 0; i < testCases; i++)
            {
                int studentNumber = Convert.ToInt32(Console.ReadLine());
                for (int j = 0; j < studentNumber; j++)
                {
                    var inputs = Console.ReadLine().Split(' ');
                    StudentName studentName = new StudentName(inputs);
                    students.Add(studentName);
                }
            }

            CheckDuplicateFirstName(students);

            Console.WriteLine(string.Join(Environment.NewLine, students.Select(x => x.FullName)));
            Console.ReadLine();
        }
    }

    public class StudentName
    {
        public StudentName(string[] name)
        {
            this.FirstName = name[0];
            this.LastName = name[1];
        }

        public string FirstName { get; set; }

        public string FullName
        {
            get
            {
                return isFirstNameDuplicate ? $"{FirstName} {LastName}" : $"{FirstName}";
            }
        }

        public bool isFirstNameDuplicate { get; set; } = false;

        public string LastName { get; set; }
    }
}