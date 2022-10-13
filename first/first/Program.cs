using System;

namespace first
{
    
        public class Person
        {
            public string FirstName { get; protected set; }
            public string LastName { get; protected set; }


            private string Sex = "Unknow";
            public virtual string GetSex() => Sex;

        private Person(string firstName, string lastName)
            {
                FirstName = firstName;
                LastName = lastName;
            }

        protected Person(string firstName, string lastName, string sex) : this(firstName, lastName) => Sex = sex;

        public static Person CreateMan(string firstName, string lastName) => new Person(firstName, lastName, "Man");

        public static Person CreateWoman(string firstName, string lastName) => new Person(firstName, lastName, "Woman");


    }

        public class Program
        {
            public static void Main(string[] args)
            {
                Person woman = Person.CreateWoman("Elena", "Kovolenko");
                Person man = Person.CreateMan("Nikita", "Smirnov");
                string sex = woman.GetSex();
                Console.WriteLine(sex);
                Console.ReadLine();
            }
        }
    

}