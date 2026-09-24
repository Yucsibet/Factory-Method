using System;
using System.Collections.Generic;
using System.Text;

namespace ConPatronFabrica
{
    public class Ninja : IPersonaje
    {
        public void Atacar()
        {
            Console.WriteLine("¡El ninja ataca con un shuriken!");
        }

        public void Defender()
        {
            Console.WriteLine("¡El ninja se defiende con una bomba de humo!");
        }
    }
}