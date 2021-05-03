using ChainOfResponsability.Middlewares;
using System;
using System.Collections.Generic;

namespace ChainOfResponsability.Servers
{
    class Server
    {
        private Dictionary<string, string> users = new Dictionary<string, string>();

        private Middleware middleware;

        public void SetMiddleware(Middleware middleware)
        {
            this.middleware = middleware;
        }

        public bool LogIn(string email, string password)
        {
            if (middleware.Check(email, password))
            {
                Console.WriteLine("Usuário autenticado com sucesso.");
                Console.WriteLine("Seja bem-vindo(a).");
                
                return true;
            }
            
            return false;
        }

        public void RegisterUser(string email, string password)
        {
            users[email] = password;
        }

        public bool HasEmail(string email)
        {
            return users.ContainsKey(email);
        }

        public bool IsValidPassword(string email, string password)
        {
            string value;

            users.TryGetValue(email, out value);
            return password == value;
        }
    }
}
