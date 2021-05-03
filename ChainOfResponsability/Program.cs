using ChainOfResponsability.Middlewares;
using ChainOfResponsability.Servers;
using System;

namespace ChainOfResponsability
{
    class Program
    {
        private static Server server;
        
        static void Init()
        {
            server = new Server();
            server.RegisterUser("master@hcode.com.br", "nsiufdh89!sfhdsi##fknds9");
            server.RegisterUser("user@hcode.com.br", "123456");

            Middleware middleware = new CheckUserMiddleware(server);
            middleware.LinkWith(new CheckPermissionMiddleware());
            middleware.LinkWith(new CheckWeakPasswordMiddleware());

            server.SetMiddleware(middleware);
        }
        
        static void Main(string[] args)
        {
            Init();

            bool done = false;

            do
            {
                Console.WriteLine("Digite o seu e-mail: ");
                string email = Console.ReadLine();

                Console.WriteLine("Digite sua senha: ");
                string password = Console.ReadLine();

                done = server.LogIn(email, password);

            } while (!done);

            Console.ReadLine();
        }
    }
}
