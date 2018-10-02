namespace BehavioralPatterns.ChainOfResponcibility
{
    public class Demodulation
    {
        private readonly DemodulationHandler _simpleDemodulator;
        private readonly DemodulationHandler _noizyDemodulator;

        private static Demodulation _instance;

        public static Demodulation GetInstance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Demodulation();
                }

                return _instance;
            }
        }

        private Demodulation()
        {
            _simpleDemodulator = new SimpleDemodulationHandler();
            _noizyDemodulator = new NoizyDemodulationHandler();
            _simpleDemodulator.Handler = _noizyDemodulator;
        }

        public double Demodulate(double value)
        {
            return _simpleDemodulator.Demodulate(value);
        }
    }
}
