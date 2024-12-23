using trabajo_final_backend.Models;

namespace trabajo_final_backend.Factory
{
    public static class SuperheroeFactory
    {
        public static ISuperheroe CreateSuperheroe(string type, string name)
        {
            switch (type.ToLower())
            {
                case "guerrero":
                    return new Guerrero(name);
                case "mago":
                    return new Mago(name);
                case "arquero":
                    return new Arquero(name);
                default:
                    throw new ArgumentException("Invalid type");
            }
        }
    }
}
