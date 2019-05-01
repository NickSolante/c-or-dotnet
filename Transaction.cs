using System;
using SplashKitSDK;
using System.Collections.Generic;


    public abstract class Transaction
{
    protected decimal amount;
    private DateTime _dateStamp;
    private bool _executed = false;
    private bool _success = false;
    private bool _reversed = false;

    public abstract bool Success
    {
        get
        {
            return _success;
        }
    }
    public abstract bool Executed
    {
        get
        {
            return _executed;
        }
    }

    // reverse bool catcher
    public abstract bool Reversed
    {

        get
        {
            return _reversed;
        }

    }

}
