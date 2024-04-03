using System.Diagnostics;

namespace Project1Phase3
{
    internal class Program
    {
        static void Main(string[] args)
        
                { int counter = 0;
                int secondCounter = 0;
                Account[] accntArr = new Account[5];
                double withdrawn = 0;
                double transferred = 0;
                int userInput = 0;
                double userInputD = 0;
                bool clearCondition = false;
                string ownerName;
                string accountNumber;
                string accountType;
                string accntTransferSource;
                string accntTransferDest;
                int ownerYOB;
                double balance;
                bool succesful = false;
                while (counter < accntArr.Length)
                {
                    accntArr[counter] = new Account("null", 0, "null", "null", 0);
                    counter++;
                }
                counter = 0;

                while (userInput != 7)
                {
                    secondCounter = 0;
                    succesful = false;
                    Console.Clear();
                    clearCondition = false;
                    Console.WriteLine(" ------------------------------------ ");
                    Console.WriteLine("Welcome to ABC bank...");
                    Console.WriteLine("1. Open a new account.");
                    Console.WriteLine("2. Withdraw.");
                    Console.WriteLine("3. Deposit.");
                    Console.WriteLine("4. Transfer.");
                    Console.WriteLine("5. Print info of a given account.");
                    Console.WriteLine("6. Show how many accounts left.");
                    Console.WriteLine("7. Exit");
                    Console.WriteLine(" ------------------------------------ ");

                    while (clearCondition == false)
                    {
                        Console.Write("Please choose a number from above: ");
                        int.TryParse(Console.ReadLine(), out userInput);

                        switch (userInput)
                        {
                            case 1:

                                if (counter < accntArr.Length)
                                {

                                    Console.Write("Enter the name: ");
                                    ownerName = Console.ReadLine();
                                    do
                                    {
                                        Console.Write("Enter the year of birth (must be 18 to 100 years old by 2022): ");
                                        int.TryParse(Console.ReadLine(), out ownerYOB);
                                    } while (2022 - ownerYOB > 100 || 2022 - ownerYOB < 18);

                                    Console.Write("Enter account number: ");
                                    accountNumber = Console.ReadLine();
                                    do
                                    {
                                        Console.Write("Enter account type (Checking or Saving): ");
                                        accountType = Console.ReadLine();
                                    }
                                    while (accountType != "Saving" && accountType != "Checking");


                                    do
                                    {
                                        Console.Write("Enter initial balance (must be 50 or more): ");
                                        double.TryParse(Console.ReadLine(), out balance);


                                    } while (balance < 50);

                                    accntArr[counter] = new Account(ownerName, ownerYOB, accountNumber, accountType, balance);

                                    Console.WriteLine("Opened successfully!");
                                    counter++;
                                }
                                else
                                {
                                    Console.WriteLine("Sorry..the maximum number of accounts is reached.");



                                }

                                Console.ReadKey();
                                clearCondition = true;

                                break;

                            case 2:
                                if (counter > 0)
                                {

                                    Console.Write("Enter account number to withdraw from: ");
                                    accountNumber = Console.ReadLine();

                                    foreach (Account account in accntArr)
                                    {
                                        if (account.accountNumber == "null")
                                        {
                                            continue;
                                        }
                                        else if (account.accountNumber == accountNumber)
                                        {

                                            Console.Write("How much would you like to withdraw? ");
                                            double.TryParse(Console.ReadLine(), out userInputD);
                                            withdrawn = account.Withdraw(userInputD);
                                            if (withdrawn > 0)
                                            {
                                                Console.WriteLine($"Succesful! {withdrawn:C2} withdrawn.");


                                            }
                                            else
                                            {
                                                Console.WriteLine("Not succesful!");

                                            }
                                            succesful = true;
                                            break;


                                        }

                                    }
                                    if (!succesful)
                                    {
                                        Console.WriteLine("The account was not found!");
                                    }



                                }
                                else
                                {
                                    Console.WriteLine("No accounts yet!");

                                }
                                Console.ReadKey();
                                clearCondition = true;
                                break;

                            case 3:
                                if (counter > 0) {
                                    Console.Write("Enter account number to deposit to: ");
                                    accountNumber = Console.ReadLine();
                                    foreach (Account account in accntArr)
                                    {
                                        if (account.accountNumber == "null")
                                        {
                                            continue;
                                        }
                                        else if (account.accountNumber == accountNumber)
                                        {
                                            Console.Write("How much would you like to deposit? ");

                                            double.TryParse(Console.ReadLine(), out userInputD);

                                            if (userInputD > 0)
                                            {
                                                account.Deposit(userInputD);
                                                Console.WriteLine($"{userInputD:C2} was deposited!");

                                            }
                                            else
                                            {
                                                Console.WriteLine("Nothing was deposited.");

                                            }
                                            succesful = true;
                                            break;
                                        }


                                    }
                                    if (!succesful)
                                    {
                                        Console.WriteLine("The account was not found!");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("No accounts yet!");
                                }
                                clearCondition = true;
                                Console.ReadKey();
                                break;

                            case 4:
                                if (counter > 1)
                                {
                                    Console.Write("Current accounts: ");
                                    foreach (Account account in accntArr)
                                    {
                                        if (account.accountNumber == "null")
                                        {
                                            continue;
                                        }
                                        else
                                        {
                                            Console.Write(account.accountNumber + "\t");
                                        }
                                    }
                                    Console.Write("\nEnter the number of the account to transfer from: ");
                                    accntTransferSource = Console.ReadLine();
                                    Console.Write("Enter the number of the account to transfer to: ");
                                    accntTransferDest = Console.ReadLine();
                                    foreach (Account account in accntArr)
                                    {
                                        if (account.accountNumber == "null")
                                        {
                                            continue;
                                        }
                                        else if (account.accountNumber == accntTransferSource)
                                        {
                                            ;

                                            foreach (Account accnt in accntArr)
                                            {
                                                if (account.accountNumber == "null")
                                                {
                                                    continue;
                                                }
                                                else if (accnt.accountNumber == accntTransferDest)
                                                {

                                                    Console.Write("How much would you like to transfer? ");
                                                    double.TryParse(Console.ReadLine(), out userInputD);
                                                    transferred = account.Transfer(accnt, userInputD);
                                                    succesful = true;
                                                    break;
                                                }
                                            }
                                            break;
                                        }
                                    }
                                    if (transferred > 0)
                                    {
                                        Console.WriteLine($"Successful! {transferred:C2} was transferred.");
                                    }
                                    else if (succesful)
                                    {
                                        Console.WriteLine("Unsuccessful!");
                                    }
                                    else
                                    {
                                        Console.WriteLine("One or both of the accounts were not found!");
                                    }
                                }
                                else
                                {
                                    Console.Write("Insufficient open accounts, (not enough accounts to perform transfer.)");
                                }
                                clearCondition = true;
                                Console.ReadKey();
                                break;

                            case 5:
                                if (counter > 0)
                                {
                                    Console.Write("Current accounts: ");
                                    while (secondCounter < counter)
                                    {
                                        Console.Write(accntArr[secondCounter].accountNumber + "\t");
                                        secondCounter++;

                                    }
                                    Console.Write("\n");
                                    while (succesful == false)
                                    {
                                        Console.Write("Enter account number to print info: ");
                                        accountNumber = Console.ReadLine();

                                        foreach (Account account in accntArr)
                                        {
                                            if (account.accountNumber == "null")
                                            {
                                                continue;
                                            }
                                            else if (account.accountNumber == accountNumber)
                                            {
                                                succesful = true;
                                                Console.Write(account.ToString());
                                                break;
                                            }
                                        }
                                    }

                                }
                                else
                                {
                                    Console.WriteLine("There are no accounts created.");
                                }
                                clearCondition = true;
                                Console.ReadKey();


                                break;

                            case 6:
                                Console.WriteLine($"You can create/open {accntArr.Length - counter} more accounts.");
                                clearCondition = true;
                                Console.ReadKey();

                                break;
                               case 7:
                            clearCondition = true;

                               break;

                                                       
                               
                        }



                    }
                }
           
        }
    }
}