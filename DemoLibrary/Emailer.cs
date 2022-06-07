using System;

namespace DemoLibrary
{
    public class Emailer
    {
        public void SendEmail(IPerson person, string message)
        {
            Console.WriteLine($"Simulating sending an email to {person.EmailAddress}");
        }
    }
}
