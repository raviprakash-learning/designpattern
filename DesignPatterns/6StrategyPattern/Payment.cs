using System;
using System.Collections.Generic;
using System.Text;

namespace _6StrategyPattern
{
    public abstract class Payment
    {
        public PaymentBehavior paymentBehavior;
        // common method will stay here and method which behavior which is not same to each client move
        // that to new behaviour ex we move paymentBehavuour to separate interface
        public void PerformPayment()
        {
            paymentBehavior.MakePayment();
        }
    }

    public interface PaymentBehavior
    {
        public void MakePayment();
    }

    public class CreditCardPaymentBehavior : PaymentBehavior
    {
        public void MakePayment()
        {
            Console.WriteLine("Payment Using Credit Card");
        }
    }
    public class UPIPaymentBehavior : PaymentBehavior
    {
        public void MakePayment()
        {
            Console.WriteLine("Payment Using UPI");
        }
    }
    public class WalletPaymentBehavior : PaymentBehavior
    {
        public void MakePayment()
        {
            Console.WriteLine("Payment Using Wallet");
        }
    }

    public class CreditCardPayment : Payment
    {
        public CreditCardPayment()
        {
            paymentBehavior = new CreditCardPaymentBehavior();
        }
    }

    public class UPIPayment : Payment
    {
        public UPIPayment()
        {
            paymentBehavior = new UPIPaymentBehavior();
        }
    }
    public class WalletPayment : Payment
    {
        public WalletPayment()
        {
            paymentBehavior = new WalletPaymentBehavior();
        }
    }


}
