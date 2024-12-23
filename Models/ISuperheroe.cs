namespace trabajo_final_backend.Models
{
    public interface ISuperheroe
    {
        string fullName { get; set; }

        string specialPower { get; set; }

        int strength { get; set; }

        int health { get; set; }

        string Attack();

        string Defend();
    }
}
