namespace BehavioralPatterns.ChainOfResponcibility
{
    public abstract class DemodulationHandler
    {
        public DemodulationHandler Handler { get; set; }
        public abstract double Demodulate(double value);
    }
}
