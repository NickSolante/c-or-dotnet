using System;
using SplashKitSDK;

public enum MethodOption
{
    Withdraw, Deposit, Print, Quit
}

public class Program
{
    public static void DoDeposit(Account accounted)
    {
        decimal theMoney;

        Console.WriteLine("Please enter money to added to the account: ");
        theMoney = Convert.ToDecimal(Console.ReadLine());


        if (accounted.Deposit(theMoney))
        {
            Console.WriteLine("Success with the deposit");
        }
        else
        {
            Console.WriteLine("Fail with the deposit");

        }


    }
    public static void DoWithdraw(Account accounted)
    {
        decimal theMoney;

        Console.WriteLine("Please enter money to deducted to the account: ");
        theMoney = Convert.ToDecimal(Console.ReadLine());

        if (accounted.Withdraw(theMoney) == false)
        {
            Console.WriteLine("Fail with the Withdrawal");
        }
        else
        {
            Console.WriteLine("Success with the Withdrawal");

        }
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
            Console.WriteLine("Choose between the options of either 1 Withdraw, 2 Deposit, 3 Print and 4 Quit");
            options = Console.ReadLine();
            option = Convert.ToInt32(options);

        } while (option < 1 && option > 4);

        return (MethodOption)(option - 1);
    }
    public static void Main()
    //Main is here

    {
        Account myAccount = new Account("Nick's Account", 0);
        myAccount.Print();

        MethodOption ClientSelection;

        do
        {
            ClientSelection = ReadOption();

            Console.WriteLine("The client chose to " + ClientSelection);
            switch (ClientSelection)
            {
                case MethodOption.Withdraw:
                    DoWithdraw(myAccount);
                    break;
                case MethodOption.Deposit:
                    DoDeposit(myAccount);
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
