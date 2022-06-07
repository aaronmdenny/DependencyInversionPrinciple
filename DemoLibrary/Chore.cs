namespace DemoLibrary
{
    /*
     * The Chore class is a "high-level" module because it depends upon the Logger and Emailer classes (initially).
     * The Emailer and Logger are "low-level" modules. They are depended upon by Chore. They also don't depend upon any
     * other class.
     */
    public class Chore : IChore
    {
        ILogger _logger;

        IMessageSender _messageSender;

        public string ChoreName { get; set; }

        public IPerson Owner { get; set; }

        public double HoursWorked { get; private set; }

        public bool IsComplete { get; private set; }

        public Chore(ILogger logger, IMessageSender messageSender)
        {
            _logger = logger;
            _messageSender = messageSender;
        }

        public void PerformedWork(double hours)
        {
            HoursWorked += hours;

            _logger.Log($"Performed work on {ChoreName}");
        }

        public void CompleteChore()
        {
            IsComplete = true;

            _logger.Log($"Completed {ChoreName}");
            _messageSender.SendMessage(Owner, $"The chore {ChoreName} is complete.");
        }
    }
}
