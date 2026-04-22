using System;

class TechnicalSupport : SupportHandler
{
    public override bool Handle()
    {
        if (AskUser("Is your issue about software not working?"))
        {
            Console.WriteLine("Technical Support: Reinstall the app.\n");
            return true;
        }

        return next != null && next.Handle();
    }
}