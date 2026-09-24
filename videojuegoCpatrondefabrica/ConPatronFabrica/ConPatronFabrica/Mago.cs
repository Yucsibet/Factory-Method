using System;
using System.Collections.Generic;
using System.Text;

namespace ConPatronFabrica
{
    public class Mago : IPersonaje
    {
        public void Atacar()
        {
            Console.WriteLine("¡El mago ataca con magia!");
        }

        public void Defender()
        {
            Console.WriteLine("¡El mago se defiende con un hechizo!");
        }
    }
}
