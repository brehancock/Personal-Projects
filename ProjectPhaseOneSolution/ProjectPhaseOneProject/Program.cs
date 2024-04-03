namespace ProjectPhaseOneProject
{
    internal class Program
    {
        static void Main()
        {
            Account acc1 = new Account("Kamal Al Nasr", 1990, "18276758", "Checking", 100.5);
            acc1.Deposit(1001.9);
            acc1.SetAddress("Augusta, GA 30905");
            Account acc2 = new Account();
            acc2.SetName("John William");
            acc2.SetYOB(2001);
            acc2.SetAddress("Augusta University");
            acc2.SetAccountType("Saving");
            acc2.SetAccountNumber("984367");
            acc2.Deposit(515.4);
            acc2.Deposit(127.2);
            Console.WriteLine(acc1);
            Console.WriteLine();
            Console.WriteLine(acc2);
            Console.WriteLine("-------------------------\n");
            double withdrawn = acc1.Withdraw(1020);
            if (withdrawn > 0)
                Console.WriteLine($"Successful withdraw from {acc1.GetAccountType()} account! balance now:{acc1.GetBalance():C2}, withdrawn: {withdrawn:C2}");
            else
                Console.WriteLine($"The withdraw was not successful from {acc1.GetAccountType()}! balance:{acc1.GetBalance():C2}");
            withdrawn = acc2.Withdraw(111.5);
            if (withdrawn > 0)
                Console.WriteLine($"Successful withdraw from {acc2.GetAccountType()} account! balance now:{acc2.GetBalance():C2}, withdrawn: {withdrawn:C2}");
            else
                Console.WriteLine($"The withdraw was not successful from {acc2.GetAccountType()}! balance:{acc2.GetBalance():C2}");
            withdrawn = acc1.Withdraw(920);
            if (withdrawn > 0)
                Console.WriteLine($"Successful withdraw from {acc1.GetAccountType()} account! balance now:      {acc1.GetBalance():C2}, withdrawn: {withdrawn:C2}");
            else
                Console.WriteLine($"The withdraw was not successful from {acc1.GetAccountType()}! balance:      {acc1.GetBalance():C2}");
            withdrawn = acc1.Withdraw(420);
            if (withdrawn > 0)
                Console.WriteLine($"Successful withdraw from {acc1.GetAccountType()} account! balance now:{ acc1.GetBalance():C2}, withdrawn: { withdrawn:C2}");
else
                Console.WriteLine($"The withdraw was not successful from {acc1.GetAccountType()}! balance:{ acc1.GetBalance():C2}");
withdrawn = acc1.Transfer(acc2, 234.5);
            if (withdrawn > 0)
                Console.WriteLine($"Successful transfer from {acc1.GetAccountType()} to {acc2.GetAccountType()}! balance now:{acc1.GetBalance():C2}, transferred: {withdrawn:C2}            ");
else
                Console.WriteLine($"Unsuccessful transfer from {acc1.GetAccountType()}! balance: {acc1.GetBalance():C2}");
            withdrawn = acc2.Transfer(acc1, 234.5);
            if (withdrawn > 0)
                Console.WriteLine($"Successful transfer from {acc2.GetAccountType()} to {acc1.GetAccountType()}! balance now:{ acc2.GetBalance():C2}, transferred: {withdrawn:C2}");
else
                Console.WriteLine($"Unsuccessful transfer from {acc2.GetAccountType()}! balance: {acc2.GetBalance():C2}");
            Console.WriteLine("\n-------------------------\n");
            Console.WriteLine(acc1);
            Console.WriteLine();
            Console.WriteLine(acc2);





        }
    }
}

