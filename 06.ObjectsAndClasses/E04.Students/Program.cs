using System;
using System.Collections.Generic;
using System.Linq;

namespace E04.Students
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            int numberOfStudents = int.Parse(Console.ReadLine());
            for (int i = 0; i < numberOfStudents; i++)
            {
                string[] tokens = Console.ReadLine()
                    .Split(' ');
                string firstName = tokens[0];
                string lastName = tokens[1];
                double grade = double.Parse(tokens[2]);
                Student oneStudent = new Student(firstName, lastName, grade);
                students.Add(oneStudent);
            }

            foreach (Student student in students.OrderByDescending(x => x.Grade))
            {
                Console.WriteLine($"{student.FirstName} {student.LastName}: {student.Grade:F2}");
            }
        }
    }

    public class Student
    {
        public Student(string firstName, string lastName, double grade)
        {
            FirstName = firstName;
            LastName = lastName;
            Grade = grade;
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Grade { get; set; }

    }
}
