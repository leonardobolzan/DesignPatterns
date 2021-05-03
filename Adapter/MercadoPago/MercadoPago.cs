using System;

namespace Adapter
{
    class MercadoPago : IMercadoPagoPayment
    {
        private Token token;

        public Token AuthToken()
        {
            return new Token();
        }

        public void ReceiveMercadoPagoPayment()
        {
            token = AuthToken();
            Console.WriteLine("Recebendo pagamento com Mercado Pago.");
        }

        public void SendMercadoPagoPayment()
        {
            token = AuthToken();
            Console.WriteLine("Enviando pagamento com Mercado Pago.");
        }
    }
}
