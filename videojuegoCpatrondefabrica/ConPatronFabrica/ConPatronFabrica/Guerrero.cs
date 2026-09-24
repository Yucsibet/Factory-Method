using System;
using System.Collections.Generic;
using System.Text;

namespace ConPatronFabrica
{
    public class Guerrero : IPersonaje
    {
        public void Atacar()
        {
            Console.WriteLine("¡El guerrero ataca con una espada!");
        }

        public void Defender()
        {
            Console.WriteLine("¡El guerrero se defiende con un escudo!");
        }
    }
}
