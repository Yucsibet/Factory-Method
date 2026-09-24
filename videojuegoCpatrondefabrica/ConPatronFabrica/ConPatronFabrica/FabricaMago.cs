using System;
using System.Collections.Generic;
using System.Text;

namespace ConPatronFabrica
{
    public class FabricaMago : FabricaPersonaje
    {
        public override IPersonaje CrearPersonaje()
        {
            return new Mago();
        }
    }
}