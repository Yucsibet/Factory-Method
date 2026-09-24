using System;
using System.Collections.Generic;
using System.Text;

namespace ConPatronFabrica
{
    public abstract class FabricaPersonaje
    {
        public abstract IPersonaje CrearPersonaje();
    }
}
