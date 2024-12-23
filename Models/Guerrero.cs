using static System.Runtime.InteropServices.JavaScript.JSType;

namespace trabajo_final_backend.Models
{
    public class Guerrero : Superheroe
    {
        public Guerrero(string nombre)
        {
            fullName = nombre;
            strength = 5;
            health = 3;
            specialPower = "Golpe Brutal";
        }

        public override string Attack()
        {
            return $"{fullName} ataca con su espada";
        }

        public override string Defend()
        {
            return $"{fullName} se defiende con su escudo de bronce";
        }
    }
}
