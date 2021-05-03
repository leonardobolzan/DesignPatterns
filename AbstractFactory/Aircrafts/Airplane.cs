using System;

namespace AbstractFactory.Aircrafts
{
    class Airplane : IAircraft
    {
        public void CheckWind()
        {
            Console.WriteLine("Verificando os ventos. Vento ok.");
        }

        public void GetCargo()
        {
            Console.WriteLine("Passageiros à bordo, vôo autorizado.");
        }

        public void StartRoute()
        {
            CheckWind();
            GetCargo();
            Console.WriteLine("Iniciando a decolagem.");
        }
    }
}
