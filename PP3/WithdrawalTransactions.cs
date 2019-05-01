using System;
using SplashKitSDK;

public class WithdrawalTransactions
{
    private Account _account;
    private decimal _amount;
    private bool _executed = false;
    private bool _success = false;
    private bool _reversed = false;

    public bool Success
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

    public WithdrawalTransactions(Account account, decimal amount)
    {
        _account = account;
        _amount = amount;

    }
    //execute rollback
    public bool Execute(Account accounting, decimal money)
    {
        _account = accounting;
        _amount = money;
        if (_executed)
        {
            throw new Exception("Cannot execute this transaction has already processes");
        }
        _executed = true;
        _success = _account.Withdraw(_amount);
        return _success;
    }

    public void RollBack(Account accounting, decimal money)
    {
        _amount = money;

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
            _account.Deposit(_amount);
        }



    }
    public void Print(decimal theMoney)
    {
        _amount = theMoney;
        if (_success)
        {
            //print if it was successful
            Console.WriteLine("The transaction was a success " + _amount + " was Withdrawn ");

        }
        else if (!_success)
        {
            Console.WriteLine("The transaction was a failure");
        }
    }

}