using System;
using System.Collections.Generic;
using System.Linq;

namespace L05.Students2._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            string input = "";

            while ((input = Console.ReadLine()) != "end")
            {
                string[] tokens = input.Split(' ');
                string firstName = tokens[0];
                string lastName = tokens[1];
                int age = int.Parse(tokens[2]);
                string homeTown = tokens[3];
                Student oneStudent = students.FirstOrDefault(s => s.FirstName == firstName && s.LastName == lastName);
                if (oneStudent != null)
                {
                    oneStudent.Age = age;
                    oneStudent.HomeTown = homeTown;
                }
                else
                {
                    students.Add(new Student(firstName, lastName, age, homeTown));
                }
            }

            string city = Console.ReadLine();

            foreach (Student student in students)
            {
                if (student.HomeTown == city)
                {
                    Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
                }
            }
        }

    }

    public class Student
    {
        public Student(string firstName, string lastName, int age, string homeTown)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            HomeTown = homeTown;
        }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Age { get; set; }

        public string HomeTown { get; set; }
    }
}
