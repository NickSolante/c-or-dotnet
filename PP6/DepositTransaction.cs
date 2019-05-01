using System;
using SplashKitSDK;

public class DepositTransactions : Transaction
{
    private Account _account;
    private bool _executed = false;
    private bool _success = false;
    private bool _reversed = false;

    public override bool Success
    {
        get
        {
            return _success;
        }
    }

    public bool Executed
    {
        get
        {
            return _executed;
        }
    }

    // reverse bool catcher
    public bool Reversed
    {

        get
        {
            return _reversed;
        }

    }

    public DepositTransactions(Account account, decimal amount) : base(amount)
    {
        _account = account;
        base.Execute();

    }
    //execute rollback
    public override void Execute()
    {
        if (_executed)
        {
            throw new Exception("Cannot execute this transaction has already processes");
        }
        _executed = true;
        _success = _account.Deposit(_amount);
    }

    public void RollBack()
    {

        if (!_executed)
        {
            throw new Exception("Cannot execute this transaction has not been executed yet");
        }
        else if (_reversed)
        {
            //rollback has been reversed
            throw new Exception("Cannot execute this transaction has been reversed");
        }
        else
        {
            _executed = false;
            _success = false;
            _reversed = true;
            _account.Withdraw(_amount);
        }

    }
    public override void Print()
    {
        Console.WriteLine($"Withdraw transaction for {_account.Name} - amount: {_amount}");

        if (_success)
        {
            //print if it was successful
            Console.WriteLine("The transaction was a success " + _amount + " was Deposited ");

        }
        else
        {
            Console.Write("The transaction was a failure");
        }

    }
}