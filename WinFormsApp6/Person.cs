using System;

namespace WinFormsApp6
{
    public abstract class Person
    {
         private string ID { get; set; }
         private string FullName { get; set; }
         private string DateOfBirth { get; set; }
         private string Gender { get; set; }
         public string Id
    {
      get { return ID; }
      set { ID = value; }
    }

     public string Fullname
    {
      get { return FullName; }
      set { FullName = value; }
    }

      public string DateOfbirth
     {
       get { return DateOfBirth; }
       set { DateOfBirth = value; }
     }

       public string GenDer
     {
        get { return Gender; }
         set { Gender = value; }
     }
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
