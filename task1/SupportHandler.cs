using System;

abstract class SupportHandler
{
    protected SupportHandler next;

    public void SetNext(SupportHandler nextHandler)
    {
        next = nextHandler;
    }

    public abstract bool Handle();
}