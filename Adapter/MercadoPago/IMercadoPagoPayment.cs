namespace Adapter
{
    interface IMercadoPagoPayment
    {
        Token AuthToken();

        void SendMercadoPagoPayment();

        void ReceiveMercadoPagoPayment();
    }
}
