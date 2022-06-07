using DemoLibrary;
using System;

namespace ConsoleUI
{
    /*
     * Program is a "high-levl" module. It depends upon Person and Chore.
     */
    class Program
    {
        /*
         * Dependency Inversion Principle: High-level modules should not depend upon low-level modules, but rather both
         * should depend upon abstractions. Those abstractions should not depend upon details.
         * 
         * We want to only "new up" an instance in one place where we can easily swap out the instance with another
         * class that implements an interface.
         */
        static void Main(string[] args)
        {
            IPerson owner = new Person
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
