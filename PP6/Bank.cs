using System;
using SplashKitSDK;
using System.Collections.Generic;


public class Bank
{
    private static List<Account> _accounts = new List<Account>();
    private List<Transaction> _transactions = new List<Transaction>();
    public void AddAccount(Account accountToBeAdded)
    {
        _accounts.Add(accountToBeAdded);
    }
    public Account getAccount(string name)
    {
        Account toTheBank;
        foreach (Account item in _accounts)
        {
            if (name == item.Name)
            {
                return toTheBank = item;
            }
        }
        return null;
    }

    public void ExecuteTransaction(Transaction transaction)
    {
        transaction.Execute();
        _transactions.Add(transaction);
    }
    public void PrintTranscationHistory()
    {
        foreach (Transaction item in _transactions)
        {
            item.Print();

        }

    }

}
