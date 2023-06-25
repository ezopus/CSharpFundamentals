using System;
using System.Collections.Generic;
using System.Linq;

namespace M02.OldestFamilyMember
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Family family = new Family();
            for (int i = 0; i < n; i++)
            {
                string[] oneMember = Console.ReadLine().Split(' ');
                string name = oneMember[0];
                int age = int.Parse(oneMember[1]);
                Person onePerson = new Person(name, age);
                family.AddMember(onePerson);

            }
            Person oldestMember = family.GetOldestMember();
            Console.WriteLine($"{oldestMember.Name} {oldestMember.Age}");

        }
    }
    class Family
    {
        public Family()
        {
            Members = new List<Person>();
        }
        public List<Person> Members { get; set; }

        public void AddMember(Person person)
        {
            Members.Add(person);
        }
        public Person GetOldestMember()
        {
            Person oldestPerson = null;
            foreach (Person p in Members)
            {
                if (oldestPerson == null || p.Age > oldestPerson.Age)
                {
                    oldestPerson = p;
                }
            }
            return oldestPerson;
        }
    }
    class Person
    {
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
