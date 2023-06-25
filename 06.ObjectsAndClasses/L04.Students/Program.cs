using System;
using System.Collections.Generic;

namespace L04.Students
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
                Student oneStudent = new Student(tokens[0], tokens[1], int.Parse(tokens[2]), tokens[3]);
                students.Add(oneStudent);
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
