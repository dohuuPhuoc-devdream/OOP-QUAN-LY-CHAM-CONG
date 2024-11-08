
using System;

namespace WinFormsApp6
{
    public class Employee : Person
    {
        public string Department { get; set; }
        public string Position { get; set; }
        public double BasicSalary { get; set; }

        public Employee(string id, string fullName, string dateOfBirth, string gender, string department, string position, double basicSalary)
            : base(id, fullName, dateOfBirth, gender)
        {
            Department = department;
            Position = position;
            BasicSalary = basicSalary;
        }
        public override void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine($"Department: {Department}, Position: {Position}");
        }
    }
}

