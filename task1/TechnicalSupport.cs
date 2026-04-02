using System;
class TechnicalSupport : SupportHandler
{
    public override bool Handle()
    {
        Console.WriteLine("Is your issue about software not working? (yes/no)");
        string input = Console.ReadLine();

        if (input.ToLower() == "yes")
        {
            Console.WriteLine("Technical Support: Try reinstalling the software.");
            return true;
        }

        return next?.Handle() ?? false;
    }
}