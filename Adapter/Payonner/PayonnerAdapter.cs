using System;

namespace Adapter
{
    class PayonnerAdapter : IPayPalPayment
    {
        private Payonner payonner;

        public PayonnerAdapter(Payonner payonner)
        {
            this.payonner = payonner;
            Console.WriteLine("Realizando adaptação de Payonner para os métodos do PayPal.");
        }
        
        public Token AuthToken()
        {
            return payonner.AuthToken();
        }

        public void PayPalPayment()
        {
            payonner.SendPayment();
        }

        public void PayPalReceive()
        {
            payonner.ReceivePayment();
        }
    }
}
