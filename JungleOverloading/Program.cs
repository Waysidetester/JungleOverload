using System;
using System.Collections.Generic;
using JungleOverloading.Employees;

namespace JungleOverloading
{
    class Program
    {
        static void Main(string[] args)
        {
            var jess = new Employee("Jess", "McGown");
            var dave = new Employee("Dave", "Westly");
            var inds = new Employee("Inds", "Cow");

            List<Employee> Friends = new List<Employee>();

            Friends.Add(dave);
            Friends.Add(inds);


            Console.WriteLine($"{jess.Eat(Friends)}");
            Console.ReadKey();
        }
    }
}
