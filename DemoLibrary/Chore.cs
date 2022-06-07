namespace DemoLibrary
{
    /*
     * The Chore class is a "high-level" module because it depends upon the Logger and Emailer classes (initially).
     * The Emailer and Logger are "low-level" modules. They are depended upon by Chore. They also don't depend upon any
     * other class.
     */
    public class Chore
    {
        public string ChoreName { get; set; }

        public IPerson Owner { get; set; }

        public double HoursWorked { get; private set; }

        public bool IsComplete { get; private set; }

        public void PerformedWork(double hours)
        {
            HoursWorked += hours;
            Logger log = new Logger();
            log.Log($"Performed work on {ChoreName}");
        }

        public void CompleteChore()
        {
            IsComplete = true;

            Logger log = new Logger();
            log.Log($"Completed {ChoreName}");

            Emailer emailer = new Emailer();
            emailer.SendEmail(Owner, $"The chore {ChoreName} is complete.");
        }
    }
}
