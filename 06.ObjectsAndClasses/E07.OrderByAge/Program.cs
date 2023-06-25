using System;
using System.Collections.Generic;
using System.Linq;

namespace E07.OrderByAge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();
            string input = "";
            while ((input = Console.ReadLine()) != "End")
            {
                string[] tokens = input.Split(" ");
                string name = tokens[0];
                int ID = int.Parse(tokens[1]);
                int age = int.Parse(tokens[2]);
                Person onePerson = people.FirstOrDefault(x => x.ID == ID);
                if (onePerson != null)
                {
                    onePerson.Name = name;
                    onePerson.Age = age;
                }
                else
                {
                    people.Add(new Person(name, ID, age));
                }
            }

            foreach (Person person in people.OrderBy(x => x.Age))
            {
                Console.WriteLine($"{person.Name} with ID: {person.ID} is {person.Age} years old.");
            }
        }
    }

    public class Person
    {
        public Person(string name, int id, int age)
        {
            Name = name;
            ID = id;
            Age = age;
        }
        public string Name { get; set; }
        public int ID { get; set; }
        public int Age { get; set; }
    }
}
