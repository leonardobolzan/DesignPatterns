using System;

namespace ChainOfResponsability.Middlewares
{
    class CheckPermissionMiddleware : Middleware
    {
        public override bool Check(string email, string password)
        {
            if (email.Equals("master@hcode.com.br"))
            {
                Console.WriteLine("Seja bem-vindo(a) administrador.");
                return true;
            }

            Console.WriteLine("Seja bem-vindo(a).");

            return CheckNext(email, password);
        }
    }
}
