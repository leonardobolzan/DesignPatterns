using System;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            IPayPalPayment payment = new PayonnerAdapter(new Payonner());
            payment.PayPalPayment();
            payment.PayPalReceive();

            IPayPalPayment payment1 = new MercadoPagoAdapter(new MercadoPago());
            payment1.PayPalPayment();
            payment1.PayPalReceive();

            Console.ReadLine();
        }
    }
}
