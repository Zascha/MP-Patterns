namespace BehavioralPatterns.State
{
    public class Demodulation
        //IComparable
        //IDisposable
        //GetHashCode,GetType,ToString
    {
        public IDemodulator Demodulator; //State
        public double Value;

        public double Demodulate(double value)
        {
            Value = value;
            return Demodulator.Demodulate(this);
        }
    }
}
