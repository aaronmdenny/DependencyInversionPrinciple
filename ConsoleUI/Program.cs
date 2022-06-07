using DemoLibrary;
using System;

namespace ConsoleUI
{
    class Program
    {
        /*
         * Dependency Inversion Principle: High-level modules should not depend upon low-level modules, but rather both
         * should depend upon abstractions. Those abstractions should not depend upon details.
         */
        static void Main(string[] args)
        {
            Person owner = new Person
            {
                FirstName = "Tim",
                LastName = "Corey",
                EmailAddress = "tim@iamtimcorey.com",
                PhoneNumber = "555-1212"
            };

            Chore chore = new Chore
            {
                ChoreName = "Take out the trash",
                Owner = owner
            };

            chore.PerformedWork(3);
            chore.PerformedWork(1.5);
            chore.CompleteChore();

            Console.ReadLine();
        }
    }
}
