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

        public static IMessageSender CreateMessageSender()
        {
            return new Emailer();
        }
    }
}
