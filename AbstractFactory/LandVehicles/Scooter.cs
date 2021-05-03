using System;

namespace AbstractFactory.LandVehicles
{
    class Scooter : ILandVehicle
    {
        public void GetCargo()
        {
            Console.WriteLine("Passageiro pronto.");
        }

        public void StartRoute()
        {
            GetCargo();
            Console.WriteLine("Iniciando o trajeto de patinete.");
        }
    }
}
