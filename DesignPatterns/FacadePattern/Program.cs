using System;

namespace FacadePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            OrderFacade paymentFacade = new OrderFacade();
            paymentFacade.makePayment();
            Console.ReadKey();
        }
    }
}
