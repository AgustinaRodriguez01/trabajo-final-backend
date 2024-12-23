namespace trabajo_final_backend.Singleton
{
    public class EnfermeriaSingleton
    {
        private static readonly EnfermeriaSingleton _instance = new EnfermeriaSingleton();
        private int remainingVisits = 5;

        private EnfermeriaSingleton() { }

        public static EnfermeriaSingleton Instance
        {
            get
            {
                return _instance;
            }
        }

        public int Attend(string type, int actualHealth, int times)
        {
            if (remainingVisits == 0)
            {
                return actualHealth;
            }
            int health = actualHealth;
            for (int i = 0; i < times; i++)
            {
                if (remainingVisits == 0)
                {
                    break;
                }
                health ++;
                remainingVisits--;
            }
            return health;
        }
    }
}
