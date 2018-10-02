namespace BehavioralPatterns.State
{
    internal class SimpleDemodulator : IDemodulator
    {
        public double Demodulate(Demodulation demodulation)
        {
            if (demodulation.Value < 10000)
            {
                demodulation.Demodulator = new NoizyDemodulator();
                demodulation.Value = demodulation.Demodulator.Demodulate(demodulation);
                return demodulation.Value;
            }

            demodulation.Value = demodulation.Value * 2;
            return demodulation.Value;
        }
    }
}
