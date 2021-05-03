using System;

namespace AbstractFactory.Aircrafts
{
    class Helicopter : IAircraft
    {
        public void CheckWind()
        {
            Console.WriteLine("Verificando os ventos. Vento sudeste, vento ok.");
        }

        public void GetCargo()
        {
            Console.WriteLine("Passageiros ok. Ligando as hélices.");
        }

        public void StartRoute()
        {
            CheckWind();
            GetCargo();
            Console.WriteLine("Iniciando a decolagem.");
        }
    }
}
