namespace trabajo_final_backend.Models
{
    public abstract class Superheroe: ISuperheroe
    {
        public string fullName { get; set; }

        public string specialPower { get; set; }

        public int strength { get; set; }

        public int health { get; set; }

        public abstract string Attack();

        public abstract string Defend();
    }
}
