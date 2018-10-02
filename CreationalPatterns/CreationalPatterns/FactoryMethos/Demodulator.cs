namespace CreationalPatterns.FactoryMethos
{
    public static class Demodulator
    {
        public static IDemodulator GetDemodulator(string field)
        {
            switch (field)
            {
                case "sand":
                    return new SimpleDemodulator();
                default:
                    return new NoizyDemodulator();
            }
        }
    }
}
