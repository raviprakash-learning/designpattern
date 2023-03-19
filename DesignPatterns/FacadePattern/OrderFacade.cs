using System;
using System.Collections.Generic;
using System.Text;

namespace FacadePattern
{
    public class OrderFacade
    {
        private readonly Product product;
        private readonly Payment payment;
        private readonly Invoice invoice;
        private readonly Notification notification;

        public OrderFacade()
        {
            this.product = new Product();
            this.payment = new Payment();
            this.invoice = new Invoice();
            this.notification = new Notification();
           
        }
        public void makePayment()
        {
            product.GetProduct();
            payment.pay(5000);
            invoice.GetInvoice();
            notification.sendNotification();
        }
    }
}
