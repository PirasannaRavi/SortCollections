using System;
using System.Collections.Generic;
using System.Linq;

namespace SortCollections
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var employees = new List<Employee>()
            {
                new Employee
                {
                    EmpName = "Pirasanna",
                    StateID = 1,
                    ReleaseID = 1
                },
                new Employee
                {
                    EmpName = "Ravi",
                    StateID = 3,
                    ReleaseID = 2
                },
                new Employee
                {
                    EmpName = "Devika",
                    StateID = 3,
                    ReleaseID = 3
                }
            };

            var predicate1 = new List<int>() { 23, 22, 21, 13, 12, 11 };
            employees = employees.OrderByDescending(x => Enumerable.Reverse(predicate1).ToList().IndexOf(int.Parse(x.StateID.ToString() + x.ReleaseID.ToString()))).ToList();

            Console.Write(employees);
        }
    }

    class Employee
    {
        public string EmpName;
        public int StateID;
        public float ReleaseID;
    }
}
