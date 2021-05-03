﻿using Bridge.Plataforms;
using System;

namespace Bridge.Transmissions
{
    class AdvancedLive : Live
    {
        public AdvancedLive(IPlatform platform): base(platform) { }
        
        public void Subtitle()
        {
            Console.WriteLine("Legendas ativadas na transmissão.");
        }

        public void Comments()
        {
            Console.WriteLine("Comentários liberados na transmissão.");
        }

        public void Record()
        {
            Console.WriteLine("Gravando transmissão.");
        }
    }
}
