using Bridge.Plataforms;
using System;

namespace Bridge.Platforms
{
    class YouTube : IPlatform
    {
        public YouTube()
        {
            ConfigureRMTP();
            Console.WriteLine("Youtube: transmissão iniciada.");
        }
        
        public void AuthToken()
        {
            Console.WriteLine("Youtube: autorizando aplicação.");
        }

        public void ConfigureRMTP()
        {
            Console.WriteLine("Youtube: configurando servidor RMTP.");
        }
    }
}
