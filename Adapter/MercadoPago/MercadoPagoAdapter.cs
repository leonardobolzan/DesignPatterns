using System;

namespace Adapter
{
    class MercadoPagoAdapter : IPayPalPayment
    {
        private MercadoPago mercadoPago;
        
        public MercadoPagoAdapter(MercadoPago mercadoPago)
        {
            this.mercadoPago = mercadoPago;
            Console.WriteLine("Realizando adaptação de Mercado Pago para os métodos do PayPal.");
        }

        public Token AuthToken()
        {
            return mercadoPago.AuthToken();
        }

        public void PayPalPayment()
        {
            mercadoPago.SendMercadoPagoPayment();
        }

        public void PayPalReceive()
        {
            mercadoPago.ReceiveMercadoPagoPayment();
        }
    }
}
