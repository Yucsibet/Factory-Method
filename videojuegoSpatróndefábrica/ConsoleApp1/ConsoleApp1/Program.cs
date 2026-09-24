/*
 * Ejemplo adaptado a C# basado en el artículo sobre Factory Method 
 * escrito por Sumonta Saha Mridul en Medium.
 */
namespace SinPatronFabrica
{
    public class Juego
    {
        public static void Main(string[] args)
        {
            // Creación de un Guerrero directamente
            Guerrero guerrero = new Guerrero();
            guerrero.Atacar();
            guerrero.Defender();

            // Creación de un Mago directamente
            Mago mago = new Mago();
            mago.Atacar();
            mago.Defender();

            // Creación de un Arquero directamente
            Arquero arquero = new Arquero();
            arquero.Atacar();
            arquero.Defender();
        }
    }
}


