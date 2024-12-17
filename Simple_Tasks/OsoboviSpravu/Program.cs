using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OsoboviSpravu
{
    class Student
    {
        public string Surname { get; }
        public string Name { get; }
        public string Grade { get; }
        public string Birth { get; }

        public Student(string surname, string name, string grade, string birth)
        {
            Surname = surname;
            Name = name;
            Grade = grade;
            Birth = birth;
        }
    }

    internal class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            List<Student> students = new List<Student>();

            for (int i = 0; i < n; i++)
            {
                string surname = Console.ReadLine();
                string name = Console.ReadLine();
                string grade = Console.ReadLine();
                string birth = Console.ReadLine();

                students.Add(new Student(surname, name, grade, birth));
            }

            students = students.OrderBy(x => int.Parse(x.Grade.Substring(0, x.Grade.Length - 1)))
                               .ThenBy(x => x.Grade[x.Grade.Length - 1])
                               .ThenBy(x => x.Surname)
                               .ToList();

            foreach (var student in students)
            {
                Console.WriteLine($"{student.Grade} {student.Surname} {student.Name} {student.Birth}");
            }
        }
    }
}
