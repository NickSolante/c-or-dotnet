using System;
using SplashKitSDK;

public enum MethodOption
{
    Deposit, Withdraw, Transfer, Print, Quit
}

public class Program
{
    public static void DoDeposit(Account accounted)
    {
        decimal theMoney;

        Console.WriteLine("Please enter money to added to the account: ");
        theMoney = Convert.ToDecimal(Console.ReadLine());
        DepositTransactions TransCheck = new DepositTransactions(accounted, theMoney);

        if (TransCheck.Execute(accounted, theMoney) == true)
        {
            Console.WriteLine("Transaction successful");

        }
        else
        {
            Console.WriteLine("Please redo transaction");

        }
        TransCheck.Print(theMoney);


    }
    public static void DoWithdraw(Account accounted)
    {
        decimal theMoney;


        Console.WriteLine("Please enter money to deducted to the account: ");
        theMoney = Convert.ToDecimal(Console.ReadLine());
        WithdrawalTransactions TransCheck = new WithdrawalTransactions(accounted, theMoney);


        if (TransCheck.Execute(accounted, theMoney) == true)
        {
            Console.WriteLine("Transaction successful");

        }
        else
        {
            Console.WriteLine("Please redo transaction");

        }
        TransCheck.Print(theMoney);

    }

    public static void DoTransfer(Account accounted, Account Jakey)
    {
        decimal theMoney;


        Console.WriteLine("Please enter money to deducted to the account: ");
        theMoney = Convert.ToDecimal(Console.ReadLine());
        TransferTransactions TransTrans = new TransferTransactions(Jakey, accounted, theMoney);

        TransTrans.Execute(accounted, Jakey, theMoney);

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

    public static void DoPrint(Account accounted)
    {

        accounted.Print();

    }

    public static MethodOption ReadOption()
    {
        int option;
        string options;

        do
        {
            Console.WriteLine("Choose between the options of either 1 Deposit, 2 Withdrawal, 3 Transfer, 4 Print and 5 Quit");
            options = Console.ReadLine();
            option = Convert.ToInt32(options);

        } while (option < 1 && option > 5);

        return (MethodOption)(option - 1);
    }
    public static void Main()
    //Main is here

    {
        Account myAccount = new Account("Nick's Account", 0);
        Account yourAccount = new Account("Jake's Account", 100000);
        myAccount.Print();

        MethodOption ClientSelection;

        do
        {
            ClientSelection = ReadOption();

            Console.WriteLine("The client chose to " + ClientSelection);
            switch (ClientSelection)
            {
                case MethodOption.Deposit:
                    DoDeposit(myAccount);
                    break;
                case MethodOption.Withdraw:
                    DoWithdraw(myAccount);
                    break;
                case MethodOption.Transfer:
                    DoTransfer(yourAccount, myAccount);
                    break;
                case MethodOption.Print:
                    DoPrint(myAccount);
                    break;
                case MethodOption.Quit:
                    Console.WriteLine("Quitting time");
                    break;
            }
        }
        while (ClientSelection != MethodOption.Quit);



    }
}
