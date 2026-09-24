using System;
using System.Collections.Generic;
using System.Text;

namespace ConPatronFabrica
{
    public class FabricaGuerrero : FabricaPersonaje
    {
        public override IPersonaje CrearPersonaje()
        {
            return new Guerrero();
        }
    }
}
