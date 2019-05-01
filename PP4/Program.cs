using System;
using SplashKitSDK;

public enum MethodOption
{
    addAccount, Deposit, Withdraw, Transfer, Print, Quit
}

public class Program
{
    private static Account FindAccount(Bank fromBank)
    {
        Console.WriteLine("Enter name: ");
        string name = Console.ReadLine();
        Account result = fromBank.getAccount(name);

        if (result == null)
        {
            Console.WriteLine($"No Account found with bane {name}");
        }
        return result;
    }
    public static void DoAdd(Bank CommBank)
    {
        string name;
        decimal theMoney;


        Console.WriteLine("Please enter name on the account: ");
        name = Console.ReadLine();
        Console.WriteLine("Please enter starting balance: ");
        theMoney = Convert.ToDecimal(Console.ReadLine());
        Account myNewAccount = new Account(name, theMoney);
        CommBank.AddAccount(myNewAccount);

    }

    public static void DoDeposit(Bank toBank)
    {
        Account toAccount = FindAccount(toBank);
        if (toAccount == null) return;

        decimal theMoney;
        Console.WriteLine("Please enter money to added to the account: ");
        theMoney = Convert.ToDecimal(Console.ReadLine());
        DepositTransactions theDeposit = new DepositTransactions(toAccount, theMoney);
        // toBank.ExecuteTransaction(TransCheck);
        toBank.ExecuteTransaction(theDeposit);
        // theDeposit.Execute();

        if (theDeposit.Success)
        {
            Console.WriteLine("Transaction successful");

        }
        else
        {
            Console.WriteLine("Please redo transaction");

        }
        theDeposit.Print(theMoney);


    }
    public static void DoWithdraw(Bank fromBank)
    {
        Account toAccount = FindAccount(fromBank);
        if (toAccount == null) return;
        decimal theMoney;

        Console.WriteLine("Please enter money to deducted to the account: ");
        theMoney = Convert.ToDecimal(Console.ReadLine());
        WithdrawalTransactions TransCheck = new WithdrawalTransactions(toAccount, theMoney);
        fromBank.ExecuteTransaction(TransCheck);

        if (TransCheck.Success)
        {
            Console.WriteLine("Transaction successful");

        }
        else
        {
            Console.WriteLine("Please redo transaction");

        }
        TransCheck.Print(theMoney);

    }

    public static void DoTransfer(Bank accounted)
    {
        Account fromAccount = FindAccount(accounted);
        if (fromAccount == null) return;
        Account toAccount = FindAccount(accounted);
        if (toAccount == null) return;

        decimal theMoney;


        Console.WriteLine("Please enter money to sent to the account: ");
        theMoney = Convert.ToDecimal(Console.ReadLine());
        TransferTransactions TransTrans = new TransferTransactions(fromAccount, toAccount, theMoney);
        accounted.ExecuteTransaction(TransTrans);


        if (TransTrans.Success)
        {
            Console.WriteLine("Transaction successful");

        }
        else
        {
            Console.WriteLine("Please redo transaction");

        }
        TransTrans.Print(theMoney);

    }

    public static void DoPrint(Bank accounted)
    {
        Account fromAccount = FindAccount(accounted);
        if (fromAccount == null) return;

        fromAccount.Print();

    }

    public static MethodOption ReadOption()
    {
        int option;
        string options;

        do
        {
            Console.WriteLine("Choose between the options of either 1 to Add an Account, 2 Deposit, 3 Withdrawal, 4 Transfer, 5 Print and 6 Quit");
            options = Console.ReadLine();
            option = Convert.ToInt32(options);

        } while (option < 1 && option > 5);

        return (MethodOption)(option - 1);
    }
    public static void Main()
    //Main is here

    {
        Bank CommBank = new Bank();


        MethodOption ClientSelection;

        do
        {
            ClientSelection = ReadOption();

            Console.WriteLine("The client chose to " + ClientSelection);
            switch (ClientSelection)
            {
                case MethodOption.addAccount:
                    DoAdd(CommBank);
                    break;
                case MethodOption.Deposit:
                    DoDeposit(CommBank);
                    break;
                case MethodOption.Withdraw:
                    DoWithdraw(CommBank);
                    break;
                case MethodOption.Transfer:
                    DoTransfer(CommBank);
                    break;
                case MethodOption.Print:
                    DoPrint(CommBank);
                    break;
                case MethodOption.Quit:
                    Console.WriteLine("Quitting time");
                    break;
            }
        }
        while (ClientSelection != MethodOption.Quit);



    }
}
