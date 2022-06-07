using DemoLibrary;

namespace ConsoleUI
{
    /// <summary>
    /// "News up" instances that implememnt an interface.
    /// </summary>
    public static class Factory
    {
        public static IPerson CreatePerson()
        {
            return new Person();
        }

        public static IChore CreateChore()
        {
            return new Chore(CreateLogger(), CreateMessageSender());
        }

        public static ILogger CreateLogger()
        {
            return new Logger();
        }

        /*
         * We can easily swap out one implementation for another. High-level modules depend upon the abstraction, not
         * the class that implements the interface.
         */
        public static IMessageSender CreateMessageSender()
        {
            //return new Emailer();
            return new Texter();
        }
    }
}
