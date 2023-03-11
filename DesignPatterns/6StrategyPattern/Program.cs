using System;

namespace _6StrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Payment payment = new CreditCardPayment();
            payment.PerformPayment();

            payment = new UPIPayment();
            payment.PerformPayment();


            payment = new WalletPayment();
            payment.PerformPayment();


            Console.ReadKey();

        }
    }
}
