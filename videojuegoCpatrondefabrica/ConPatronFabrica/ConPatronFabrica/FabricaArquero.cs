using System;
using System.Collections.Generic;
using System.Text;

namespace ConPatronFabrica
{
    public class FabricaArquero : FabricaPersonaje
    {
        public override IPersonaje CrearPersonaje()
        {
            return new Arquero();
        }
    }
}