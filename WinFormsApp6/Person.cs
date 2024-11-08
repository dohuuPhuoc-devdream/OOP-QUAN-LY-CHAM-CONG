using System;

namespace WinFormsApp6
{
    public abstract class Person
    {
        public string Id { get; set; }
        public string FullName { get; set; }
        public string DateOfBirth { get; set; }
        public string Gender { get; set; }

        protected Person(string id, string fullName, string dateOfBirth, string gender)
        {
            Id = id;
            FullName = fullName;
            DateOfBirth = dateOfBirth;
            Gender = gender;
        }
        public virtual void DisplayDetails()
        {
            Console.WriteLine($"ID: {Id}, Name: {FullName}, Gender: {Gender}, Date of Birth: {DateOfBirth}");
        }
    }
}
