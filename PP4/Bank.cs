using System;
using SplashKitSDK;
using System.Collections.Generic;


public class Bank
{
    private static List<Account> _accounts = new List<Account>();
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

    public void ExecuteTransaction(DepositTransactions transaction)
    {
        transaction.Execute();
    }
    public void ExecuteTransaction(WithdrawalTransactions transaction)
    {
        transaction.Execute();
    }

    public void ExecuteTransaction(TransferTransactions transaction)
    {
        transaction.Execute();
    }


}
