using System;
using System.Collections.Generic;
using System.Text;

namespace ConPatronFabrica
{
    public class FabricaNinja : FabricaPersonaje
    {
        public override IPersonaje CrearPersonaje()
        {
            return new Ninja();
        }
    }
}