using System;

class BasicSupport : SupportHandler
{
    public override bool Handle()
    {
        if (AskUser("Is your issue about password reset?"))
        {
            Console.WriteLine("Basic Support: Use 'Forgot Password'.\n");
            return true;
        }

        return next != null && next.Handle();
    }
}