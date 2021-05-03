using AbstractFactory.App;
using AbstractFactory.Factories;
using System;

namespace AbstractFactory
{
    class Program
    {
        static Application ConfigureApplication()
        {
            Application app;

            ITransportFactory transportFactory;

            string company = "Lime";

            if (company == "99")
            {
                transportFactory = new NineNineTransport();
            } else if (company == "Lime")
            {
                transportFactory = new LimeTransport();
            } else
            {
                transportFactory = new UberTransport();
            }

            app = new Application(transportFactory);

            return app;
        }

        static void Main(string[] args)
        {
            Application app = ConfigureApplication();

            app.StartRoute();

            Console.ReadLine();
        }
    }
}
