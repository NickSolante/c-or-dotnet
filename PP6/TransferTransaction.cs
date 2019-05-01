using System;
using SplashKitSDK;

public class TransferTransactions : Transaction
{
    private Account _toAccount;
    private Account _fromAccount;
    private DepositTransactions _theDeposit;
    private WithdrawalTransactions _theWithdrawal;
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

    public TransferTransactions(Account Fromaccount, Account Toaccount, decimal amount) : base(amount)
    {
        _fromAccount = Fromaccount;
        _toAccount = Toaccount;


    }
    //execute rollback
    public override void Execute()
    {
        _theWithdrawal = new WithdrawalTransactions(_fromAccount, _amount);
        _theDeposit = new DepositTransactions(_toAccount, _amount);
        _theWithdrawal.Execute();


        if (_theWithdrawal.Success)
        {
            _theDeposit.Execute();
            if (_theDeposit.Success)
            {
                _theWithdrawal.RollBack();
            }
        }
        _executed = true;
        _success = true;
    }

    public void RollBack(Account Fromaccount, Account Toaccount, decimal money)
    {
        _fromAccount = Fromaccount;
        _toAccount = Toaccount;
        _amount = money;
        _theWithdrawal = new WithdrawalTransactions(_fromAccount, _amount);
        _theDeposit = new DepositTransactions(_toAccount, _amount);


        if (!_executed)
        {
            throw new Exception("Cannot execute this transaction has not been executed yet");
        }
        else if (_reversed)
        {
            //rollback has been reversed
            throw new Exception("Cannot execute this transaction has been reversed");
        }
        else if (_theWithdrawal.Success)
        {
            _theWithdrawal.RollBack();
        }
        else if (_theWithdrawal.Success)
        {
            _theDeposit.RollBack();
        }

    }
    public override void Print()
    {

        if (_success)
        {
            //print if it was successful
            Console.WriteLine($"The transaction was a success {_amount} was transfered from account ");

        }
        else
        {
            Console.Write("The transaction was a failure");
        }

    }
}