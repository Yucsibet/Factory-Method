using ConPatronFabrica;
/*
 * Ejemplo adaptado a C# basado en el artículo sobre Factory Method 
 * escrito por Sumonta Saha Mridul en Medium.
 */
namespace ConPatronFabrica
{
    public class Juego
    {
        public static void Main()
        {
            // Usando la fábrica para un Guerrero
            FabricaPersonaje fabrica = new FabricaGuerrero();
            IPersonaje personaje = fabrica.CrearPersonaje();
            personaje.Atacar();
            personaje.Defender();

            // Usando la fábrica para un Ninja
            FabricaPersonaje fabricaNinja = new FabricaNinja();
            IPersonaje ninja = fabricaNinja.CrearPersonaje();
            ninja.Atacar();
            ninja.Defender();
        }
    }
}
