using System;

namespace BankExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            
            try
            {
                Account acc = new Account("zuhair", 10000);
                Account acc1 = new Account() { Name = "David", Balance = 2000.00M };
                acc.Deposit(234);
                Console.WriteLine(acc.Balance);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadKey();
            
        }
    }
}
