using System;

namespace ChainOfResponsability.Middlewares
{
    class CheckWeakPasswordMiddleware : Middleware
    {
        public override bool Check(string email, string password)
        {
            if (password.Equals("123456"))
            {
                Console.WriteLine("Senha muito fraca. Sugerimos que a mesma seja alterada o mais breve possível.");
                return true;
            }

            return CheckNext(email, password);
        }
    }
}
