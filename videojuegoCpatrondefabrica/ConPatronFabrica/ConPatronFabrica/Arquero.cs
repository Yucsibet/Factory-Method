using System;
using System.Collections.Generic;
using System.Text;


namespace ConPatronFabrica
{
    public class Arquero : IPersonaje
    {
        public void Atacar()
        {
            Console.WriteLine("¡El arquero ataca con un arco!");
        }

        public void Defender()
        {
            Console.WriteLine("¡El arquero se defiende esquivando!");
        }
    }
}