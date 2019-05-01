using System;
using SplashKitSDK;

public class Account
{
    private decimal _balance;
    private string _name;


    public Account(string name, decimal startingBalance)
    {
        _name = name;
        _balance = startingBalance;

    }
    public bool Deposit(decimal amountToAdd)
    {
        if (amountToAdd > 0)
        {
            _balance = _balance + amountToAdd;

            return true;
        }
        return false;


    }
    public bool Withdraw(decimal amountToSubtract)
    {
        if (amountToSubtract < _balance)
        {
            _balance -= amountToSubtract;
            return true;
        }
        return false;

    }
    public string Name
    {
        get { return _name; }
    }

    public void Print()

    {
        Console.WriteLine("Display account name and balance respectively: " + _name + " Balance is: " + _balance);
    }


}