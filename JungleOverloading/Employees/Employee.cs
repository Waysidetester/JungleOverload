using System;
using System.Collections.Generic;
using System.Text;

namespace JungleOverloading.Employees
{
    class Employee
    {
        public string EmpFirstName { get; private set; }
        public string EmpLastName { get; private set; }

        public Employee(string fName, string lName)
        {
            EmpFirstName = fName;
            EmpLastName = lName;
        }

        private string RandRestChosen()
        {
            Random rndNum = new Random();
            int restarChosen = rndNum.Next(0, (Restaraunts.Count - 1));
            return Restaraunts[restarChosen];
        }

        public string EmpFullName()
        {
            string employeeName = $"{this.EmpFirstName} {this.EmpLastName}";
            return employeeName;
        }

        public string Eat()
        {
            string restEatingAt = RandRestChosen();
            Console.WriteLine($"{EmpFullName()} is eating at {restEatingAt}");
            return restEatingAt;
        }

        public string Eat(string food)
        {
            string restEatingAt = RandRestChosen();
            Console.WriteLine($"{EmpFullName()} ate {food} at {restEatingAt}");
            return restEatingAt;
        }

        public string Eat(List<Employee> companions)
        {
            string restEatingAt = RandRestChosen();
            string eatingWith = $"with ";
            short counter = 0;
            foreach (var friend in companions)
            {
                ++counter;
                if (companions.Count == counter)
                {
                    eatingWith += $"and {friend.EmpFirstName}";
                    break;
                }
                eatingWith += $"{friend.EmpFirstName}, ";
            }

            Console.WriteLine($"{EmpFullName()} is eating at {restEatingAt} {eatingWith}");

            return restEatingAt;
        }

        public string Eat(string food, List<Employee> companions)
        {
            string restEatingAt = RandRestChosen();
            string eatingWith = $"with ";
            short counter = 0;
            foreach (var friend in companions)
            {
                ++counter;
                if (companions.Count == counter)
                {
                    eatingWith += $"and {friend.EmpFirstName}";
                    break;
                }
                eatingWith += $"{friend.EmpFirstName}, ";
            }
            Console.WriteLine($"{EmpFullName()} ate {food} at {restEatingAt} {eatingWith}");
            return restEatingAt;
        }

        readonly List<string> Restaraunts = new List<string>
        {
            "Arbys",
            "Logans",
            "Wendys",
            "McDonalds",
            "Shogun"
        };
    }

}
