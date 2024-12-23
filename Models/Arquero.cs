namespace trabajo_final_backend.Models
{
    public class Arquero : Superheroe
    {
        public Arquero(string nombre)
        {
            fullName = nombre;
            strength = 3;
            health = 5;
            specialPower = "Disparar Flechas";
        }

        public override string Attack()
        {
            return $"{fullName} ataca con su arco";
        }

        public override string Defend()
        {
            return $"{fullName} se defiende esquivando";
        }
    }
}
