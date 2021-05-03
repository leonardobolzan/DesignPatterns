using System;

namespace AbstractFactory.Aircrafts
{
    class Drone : IAircraft
    {
        public void CheckWind()
        {
            Console.WriteLine("Verificando os ventos. Vento ok para drones.");
        }

        public void GetCargo()
        {
            Console.WriteLine("Tudo pronto para decolagem.");
        }

        public void StartRoute()
        {
            CheckWind();
            GetCargo();
            Console.WriteLine("Iniciando a decolagem do drone.");
        }
    }
}
