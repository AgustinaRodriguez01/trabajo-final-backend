using static System.Runtime.InteropServices.JavaScript.JSType;

namespace trabajo_final_backend.Models
{
    public class Mago: Superheroe
    {

        public Mago(string nombre)
        {
            fullName = nombre;
            strength = 3;
            health = 5;
            specialPower = "Lanzar Hechizos";
        }

        public override string Attack()
        {
            return $"{fullName} ataca con magia";
        }

        public override string Defend()
        {
            return $"{fullName} crea una burbuja mágico";
        }
    }
}
