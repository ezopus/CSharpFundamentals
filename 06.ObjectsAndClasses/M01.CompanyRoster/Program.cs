using System;
using System.Collections.Generic;
using System.Linq;

namespace M01.CompanyRoster
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Department> departments = new List<Department>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] tokens = Console.ReadLine().Split(' ');
                string name = tokens[0];
                decimal salary = decimal.Parse(tokens[1]);
                string departmentName = tokens[2];
                Employee oneEmployee = new Employee(name, salary); //add new employees
                Department oneDepartment = departments.FirstOrDefault(x => x.DepartmentName == departmentName);
                if (oneDepartment != null)
                {
                    oneDepartment.Employees.Add(oneEmployee);
                }
                else
                {
                    Department newDepartment = new Department(departmentName);
                    departments.Add(newDepartment);
                    newDepartment.Employees.Add(oneEmployee);
                }
            }
            // find highest average
            decimal highestAverage = 0;
            Department bestDepartment = null;
            foreach (Department d in departments)
            {
                decimal averageSalary = d.Employees.Average(x => x.Salary);
                if (averageSalary > highestAverage)
                {
                    highestAverage = averageSalary;
                    bestDepartment = d;
                }
            }
            //print
            Console.WriteLine($"Highest Average Salary: {bestDepartment.DepartmentName}");
            foreach (Employee emp in bestDepartment.Employees.OrderByDescending(x => x.Salary))
            {
                Console.WriteLine($"{emp.Name} {emp.Salary:f2}");
            }

        }
    }

    public class Employee
    {
        public Employee(string name, decimal salary)
        {
            Name = name;
            Salary = salary;
        }
        public string Name { get; set; }
        public decimal Salary { get; set; }
    }

    public class Department
    {
        public Department(string departmentName)
        {
            Employees = new List<Employee>();
            DepartmentName = departmentName;
        }
        public List<Employee> Employees { get; set; }
        public string DepartmentName { get; set; }

    }
}
