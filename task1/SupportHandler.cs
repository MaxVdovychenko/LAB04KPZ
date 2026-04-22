using System;

abstract class SupportHandler
{
    protected SupportHandler next;

    // Fluent chaining
    public SupportHandler SetNext(SupportHandler nextHandler)
    {
        next = nextHandler;
        return nextHandler;
    }

    // Safe input method (shared)
    protected bool AskUser(string question)
    {
        while (true)
        {
            Console.WriteLine(question + " (yes/no)");
            string input = Console.ReadLine()?.Trim().ToLower();

            if (input == "yes") return true;
            if (input == "no") return false;

            Console.WriteLine("Invalid input. Try again.\n");
        }
    }

    public abstract bool Handle();
}