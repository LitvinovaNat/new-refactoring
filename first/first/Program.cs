using System;

namespace first
{
    
        public class Person
        {
            public string FirstName { get; protected set; }
            public string LastName { get; protected set; }
            public virtual string GetSex() => "Unknow";

            public Person(string firstName, string lastName)
            {
                FirstName = firstName;
                LastName = lastName;
            }


        }

        public class Man : Person
        {
            public Man(string firstName, string lastName) : base(firstName, lastName) { }
            public override string GetSex() => "Man";
        }

        public class Woman : Person
        {
            public Woman(string firstName, string lastName) : base(firstName, lastName) { }
            public override string GetSex() => "Woman";
        }

        public class Program
        {
            public static void Main(string[] args)
            {
                Person woman = new Woman("Elena", "Kovolenko");
                Person man = new Man("Nikita", "Smirnov");
                string sex = woman.GetSex();
                Console.WriteLine(sex);
                Console.ReadLine();
            }
        }
    

}