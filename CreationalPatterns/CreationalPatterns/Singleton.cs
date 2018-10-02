namespace CreationalPatterns
{
    public sealed class Singleton
    {
        private static Singleton _instance;
        private static readonly object _lockObject = new object();

        public static Singleton GetInstance
        {
            get
            {
                lock (_lockObject)
                {
                    return _instance ?? (_instance = new Singleton());
                }
            }
        }

        private Singleton() { }
    }
}
