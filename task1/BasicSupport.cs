using System;
class BasicSupport : SupportHandler
{
    public override bool Handle()
    {
        Console.WriteLine("Is your issue about password reset? (yes/no)");
        string input = Console.ReadLine();

        if (input.ToLower() == "yes")
        {
            Console.WriteLine("Basic Support: Reset your password using 'Forgot Password'.");
            return true;
        }

        return next?.Handle() ?? false;
    }
}