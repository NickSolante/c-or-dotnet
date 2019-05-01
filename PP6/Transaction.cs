using System;
using SplashKitSDK;

public abstract class Transaction
{
    protected decimal _amount;
    private bool _executed = false;
    private bool _reversed = false;

    private DateTime _dateStamp;

    private bool _Success;

    public abstract bool Success
    {

        get;

    }

    public bool Executioning
    {
        get
        {
            return _executed;
        }
    }

    public DateTime DateStamp{

        get {

            return _dateStamp = DateTime.Now;

        }
    }


    public Transaction(decimal amount)
    {
        _amount = amount;
    }

    public abstract void Print();

    public virtual void Execute(){
        if(_executed){
            throw new Exception("Cannot execute this transaction has already been executed");

        }
        _executed = true;
        _dateStamp = DateTime.Now;

    }

    public virtual void Rollback()
    {
        if (_reversed)
        {
            throw new Exception("Cannot execute this transaction has already been reversed");

        }
        _reversed = true;
        _dateStamp = DateTime.Now;
    }



}